using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. 배경음악이 재생된다
        SoundManager.instance.PlayAudio("브금1", "BGM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
