using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    public float wait_time = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait_splash());
    }

    // Update is called once per frame
    
    IEnumerator wait_splash()
    {
        yield return new WaitForSeconds(wait_time);

        SceneManager.LoadScene("MainMenu");
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
