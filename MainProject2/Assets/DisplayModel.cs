using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayModel : MonoBehaviour
{
    // Start is called before the first frame updat
    public GameObject gameObject;


    public void Desplay()
    {

        gameObject.SetActive(true);

    }
    public void Destroy()
    {

        gameObject.SetActive(false);

    }

}