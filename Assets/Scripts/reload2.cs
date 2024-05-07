using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reload2 : MonoBehaviour
{
    void OnTriggerEnter(Collider guy)
    {
        if (guy.tag == "Berry")
        {
            SceneManager.LoadScene("level3");
        }
        else if (guy.tag == "Player")
        {
            SceneManager.LoadScene("level3");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
