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
        audioSource = gameObject.AddComponent<AudioSource>();   //����� �ҽ��� ���δ�
        audioSource.clip = backgroundClip;                      //Ŭ���� �Ҵ��Ѵ�
        audioSource.loop = true;                                //�ݺ� Ŭ���̶� ����
        audioSource.Play();                                     //���� ���
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
