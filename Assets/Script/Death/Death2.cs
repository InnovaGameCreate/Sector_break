using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death2 : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject ItemBar;
    [SerializeField]
    GameObject Explosion;
    private bool dead = true;

    public bool Dead { get => dead; set => dead = value; }

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Dead == false)
        {
            StartCoroutine("DeathTwo");
        }

    }
    IEnumerator DeathTwo()
    {
        yield return new WaitForSeconds(0f);
        Player.GetComponent<PlayerController>().enabled = false;
        ItemBar.SetActive(false);
        yield return new WaitForSeconds(1f);
        Explosion.SetActive(true);//アニメションの再生
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Stage_CameraMove");

    }
}
