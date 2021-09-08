using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timerText;
    private float second = 00;//êßå¿éûä‘(ï™)
    private int minute = 10;//êßå¿éûä‘(ïb)

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        second -= Time.deltaTime;

        if (second <= 0f)
        {
            minute -= 1;
            second = 59;
        }
        timerText.text = minute.ToString("00") + ":" + second.ToString("f2");

        if (minute <= -1f)
        {
            timerText.text = "00:00.00";
        }
    }
}
