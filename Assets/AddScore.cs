using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    
    public Text scoreText;

    public static int score = 0;

    void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
        scoreText.text = score.ToString();
    }

    void Update()
    {

    }


    public void AddNewText()
    {
        score++;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt("score", score);
    }
}
