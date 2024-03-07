using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    //도착하기 전까지는 시간을 지속적으로 체크합니다.

    //ui의 텍스트로 그 시간을 실시간으로 출력합니다

    private void Update()
    {
        if(GoalArea.goal == false)
        {
            time += Time.deltaTime;
        }
        int t = (int)time;

        Text text = GetComponent<Text>();
        text.text = "Time : " + t;
    }

}
