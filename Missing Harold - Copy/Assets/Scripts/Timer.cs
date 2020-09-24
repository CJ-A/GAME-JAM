using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text time;
    public float timeAmount;
    public float pointIncreasedPerSecond;

    void Start()
    {
        timeAmount = 0f;
        pointIncreasedPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        time.text =  " Time: " + (int)timeAmount;
        timeAmount += pointIncreasedPerSecond = Time.deltaTime;
    }
}
