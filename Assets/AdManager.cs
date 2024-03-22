using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdManager : MonoBehaviour
{
    public static bool rewardedNeeded;

    public Animator adAnimator;
    public Text timeLeft;
    public SceneScript sceneScript;

    void Start()
    {
        rewardedNeeded = false;
    }

    public void PlayAd()
    {
        StartCoroutine(StartAd());
    }

    IEnumerator StartAd()
    {
        adAnimator.Play("Play");
        //ShowSeconds();
        yield return new WaitForSeconds(30);
        rewardedNeeded = true;
        sceneScript.MoveToScene("Level");
    }


}
