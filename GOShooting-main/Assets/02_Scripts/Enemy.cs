using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float damage = 1;
    [SerializeField] int scorePoint = 100;
    PlayerController playerController;
    [SerializeField] GameObject explosionPrfab;
ObjectPloor enemylooler;

    private void Awake()
    {
        enemylooler = GameObject.Find("EnemySpwaner").GetComponent<ObjectPloor>();
        //���� �� �Ȱ��ٰ� �����ϸ� ��
        playerController = FindObjectOfType<PlayerController>();
        //���� ������Ʈ �̸����� ã��playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //playerController = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TakeDamge(damage);
            Destroy(gameObject);
            Die();
        }
    }

    public void Die()
    {
       GameObject clon= Instantiate(explosionPrfab,transform.position,Quaternion.identity);
       enemylooler.ReturnObject(gameObject);
       // Destroy(clon,1f);
        playerController.Score += scorePoint;
        Destroy(gameObject);
    }
}
