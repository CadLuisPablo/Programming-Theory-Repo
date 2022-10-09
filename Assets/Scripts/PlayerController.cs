using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    private float speed;

    // ENCAPSULATION
    public float Speed { get { return speed; } set { speed = value; } }    

    private Rigidbody playerRb;
    public GameObject emptyDirection;

    // Start is called before the first frame update
    void Start()
    {        
        Speed = 1500f;        
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        
    }

    void PlayerMove()
    {
        // Vertical Direction
        float forwardInput = Input.GetAxis("Vertical");        
        playerRb.AddForce(emptyDirection.transform.forward * speed * forwardInput);        

        // Horizontal Direction
        float rightInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(emptyDirection.transform.right * speed * rightInput);

        // Stop AddForce
        if(Input.GetKey(KeyCode.Space))
        {            
            playerRb.velocity = new Vector3(0, 0, 0);

        }

        emptyDirection.transform.position = transform.position;

    }

}
