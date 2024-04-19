using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolding : MonoBehaviour
{
    public int weaponSelected = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectW();
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelected = weaponSelected;

        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (weaponSelected >= transform.childCount - 1)
            {
                weaponSelected = 0;
            }
            else
            {
                weaponSelected++;
            }
            
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (weaponSelected <= 0)
            {
                weaponSelected = transform.childCount - 1;
            }
            else
            {
                weaponSelected--;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponSelected = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >=2)
        {
            weaponSelected = 1;
        }


        if (previousSelected != weaponSelected)
        {
            SelectW();
        }
    }

    void SelectW()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == weaponSelected)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
