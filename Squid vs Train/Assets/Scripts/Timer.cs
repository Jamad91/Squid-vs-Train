using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeLeft = 5f;
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
    }

    //IEnumerator DecreaseTime()
    //{
    //    yield return new WaitForSeconds(1);
    //    startingTime--;
    //}
}
