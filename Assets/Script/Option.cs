using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public Text BGMtext;
    public Text SEtext;
    public Slider BGMslider;
    public Slider SEslider;
    private bool sliderBool;

    // Start is called before the first frame update
    void Start()
    {
        BGMslider.gameObject.SetActive(false);
        SEslider.gameObject.SetActive(false);
        sliderBool = false;
    }

    // Update is called once per frame
    void Update()
    {
            if (sliderBool == true)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    BGMtext.text = "";
                    SEtext.text = "";
                    BGMslider.gameObject.SetActive(false);
                    SEslider.gameObject.SetActive(false);
                    sliderBool = false;
                   Time.timeScale = 1;
                }
            }

            else
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    BGMtext.text = "BGM‰¹—Ê";
                    SEtext.text = "SE‰¹—Ê";
                    BGMslider.gameObject.SetActive(true);
                    SEslider.gameObject.SetActive(true);
                    sliderBool = true;
                  Time.timeScale = 0;
                }
            }
    }
}
