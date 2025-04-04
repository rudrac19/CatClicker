using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject canvas;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(200, 400), Random.Range(200, 400),0);

        
        GameObject cat = PhotonNetwork.Instantiate(playerPrefab.name, 
            randomPosition, 
            Quaternion.identity); 

        cat.transform.SetParent(canvas.transform);
    }
}
