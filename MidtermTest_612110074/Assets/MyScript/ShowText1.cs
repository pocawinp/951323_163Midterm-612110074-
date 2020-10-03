using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText1 : MonoBehaviour
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
        timeShow.text = "Time : " + time.ToString();
    }
}
