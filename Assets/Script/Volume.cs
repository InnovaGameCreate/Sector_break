using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Text BGMtext;
    public Text SEtext;
    public Slider BGMslider;
    public Slider SEslider;
    private bool BGMsliderBool;
    private bool SEsliderBool;

    // Start is called before the first frame update
    void Start()
    {
        BGMslider.gameObject.SetActive(false);
        BGMsliderBool = false;
        SEslider.gameObject.SetActive(false);
        SEsliderBool = false;
    }
    public void SelectOption()
    {
        BGMtext.text = "BGM‰¹—Ê";
        SEtext.text = "SE‰¹—Ê";

        if (BGMsliderBool == false)
        {
            BGMslider.gameObject.SetActive(true);
            BGMsliderBool = true;
        }
        else
        {
            BGMslider.gameObject.SetActive(false);
            BGMsliderBool = false;
        }

        if (SEsliderBool == false)
        {
            SEslider.gameObject.SetActive(true);
            SEsliderBool = true;
        }
        else
        {
            SEslider.gameObject.SetActive(false);
            SEsliderBool = false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
