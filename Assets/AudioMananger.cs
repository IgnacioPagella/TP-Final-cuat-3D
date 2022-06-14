using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMananger : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            PlayClip();

        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            PlayClip();

        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            PlayClip();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            PlayClip();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
    void PlayClip()
    {
        source.clip = clip;
        source.Play();
    }
}
