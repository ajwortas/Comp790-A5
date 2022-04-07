using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
     */
    public int progress = 0;
    void OnTriggerEnter(Collider other)
    {

        //Audio Player
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

        //Check for the first item
        if(other.gameObject.name == "APartOfYou" & progress == 2){
            if (firstFetch.isPlaying)
            {
                firstFetch.Stop();
            }
            secondFetch.Play();
            Destroy(other.gameObject);
            progress = 3;
        }

        //Check for the second item
        if (other.tag == "Torch" & progress == 3){
            if (secondFetch.isPlaying)
            {
                secondFetch.Stop();
            }
            SceneManager.LoadScene("GameOverScenes/GameClear");
        }
    }
}
