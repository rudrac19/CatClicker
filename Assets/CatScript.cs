using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{


    public void Clicker()
    {
        

        transform.localPosition = new Vector3(Random.Range(110, -110), Random.Range(150, -150),0);
    }
}
