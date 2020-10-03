using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine2 : MonoBehaviour
{

   

    // Use this for initialization
    void Start()
    {
        

    }

    void OnTriggerEnter(Collider Finish)
    {
        if (Finish.tag == "Player")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }



}
