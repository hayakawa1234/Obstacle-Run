using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour
{
    void Start()
    {
        gameObject.tag = "Player";
    }
    private void OnTriggerEnter(Collider col)
    {
        if (gameObject.tag == "Player")
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
        
    }
}
