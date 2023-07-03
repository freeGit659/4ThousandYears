using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        DestroyBullet();
    }
    private void BulletMove()
    {
        Vector3 scale = transform.localScale;
        transform.Translate(speed * Time.deltaTime, y:0, z:0);
        transform.localScale = scale;
    }
    private void DestroyBullet()
    {
        if (gameObject.transform.localPosition.x >= 50.0f) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
