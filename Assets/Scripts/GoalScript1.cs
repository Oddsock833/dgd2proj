using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript1 : MonoBehaviour
{
    void OnTriggerEnter(Collider berre)
    {
        if (berre.tag == "Berry")
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
