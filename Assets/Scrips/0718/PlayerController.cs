using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float jumpForce = 700;           //������ ����� ��

    private int jumpCount = 0;           //���� ī��Ʈ
    private bool isGrounded = false;    //�� üũ
    private bool isDead = false;        //��� üũ

    private Rigidbody2D playerRigidbody;        //�÷��̾� ������ٵ� ����
    private Animator animator;                  //�ִϸ����� ����
    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ�� ���� ����� ������Ʈ ������ ���� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) return;                                                     //��� �� ó���� ���̻� �������� �ʰ� ����

        if(Input.GetMouseButtonDown(0) && jumpCount <2)                         //���콺 ���� ��ư�� �������鼭 ���ÿ� �ִ� ������ Ƚ�� 2�� ���� ���� �ʾҴٸ�
        {
            jumpCount++;    //���� Ƚ�� ����
            playerRigidbody.velocity = Vector2.zero;                            //���� ������ �ӵ��� ���������� (0,0)���� ����
            playerRigidbody.AddForce(new Vector2(0, jumpForce));                //������ٵ� �������� ���� �߰�
        }
        else if (Input.GetMouseButtonUp(0)&& playerRigidbody.velocity.y>0)      //���콺 ���� ��ư���� ���� ���� ���� && �ӵ��� y���� ���� ������̶��
        {
            playerRigidbody.velocity = playerRigidbody.velocity * 0.5f;         //���� �ӵ��� �������� ����
            
        }
        animator.SetBool("Geound", isGrounded); ;                               //�ִϸ������� Grounded �Ķ���͸� isisGrounded ������ ����
    }
    void Die()
    {
        animator.SetTrigger("Die");                     //�ִϸ������� Die Ʈ���Ÿ� ����
        playerRigidbody.velocity = Vector2.zero;        //�ӵ��� ���η� ����
        isDead = true;                                  //��� ���¸� true�� ����
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Dead" && !isDead)
        {
            //�浹�� ������ �±װ� Dead�̸� ���� ������� �ʾҴٸ� Die() ����
           //Die(); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)  //� �ݶ��̴��� �������, �浹 ǥ���� ������ ���� ������
    {
        if(collision.contacts[0].normal.y>0.7f)
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)   //� �ݶ��̴����� ������ ���
    {
        isGrounded = false;
        
    }
}
