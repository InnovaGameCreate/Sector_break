using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressData : MonoBehaviour
{
    public float stress;

    [SerializeField]
    Text stressde;
    Death2 death2;
    void Start()
    {
        stress = 100.0f;
        StartCoroutine("electricNumber");
    }

    private void Update()
    {
        stressde.text = "ƒXƒgƒŒƒX"+stress.ToString("0"); 
    }
    public void eating()
    {
        stress += 20;
    }

    IEnumerator electricNumber()
    {
        for (stress = 100; stress > 0;)
        {
            stress -=1;
            yield return new WaitForSeconds(1.0f);
        }
        if (stress< 0)
        {
            Debug.Log("0");
            death2 = GameObject.Find("GameSystem").GetComponent<Death2>();
            death2.Dead = false;

        }
    }
}
