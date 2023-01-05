using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTImerUI : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;

    [SerializeField] TextMeshProUGUI countDownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        if(currentTime<=10.5){
            countDownText.color = Color.red;;
        }

        if(currentTime<=0){
            currentTime = 0;
            Debug.Log("Time's Up!");
        }
    }
}
