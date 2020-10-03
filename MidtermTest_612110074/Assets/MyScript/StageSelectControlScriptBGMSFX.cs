using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class StageSelectControlScriptBGMSFX : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Button buttonStage1;
    [SerializeField] Button buttonStage2;
    [SerializeField] Button buttonBack;
    
    

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
        buttonStage1.onClick.AddListener(delegate { Stage1ButtonClick(buttonStage1); });
        buttonStage2.onClick.AddListener(delegate { Stage2ButtonClick(buttonStage2); });
        buttonBack.onClick.AddListener(delegate { BackButtonClick(buttonBack); });
        
    }
        // Update is called once per frame
        void Update()
        {
             }

        public void Stage1ButtonClick(Button button)
        {
            SceneManager.LoadScene("Stage1");
        }

        public void Stage2ButtonClick(Button button)
        {
            SceneManager.LoadScene("Stage2");
        }

        public void BackButtonClick(Button button)
        {
            SceneManager.LoadScene("MainMenu");
        }




}
