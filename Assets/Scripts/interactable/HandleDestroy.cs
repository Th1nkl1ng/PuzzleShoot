using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class DestroyHandler : MonoBehaviour
{

    private int sceneNumber { get { return EditorSceneManager.GetActiveScene().buildIndex; } }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sceneNumber == 3 || sceneNumber == 4)
        {
            Destroy(this.gameObject);
        }
    }
}
