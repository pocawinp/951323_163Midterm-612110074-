using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    

    // Use this for initialization
    void Start()
    {
        
        
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider Finish)
    {
        if (Finish.tag == "Player")
        {
            SceneManager.LoadScene("Stage2");
        }
    }



}
