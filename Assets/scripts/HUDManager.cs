using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{

    public Text health;

    public void UpdateHeathText(string healthText)
    {
        this.health.text = healthText;
    }
}
