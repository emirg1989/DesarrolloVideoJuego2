using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;

public class InitColletableCommand : EventCommand
{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    override public void Execute()
    {
        // load JSON from URL, tenes que hacerlo SI o SI desde una Corutina
        contextView.GetComponent<InicializadorStrange>().StartCoroutine("loadJson");

        // usando Resources
        TextAsset config = Resources.Load<TextAsset>("config.json");
        //JsonUtility.FromJson<>(config.text);
        // dispatcher.Dispatch(GameEvents.CONFIG_LOADED, config);

        /*
        {
            "collectibles":
            [
                {
                    "name" : "collectible0",
                    "event": "nombreEvento",
                    "amount" : 25
                }
            ]
        }


				// recorremos el array e instanciamos los modelos y crearías las vistas
        for (int i = 0; i < config["collectibles"].length; i++)
        {
            JSonObject collectible = config["collectibles"][i];
            // acá hacer los mapeaos de los eventos, sacar el collectible name
            // setearías todos los atributos de cada collectible de la misma forma
        }
 				*/

        for (int i = 0; i < 3; i++)
        {
            ICollectableModel collectableModel = injectionBinder.GetInstance<ICollectableModel>();
            string collectableName = Utility.Collectable + i;



            if (i == 0)
            {
                injectionBinder.Bind("collectible_event_" + collectableName).To(GameEvents.ON_UPDATE_NEW_SPEED_PLAYER);
                collectableModel.amountPower = 30f;
            }
            else if (i == 1)
            {
                injectionBinder.Bind("collectible_event_" + collectableName).To(GameEvents.ON_UPDATE_NEW_DAMAGE_WEAPON);
                collectableModel.amountPower = 5f;
            }
            else
            {
                injectionBinder.Bind("collectible_event_" + collectableName).To(GameEvents.ON_UPDATE_NEW_SPEED_ENEMY);
                collectableModel.amountPower = 20f;
            }


            GameObject goCollectable = GameObject.Instantiate(Resources.Load(collectableName)) as GameObject;
            goCollectable.name = collectableName;
            goCollectable.AddComponent<CollectableView>();
            goCollectable.transform.parent = contextView.transform;
            injectionBinder.Bind(collectableName).To(collectableModel);
        }
    }


    IEnumerator loadJson()
    {
        // le aviso a Strange que este es un comando asíncrono
        Retain();
        // ejecutas la tarea async
        WWW req = new WWW("https://raw.githubusercontent.com/emirg1989/DesarrolloVideoJuego2/master/config.json");
        yield return req.data;
        // le aviso a Strange que terminó tu tarea async
        Release();
    }

}
