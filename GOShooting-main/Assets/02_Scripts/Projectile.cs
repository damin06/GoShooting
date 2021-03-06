using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    ObjectPloor bulletPlooer;
    private void Start()
    {
        bulletPlooer=GameObject.Find("Player").GetComponent<ObjectPloor>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //Destroy(collision.gameObject);
            collision.GetComponent<Enemy>().Die();
            //Destroy(gameObject);
            bulletPlooer.ReturnObject(gameObject);
        }
    }
}
