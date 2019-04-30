using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalScript : MonoBehaviour
{
   

      

    private void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Portal");
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }

    }
}
