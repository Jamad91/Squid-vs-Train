using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public float timeLeft = 5f;
    [SerializeField] GameObject Game;

    int intTime;
    Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        intTime = (int)timeLeft;
        timerText.text = intTime.ToString();
        if (intTime > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        if (Game.GetComponent<Game>().GameOver())
        {
            timerText.fontSize = 40;
            if (Game.GetComponent<Game>().Winner() == "Squid")
            {
                timerText.text = "Squid Wins!";
            }
            else
            {
                timerText.text = "Train Wins!";
            }
        }
    }

}
