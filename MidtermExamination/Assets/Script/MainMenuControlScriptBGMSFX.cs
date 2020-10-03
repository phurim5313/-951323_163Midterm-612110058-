 using System.Collections;
 using System.Collections.Generic;  
 using UnityEngine;
 using UnityEngine.SceneManagement;  
 using UnityEngine.UI;
 using UnityEngine.EventSystems;

public class MainMenuControlScriptBGMSFX : MonoBehaviour , IPointerEnterHandler
{
    [SerializeField] Button buttonStart;
    [SerializeField] Button buttonOptions;
    [SerializeField] Button buttonCredit;
    [SerializeField] Button buttonExit;
    

    AudioSource audiosourceButtonUI;
    [SerializeField] AudioClip audioclipHoldOver;
    void Start()
    {
        this.audiosourceButtonUI = this.gameObject.AddComponent<AudioSource>();
        this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer.FindMatchingGroups("UI")[0];
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
        buttonStart.onClick.AddListener(delegate { StartButtonClick(buttonStart); });
        buttonOptions.onClick.AddListener(delegate { OptionsButtonClick(buttonOptions); }); 
        buttonCredit.onClick.AddListener(delegate { HelpButtonClick(buttonCredit); });
        buttonExit.onClick.AddListener(delegate { ExitButtonClick(buttonExit); }); 
        
    }
    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneSelection");
    }
    public void OptionsButtonClick(Button button)
    {
        
        {
            
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Single);
            SingletonGameApplicationManager.Instance.IsOptionMenuActive = false;
        }
    }
    public void HelpButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneCredit");
    }
    
    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}
