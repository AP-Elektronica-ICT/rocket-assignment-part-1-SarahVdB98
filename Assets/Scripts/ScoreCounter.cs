using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int counter = 0;
    void Start()
    {
        
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "coin")
        {
            counter ++;
            GameObject.FindGameObjectWithTag("score").GetComponent<Text>().text = counter.ToString();
        }
    }
}
