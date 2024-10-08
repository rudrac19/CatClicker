using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    }
    public void ToCat()
    {
        currentCatShownOnScreen = "Cat";
    }
    public void ToDog()
    {
        if (isDogPurchased) 
        { 
            currentCatShownOnScreen = "Dog"; 
        }
    }




}
