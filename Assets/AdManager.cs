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
        PlayAd();
    }

    public void PlayAd()
    {
        StartCoroutine(StartAd());
        StartCoroutine(ShowSeconds());
    }

    IEnumerator StartAd()
    {
        yield return new WaitForSeconds(0.1f);
        adAnimator.SetTrigger("Play");
        yield return new WaitForSeconds(15f);
        rewardedNeeded = true;
        sceneScript.MoveToScene("Level");
    }

    IEnumerator ShowSeconds()
    {
        timeLeft.text = "Ad ends in 15 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 14 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 13 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 12 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 11 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 10 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 09 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 08 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 07 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 06 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 05 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 04 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 03 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 02 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 01 seconds";
        yield return new WaitForSeconds(1f);
        timeLeft.text = "Ad ends in 00 seconds";
        yield return new WaitForSeconds(1f);


    }


}
