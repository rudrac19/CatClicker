using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
public class CatScript : MonoBehaviour
{
    PhotonView view;
    private void Start()
    {
        view = GetComponent<PhotonView>();
    }


    public void Clicker()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            transform.localPosition = new Vector3(Random.Range(-199, 199), Random.Range(-199, 199),0);
        }else{
            if (view.IsMine){
                transform.localPosition = new Vector3(Random.Range(-199, 199), Random.Range(-199, 199),0);
                AddScore.AddNewText();
            }

        }

        
    }
}
