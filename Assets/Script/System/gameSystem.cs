using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSystem : MonoBehaviour
{
    private int timePast1 = 600;
    private int timePast2 = 300;
    private int timePast3 = 300;
    public static bool isIncindent1 = false;
    public static bool isIncindent2 = false;
    public static bool isIncindent3 = false;
    public static bool isIncindent4 = false;
    public static bool isIncindent5 = false;
    public static bool isO2Incident = false;
    public static bool isPowerIncident = false;
    public static bool isMeteorIncident = false;
    void Start()
    {
        StartCoroutine("timeControl");
    }

    private IEnumerator timeControl()
    {
        Incindent1();
        Incindent2();
        Incindent3();
        yield return new WaitUntil(() => isIncindent1 && isIncindent2 && isIncindent3);
        yield return new WaitForSeconds(timePast1);
        cameraShake();
        O2Incident();
        yield return new WaitForSeconds(timePast2);
        cameraShake();
        PowerIncident();
        yield return new WaitForSeconds(timePast3);
        MeteorIncident();
        cameraShake();
        //エンディング
        if (isPowerIncident == false) death2();
        else if (isO2Incident == false || isMeteorIncident == false) death1();
        else gameClear();

    }

    private void O2Incident()
    {

    }
    private void PowerIncident()
    {

    }
    private void MeteorIncident()
    {

    }
    private void cameraShake()
    {

    }

    private void Incindent1()
    {

    }

    private void Incindent2()
    {

    }

    private void Incindent3()
    {

    }

    private void Incindent4()
    {

    }

    private void Incindent5()
    {

    }

    private void death1()
    {

    }

    private void death2()
    {

    }
    private void gameClear()
    {

    }
}
