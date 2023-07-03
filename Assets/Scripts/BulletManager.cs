using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] GameObject positionSpawn, bullet;
    private float timeSpawn;
    void Start()
    {
        timeSpawn = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSpawn == 2.0f ) 
        {
            Vector2 spawnBulletPosition = new Vector2(positionSpawn.transform.position.x, positionSpawn.transform.position.y);
            Instantiate(bullet, spawnBulletPosition, Quaternion.identity, this.transform);
        }
        timeSpawn -= Time.deltaTime;
        if (timeSpawn <= 0) timeSpawn = 2.0f;

    }

}
