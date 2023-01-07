using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInteractables : MonoBehaviour
{
    [SerializeField] private GameObject screenUI;
    [SerializeField] private TextMeshProUGUI textDisplay;
   
    [Header("Custom Reason")]
    public string txt; 
   
    void Start(){
        screenUI.SetActive(false);
    }
    public void Interact(){
       
        if(gameObject.tag == "Right Door"){
            screenUI.SetActive(true);
            textDisplay.text = txt;
            Time.timeScale = 0f;
        }

        if(gameObject.tag == "Wrong Door"){
            screenUI.SetActive(true);
            textDisplay.text = "Wrong Answer !";
            Time.timeScale = 0f;
        }
    }
}
