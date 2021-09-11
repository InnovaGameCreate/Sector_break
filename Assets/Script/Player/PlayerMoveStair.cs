using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveStair : MonoBehaviour
{
    public float start;
    public float jyousyouritu;

    private void OnTriggerStay(Collider col)
    {
        col.gameObject.transform.position = new Vector3(col.gameObject.transform.position.x, (col.gameObject.transform.position.x - start) * jyousyouritu, col.gameObject.transform.position.z);

    }

}
