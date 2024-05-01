using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    [SerializeField]
    GameObject CollisionActor;
    [SerializeField]
    CapsuleCollider playerCapsule;
    [SerializeField]
    BoxCollider OffArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject == CollisionActor || col.gameObject == playerCapsule)
        {
            //Debug.Log("Damage player");
            SendDamage(25);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        collider = OffArea;
        //Debug.Log("Damage player");
        SendDamage(25);
    }



        public void SendDamage(int dam)
    {
        PlayerHealth playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        playerStats.TakeDamage(dam);
    }
}
