using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timing : MonoBehaviour
{
    public TextMeshPro tm;
    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetInt("time", 120);
        PlayerPrefs.SetInt("count1",0);
        tm.text = PlayerPrefs.GetInt("time").ToString();
       

    }
    private void Update()
    {
        int count1 = PlayerPrefs.GetInt("count1");
        int count = PlayerPrefs.GetInt("count");
        if (PlayerPrefs.GetInt("isReady") == 1 && count == 1&& count1==0)
        {
            StartCoroutine(PauseRoutine());
            PlayerPrefs.SetInt("count1", 1);
        }
    }

    // Update is called once per frame


    private IEnumerator PauseRoutine()
    {while (PlayerPrefs.GetInt("time") >= 0)
        {
            yield return new WaitForSeconds(1);
            tm.text = PlayerPrefs.GetInt("time").ToString();
            PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") - 1);
        if(PlayerPrefs.GetInt("time") == 0) {
                PlayerPrefs.SetInt("isReady", 0);
        }
        }
    }
}
