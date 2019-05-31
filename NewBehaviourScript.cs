using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshPro text;
    Rigidbody rb = null;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("isReady",0);
        PlayerPrefs.SetInt("count", 0);
        PlayerPrefs.SetInt("Score", 0);
        rb = GetComponent<Rigidbody>();
        if (PlayerPrefs.HasKey("Score"))
        {
            text.text = PlayerPrefs.GetInt("Score").ToString();
        }
        else { text.text = "0"; }

    }

    // Update is called once per frame
    void Update()
    {
        int count= PlayerPrefs.GetInt("count");
        if (PlayerPrefs.GetInt("isReady") == 1 && count==0)
        {
            rb.AddForce(Vector3.up * 30000);
            PlayerPrefs.SetInt("count", 1);

        }

        if(PlayerPrefs.GetInt("isReady") == 0) { rb.velocity = Vector3.zero; }

        text.text = PlayerPrefs.GetInt("Score").ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("bottom"))
        {
            PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 5);
        }
    }
}
