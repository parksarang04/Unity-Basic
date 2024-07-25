using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] // 오디오 소스 컴포넌트가 반드시 필요
public class AudioReverEffect : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;

    //리버브 프리셋 (다양한 환경에 대한 사전 설정)
    public AudioReverbPreset reverbPreset = AudioReverbPreset.Cave;

    // Update is called once per frame
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        AudioReverbFilter reverbFilter = gameObject.AddComponent<AudioReverbFilter>();  
        reverbFilter.reverbPreset = reverbPreset;
    }
}
