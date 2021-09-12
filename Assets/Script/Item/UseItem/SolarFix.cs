using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarFix : MonoBehaviour
{
    public bool IsEngineActive = false;
    private bool IsOnce = false;

    private bool solarFixClear = false;

 public bool SolarFixClear { get => solarFixClear; set => solarFixClear = value; }
    [SerializeField]
    GameObject textgackGround;
    [SerializeField]
    Text remainTextParts;
    [SerializeField]
    float fixPartsSolar;
    [SerializeField]
    GameObject electricManager;

   

    private void Awake()
    {
        
    }
    private void Start()
    {
        textgackGround.SetActive(false);
        remainTextParts.enabled = false;
        StartCoroutine("PanelActive");
        Text text = remainTextParts;
        remainTextParts.text = "修理完了まで残り" + fixPartsSolar + "個\nソーラーパネルをクリックで修理";
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

    public void ClickSolar()
    {
        if (IsOnce == true)
        {
            StopCoroutine("PanelActive");
            fixPartsSolar -= 1;
            StartCoroutine("PanelActive");
        }
    }

    IEnumerator PanelActive()
    {
        if (fixPartsSolar > 0.0f)
        {
            remainTextParts.text = "修理完了まで残り" + fixPartsSolar + "個\nソーラーパネルをクリックで修理";
            yield return null;
        }
        else
        {
            remainTextParts.text = "修理完了";
            fixPartsSolar = 7.0f;
            SolarFixClear = true;
            electricManager.GetComponent<electricData>().solarfix();
            yield return new WaitForSeconds(1.0f);
            textgackGround.SetActive(false);
            remainTextParts.enabled = false;
            remainTextParts.text = "修理完了まで残り" + fixPartsSolar + "個\nソーラーパネルをクリックで修理";
        }
    }
}
