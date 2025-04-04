using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddScore : MonoBehaviour
{

    public static Text scoreText;
    public GameObject timesTwo;

    public static int score = 0;
    static bool giveReward = false;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1){   
            score = PlayerPrefs.GetInt("score", 0);
            scoreText.text = score.ToString();
            if (AdManager.rewardedNeeded == true)
            {
                StartCoroutine(GiveReward());
            }
            else
            {
                timesTwo.SetActive(false);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 4){
            score = 0;
            scoreText.text = score.ToString();
        }
    }

    IEnumerator GiveReward()
    {
        timesTwo.SetActive(true);
        giveReward = true;
        yield return new WaitForSeconds(30f);
        giveReward = false;
        AdManager.rewardedNeeded = false;
        timesTwo.SetActive(false);

    }


    public static void AddNewText()
    {
        score++;
        if (giveReward)
        {
            score++;
        }
        scoreText.text = score.ToString();
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            PlayerPrefs.SetInt("score", score);
        }
    }
}
