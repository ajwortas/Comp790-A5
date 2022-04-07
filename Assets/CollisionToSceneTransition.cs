using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionToSceneTransition : MonoBehaviour
{

    public string scene;
    void OnTriggerEnter(Collider other)
    {

        //Audio Player
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("GameOverScenes/GameOver");
        }

    }
}
