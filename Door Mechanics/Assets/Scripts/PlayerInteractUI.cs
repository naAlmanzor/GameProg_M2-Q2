using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteractions playerInteractions;
    
    void Update(){
        if(playerInteractions.GetObjectInteractables()){
            Show();
        }
        else{
            Hide();
        }
    }

    public void Show(){
        containerGameObject.SetActive(true);
    }

    public void Hide(){
        containerGameObject.SetActive(false);
    }   
}
