using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitcheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+1);
        Destroy(gameObject);
        //StartCoroutine(PauseRoutine());
    }



 
}
