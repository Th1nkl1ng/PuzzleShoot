using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonFunction : MonoBehaviour
{
    [SerializeField]
    GameObject puzzleObj;
    private Vector3 OriginalpuzObj;
    // Start is called before the first frame update
    void Start()
    {
        OriginalpuzObj = puzzleObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //Debug.Log("Collision");
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Debug.Log("Collision 2");
                puzzleObj.transform.position = OriginalpuzObj;
            }
        }
        
    }
}
