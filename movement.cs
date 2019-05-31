using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("isReady") == 1)
        {
            transform.Translate(0, Input.acceleration.x * 100, 0);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }

    }
}
