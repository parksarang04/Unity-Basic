using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerq : MonoBehaviour
{
    [System.Serializable]       //����Ʈ�� ���� ������ ������ �׷�ȭ�� Ŭ����
    public class LightDamageSettings
    {
        public float nearDistance = 2f;         //����� �Ÿ� ����
        public float mediumDistance = 5f;       //�߰� �Ÿ� ����
        public int nearDamage = 3;              //����� �Ÿ������� ������
        public int mediumDamage = 2;            //�߰� �Ÿ������� ������
        public int farDamage = 1;               //�� �Ÿ������� ������
    }

    [System.Serializable]                                       //�𷺼ų� ����Ʈ ������ ������ �׷�ȭ�� Ŭ���� 
    public class DirectionalLightSettings
    {
        public int baseDamage = 1;                              //�⺻ ������
        public int maxDamage = 5;                               //�ִ� ������
        public float damageIncreaseInterval = 2f;               //������ ���� ����
    }

    public float damageInterval = 1f;                           //�������� �޴� ����
    public float nightThreshold = 0.2f;                         //������ ������ ���� ���� �Ӱ谪
    public float moveSpeed = 5;                                 //�̵��ӵ�
    public LightDamageSettings lightDamageSettings;             //����Ʈ ������ ����
    public DirectionalLightSettings directionalLightSettings;   //�𷺼ų� ����Ʈ ������ ����

    private CharacterController controller;                     //ĳ���� ��Ʈ�ѷ� ������Ʈ
    private Light[] sceneLights;                                //Scene�� ��� ����Ʈ
    private int currentDirectionalLightDamage;                  //���� �𷺼ų� ����Ʈ ������
    private float lastDamageTime;                               //���������� �������� ���� �ð�
    private float lastDirectionalLightDamageTime;               //���������� �𷺼ų� ����Ʈ �������� ������ �ð�
    private float cumulativeDamage;                             //���� ������

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        sceneLights = FindObjectsOfType<Light>();                   //Scene�� ��� ����Ʈ ã��
        ResetDirectionalLightDamage();
    }

    private void Update()
    {
        Move();
        HandleDamage();
    }

    void Move()     //�÷��̾� �̵� ó�� �Լ�
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }

    void ResetDirectionalLightDamage()                              //�𷺼ų� ����Ʈ ������ ����
    {
        currentDirectionalLightDamage = directionalLightSettings.baseDamage;
    }

    void UpdateDirectionalLightDamage()                             //�𷹼ų� ����Ʈ ������ ������Ʈ
    {
        //���������� ���� ���� ������ �������� 1�� �ö󰣴�. 
        if (Time.time - lastDirectionalLightDamageTime >= directionalLightSettings.damageIncreaseInterval)
        {
            currentDirectionalLightDamage = Mathf.Min(currentDirectionalLightDamage + 1, directionalLightSettings.maxDamage);
            lastDirectionalLightDamageTime = Time.time;
        }
    }

    void HandleDamage()
    {
        if (IsExposedToLight())                                  //�÷��̾ ���� ���� �Ǿ��ִ��� Ȯ��
        {
            if (Time.time - lastDamageTime >= damageInterval)        //ƽ �ð��� Ȯ���ϰ�
            {
                TakeDamage();                                       //�������� ��� �� ����
            }
            UpdateDirectionalLightDamage();                         //���̷��ų� ����Ʈ ������ ����
        }
        else
        {
            ResetDirectionalLightDamage();                          //�ƴϸ� ����
        }
    }

    bool IsExposedToLight()                             //�÷��̾ ���� ���� �Ǿ��ִ��� Ȯ��
    {
        return IsExposedToDirectionalLight() || IsExposedToAnyPointLight();
    }

    bool IsExposedToDirectionalLight()                  //�𷺼ų� ����Ʈ�� ���� �Ǿ����� Ȯ��
    {
        for (int i = 0; i < sceneLights.Length; i++)
        {
            if (sceneLights[i].type == LightType.Directional && !IsInDirectionalShadow(sceneLights[i]))
            {
                return true;
            }
        }
        return false;
    }

    bool IsExposedToAnyPointLight()                         //����Ʈ ����Ʈ�� ����Ǿ��ִ��� Ȯ��
    {
        for (int i = 0; i < sceneLights.Length; i++)
        {
            if (sceneLights[i].type == LightType.Point && !IsExposedToPointLight(sceneLights[i]))
            {
                return true;
            }
        }
        return false;
    }

    bool IsInDirectionalShadow(Light light)         //�𷺼ų� ����Ʈ�� �׸��� �ȿ� �ִ��� Ȯ��
    {
        const int rayCount = 5;
        const float rayRadius = 0.5f;
        int shoadowCount = 0;

        for (int i = 0; i < rayCount; i++)
        {
            Vector3 rayStart = transform.position + Quaternion.Euler(0, i * 360f / rayCount, 0) * (Vector3.forward * rayRadius);
            if (Physics.Raycast(rayStart, -light.transform.forward, out _))
            {
                shoadowCount++;
            }
        }
        return shoadowCount > rayCount / 2;
    }

    bool IsExposedToPointLight(Light light)         //����Ʈ ����Ʈ�� ���� �Ǿ��ִ��� Ȯ��
    {
        Vector3 directionToLight = light.transform.position - transform.position;
        return directionToLight.magnitude <= light.range &&
            !Physics.Raycast(transform.position, directionToLight.normalized, directionToLight.magnitude);
    }

    int CalculateDamage()                               //������ ���
    {
        int damage = currentDirectionalLightDamage;
        float closestPointLightDistance = float.MaxValue;
        bool exposedToPointLight = false;

        for (int i = 0; i < sceneLights.Length; i++)         //���� ����� ����Ʈ ����Ʈ ã��
        {
            if (sceneLights[i].type == LightType.Point && IsExposedToPointLight(sceneLights[i]))
            {
                float distance = Vector3.Distance(transform.position, sceneLights[i].transform.position);
                if ((distance < closestPointLightDistance))
                {
                    closestPointLightDistance = distance;
                    exposedToPointLight = true;
                }
            }
        }

        if (exposedToPointLight)                    //����Ʈ ����Ʈ�� ���� ������ ���
        {
            if (closestPointLightDistance <= lightDamageSettings.nearDistance)

                damage += lightDamageSettings.nearDamage;
            else if (closestPointLightDistance <= lightDamageSettings.mediumDistance)
                damage += lightDamageSettings.mediumDamage;
            else
                damage += lightDamageSettings.farDamage;
        }

        return damage;
    }

    void TakeDamage()                           //������ ���� �Լ�
    {
        int damage = CalculateDamage();
        cumulativeDamage += damage;
        lastDamageTime = Time.time;
        Debug.Log($"�÷��̾ �������� ���� : {damage}, ���� ������ : {cumulativeDamage}");
    }


}
