using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SilencerSound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip bgm;
    bool isSound = false;
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = bgm;
        audioSource.volume = 1;
        
    }

    void Update()
    {
        StartSound();
    }

    void StartSound()
    {
        if (Vector3.Distance(GameObject.FindGameObjectWithTag("silencer").transform.position,
        GameObject.FindGameObjectWithTag("Player").transform.position) <= 14f)
        {
            if (!isSound)
            {
                isSound = true; //처음에 한번만 호출하기 위해서
                audioSource.Play();
            }
        }
        else
        {            
            audioSource.Stop();
            isSound = false; //사운드가 끝난 뒤에 꺼졌다고 말을 해야됨(가독성 굿)            
        }
    }
}