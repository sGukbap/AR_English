using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    private void OnEnable()
    {
        // 1. 효과음 소리를 낸다
        SoundManager.instance.PlayAudio("Apple", "SE");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
