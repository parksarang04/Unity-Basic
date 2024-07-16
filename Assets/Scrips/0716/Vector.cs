using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{

    public float viewRadius = 5.0f;
    public float viewAngle = 90f;
    public LayerMask enemyLayer;

    public List<Transform> detectedEnemies = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DetectEnemies();
    }
    void DetectEnemies()
    {
        detectedEnemies.Clear();

        Collider[] enemiesInRadius = Physics.OverlapSphere(transform.position, viewRadius, enemyLayer);

        foreach (Collider enemyCollider in enemiesInRadius)
        {
            Transform enemy = enemyCollider.transform;
            Vector3 directionToEnemy = (enemy.position - transform.position).normalized;

            float dotProduct = Vector3.Dot(transform.forward, directionToEnemy);
            float viewThreshold = Mathf.Cos(viewAngle * 0.5f * Mathf.Deg2Rad);

            if (dotProduct > viewThreshold)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.position);

                if (!Physics.Raycast(transform.position, directionToEnemy, -enemyLayer))
                {
                    detectedEnemies.Add(enemy);
                    Debug.Log("Àû Å½Áö :" + enemy.name);
                }
            }


        }
        
    }
    Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, viewRadius);

        Gizmos.color = Color.yellow;

        Vector3 viewAngleA = DirFromAngle(-viewAngle / 2, false);
        Vector3 viewAngleB = DirFromAngle(viewAngle / 2, false);

        Gizmos.DrawLine(transform.position, transform.position + viewAngleA * viewRadius);
        Gizmos.DrawLine(transform.position, transform.position + viewAngleB * viewRadius);

        Vector3 prevPoint = transform.position + viewAngleA * viewRadius;

        for (float angle = -viewAngle / 2; angle <= viewAngle / 2; angle += 5)
        {
            Vector3 newPoint = transform.position + DirFromAngle(angle, false) * viewRadius;
            Gizmos.DrawLine(prevPoint, newPoint);
            prevPoint = newPoint;
        }

    }
}
    

