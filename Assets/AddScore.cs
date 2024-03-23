using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    
    public Text scoreText;
    public GameObject timesTwo;

    public static int score = 0;
    bool giveReward;

    void Start()
    {
        
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

    IEnumerator GiveReward()
    {
        timesTwo.SetActive(true);
        giveReward = true;
        yield return new WaitForSeconds(30f);
        giveReward = false;
        AdManager.rewardedNeeded = false;
        timesTwo.SetActive(false);

    }


    public void AddNewText()
    {
        score++;
        if (giveReward)
        {
            score++;
        }
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
    }
}
