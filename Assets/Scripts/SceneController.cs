using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;

    void Start()
    {
        for (int i = 0; i < Utility.numEnemies; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(5, 0, 10);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            _enemy.GetComponent<WanderingAI>().SetAlive(true);
        }

        for (int i = 0; i < Utility.numEnemies; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(-3, 0, 0);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            _enemy.GetComponent<WanderingAI>().SetAlive(true);
        }


        for (int i = 0; i < Utility.numEnemies; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(15, 0, 10);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            _enemy.GetComponent<WanderingAI>().SetAlive(true);
        }

        for (int i = 0; i < Utility.numEnemies; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(15, 0, 10);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            _enemy.GetComponent<WanderingAI>().SetAlive(true);
        }

        for (int i = 0; i < Utility.numEnemies; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(-15, 0, 5);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            _enemy.GetComponent<WanderingAI>().SetAlive(true);
        }


        for (int i = 0; i < Utility.numEnemies; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(-10, 0, 20);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            _enemy.GetComponent<WanderingAI>().SetAlive(true);
        }

        for (int i = 0; i < Utility.numEnemies; i++)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(4, 0, -20);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
            _enemy.GetComponent<WanderingAI>().SetAlive(true);
        }
    }
}
