using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSelector : MonoBehaviour
{
    public GameObject catUI;
    public GameObject dogUI;
    public GameObject witchCatUI;

    public bool isDogPurchased;
    public bool isWitchCatPurchased;

    public string selectedCat;
    public string currentCatShownOnScreen;

    public void ToWitchCat()
    {
        if (isWitchCatPurchased)
        {
            currentCatShownOnScreen = "Witch";
        }
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
        if (isDogPurchased)
        {
            currentCatShownOnScreen = "Dog";
        }
        catUI.SetActive(false);
        dogUI.SetActive(true);
        witchCatUI.SetActive(false);
    }
}
