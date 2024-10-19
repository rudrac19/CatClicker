using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSkin : MonoBehaviour
{
    public GameObject[] skins;
    
    void Start()
    {
        foreach (GameObject skin in skins)
        {
            skin.SetActive(false);
        }
        if (CatSelector.selectedCat == 0)
        {
            skins[0].SetActive(true);
        }
        if (CatSelector.selectedCat == 1)
        {
            skins[1].SetActive(true);
        }
        if (CatSelector.selectedCat == 2)
        {
            skins[2].SetActive(true);
        }
    }
}
