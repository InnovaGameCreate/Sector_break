using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public GameObject OptionButton;
    public GameObject BackButton;
    public Text BGMtext;
    public Text SEtext;
    public Slider BGMslider;
    public Slider SEslider;
    private bool BGMsliderBool;
    private bool SEsliderBool;
    [SerializeField] GameObject startPanel;

    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(false);
        OptionButton.SetActive(true);
        BackButton.SetActive(false);
        BGMslider.gameObject.SetActive(false);
        SEslider.gameObject.SetActive(false);
        BGMsliderBool = false;
        SEsliderBool = false;
    }
    public void SelectOption()
    {
        BGMtext.text = "BGM‰¹—Ê";
        SEtext.text = "SE‰¹—Ê";
        OptionButton.SetActive(false);
        BackButton.SetActive(true);
        startPanel.SetActive(true);

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
    public void SelectBack()
    {
        BGMtext.text = "";
        SEtext.text = "";
        startPanel.SetActive(false);
        OptionButton.SetActive(true);
        BackButton.SetActive(false);
        BGMslider.gameObject.SetActive(false);
        SEslider.gameObject.SetActive(false);
        BGMsliderBool = false;
        SEsliderBool = false;
    }

    public void SelectStart()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
