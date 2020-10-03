using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _startButton2;
    [SerializeField] Button _startButton3;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;
    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener(delegate { StartButtonClick(_startButton); });
        _startButton2.onClick.AddListener(delegate { StartGame2Click(_startButton2); });
        _startButton3.onClick.AddListener(delegate { StartGame3Click(_startButton3); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneSelection");
    }
    public void StartGame2Click(Button button)
    {
        SceneManager.LoadScene("Scene1");
    }
    public void StartGame3Click(Button button)
    {
        SceneManager.LoadScene("Scene2");
    }
    public void OptionsButtonClick(Button button)
    {
        if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOption", LoadSceneMode.Additive);
            SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }

}
