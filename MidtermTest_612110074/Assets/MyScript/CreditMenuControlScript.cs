﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;


    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener
        (delegate { BackToMainMenuButtonClick(_backButton); });

    }


    // Update is called once per frame
    void Update()
    {

    }
    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("Credit");
        SceneManager.LoadScene("MainMenu");
    }
}
