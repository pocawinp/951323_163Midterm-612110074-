using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCountStage2 : MonoBehaviour
{
    public Text timeShow;
    float time = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        

        if (time <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }

        
    }
}
