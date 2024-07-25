using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //����� �ҽ� ������Ʈ�� �ݵ�� �ʿ��ϴ�.
public class AudioPeer : MonoBehaviour
{
    AudioSource audioSource;

    public static float[] samples = new float[512];         //FFT �� ���� ����Ƽ�� ������ ����
    public static float[] freqBand = new float[8];          //���ļ� �뿪
    public static float[] bandBuffet = new float[8];        //���Ľ� �뿪 ����
    float[] bufferDecreas = new float[8];                   //���� ���� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();   //����� ����Ʈ�� �����͸� �����´�.
        MakeFrequenyBand();
    }

    void GetSpectrumAudioSource()
    {
        audioSource.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    void MakeFrequenyBand()             //���ļ� �뿪�� ����� �Լ�
    {
        int count = 0;

        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;

            if (i == 7)  //������ ���ļ� �뿪�� 2���� ���ø� �߰��� ���
            {
                sampleCount += 2;
            }

            for (int j = 0; j < sampleCount; j++)
            {
                average += samples[count] * (count + 1);
                count++;
            }

            average /= count;

            //���ļ� �뿪 ���� ����(���������� �� �� ���̵��� 10�� ����)
            freqBand[i] = average * 10;
        }
    }

    void BandBuffer()           //���ļ� �뿪 ���۸� ����� �Լ�
    {
        for (int i = 0; i < 8; i++)
        {
            //���ļ� �뿪�� ���ۺ��� ũ�� ���۸� ���ļ� �뿪 ������ ����
            if (freqBand[i] > bandBuffet[i])
            {
                bandBuffet[i] = freqBand[i];
                bufferDecreas[i] = 0.005f;
            }

            //���ļ� �뿪�� ���ۺ��� ������ ���۸� ����
            if (freqBand[i] < bandBuffet[i])
            {
                bandBuffet[i] -= bufferDecreas[i];
                bufferDecreas[i] *= 1.2f;
            }
        }

    }
}
