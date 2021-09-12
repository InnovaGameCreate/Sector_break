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

    [SerializeField]
    Text checktext;

    [SerializeField]
    GameObject elekidata;

    public void OnClick(int number)
    {
        switch (number)
        {
            case 0:

                if (O2 == true) 
                {
                    checktext.text = "O2room�𕕍����܂����H";
                    elekidata.GetComponent<electricData>().O2room();
                }
                break;
            case 1:
                if (Storage == true)
                {
                    checktext.text = "�X�g���[�W���[���𕕍����܂����H";
                    elekidata.GetComponent<electricData>().strage();
                }
                break;
            case 2:
                if (Engine == true)
                {
                    checktext.text = "�G���W�����[���𕕍����܂����H";
                    elekidata.GetComponent<electricData>().engine();
                }
                break;
            case 3:
                if (Coffee == true)
                {
                    checktext.text = "�R�[�q�[���[���𕕍����܂����H";
                    elekidata.GetComponent<electricData>().coffee();
                }
                break;
            case 4:
                if (Living == true)
                {
                    checktext.text = "���r���O���[���𕕍����܂����H";
                    elekidata.GetComponent<electricData>().living();
                }
                break;
            default:
                break;
        }//���̊e�{�^���ɂ��ꂼ��O�`�S�̈قȂ������n���Ă��������B
    }
        
    }

