using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 0;
    private float m_threshold = -9.0f;
    private PlayerController m_PC;

    private void Awake()
    {
        moveSpeed = Random.Range(1.0f, 5.0f);
        m_PC = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - moveSpeed * Time.deltaTime
        );
        if(Vector3.Distance(m_PC.transform.position, transform.position) < 1.0f) {
            m_PC.TakeDamage();
            Destroy(gameObject);
        } else if (transform.position.z <= m_threshold)
        {
            Destroy(gameObject);
        }
    }
}
