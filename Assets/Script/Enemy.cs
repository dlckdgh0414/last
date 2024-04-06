using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float EnemyMove = 5f;
    Vector3 dir;
    void Start()
    {
        int randValue = Random.Range(0, 10);
        if(randValue<3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }
    void Update()
    {
        transform.position += dir * EnemyMove * Time.deltaTime;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            ScoreManger.Instanc.SetScore(ScoreManger.Instanc.GetScore() + 1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
  
    }
}
