using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        /*myRigidbody = GetComponent<Rigidbody>();
        if(myRigidbody == null)
        {
            myRigidbody = gameObject.AddComponent<Rigidbody>();
        }*/
        myRigidbody.AddForce(0, 500, 0);//y축으로 500 이동한다.   
    }
}
