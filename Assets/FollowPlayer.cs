using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowPlayer : MonoBehaviour
{

    private CinemachineVirtualCamera vcam;
    public GameObject playerCap;
    void Start()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();
        //vcam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
        vcam.Follow = playerCap.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
