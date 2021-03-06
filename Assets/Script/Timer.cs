using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private Text timerText;
    private float second = 00;//制限時間(分)
    private int minute = 10;//制限時間(秒)

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
            SceneManager.LoadScene("end");
        }

    }
}
