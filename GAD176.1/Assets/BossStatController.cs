using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BossStatController : BaseStatController
{
    public int bossHealth;
    public GameObject Explosion;
    public TMP_Text bossHealthDisplayText;

    // Start is called before the first frame update
    void Start()
    {
        bossHealth = 500;
    }

    // Update is called once per frame
    void Update()
    {
        bossHealthDisplayText.text = ("Boss Health: " + bossHealth);
    }

    public void BossTakeDamage(int damage)
    {
        print("hurt");
        bossHealth -= damage;
        if (bossHealth <= 0)
        {
            CharacterDie();
        }
    }
}
