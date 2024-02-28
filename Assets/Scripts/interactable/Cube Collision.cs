using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    [SerializeField]
    GameObject DoorPrefab;
    [SerializeField]
    GameObject CollisionActor;
    [SerializeField]
    BoxCollider OffArea;
    [SerializeField]
    int doorx;
    [SerializeField]
    int doory;
    [SerializeField]
    int doorz;

    int doorTranslate  = 6;

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
        if (col.gameObject == CollisionActor)
        {
            //Debug.Log(" TEST ");
            DoorPrefab.transform.position += new Vector3(0, doorTranslate, 0);
        }
        else 
        {
            DoorPrefab.transform.position = new Vector3(-9, 3, 81);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        collider = OffArea;
        //Debug.Log(" TEST 2 ");
        DoorPrefab.transform.position = new Vector3(doorx, doory, doorz);
    }
}
