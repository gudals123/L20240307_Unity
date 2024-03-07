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
                OnButtonExit("�α��� ����~!");
            }
            else
            {
                OnButtonExit("��ϵ� ȸ���� �ƴմϴ�.");
            }
            
        }
        else
        {
            OnButtonExit("���� �Է����ּ���");
        }
    }


    public void Singup()
    {
        if (inputFieldId.text != "" && inputFieldPw.text != "")
        {
            PlayerPrefs.SetString("ID", inputFieldId.text);
            PlayerPrefs.SetString("PW", inputFieldPw.text);
            OnButtonExit("ȸ�� ���� ����~!");
        }
        else
        {
            OnButtonExit("ȸ������ ����~!");
        }
    }

    public void OnButtonExit(string message)
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }


}
