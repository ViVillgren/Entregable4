using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    public Vector3 randomPosition()
    {
        float Randomx = Random.Range(0, 8);
        float Randomy = Random.Range(0, 8);
        float Randomz = Random.Range(0, 8);

        return new Vector3(Randomx, Randomy, Randomz);
    }

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = randomPosition();
        }
    }
}
