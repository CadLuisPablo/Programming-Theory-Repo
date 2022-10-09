using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Text playerName;    
    public Input nameText;
    public GameObject player;
    public PlayerController getSet;

    private void Start()
    {
        player = GameObject.Find("Player");
        getSet = player.GetComponent<PlayerController>();        
        
    }
    private void Update()
    {
        playerName.text = "Speed: " + getSet.Speed + " Player Name: " + DataManager.Instance.PlayerName; 
    }
}
