using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    private float timer;
    [SerializeField] TextMeshProUGUI timerText;
    float elaspedTime;
    void Update()
    {
        elaspedTime += Time.deltaTime;
        int minute = Mathf.FloorToInt(elaspedTime / 60);
        int seconds = Mathf.FloorToInt(elaspedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minute, seconds);

        
    }
    public void CollectTimer()
    {
        // This method can be called when transitioning to the next scene
        // Collect the timer value to a variable or perform any necessary actions
        float collectedTimer = timer;

        // Output the collected timer value to the console (you can modify this part)
        Debug.Log("Collected Timer Value: " + collectedTimer);

        // Example: Load the next scene
       
    }
}
