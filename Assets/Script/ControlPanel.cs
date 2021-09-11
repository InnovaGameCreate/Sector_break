using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    private Image image;
    public Sprite[] sprite;
    bool Change;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void onclick()
    {
        if (Change)
        {
            // スプライトオブジェクトの変更
            //（配列 sprite[0] に格納したスプライトオブジェクトを変数 image に格納したImage コンポーネントに割り当て）
            image.sprite = sprite[0];
            Change = false;
        }
        // スプライトオブジェクトの変更フラグが false の場合
        else
        {
            // スプライトオブジェクトの変更
            //（配列 sprite[1] に格納したスプライトオブジェクトを変数 image に格納したImage コンポーネントに割り当て）
            image.sprite = sprite[1];
            Change = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
