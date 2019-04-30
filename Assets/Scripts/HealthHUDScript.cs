using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthHUDScript : MonoBehaviour {
    static bool isPlayerDead;
    public GameObject Live;


    // Use this for initialization
    void Start() {
        Live.SetActive(true);

    }

    // Update is called once per frame
    void Update() {
        if (isPlayerDead)
        {
            Live.SetActive(false);
        }

    }

    public static void playerDead()
    {
        isPlayerDead = true;
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    } 
}
