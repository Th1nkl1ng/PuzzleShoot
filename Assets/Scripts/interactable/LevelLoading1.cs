using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelLoadingdifferent : MonoBehaviour
{
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
    }
}
