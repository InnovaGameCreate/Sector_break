using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_identify : MonoBehaviour
{
    public bool O2 = true;
    public bool Storage = true;
    public bool Engine = true;
    public bool Coffee = true;
    public bool Living = true;

    [SerializeField] GameObject door_O2tank;

    [SerializeField] GameObject door_Strage;

    [SerializeField] GameObject door_Engineroom;

    [SerializeField] GameObject door_Coffeeroom;

    [SerializeField] GameObject door_Livingroom;

    [SerializeField] GameObject O2tank;

    [SerializeField] GameObject Strage;

    [SerializeField] GameObject Engineroom;

    [SerializeField] GameObject Coffeeroom;

    [SerializeField] GameObject Livingroom;

    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:

                if (O2 == true) 
                {
                    Debug.Log("O2room�𕕍����܂����H");
                }
                break;
            case 1:
                if (Storage == true)
                {
                    Debug.Log("�X�g���[�W���[���𕕍����܂����H");
                }
                break;
            case 2:
                if (Engine == true)
                {
                    Debug.Log("�G���W�����[���𕕍����܂����H");
                }
                break;
            case 3:
                if (Coffee == true)
                {
                    Debug.Log("�R�[�q�[���[���𕕍����܂����H");
                }
                break;
            case 4:
                if (Living == true)
                {
                    Debug.Log("���r���O���[���𕕍����܂����H");
                }
                break;
            default:
                break;
        }//���̊e�{�^���ɂ��ꂼ��O�`�S�̈قȂ������n���Ă��������B
    }
        
    }

