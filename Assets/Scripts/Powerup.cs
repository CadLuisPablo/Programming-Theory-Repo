using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    GameObject player;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }       

    private void OnTriggerEnter(Collider other)
    {
        // ENCAPSULATION
        playerController.Speed = playerController.Speed + 500;
        Destroy(other.gameObject);
    }
}
