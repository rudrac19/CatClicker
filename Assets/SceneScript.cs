using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public Animator sceneTransition;

    public float transitionTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void MoveToScene(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));
    }

    IEnumerator LoadScene(string levelName)
    {
        sceneTransition.SetTrigger("Next");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelName);
    }
}
