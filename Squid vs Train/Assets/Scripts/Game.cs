using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject squid;
    [SerializeField] GameObject train;

    float timeLeft;
    float squidPos = 0f;
    float trainPos = 0f;
    bool squidCollide = false;
    bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = FindObjectOfType<Timer>().timeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            SquidMove();
            TrainMove();
        }
        StartCoroutine(Movement());   
    }

    private void SquidMove()
    {
            if (squidPos > -1 && Input.GetKeyDown("left"))
            {
                squidPos -= 1;
            }

            if (squidPos < 1 && Input.GetKeyDown("right"))
            {
                squidPos += 1;
            }
    }

    private void TrainMove()
    {
        if (trainPos > -1 && Input.GetKeyDown("a"))
        {
            trainPos -= 1;
        }

        if (trainPos < 1 && Input.GetKeyDown("d"))
        {
            trainPos += 1;
        }
    }

    IEnumerator Movement()
    {
        yield return new WaitForSeconds(timeLeft);
        if (!gameOver)
        {
            squid.transform.position = new Vector3(1.8f * squidPos, squid.transform.position.y, 0);
            train.transform.position = new Vector3(1.8f * trainPos, train.transform.position.y, 0);
        }
        if (train)
        {
            train.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10f);
            if (train.GetComponent<Train>().IsFinishedCrossed())
            {
                squidCollide = train.GetComponent<Train>().IsSquidHit();
                gameOver = true;
            }
        }
    }

    public bool GameOver()
    {
        return gameOver;
    }

    public string Winner()
    {
        if (squidCollide)
        {
            return "Train";
        }
        else
        {
            return "Squid";
        }
    }

}
