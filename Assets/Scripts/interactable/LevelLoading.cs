using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    public GameObject emptyPostion;
    public GameObject playerCapsule;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "LevelExit")
        {
            EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(other.tag == "LevelExit2")
        {
            playerCapsule.transform.position = emptyPostion.transform.position + new Vector3(0, 1, 0);
            EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (other.tag == "GameEnd")
        {
            EditorSceneManager.LoadScene(0);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
