using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField]TMP_Text text;
    float currentTime;

    void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        text.text ="Time: " +  time.ToString(@"mm\:ss\:ff");
    }
}