using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitEnemyCommand : EventCommand
{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    override public void Execute()
    {
		
		TextAsset file = Resources.Load ("Enemies") as TextAsset;
		var n = SimpleJSON.JSON.Parse (file.text);
		for (int i = 0; i < n ["enemies"].Count; i++) 
		{
            IEnemyModel enemyModel = injectionBinder.GetInstance<IEnemyModel>();
			string enemyName = n["enemies"][i]["name"].Value;
			enemyModel.speed = n ["enemies"] [i] ["speed"].AsFloat;
            GameObject goEnemy = GameObject.Instantiate(Resources.Load(enemyName)) as GameObject;
            goEnemy.name = enemyName;
            goEnemy.AddComponent<EnemyView>();
			EnemyView enemyView = goEnemy.GetComponent<EnemyView> ();
			enemyView.GetSpeed (enemyModel.speed);
            goEnemy.transform.parent = contextView.transform;
            injectionBinder.Bind(enemyName).To(enemyModel);
        }
    }
}
