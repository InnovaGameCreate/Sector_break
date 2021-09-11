using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject darkPanel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Yes");
        darkPanel.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            darkPanel.SetActive(false);
        }
    }
}
