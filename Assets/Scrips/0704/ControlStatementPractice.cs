using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//제어문 연습
public class ControlStatementPractice : MonoBehaviour
{
    public int love = 100;
    // Start is called before the first frame update
    void Start()
    {
        if (love > 90)
        {
            //love가 90보다 큰 경우
            Debug.Log("트루 엔딩");
        }
        else if (love > 70)                   //love가 90보다 작거나 같고, 70보다 큰 경우
        {
            Debug.Log("굿엔딩");
        }
         //if(love <= 70)                 //if문 love 이 70 이하 일 경우
         else
        {
            //if문 love가 70초과 이외의 경우
            Debug.Log("배드엔딩");
        }
    } 
   
}
