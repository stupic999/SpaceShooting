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
		
	}
	
	// Update is called once per frame
	void Update () {

        if (weopen == "")
        {
            weopenWord.text = "∞";
        }
        else if (weopen == "Heavy Machince Gun")
        {
            weopenWord.text = bullet+"/200";
        }
        if (bullet <= 0)
        {
            weopen = "";
        }
    }
}
