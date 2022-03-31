using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public AudioSource opening;
    public AudioSource firstFetch;
    public AudioSource secondFetch;

    /*
     * 0 = never triggered before
     * 1 = opening is playing
     * 2 = first fetch 
     * 3 = second fetch
     *
     * 
     */
    public int progress = 0;
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            switch (progress)
            {
                case 0:
                    opening.Play();
                    progress++;
                    break;
                case 1:
                    if (!opening.isPlaying)
                    {
                        firstFetch.Play();
                        progress++;
                    }
                    break;
                case 2:
                    if (!firstFetch.isPlaying)
                    {
                        firstFetch.Play();
                    }
                    break;
                case 3:
                    if (!secondFetch.isPlaying)
                    {
                        secondFetch.Play();
                    }
                    break;
            }
        }
        //Add logic for other objects entering

    }
}
