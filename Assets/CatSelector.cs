using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSelector : MonoBehaviour
{
    public GameObject catUI;
    public GameObject dogUI;
    public GameObject witchCatUI;

    public GamObject[] selectedCatButtonUI


    public bool isDogPurchased;
    public bool isWitchCatPurchased;

    public int selectedCat;
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
        if ()
    }
    
    public void ToWitchCat()
    {
        
        catUI.SetActive(false);
        dogUI.SetActive(false);
        witchCatUI.SetActive(true);
    }

    public void ToCat()
    {
        catUI.SetActive(true);
        dogUI.SetActive(false);
        witchCatUI.SetActive(false);
    }

    
    public void ToDog()
    {
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
