using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Serialize Field
    [SerializeField] 
    private GameObject menu = null;
    #endregion

    #region Static Field
    static public GameManager instance;
    #endregion

    bool isMenu = false;

    private void Awake()
    {
        Debug.Log("GameManager : Awake Callback Calls");
        // 1. 싱글턴 선언
        if (instance == null) { instance = this; }
        else { Destroy(this.gameObject); }
    }
    void Start()
    {
        
    }
    void Update()
    {
        // 만약 esc버튼을 눌렀는데
        if (Input.GetKeyDown(KeyCode.Escape) && menu != null)
        {
            menu.SetActive(isMenu = !isMenu);
        }
    }

    public void ChnageMainScene()
    {
        // 
        SoundManager.instance.PlayAudio("뾰로롱", "SE");
        SoundManager.instance.StopAudio("BGM");
        // 메인씬으로 넘어감
        SceneManager.LoadScene("MainScene");
    }

    public void ChangeARScene()
    {
        SoundManager.instance.PlayAudio("뾰로롱", "SE");
        SoundManager.instance.StopAudio("BGM");
        // AR씬으로 넘어감
        SceneManager.LoadScene("ARScene");
    }

    public void ChangeIntroScene()
    {
        // Intro씬으로 넘어감
        SceneManager.LoadScene("IntroScene");
    }

    public void QuitMenu()
    {
        menu.SetActive(isMenu = false);
    }

    public void OnClickExitButton()
    {
        Application.Quit();
    }
}
