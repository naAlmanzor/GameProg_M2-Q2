using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInteractables : MonoBehaviour
{
    [SerializeField] private GameObject screenUI;
    [SerializeField] private TextMeshProUGUI textDisplay;
   
    void Start(){
        screenUI.SetActive(false);
    }
    public void Interact(){
       
        if(gameObject.tag == "Right Door"){
            screenUI.SetActive(true);
            textDisplay.text = "Gen V had 156 new Pokemon. \nIn comparison, the original game only had 151";
            Time.timeScale = 0f;
        }

        if(gameObject.tag == "Wrong Door"){
            screenUI.SetActive(true);
            textDisplay.text = "Wrong Answer !";
            Time.timeScale = 0f;
        }
    }
}
