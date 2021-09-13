using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    [SerializeField] GameObject finishLine;
    [SerializeField] GameObject gameBoundary;
    private bool squidHit;
    private bool finshCrossed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Squid")
        {
            squidHit = true;
        }

        if (collision.name == finishLine.name)
        {
            finshCrossed = true;
        }

        if (collision.name == gameBoundary.name)
        {
            Destroy(gameObject);
        }
    }

    public bool IsSquidHit()
    {
        return squidHit;
    }

    public bool IsFinishedCrossed()
    {
        return finshCrossed;
    }
}
