using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayModel : MonoBehaviour
{
    // Start is called before the first frame updat
    public GameObject gameObject;
    public AudioSource audioSource;
    public AudioClip  audioClip;


    public void Desplay()
    {

        gameObject.SetActive(true);
        audioSource.PlayOneShot(audioClip);
    }
    public void Destroy()
    {

        gameObject.SetActive(false);
        audioSource.Stop();
    }

}