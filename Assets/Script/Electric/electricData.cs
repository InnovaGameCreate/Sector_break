using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class electricData : MonoBehaviour
{
    public float electric;
    private float electricSupply = 75.0f;
    public float electricComsume = 95.0f;

    [SerializeField]
    Text electronic;

    Death2 death2;
    // Start is called before the first frame update
    void Start()
    {
        electric = 100.0f;
        StartCoroutine("electricNumber");
        StartCoroutine("elctricCounter");
    }

    public void EngineClick()
    {
        electric -= 40;
    }

    public void solarfix()
    {
        electricSupply += 40;
    }

    private void Update()
    {
        electronic.text = "ƒGƒ“ƒWƒ“"+electric.ToString("0");
    }

    IEnumerator electricNumber()
    {
        for (electric = 100; electric > 0;)
        {
            electric += 0.01f * (electricSupply  - electricComsume);
            yield return new WaitForSeconds(1.0f);
        }
        if(electric < 0)
        {
            Debug.Log("0");
            death2 = GameObject.Find("GameSystem").GetComponent<Death2>();
            death2.Dead = false;

        }

    }

    IEnumerator elctricCounter()
    {
        yield return new WaitForSeconds(150.0f);
        electricSupply -= 30;
        yield return new WaitForSeconds(150.0f);
        electricSupply -= 30;
        yield return new WaitForSeconds(150.0f);
        electricSupply -= 30;
        yield break;
    }
}
