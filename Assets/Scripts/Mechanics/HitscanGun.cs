using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanGun : MonoBehaviour
{
    [SerializeField] GunData gunData;
    [SerializeField] Transform muzzle;

    float timeSinceLastShot;

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
        
        if (gunData.currentAmmo > 0)
        {
            //Debug.Log("test");
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, gunData.maxDistance))
            {
                Debug.Log(hitInfo.transform.name);
                CanDamage damageable = hitInfo.transform.GetComponent<CanDamage>();
                damageable?.Damage(gunData.damage);
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
    }

    private void OnGunShot()
    {
        //throw new NotImplementedException();
    }

    
}

    
