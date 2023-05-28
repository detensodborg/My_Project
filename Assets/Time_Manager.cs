using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Manager : MonoBehaviour
{

    public float time_scale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpeedUp()
    {
        time_scale = 1.2f;

    }

    public void SpeedReset()
    {
        time_scale = 1.0f;

    }
}
