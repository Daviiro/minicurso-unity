using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public int tempo = 0, tempoLimite = 0;

    GameObject player;

    List<GameObject> enemysAlive;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemysAlive = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + 1;
        tempoLimite = tempoLimite + 1;
        if(tempo == 2 && tempoLimite <= 60)
        {
            Vector3 enemyPosition = new Vector3(player.transform.position.x + Random.Range(-30, 30),
                player.transform.position.y, player.transform.position.z + Random.Range(-30, 30));

            GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);

            enemysAlive.Add(newEnemy);
            tempo = 0;
        }

        for(int i = 0; i < enemysAlive.Count; i++)
        {
            if(enemysAlive[i] == null)
            {
                enemysAlive.RemoveAt(i);
                break;
            }
        }
    }
}
