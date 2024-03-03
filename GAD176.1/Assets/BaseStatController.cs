using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseStatController : MonoBehaviour
{
    protected int health;
    // Start is called before the first frame update

    // Update is called once per frame
     protected virtual void CharacterDie()
    {
        Destroy(gameObject);
    }
}
