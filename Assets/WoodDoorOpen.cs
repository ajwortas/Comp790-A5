using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDoorOpen : MonoBehaviour
{
    public GameObject door;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "axe")
        {
            door.GetComponent<AudioSource>().Play();
            Destroy(door);
        }
    }
}
