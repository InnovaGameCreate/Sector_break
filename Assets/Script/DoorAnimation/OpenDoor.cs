using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator animator;
    public AudioSource open_door;
    private bool canOpendoor = true;

    public bool CanOpendoor { get => canOpendoor; set => canOpendoor = value; }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsOpen", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && CanOpendoor == true)
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
