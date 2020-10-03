using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StageSelection : MonoBehaviour
{
    [SerializeField] Button _stage1;
    [SerializeField] Button _stage2;
    [SerializeField] Button _backButton;

    // Start is called before the first frame update
    void Start()
    {
        _stage1.onClick.AddListener(delegate { Stage1ButtonClick(_stage1); });
        _stage2.onClick.AddListener(delegate { Stage2ButtonClick(_stage2); });
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Stage1ButtonClick(Button button)
    {
        SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
        SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
    }
    public void Stage2ButtonClick(Button button)
    {
        SceneManager.LoadScene("Stage2", LoadSceneMode.Single);
        SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
    }

    public void BackButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneMainmenu", LoadSceneMode.Single);
        SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;

    }
}
