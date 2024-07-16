using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public int[] students;
    public float[] Heights;
    public bool[] flage;
    public string[] strings;
    public GameObject[] gameObjects;
    internal static float insideUnitSphere;

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i< students.Length; i++)
        {
            students[i] = Random.Range(50, 100);
        }

        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log(i.ToString() + "번 학생의 점수 :" + students[i]);
        }
    }

    private static int Range(int v1, int v2)
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}//나 왜 배열 100개 안나옴? ㅜ
