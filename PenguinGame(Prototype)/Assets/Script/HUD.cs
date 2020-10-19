using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text StartTimer;
    public Text Collected_Babies;
    Timer time;
    // Start is called before the first frame update
    void Start()
    {
        time = gameObject.AddComponent<Timer>();
        time.AddTimerFinishedEventListener(FinishedTimerEvent);
        time.Duration = 4f;
        time.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (time.Running)
        {
            StartTimer.text ="Time Remaining:"+ (time.TotalTime-time.ElapsedSeconds).ToString("0.0");
        }
    }
    void FinishedTimerEvent()
    {
        StartTimer.text = "Start....";
    }
}
