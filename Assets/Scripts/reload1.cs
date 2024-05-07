using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reload1 : MonoBehaviour
{
    void OnTriggerEnter(Collider guy)
    {
        if (guy.tag == "Berry")
        {
            SceneManager.LoadScene("level2");
        }
        else if (guy.tag == "Player")
        {
            SceneManager.LoadScene("level2");
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
