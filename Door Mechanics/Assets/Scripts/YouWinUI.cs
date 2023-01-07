using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinUI : MonoBehaviour
{
   void Update(){
        if(Input.GetKeyDown(KeyCode.Return)){
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
