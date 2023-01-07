using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class YouWinUI : MonoBehaviour
{
    [SerializeField] private string sceneSelection;
    [SerializeField] private TextMeshProUGUI textDisplay;
    [SerializeField] private TextMeshProUGUI prompt;

    [Header("Custom Reason")]
    public string reason; 

    void Start(){
        Scene scene = SceneManager.GetActiveScene();
        textDisplay.text = reason;
        
        if(scene.name == "Level 3"){
            prompt.text = "Press 'Enter' to Restart Game";
        }

        else
        {
            prompt.text = "Press 'Enter' to Start Next Level";
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)){
            Time.timeScale = 1;
            SceneManager.LoadScene(sceneSelection);
        }
    }
}
