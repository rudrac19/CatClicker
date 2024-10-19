using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSelector : MonoBehaviour
{
    public GameObject catUI;
    public GameObject dogUI;
    public GameObject witchCatUI;

    public GameObject[] selectedCatButtonUI;


    public bool isDogPurchased;
    public bool isWitchCatPurchased;

    public static int selectedCat;
    public string currentCatShownOnScreen;

    void Start()
    {
        selectedCat = PlayerPrefs.GetInt("selectedCat", 0);
    }


    void Update()
    {
        // setting up the score
        int score = AddScore.score;

        // setting up the booleans
        if (score >= 500 && score <= 1999)
        {
            isWitchCatPurchased = true;
            isDogPurchased = false;
        }

        if (score >= 2000)
        {
            isDogPurchased = true;
            isWitchCatPurchased = false;
        }

        // setting up the selected cat

        if (currentCatShownOnScreen == "Cat")
        {
            if (selectedCat != 0)
            {
                foreach (GameObject button in selectedCatButtonUI)
                {
                    button.SetActive(false);
                }
                selectedCatButtonUI[0].SetActive(true);
            }
            else if (selectedCat == 0)
            {
                foreach (GameObject button in selectedCatButtonUI)
                {
                    button.SetActive(false);
                }
                selectedCatButtonUI[1].SetActive(true);
            }
        }

        if (currentCatShownOnScreen == "Witch")
        {
            if (selectedCat != 1)
            {
                foreach(GameObject button  in selectedCatButtonUI)
                {
                    button.SetActive(false);
                }
                selectedCatButtonUI[2].SetActive(true);
            }
            else if (selectedCat == 1)
            {
                foreach (GameObject button in selectedCatButtonUI)
                {
                    button.SetActive(false);
                }
                selectedCatButtonUI[3].SetActive(true);
            }
        }

        if (currentCatShownOnScreen == "Dog")
        {
            if (selectedCat != 2)
            {
                foreach (GameObject button in selectedCatButtonUI)
                {
                    button.SetActive(false);
                }
                selectedCatButtonUI[4].SetActive(true);
            }
            else if (selectedCat == 2)
            {
                foreach (GameObject button in selectedCatButtonUI)
                {
                    button.SetActive(false);
                }
                selectedCatButtonUI[5].SetActive(true);
            }
        }

    }

    public void ToWitchCat()
    {
        currentCatShownOnScreen = "Witch";

        catUI.SetActive(false);
        dogUI.SetActive(false);
        witchCatUI.SetActive(true);
    }

    public void ToCat()
    {
        currentCatShownOnScreen = "Cat";

        catUI.SetActive(true);
        dogUI.SetActive(false);
        witchCatUI.SetActive(false);
    }


    public void ToDog()
    {
        currentCatShownOnScreen = "Dog";

        catUI.SetActive(false);
        dogUI.SetActive(true);
        witchCatUI.SetActive(false);
    }


    public void SelectCat(int catIndex)
    {
        if (catIndex == 0)
        {
            selectedCat = catIndex;
            PlayerPrefs.SetInt("selectedCat", selectedCat);
        }
        if (catIndex == 1 && isWitchCatPurchased)
        {
            selectedCat = catIndex;
            PlayerPrefs.SetInt("selectedCat", selectedCat);
        }
        if (catIndex == 2 && isDogPurchased)
        {
            selectedCat = catIndex;
            PlayerPrefs.SetInt("selectedCat", selectedCat);
        }

    }
}