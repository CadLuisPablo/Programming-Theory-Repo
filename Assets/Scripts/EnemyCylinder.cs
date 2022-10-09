using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCylinder : Enemy // INHERITANCE
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        StartEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy Cylinder Speed
        EnemyDirectionForce(speed); // POLYMORPHISM
    }
}
