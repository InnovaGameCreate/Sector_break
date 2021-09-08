using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BgmManager : MonoBehaviour
{
    public Slider BGMslider;
    AudioSource audioSource;
    public static BgmManager Instance   //DontDestroyï°êªñhé~Ç…égóp
    {
        get; private set;
    }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        if (SceneManager.GetActiveScene().name != "Starting")
            DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        BGMslider.onValueChanged.AddListener(value => this.audioSource.volume = value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
