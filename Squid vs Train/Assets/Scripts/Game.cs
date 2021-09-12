using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject squid;
    [SerializeField] GameObject train;

    float squidPos = 0f;
    float trainPos = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SquidMove();
        TrainMove();
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

        // squid.transform.position = new Vector3(1.8f * squidPos, squid.transform.position.y, 0);
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

        // train.transform.position = new Vector3(1.8f * trainPos, train.transform.position.y, 0);
    }

    IEnumerator Movement()
    {
        yield return new WaitForSeconds(5);
        squid.transform.position = new Vector3(1.8f * squidPos, squid.transform.position.y, 0);
        train.transform.position = new Vector3(1.8f * trainPos, train.transform.position.y, 0);
    }

}
