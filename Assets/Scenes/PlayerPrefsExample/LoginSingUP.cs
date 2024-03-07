using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginSingUP : MonoBehaviour
{
    public InputField inputFieldId;
    public InputField inputFieldPw;
    public GameObject Message;

    public void Start()
    {
        SetMessage();

    }
    public void SetMessage()
    {
        Message.SetActive(false);
    }

    public void Login()
    {
        if (inputFieldId.text != "" && inputFieldPw.text != "")
        {

            if (inputFieldId.text == PlayerPrefs.GetString("ID") && 
                inputFieldPw.text == PlayerPrefs.GetString("PW"))
            {
                OnButtonExit("로그인 성공~!");
            }
            else
            {
                OnButtonExit("등록된 회원이 아닙니다.");
            }
            
        }
        else
        {
            OnButtonExit("값을 입력해주세요");
        }
    }


    public void Singup()
    {
        if (inputFieldId.text != "" && inputFieldPw.text != "")
        {
            PlayerPrefs.SetString("ID", inputFieldId.text);
            PlayerPrefs.SetString("PW", inputFieldPw.text);
            OnButtonExit("회원 가입 성공~!");
        }
        else
        {
            OnButtonExit("회원가입 실패~!");
        }
    }

    public void OnButtonExit(string message)
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }


}
