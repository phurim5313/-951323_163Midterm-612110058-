using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToStageSelection : MonoBehaviour
{
    [SerializeField] Button _backButton;

    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneSelection", LoadSceneMode.Single);
        SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;

    }
}
