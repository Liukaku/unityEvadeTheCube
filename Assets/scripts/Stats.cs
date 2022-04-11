using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float Health;
    public int MoveSpeed;

    public void updateHealth(float value)
    {
        Health -= value;
    }
}
