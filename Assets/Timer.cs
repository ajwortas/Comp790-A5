using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public long seconds;
    public Text uiElement;
    private float timePassed;
    void Start()
    {
        timePassed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > seconds)
        {
            //END OF GAME
        }

        long secondsPassed = Mathf.FloorToInt(seconds - timePassed);
        uiElement.text = "Timer: " + secondsPassed;

    }
}
