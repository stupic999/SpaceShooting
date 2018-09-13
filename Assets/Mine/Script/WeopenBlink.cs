using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeopenBlink : MonoBehaviour {

    int blink = 1;

    private void Start()
    {
        InvokeRepeating("blinking", 5f, 0.1f);
    }

    // Update is called once per frame
    void FixedUpdate () {
        
	}

    void blinking()
    {
        blink = -blink;
        if (blink == 1)
        {
            transform.gameObject.SetActive(true);
        }
        else if (blink == -1)
        {
            transform.gameObject.SetActive(false);
        }
            
    }
}
