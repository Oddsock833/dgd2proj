using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript2 : MonoBehaviour
{
    void OnTriggerEnter(Collider berr)
    {
        if (berr.tag == "Berry")
        {
            SceneManager.LoadScene("level4");
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
