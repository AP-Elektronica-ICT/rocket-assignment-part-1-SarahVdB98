using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelReset :MonoBehaviour
{
    public string mLevelToLoad;
    private void OnCollisionEnter(Collision collision)
    {
        if (this.tag == "EndPlatform" && collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(mLevelToLoad);
        }
    }
   
}
