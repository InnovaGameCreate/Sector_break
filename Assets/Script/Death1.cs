using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death1 : MonoBehaviour
{
    [SerializeField]
    Player player;
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
        yield return new WaitForSeconds(0f);
       player.GetComponent<PlayerController>();
        //player.PlayerController.enabled = false;
        
        

    }
}
