using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //needed for UI time

public class EndGameTime : MonoBehaviour
{
    public Text timeElement;

    // Update is called once per frame
    void Update()
    {

        SaveEndTime();
        
    }

    // Update is called once per frame
    public void SaveEndTime()
    {
        //endTime
       // timeElement.text = PlayerPrefs.GetInt("EndGameTime").ToString();
        
         //Time.timeScale = 0;
    }
}
