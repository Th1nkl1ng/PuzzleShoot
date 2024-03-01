using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    // door 1 collision
    [Header("Door 1 collision")]
    [SerializeField]
    GameObject DoorPrefab;
    [SerializeField]
    GameObject CollisionActor;
    [SerializeField]
    BoxCollider OffArea;
    [SerializeField]
    int door1x;
    [SerializeField]
    int door1y;
    [SerializeField]
    int door1z;

    //door 2 collision
    [Header("Door 2 collision")]
    [SerializeField]
    GameObject DoorPrefab2;
    [SerializeField]
    float door2x;
    [SerializeField]
    int door2y;
    [SerializeField]
    int door2z;

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
            //door 1 go up
            DoorPrefab.transform.position += new Vector3(0, doorTranslate, 0);
            // door 2 stays where it is
            DoorPrefab2.transform.position = new Vector3(door2x, door2y, door2z);
        }
        else 
        {
            //door 1 stays where it is / goes back to where it was
            DoorPrefab.transform.position = new Vector3(door1x, door1y, door1z);
            // Door 2 moves up
            DoorPrefab2.transform.position += new Vector3(0, doorTranslate, 0);
        }


        
    }

    private void OnTriggerEnter(Collider collider)
    {
        collider = OffArea;
        //Debug.Log(" TEST 2 ");
        //door 1 stays where it is / goes back to where it was
        DoorPrefab.transform.position = new Vector3(door1x, door1y, door1z);
        // Door 2 moves up
        DoorPrefab2.transform.position += new Vector3(0, doorTranslate, 0);
    }
}
