using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorFix : MonoBehaviour
{
    public bool IsEngineActive = false;
    private bool IsOnce = false;

    private bool doorFixClear = false;

 public bool DoorFixClear { get => doorFixClear; set => doorFixClear = value; }
    [SerializeField]
    GameObject textgackGround;
    [SerializeField]
    Text remainTextParts;
    [SerializeField]
    float fixPartsEngine;
    [SerializeField]
    GameObject door_Coffeeroom;
    [SerializeField]
    GameObject DamageEffect;

    OpenDoor doorScript;

   

    private void Awake()
    {
        DamageEffect.SetActive(true);
        door_Coffeeroom.GetComponent<OpenDoor>().CanOpendoor = false;
    }
    private void Start()
    {
        textgackGround.SetActive(false);
        remainTextParts.enabled = false;
        StartCoroutine("DoorActive");
        Text text = remainTextParts;
        remainTextParts.text = "修理完了まで残り" + fixPartsEngine + "個\n電子部品をクリックで修理";
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
            remainTextParts.text = "修理完了まで残り" + fixPartsEngine + "個\n電子部品をクリックで修理";
            yield return null;
        }
        else
        {
            remainTextParts.text = "修理完了";
            DoorFixClear = true;
            DamageEffect.SetActive(false);
            IsEngineActive = true;
            yield return new WaitForSeconds(1.0f);
            textgackGround.SetActive(false);
            door_Coffeeroom.GetComponent<OpenDoor>().CanOpendoor = true;
            remainTextParts.enabled = false;

        }
    }
}
