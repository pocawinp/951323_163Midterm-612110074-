using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MainMenuControlScriptBGMSFX : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Button buttonStageSelection;
    [SerializeField] Button buttonOptions;
    [SerializeField] Button buttonCredit;
    [SerializeField] Button buttonExit;
    

    AudioSource audiosourceButtonUI;
    [SerializeField] AudioClip audioclipHoldOver;
    // Use this for initialization
    void Start()
        {
        this.audiosourceButtonUI = this.gameObject.AddComponent<AudioSource>();
        this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer
        .FindMatchingGroups("UI")[0];

        SetupButtonsDelegate();
        if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audiosourceButtonUI.isPlaying)
             audiosourceButtonUI.Stop();
        
             audiosourceButtonUI.PlayOneShot(audioclipHoldOver);
    }

    void SetupButtonsDelegate()
    {
        buttonStageSelection.onClick.AddListener(delegate { StageSelectionButtonClick(buttonStageSelection); });
        buttonOptions.onClick.AddListener(delegate { OptionsButtonClick(buttonOptions); });
        buttonCredit.onClick.AddListener(delegate { CreditButtonClick(buttonCredit); });
        buttonExit.onClick.AddListener(delegate { ExitButtonClick(buttonExit); });
        
    }
        // Update is called once per frame
        void Update()
        {
             }

        public void StageSelectionButtonClick(Button button)
        {
            SceneManager.LoadScene("StageSelection");
        }




    public void OptionsButtonClick(Button button)
        {
             if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
                 {
                 SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
                 SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
                 }
             }

    public void CreditButtonClick(Button button)
    {
         SceneManager.LoadScene("Credit");
         }

    public void SoundTestingButtonClick(Button button)
    {
        
      if (SingletonSoundManager.Instance.BGMSource.isPlaying)
             SingletonSoundManager.Instance.BGMSource.Stop();
        
      SceneManager.LoadScene("SceneGameplay3");
         }

    public void ExitButtonClick(Button button)
        {
             Application.Quit();
             }
 
}
