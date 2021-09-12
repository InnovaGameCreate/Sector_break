using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricData : MonoBehaviour
{
    public float electric;
    private float electricSupply = 75.0f;
    private float electricComsume = 95.0f;
    // Start is called before the first frame update
    void Start()
    {
        electric = 100.0f;
        StartCoroutine("electricNumber");
        StartCoroutine("elctricCounter");
    }

    public void EngineClick()
    {
        electric -= 50;
    }

    public void solarfix()
    {
        electricSupply += 10;
    }

    private void Update()
    {
        //electric += 0.1f * (electricSupply - electricComsume);
    }

    IEnumerator electricNumber()
    {
        for (electric = 100; electric > 0;)
        {
            electric += 0.03f * (electricSupply  - electricComsume);
            yield return new WaitForSeconds(1.0f);
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
