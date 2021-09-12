using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineFix : MonoBehaviour
{
    public bool IsEngineActive = false;
    private bool IsOnce = false;

    [SerializeField]
    GameObject textgackGround;
    [SerializeField]
    Text remainTextParts;
    [SerializeField]
    float fixPartsEngine;
    [SerializeField]
    GameObject damageEffect;
    private void Awake()
    {
        damageEffect.SetActive(true);
        textgackGround.SetActive(false);
        remainTextParts.enabled = false;
        StartCoroutine("EngineActive");
        Text text = remainTextParts;
        remainTextParts.text = "修理完了まで残り" + fixPartsEngine + "個\n金属をクリックで修理";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && IsEngineActive == false)
        {
            textgackGround.SetActive(true);
            remainTextParts.enabled = true;
            IsOnce = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && IsEngineActive == false)
        {
            textgackGround.SetActive(false);
            remainTextParts.enabled = false;
            IsOnce = false;
        }
    }

    public void ClickMetal()
    {
        if (IsOnce == true)
        {
            StopCoroutine("EngineActive");
            fixPartsEngine  -= 1;
            StartCoroutine("EngineActive");
        }
    }

    IEnumerator EngineActive()
    {
        if (fixPartsEngine > 0.0f)
        {
            remainTextParts.text = "修理完了まで残り" + fixPartsEngine + "個\n金属をクリックで修理";
            yield return null;
        }
        else
        {
            remainTextParts.text = "修理完了";
            damageEffect.SetActive(false);
            IsEngineActive = true;
            yield return new WaitForSeconds(3.0f);
            textgackGround.SetActive(false);
            remainTextParts.enabled = false;

        }
    }
}
