using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour 
{
	public float health;
	public TMP_Text healthText;
	public float MaxHealth = 100f;

    public void Start()
    {
		health = MaxHealth;
    }
    public void TakeDamage(int damage)
	{
		health -= damage;
		//Debug.Log("Health = " + health.ToString());
	}

    private void Update()
    {
		healthText.text = health.ToString();
		health = Mathf.Clamp(health, 0, MaxHealth);
    }
}
