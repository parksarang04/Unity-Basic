using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] // ����� �ҽ� ������Ʈ�� �ݵ�� �ʿ�
public class AudioEchoEffect : MonoBehaviour
{
    private AudioSource audioSource;
    public float delay = 500.0f;
    public float delayRatio = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        AudioEchoFilter echoFilter = gameObject.AddComponent<AudioEchoFilter>();
        echoFilter.delay = delay;
        echoFilter.decayRatio = delayRatio;
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic here, if needed
    }
}
