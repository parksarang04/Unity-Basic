using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioParam : MonoBehaviour
{
    public int band;                                //주파수 대역 설정 (0 ~ 7)
    public float startScale;                        //시작 스케일
    public float scaleMultiplier;

    private Vector3 initalPostion;
    public bool useBuffer;

    void Start()
    {
        initalPostion = transform.position;             //시작할때의 위치값을 저장한다. 
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
