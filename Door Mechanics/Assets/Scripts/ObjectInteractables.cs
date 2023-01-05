using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractables : MonoBehaviour
{
    public void Interact(){
        if(gameObject.tag == "Right Door"){
            Debug.Log("Correct!");
        }

        if(gameObject.tag == "Wrong Door"){
            Debug.Log("Wrong!");
        }
    }
}
