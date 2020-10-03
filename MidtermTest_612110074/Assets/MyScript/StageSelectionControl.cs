using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectionControl : MonoBehaviour
{
    [SerializeField] Button _stage1Button;
    [SerializeField] Button _stage2Button;
    [SerializeField] Button _backButton;


    // Start is called before the first frame update
    void Start()
    {
        _stage1Button.onClick.AddListener
        (delegate { Stage1ButtonClick(_backButton); });

        _stage2Button.onClick.AddListener
        (delegate { Stage2ButtonClick(_backButton); });

        _backButton.onClick.AddListener
        (delegate { BackToMainMenuButtonClick(_backButton); });

    }


    // Update is called once per frame
    void Update()
    {

    }
    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("StageSelection");
        SceneManager.LoadScene("MainMenu");
    }

    public void Stage1ButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("StageSelection");
        SceneManager.LoadScene("Stage1");
    }

    public void Stage2ButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("StageSelection");
        SceneManager.LoadScene("Stage2");
    }
}
