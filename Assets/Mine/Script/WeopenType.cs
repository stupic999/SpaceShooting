using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeopenType : MonoBehaviour {

    public static string weopen;
    public static int bullet;
    public GUIText weopenWord;

    // Use this for initialization
    void Start () {
        bullet = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (weopen == "")
        {
            weopenWord.text = "∞";
        }
        else if (weopen == "Heavy Machince Gun")
        {
            weopenWord.text = bullet.ToString();
        }
        if (bullet <= 0)
        {
            weopen = "";
            weopenWord.text = "∞";
        }
    }
}
