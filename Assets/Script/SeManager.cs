using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeManager : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;

    public Slider SEslider;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SEslider.onValueChanged.AddListener(value => this.audioSource.volume = value);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            audioSource.PlayOneShot(sound1);
        }

    }
}
