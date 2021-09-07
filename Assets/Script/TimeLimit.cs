using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLimit : MonoBehaviour
{
    [SerializeField]
    private float lifeTime_Case1 = 10.0f;
    [SerializeField]
    private float lifeTime_Case2 = 20.0f;

    public bool hit_1 = false;
    public bool hit_2 = false;

    void Start()
    {
        StartCoroutine("CoroutineManager");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Case1")
        {
            hit_1 = true;
        }
        if (collision.gameObject.tag == "Case2")
        {
            hit_2 = true;
        }
    }

    IEnumerator CoroutineManager()
    {
        yield return new WaitUntil(() => transform.position.x > 450.0f);
        StartCoroutine("case1");
        StartCoroutine("case2");//ケース2の方が待機時間が長いものとしてboolの処理を行っている
        yield break;
    }
    IEnumerator case1()
    {
        yield return new WaitForSeconds(lifeTime_Case1);
        if (hit_1 == true)
        {
            yield break;
        }
        else
        {
            this.gameObject.transform.position = new Vector3(453.0f, 22.0f, 168.0f);
            StartCoroutine("case1");
            StartCoroutine("case2");
            hit_2 = false;
            yield break;
        }
    }

    IEnumerator case2()
    {
        yield return new WaitForSeconds(lifeTime_Case1);
        if (hit_1 == true)
        {
            yield return new WaitForSeconds(lifeTime_Case2 - lifeTime_Case1);
            if (hit_2 == true)
            {
                yield break;
            }
            else if (hit_2 == false)
            {
                this.gameObject.transform.position = new Vector3(453.0f, 22.0f, 168.0f);
                StartCoroutine("case1");
                StartCoroutine("case2");
                yield break;
            }
        }
        else if (hit_1 == false)
        {
            yield break;
        }
    }
}
