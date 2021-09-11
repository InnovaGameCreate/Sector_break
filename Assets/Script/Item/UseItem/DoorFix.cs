using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorFix : MonoBehaviour
{
    public bool IsEngineActive = false;
    private bool IsOnce = false;

    [SerializeField]
    GameObject textgackGround;
    [SerializeField]
    Text remainTextParts;
    [SerializeField]
    float fixPartsEngine;
    private void Start()
    {
        textgackGround.SetActive(false);
        remainTextParts.enabled = false;
        StartCoroutine("DoorActive");
        Text text = remainTextParts;
        remainTextParts.text = "�C�������܂Ŏc��" + fixPartsEngine + "��\n�d�q���i���N���b�N�ŏC��";
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

    public void ClickElectronic()
    {
        if (IsOnce == true)
        {
            StopCoroutine("DoorActive");
            fixPartsEngine -= 1;
            StartCoroutine("DoorActive");
        }
    }

    IEnumerator DoorActive()
    {
        if (fixPartsEngine > 0.0f)
        {
            remainTextParts.text = "�C�������܂Ŏc��" + fixPartsEngine + "��\n�d�q���i���N���b�N�ŏC��";
            yield return null;
        }
        else
        {
            remainTextParts.text = "�C������";
            IsEngineActive = true;
            yield return new WaitForSeconds(1.0f);
            textgackGround.SetActive(false);
            
            remainTextParts.enabled = false;

        }
    }
}
