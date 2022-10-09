using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : Enemy // INHERITANCE
{
    [SerializeField] float speed;
    [SerializeField] float posY;
    // Start is called before the first frame update
    void Start()
    {
        posY = 20f;
        speed = 1.0f;
        StartEnemy();
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, posY, gameObject.transform.position.z);
    }

    // Update is called once per frame
    
    
    void Update()
    {        
        EnemyDirectionForce(speed); // POLYMORPHISM
        

    }
    
    
}
