using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class reload : MonoBehaviour
{
    private string currentSceneNames;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSceneNames = SceneManager.GetActiveScene().name;
    }
    void OnTriggerEnter(Collider guy)
    {
        if (guy.tag == "Berry")
        {
            SceneManager.LoadScene(currentSceneNames);
        }

        else if (guy.tag == "Player")
        {
            SceneManager.LoadScene(currentSceneNames);
        }
    }
}