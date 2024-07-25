using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioParam : MonoBehaviour
{
    public int band;                                //���ļ� �뿪 ���� (0 ~ 7)
    public float startScale;                        //���� ������
    public float scaleMultiplier;

    private Vector3 initalPostion;
    public bool useBuffer;

    void Start()
    {
        initalPostion = transform.position;             //�����Ҷ��� ��ġ���� �����Ѵ�. 
    }

    void Update()
    {
        float newYScale = 0;
        if (!useBuffer)
        {
            newYScale = (AudioPeer.freqBand[band] * scaleMultiplier) + startScale;
        }
        if (useBuffer)
        {
            newYScale = (AudioPeer.bandBuffet[band] * scaleMultiplier) + startScale;
        }
        transform.localScale = new Vector3(transform.localScale.x, newYScale, transform.localScale.z);
        transform.position = new Vector3(transform.position.x, initalPostion.y + (newYScale / 2), transform.position.z);
    }
}
