using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    public AudioSource open_door;
    private bool canOpenDoor;

    public bool CanOpenDoor { get => CanOpenDoor; set => CanOpenDoor = value; }
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsOpen", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ƒhƒA‚É“–‚½‚è‚Ü‚µ‚½");
        if (other.gameObject.tag == "Player" && CanOpenDoor)
        {
            animator.SetBool("IsOpen", true);
            open_door.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            animator.SetBool("IsOpen", false);
        }
    }
}
