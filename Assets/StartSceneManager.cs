using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//この下にコードを追加する
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") == true)
        {
            SceneManager.LoadScene("Main");
        }    
    }
}

