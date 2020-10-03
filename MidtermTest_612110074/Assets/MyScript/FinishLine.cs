using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    float time = 5;

    // Use this for initialization
    void Start()
    {
        
        
    }

    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    void OnTriggerEnter(Collider Finish)
    {
        if (Finish.tag == "Player")
        {
            SceneManager.LoadScene("Stage2");
        }
    }



}
