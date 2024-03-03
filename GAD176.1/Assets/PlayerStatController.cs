using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatController : BaseStatController
{
    public int playerHealth;
    public int gameScore;
    public TMP_Text scoreDisplayText;
    public TMP_Text healthDisplayText;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplayText.text = ("Health: " + playerHealth);
        scoreDisplayText.text = ("Score: " + gameScore);
    }

    public void PlayerTakeDamage (int damage)
    {
        print ("hurt");
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            CharacterDie();
        }
    }
}
