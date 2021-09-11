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
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Death");

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Death()
    {
        Debug.Log("€‚ñ‚¾‚æ");
        yield return new WaitForSeconds(2f);
        Explosion.SetActive(true);//ƒAƒjƒƒVƒ‡ƒ“‚ÌÄ¶
        Player.GetComponent<PlayerController>().enabled = false;
        ItemBar.SetActive(false);
        yield return new WaitForSeconds(5f);
        

    }
}
