using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverUI : MonoBehaviour{
    [SerializeField] public TextMeshProUGUI textDisplay;
    
    void Start(){
        textDisplay.text = "Wrong Answer !";
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}