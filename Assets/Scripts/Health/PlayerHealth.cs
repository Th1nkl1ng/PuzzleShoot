using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
public class PlayerHealth : MonoBehaviour 
{
	public GameObject emptyPostion;
	public GameObject playerCapsule;
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
		if (health <= 0)
        {
			//EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex);
			health = 100;
			playerCapsule.transform.position = emptyPostion.transform.position + new Vector3(0,1,0);
			
			//playerCapsule.transform.position = new Vector3(emptyPostion.transform.position.x, emptyPostion.transform.position.y, emptyPostion.transform.position.z);

		}
    }
}
