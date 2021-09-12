using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death1 : MonoBehaviour
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
         
        if(Dead == false)
        {
            StartCoroutine("Death");
        }
        
    }
    IEnumerator Death()
    {
        Debug.Log("€‚ñ‚¾‚æ");
        yield return new WaitForSeconds(0f);
       Player.GetComponent<PlayerController>().enabled = false;
        ItemBar.SetActive(false);
        yield return new WaitForSeconds(5f);
         Explosion.SetActive(true);//ƒAƒjƒƒVƒ‡ƒ“‚ÌÄ¶
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Stage_CameraMove");

    }
}
