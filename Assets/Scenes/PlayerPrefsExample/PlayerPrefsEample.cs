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
        Debug.Log("Red Apple 5���� ȹ���߽��ϴ�!");
        Debug.Log("���� ��ġ�� " + PlayerPrefs.GetString("Way"));

        //1ȸ �������� ���� �ڵ�� �ּ����� ���Ƶΰڽ��ϴ�.

        if (PlayerPrefs.HasKey("Red Apple"))
        {
            Debug.Log("���� Red Apple�� ������ " + PlayerPrefs.GetInt("Red Apple") + "���Դϴ�.");
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
            Debug.Log("����� ������ ���� �ʽ��ϴ�.");
        }
        
    }

}
