using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanGun2 : MonoBehaviour
{
    [SerializeField] GunData gunData;
    [SerializeField] Transform muzzle;
    [SerializeField] Rigidbody boxRB;
    public int force = 10;
    public Animator animator;
    private bool shootanim = false;
    public ParticleSystem muzzleFlash;

    float timeSinceLastShot;

    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput += StartReload;
    }

    public void StartReload()
    {
        if (!gunData.reloading)
        {
            StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = gunData.magSize;

        gunData.reloading = false;
    }

    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    public void Shoot()
    {
        
        if(muzzleFlash != null)
        { 
            muzzleFlash.Play();
        }

      

        if (gunData.currentAmmo > 0)
        {
            shootanim = true;
            //Debug.Log("test");
            if (Physics.Raycast(transform.position, transform.forward, 
                out RaycastHit hitInfo, gunData.maxDistance))
            {
                //Debug.Log(hitInfo.transform.name);
                CanDamage damageable = hitInfo.transform.GetComponent<CanDamage>();
                damageable?.Damage(gunData.damage);
                if (hitInfo.transform.gameObject.GetComponent<Rigidbody>())
                {
                    //Debug.Log("object does have rigid body");
                    boxRB = hitInfo.rigidbody;
                    boxRB.AddForce(transform.forward * force);
                }
            } 
            if (CanShoot())
            {
                gunData.currentAmmo--;
                timeSinceLastShot = 0;
                OnGunShot();
                
            }
        }
    }
    
    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        Debug.DrawRay(muzzle.position, muzzle.forward);
        
        animator.SetBool("isShooting", shootanim);
        shootanim = false;
    }

    private void OnGunShot()
    {
        //throw new NotImplementedException();
        
    }

    
}

    
