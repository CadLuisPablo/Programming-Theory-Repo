using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public float speed;
    public Rigidbody enemyRb;
    public GameObject player;

    // INHERITANCE
    public void StartEnemy()
    {
        //speed = 1f;
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    public void EnemyDirectionForce(float _speed)
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * _speed);

        if (gameObject.transform.position.y < 0)
        {
            Destroy(gameObject);
        }
    }

}
