using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricData : MonoBehaviour
{
    public float electric;
    // Start is called before the first frame update
    void Start()
    {
        electric = 100.0f;
    }

    public void EngineClick()
    {
        electric -= 20;
    }

    private void Update()
    {
        if (electric < 0)
        {
            Debug.Log("YouDead");
        }
    }
}
