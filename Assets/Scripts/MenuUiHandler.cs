using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUiHandler : MonoBehaviour
{
    [SerializeField] private InputField inputTextName;
    
    // Start is called before the first frame update
    public void MainScene()
    {
        // Button Start Action
        SetPlayerName();
        SceneManager.LoadScene(1);
    }

    void SetPlayerName()
    {
        DataManager.Instance.PlayerName = inputTextName.text;
    }
}