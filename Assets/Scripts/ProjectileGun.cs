using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;


public class ProjectileGun : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject bulletStart;
    [SerializeField]
    private float bulletSpeed = 600;
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (_input.shoot) 
        {
            Shoot();
            _input.shoot = false;
        }
    }
    void Shoot() 
    {
        Debug.Log("shoot!");
        GameObject bullet =  Instantiate(bulletPrefab, bulletStart.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(bullet, 2);
    }
}
