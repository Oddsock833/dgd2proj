using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    void OnTriggerEnter(Collider berrer)
    {
        if (berrer.tag == "Berry")
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
