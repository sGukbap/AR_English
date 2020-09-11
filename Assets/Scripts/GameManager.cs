using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
   

    private void Awake()
    {
        // 1. 싱글턴 선언
        if (instance == null) { instance = this; DontDestroyOnLoad(this.gameObject); }
        else { Destroy(this.gameObject); }

    }
    void Start()
    {
        // 1. 배경음악이 재생된다
        SoundManager.instance.PlayAudio("브금1", "BGM");
    }
    void Update()
    {
        // 만약 esc버튼을 누르면
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Intro씬으로 넘어감
            SceneManager.LoadScene("IntroScene");
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

    
}
