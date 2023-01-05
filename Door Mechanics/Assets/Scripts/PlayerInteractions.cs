using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach(Collider collider in colliderArray){
                if (collider.TryGetComponent(out ObjectInteractables objectInteractables)){
                    objectInteractables.Interact();
                }
            }
        }
    }

    public ObjectInteractables GetObjectInteractables(){
        float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach(Collider collider in colliderArray){
                if (collider.TryGetComponent(out ObjectInteractables objectInteractables)){
                    return objectInteractables;
                }
            }
            return null;
    }
}
