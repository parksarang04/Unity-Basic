using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] // ����� �ҽ� ������Ʈ�� �ݵ�� �ʿ�
public class AudioReverEffect : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;

    //������ ������ (�پ��� ȯ�濡 ���� ���� ����)
    public AudioReverbPreset reverbPreset = AudioReverbPreset.Cave;

    // Update is called once per frame
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        AudioReverbFilter reverbFilter = gameObject.AddComponent<AudioReverbFilter>();  
        reverbFilter.reverbPreset = reverbPreset;
    }
}
