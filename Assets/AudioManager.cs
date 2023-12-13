using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip Background;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.Play();
    }
    // Start is called before the first frame update
    
}
