using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehaviour : MonoBehaviour
{
    // goal collision
    [Header("Door 1 collision")]
    [SerializeField]
    GameObject PlayerPrefab;
    [SerializeField]
    GameObject goalPrefab;
    [SerializeField]
    GameObject CollisionActor;
    [SerializeField]
    BoxCollider OffArea;
    [SerializeField]
    int goalx;
    [SerializeField]
    int goaly;
    [SerializeField]
    int goalz;

    int goalTranslate = -6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefab == CollisionActor)
        {
            Debug.Log(" TEST ");
            //goal go up
            goalPrefab.transform.position += new Vector3(0, 0, goalTranslate);

        }
        else
        {
            //door 1 stays where it is / goes back to where it was
            goalPrefab.transform.position = new Vector3(goalx, goaly, goalz);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == CollisionActor)
        {
            Debug.Log(" TEST ");
            //goal go up
            goalPrefab.transform.position += new Vector3(0, 0, goalTranslate);
            
        }
        else
        {
            //door 1 stays where it is / goes back to where it was
            goalPrefab.transform.position = new Vector3(goalx, goaly, goalz);
        }



    }


    private void OnTriggerEnter(Collider collider)
    {
        collider = OffArea;
        //Debug.Log(" TEST 2 ");
        //goAL stays where it is / goes back to where it was
        goalPrefab.transform.position = new Vector3(goalx, goaly, goalz);
        
    }
}
