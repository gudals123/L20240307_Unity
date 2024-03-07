using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Mesh;


public class TestPrefs : MonoBehaviour
{
 

    public InputField inputField_Name;
    public InputField inputField_Age;
    public InputField inputField_Height;

    public GameObject Message;


    public void Start()
    {
        SetMessage();

    }
    public void SetMessage()
    {
        Message.SetActive(false);
    }


    public void SaveData()
    {
        if (inputField_Name.text != "" && inputField_Age.text != ""
            && inputField_Height.text != "")
        {
            PlayerPrefs.SetString("User Name", inputField_Name.text);
            PlayerPrefs.SetInt("User Age", int.Parse(inputField_Age.text));
            PlayerPrefs.SetFloat("User Height", float.Parse(inputField_Height.text));
            OnButtonExit("데이터가 저장되었습니다.");

        }
        else
        {
            OnButtonExit("작성된 내용이 없습니다.");
        }


    }


    public void LoadData()
    { 
        if(PlayerPrefs.HasKey("User Name")&& PlayerPrefs.HasKey("User Age") &&
            PlayerPrefs.HasKey("User Height"))
        {
            Debug.Log(PlayerPrefs.GetString("User Name"));
            Debug.Log(PlayerPrefs.GetInt("User Age"));
            Debug.Log(PlayerPrefs.GetFloat("User Height"));
        }
        else
        {
            OnButtonExit("불러올 데이터가 없습니다.");
        }

    }

    public void OnButtonExit(string message)
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }

}
