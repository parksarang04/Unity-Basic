using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    public GameObject dicePrefabs;
    public float throwForce = 5.0f;
    public float torqueForce = 2f;

    private Rigidbody diceRigidboy;
    private bool isRolling = false;
    private Vector3[] diceDirections = new Vector3[6];  //6��ü Vector �� 

        
    // Start is called before the first frame update
    void Start()
    {
        diceDirections[0] = Vector3.forward;    //1
        diceDirections[1] = Vector3.up;         //2
        diceDirections[2] = Vector3.left;       //3 
        diceDirections[3] = Vector3.right;      //4
        diceDirections[4] = Vector3.down;       //5
        diceDirections[5] = Vector3.back;       //6
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& !isRolling)
        {
            RollDice();
        }
        if(isRolling && diceRigidboy.IsSleeping())
        {
            CheckDiceResult();
            isRolling = false;
        }
    }

    void RollDice()
    {
        GameObject diceInsance = Instantiate(dicePrefabs, transform.position, UnityEngine.Random.rotation);
        diceRigidboy = diceInsance.GetComponent<Rigidbody>();

        //�ֻ����� �������� ���� ����
        diceRigidboy.AddForce(Vector3.up * throwForce, ForceMode.Impulse);

        //�ֻ����� ȸ������ ����
        diceRigidboy.AddTorque(UnityEngine.Random.insideUnitSphere * torqueForce, ForceMode.Impulse);

        isRolling = true;
    }

    void CheckDiceResult()
    {
        float bestDotProdut = float.NegativeInfinity;
        int result = 0;

        for (int i = 0; i < 6; i++)
        {
            Vector3 worldDirection = diceRigidboy.transform.TransformDirection(diceDirections[i]);
            float dotProict = Vector3.Dot(worldDirection, Vector3.up);

            if(dotProict> bestDotProdut)
            {
                bestDotProdut = dotProict;
                result = i + 1;
            }
        }
        Debug.Log("�ֻ��� ��� :" + result);

        Vector3 diceRight = diceRigidboy.transform.right;
        Vector3 diceForward = diceRigidboy.transform.forward;
        Vector3 rotationDirection = Vector3.Cross(diceRight, diceForward);

        if(Vector3.Dot(rotationDirection, Vector3.up)>0)
        {
            Debug.Log("�ֻ����� �ð� �������� ȸ��");
        }
        else
        {
            Debug.Log("�ֻ����� �ݽð� �������� ȸ��");
        }
        Debug.Log("�ֻ��� ��� : " + result);
    }
    
}
