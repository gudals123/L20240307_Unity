using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsEample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Red Apple", 5);
        PlayerPrefs.SetString("Way", "Lake como");
        Debug.Log("Red Apple 5개를 획득했습니다!");
        Debug.Log("현재 위치는 " + PlayerPrefs.GetString("Way"));

        //1회 실행이후 위의 코드는 주석으로 막아두겠습니다.

        if (PlayerPrefs.HasKey("Red Apple"))
        {
            Debug.Log("현재 Red Apple의 갯수는 " + PlayerPrefs.GetInt("Red Apple") + "개입니다.");
        }


    }
    public void UseApple()
    {
        if(PlayerPrefs.HasKey("Red Apple"))
        {
            int count = PlayerPrefs.GetInt("Red Apple");
            count--;
            PlayerPrefs.SetInt("Red Apple", count);

            if (PlayerPrefs.GetInt("Red Apple") <= 0 ) 
            {
                PlayerPrefs.DeleteKey("Red Apple");
            }
        }
        else
        {
            Debug.Log("사과를 가지고 있지 않습니다.");
        }
        
    }

}
