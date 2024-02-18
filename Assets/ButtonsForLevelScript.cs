using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsForLevelScript : MonoBehaviour
{
    public void HomeInput()
    {
        SceneManager.LoadScene("Menu");
    }

}
