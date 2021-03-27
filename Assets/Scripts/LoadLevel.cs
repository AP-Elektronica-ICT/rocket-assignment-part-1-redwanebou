using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string mLevelToLoad;

    void Start() { }

    void Update()   { }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Level 2 laden...");
            SceneManager.LoadScene(mLevelToLoad);
        }
    }
}
