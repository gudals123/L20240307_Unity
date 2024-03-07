using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour
{

    private int highScore;
    public TextMeshProUGUI resultTime;
    public TextMeshProUGUI bestTime;
    public GameObject resultUI;


    // Start is called before the first frame update
    void Start()
    {
        resultUI.SetActive(false);
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 999;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalArea.goal)
        {
            resultUI.SetActive(true);
            int result = Mathf.FloorToInt(Timer.time);

            resultTime.text = "ResultTime : " + result;
            bestTime.text = "BestTime : "+highScore; 

            if(highScore>result)
            {
                PlayerPrefs.SetInt("HighScore", result);
            }

        }
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
