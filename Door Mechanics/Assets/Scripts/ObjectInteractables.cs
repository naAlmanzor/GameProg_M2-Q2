using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ObjectInteractables : MonoBehaviour
{
    [SerializeField] private GameObject screenUI;
    [SerializeField] private TextMeshProUGUI textDisplay;
   
    private bool isGameOver = false;
    void Start(){
         screenUI.SetActive(false);
    }
    public void Interact(){
       
        if(gameObject.tag == "Right Door"){
            Debug.Log("Correct!");
        }

        if(gameObject.tag == "Wrong Door"){
            screenUI.SetActive(true);
            isGameOver = true;
            textDisplay.text = "Wrong Answer !";
            Time.timeScale = 0f;
        }
    }

    void Update(){
        if(isGameOver && Input.GetKeyDown(KeyCode.R)){
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
