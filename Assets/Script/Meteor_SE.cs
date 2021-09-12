using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor_SE : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine("Bomb");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Bomb()
     {
        //yield return new WaitForSeconds(0f);
        //audioSource.Stop();
        yield return new WaitForSeconds(150f);
       audioSource.Play();
       yield return new WaitForSeconds(150f);
       audioSource.Play();
       yield return new WaitForSeconds(150f);
       audioSource.Play();

     }
}
