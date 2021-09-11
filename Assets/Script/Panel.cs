using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    [SerializeField] GameObject CheckPanel;

   
    // Start is called before the first frame update
    void Start()
    {
        CheckPanel.SetActive(false);
    }

    public void OnClick()
    {
        CheckPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
