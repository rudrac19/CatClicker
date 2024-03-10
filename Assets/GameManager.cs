using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] slides;

    public void Quit()
    {
        Application.Quit();
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
}
