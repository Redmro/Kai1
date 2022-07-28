using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.FPS.Gameplay;

public class DashCoolDownText : MonoBehaviour
{
    public TextMeshProUGUI dashCoolDown;
    public TextMeshProUGUI rupiesCollected;
    public int rupiesInLevel;
    PlayerCharacterController player;

    void Start()
    {
        player = FindObjectOfType<PlayerCharacterController>();
    }

    void Update()
    {
        dashCoolDown.text = "Dash Cooldown: " + Mathf.Round(player.dashCooldown);
        rupiesCollected.text = "Crystals Collected: " + player.rupies + " / " + rupiesInLevel;
    }
}
