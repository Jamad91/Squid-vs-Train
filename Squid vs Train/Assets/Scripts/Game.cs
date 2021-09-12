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

        squid.transform.position = new Vector3(1.8f * squidPos, squid.transform.position.y, 0);
        Debug.Log(squidPos);
        Debug.Log(squid.transform.position.x);
    }
}
