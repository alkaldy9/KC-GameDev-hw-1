using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{

    string hero;
    string health;

     int Health = 100;
     int damagedHealth;

    // Start is called before the first frame update
    void Start()
    {
        damagedHealth = Damage();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    int Damage()
    {
        return Health - 20;
    }
}
