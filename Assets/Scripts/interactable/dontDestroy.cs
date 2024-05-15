using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class dontDestroy : MonoBehaviour
{
    private int sceneNumber { get { return EditorSceneManager.GetActiveScene().buildIndex; } }

    void Awake()
    {     
        DontDestroyOnLoad(this.gameObject);

        //test
        //float currentScene = EditorSceneManager.GetActiveScene().buildIndex;
        if (sceneNumber == 0)
        {
            Destroy(this.gameObject);
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(sceneNumber);

        if (sceneNumber == 0)
        {
            Destroy(this.gameObject);
        }

        
    }

}
