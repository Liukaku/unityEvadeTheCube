using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnemyType{
    Catcher,
    Enemy
}
public class EnemyController : MonoBehaviour
{

    public float moveSpeedMin = 0.0f;
    public float moveSpeedMax = 0.0f;
    public EnemyType enemyType;

    private float moveSpeed;    
    private float m_threshold = -9.0f;
    private PlayerController m_PC;

    private void Awake()
    {
        moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
        m_PC = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - moveSpeed * Time.deltaTime
        );
        if(enemyType == EnemyType.Enemy)
        {
            AvoidCube();
        } else
        {
            CatchCube();
        }
    }

    private void AvoidCube()
    {
        if (Vector3.Distance(m_PC.transform.position, transform.position) < 1.0f)
        {
            m_PC.TakeDamage();
            Destroy(gameObject);
        }
        else if (transform.position.z <= m_threshold)
        {
            Destroy(gameObject);
        }
    }

    private void CatchCube()
    {
        if(Vector3.Distance(m_PC.transform.position, transform.position) < 1.0f)
        {
            Destroy(gameObject);
        } else if (transform.position.z <= m_threshold)
        {
            m_PC.TakeDamage();
            Destroy(gameObject);
        }
    }
}
