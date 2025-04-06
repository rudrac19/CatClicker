using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
public class CatScript : MonoBehaviour
{
    PhotonView view;
    GameObject canvas;
    void Awake()
    {
        canvas  = GameObject.Find("Canvas");
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4){
            view = GetComponent<PhotonView>();
            transform.SetParent(canvas.transform);
        }
        
    }


    public void Clicker()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            transform.localPosition = new Vector3(Random.Range(-199, 199), Random.Range(-199, 199),0);
        }else{
            if (view.IsMine){
                transform.localPosition = new Vector3(Random.Range(-199, 199), Random.Range(-199, 199),0);
                GameObject.Find("Score").GetComponent<AddScore>().AddNewText();
                
            }

        }

        
    }
}
