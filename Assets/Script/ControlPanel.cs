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
            // �X�v���C�g�I�u�W�F�N�g�̕ύX
            //�i�z�� sprite[0] �Ɋi�[�����X�v���C�g�I�u�W�F�N�g��ϐ� image �Ɋi�[����Image �R���|�[�l���g�Ɋ��蓖�āj
            image.sprite = sprite[0];
            Change = false;
        }
        // �X�v���C�g�I�u�W�F�N�g�̕ύX�t���O�� false �̏ꍇ
        else
        {
            // �X�v���C�g�I�u�W�F�N�g�̕ύX
            //�i�z�� sprite[1] �Ɋi�[�����X�v���C�g�I�u�W�F�N�g��ϐ� image �Ɋi�[����Image �R���|�[�l���g�Ɋ��蓖�āj
            image.sprite = sprite[1];
            Change = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
