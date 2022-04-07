using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellDoorOpen : MonoBehaviour
{
    public GameObject door;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Key")
        {
            Destroy(other.gameObject);
            door.GetComponent<Rigidbody>().useGravity = true;
            door.GetComponent<Rigidbody>().isKinematic = false;
            door.transform.Rotate(-5, 0, 0);

        }
    }
}
