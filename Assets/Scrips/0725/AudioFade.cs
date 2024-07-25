using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFade : MonoBehaviour
{
    AudioSource audioSource;

    public float fadeDuration = 1.0f;                   //���̵� ��/�ƿ� ���� �ð�
    private bool isFadingIn = false;                    //���̵� �� ���� Ȯ��
    private bool isFadingOut = false;
    private float fadeTimer = 0.0f;                     //���̵� Ÿ�̸� 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (isFadingIn)                      //���̵� �ν�
        {
            fadeTimer += Time.deltaTime;    //Ÿ�̸� ����
            audioSource.volume = Mathf.Clamp01(fadeTimer / fadeDuration);

            if (audioSource.volume >= 1.0f)  //�Ϸ�Ǹ� �ʱ�ȭ
            {
                isFadingIn = false;
                fadeTimer = 0.0f;
            }
        }
        if (isFadingOut)
        {
            fadeTimer += Time.deltaTime;    //Ÿ�̸� ����
            audioSource.volume = Mathf.Clamp01(1.0f - (fadeTimer / fadeDuration));

            if (audioSource.volume <= 0.0f)  //�Ϸ�Ǹ� �ʱ�ȭ
            {
                isFadingOut = false;
                fadeTimer = 0.0f;
                audioSource.Stop();
            }
        }

    }

    public void StartFadeIn()
    {
        isFadingIn = true;
        isFadingOut = false;
        fadeTimer = 0.0f;
        audioSource.Play();
    }

    public void StartFadeOut()
    {
        isFadingOut = true;
        isFadingIn = false;
        fadeTimer = 0.0f;
    }
}
