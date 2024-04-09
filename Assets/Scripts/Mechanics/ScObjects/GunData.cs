using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Gun", menuName="Weapon/Gun")]
public class GunData : ScriptableObject
{
    [Header("name")]
    public new string name;

    [Header("ShootData")]
    public float damage;
    public float maxDistance;

    [Header("Realoading")]
    public int currentAmmo;
    public int magSize;
    public float fireRate;
    public float reloadTime;
    [HideInInspector]
    public bool reloading;

}
