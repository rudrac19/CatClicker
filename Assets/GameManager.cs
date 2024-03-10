using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] slides;
    public string currentScreen;
    public Animator navbarAnimator;

    void Start()
    {
        slides[0].SetActive(false);
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(false);
        }
        slides[0].SetActive(true);
        currentScreen = "Home";
    }

    public void ChangeSlide(int index)
    {
        slides[0].SetActive(false);
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(false);
        }
        slides[index].SetActive(true);
    }

    public void Navbar(string triggerName)
    {
        if (triggerName == "Home" && currentScreen == "Leaderboard")
        {
            navbarAnimator.SetTrigger(triggerName);
            currentScreen = "Home";
        }
        if (triggerName == "Leaderboard" && currentScreen == "Home")
        {
            navbarAnimator.SetTrigger(triggerName);
            currentScreen = "Leaderboard";
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
