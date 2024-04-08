using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour 
{

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SendDamage(10);
        }
    }


    public void SendDamage (int dam)
	{
		PlayerHealth playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerStats.TakeDamage(dam);
	}
}
