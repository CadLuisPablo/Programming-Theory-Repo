using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text textPlayerName;
    public Button backToMainMenu;
    // Start is called before the first frame update

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
