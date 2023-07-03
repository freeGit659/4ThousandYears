using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemyLv1;
    [SerializeField] GameObject[] cell;
    [SerializeField] GameManager gameManager;
    private float timeSpawn;
    public bool spawnComplete;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        timeSpawn = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnEnemy(string name)
    {
        if (name == "EnemyLv1" && num > 0)
        {
            if (timeSpawn == 1.0f)
            {
                GameObject postitionSpawn = cell[Random.Range(0, cell.Length)];
                Vector2 spawnEnemyLv1 = new Vector2(postitionSpawn.transform.position.x, postitionSpawn.transform.position.y);
                Instantiate(enemyLv1, spawnEnemyLv1, Quaternion.identity, this.transform);
            }
            timeSpawn -= Time.deltaTime;
            if (timeSpawn <= 0)
            {
                timeSpawn = 1.0f;
                num--;
            }
            if (num <= 0) spawnComplete = true; 

        }

    }
}
