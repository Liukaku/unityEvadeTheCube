using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Stats stats;

    public Transform lWall;
    public Transform rWall;
    public HUDManager hudManager;

    private void Awake()
    {
        hudManager.UpdateHeathText("Health: " + stats.Health);
    }
    void Update()
    {
        float horizonalInput = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float yPos = transform.position.y;
        float futureXPos = transform.position.x + horizonalInput * stats.MoveSpeed * Time.deltaTime;
        float currentXPos = transform.position.x;

        if (futureXPos <= (lWall.position.x + 0.8f))
        {
            return;
        }

        if (futureXPos >= (rWall.position.x - 0.8f))
        {
            return;
        }

        transform.position = new Vector3(
            transform.position.x + horizonalInput * stats.MoveSpeed * Time.deltaTime, 
            yPos, 
            transform.position.z + inputZ * stats.MoveSpeed * Time.deltaTime
            );
    }

    public void TakeDamage()
    {
        stats.updateHealth(10);
        hudManager.UpdateHeathText("Health: " + stats.Health);
    }

}
