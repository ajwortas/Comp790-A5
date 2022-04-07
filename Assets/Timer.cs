using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public long seconds;
    public Text uiElement;
    private float timePassed;
    void Start()
    {
        timePassed = 0;
        uiElement.text = "Timer: " + seconds;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > seconds)
        {
            SceneManager.LoadScene("GameOverScenes/GameOver");
        }

        long secondsPassed = Mathf.FloorToInt(seconds - timePassed);
        uiElement.text = "Timer: " + secondsPassed;

    }
}
