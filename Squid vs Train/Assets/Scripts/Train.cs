using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    [SerializeField] GameObject finishLine;
    [SerializeField] GameObject gameBoundary;
    private bool squidHit;
    private bool finshCrossed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Squid")
        {
            Debug.Log("hit");
            squidHit = true;
        }

        if (collision.name == finishLine.name)
        {
            Debug.Log("crossed");
            finshCrossed = true;
        }
        Debug.Log(collision.name);
    }

    public bool IsSquidHit()
    {
        Debug.Log("Squid hit is " + squidHit);
        return squidHit;
    }

    public bool IsFinishedCrossed()
    {
        Debug.Log("Finish line crossed: " + finshCrossed);
        return finshCrossed;
    }
}
