using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int healthPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        healthPoint = 5;
        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyEnemy();
        EnemyMoving();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            healthPoint -= 1;
        }
    }
    private void DestroyEnemy()
    {
        if (healthPoint <= 0) Destroy(gameObject);
    }
    private void EnemyMoving()
    {
        Vector3 scale = transform.localScale;
        transform.Translate(-1 * speed * Time.deltaTime, y: 0, z: 0);
        transform.localScale = scale;
    }
}
