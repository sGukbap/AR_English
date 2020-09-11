using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Runtime;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] obj; // 누르면 뜨게될 오브젝트 변수 배열

    public string[] audioName; 

    public void ActiveObj()
    {
        // 오브젝트 배열의 길이만큼 검사한다
        for (int i = 0; i < obj.Length; i++)
        {
            // 만약 선택된 버튼과 같은 이름의 오브젝트가 있으면
            if ( EventSystem.current.currentSelectedGameObject.name == obj[i].name)
            {
                // 활성화한다
                obj[i].SetActive(true);
            }
            // 그렇지않고 다른 이름의 오브젝트들은
            else
            {
                obj[i].SetActive(false);
            }
        }
    }

    public void ButtonSound()
    {
        // 오디오 배열의 길이만큼 검사한다
        for (int i = 0; i < audioName.Length; i++)
        {
            // 만약 선택된 버튼과 같은 이름의 오디오가 있으면
            if (obj[i].name == EventSystem.current.currentSelectedGameObject.name)
            {
                // 그 오디오를 재생한다
                SoundManager.instance.PlayAudio(obj[i].name, "SE");
            }
        }
    }
}
