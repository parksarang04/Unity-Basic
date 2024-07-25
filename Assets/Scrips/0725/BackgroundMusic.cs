using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip backgroundClip;        //MP2.WAV
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();   //오디오 소스를 붙인다
        audioSource.clip = backgroundClip;                      //클립을 할당한다
        audioSource.loop = true;                                //반복 클립이라서 설정
        audioSource.Play();                                     //사운드 재생
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
