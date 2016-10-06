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
        //instanciamos el enemigo
        for (int i = 0; i < 2; i++)
		{
            IEnemyModel enemyModel = injectionBinder.GetInstance<IEnemyModel>();
			string enemyName = Utility.Enemy + i;
            GameObject goEnemy = GameObject.Instantiate(Resources.Load(enemyName)) as GameObject;
            goEnemy.name = enemyName;
            goEnemy.AddComponent<EnemyView>();
			EnemyView enemyView = goEnemy.GetComponent<EnemyView> ();
			if (i == 0)
			{
				enemyModel.speed = 50f;
			}
			else
			{
				enemyModel.speed = 60f;
			}
			enemyView.GetSpeed (enemyModel.speed);
            goEnemy.transform.parent = contextView.transform;
            injectionBinder.Bind(enemyName).To(enemyModel);
        }
    }
}
