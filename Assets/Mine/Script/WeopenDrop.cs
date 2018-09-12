using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeopenDrop : MonoBehaviour {

    int offsetx;
    float x1;
    float z1;
    int offsetz;
    public GameObject voice;

	// Use this for initialization
	void Start () {
        offsetx = UnityEngine.Random.Range(0, 2);
        offsetz = UnityEngine.Random.Range(0, 2);
        if (offsetx == 0)
        {
            x1 = -0.05f;
        }
        else
        {
            x1 = 0.05f;
        }
        if (offsetz == 0)
        {
            z1 = -0.1f;
        }
        else
        {
            z1 = 0.1f;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (transform.position.x <= -6)
        {
            x1 = 0.05f;
        }
        if (transform.position.x >= 6)
        {
            x1 = -0.05f;
        }
        if (transform.position.z >= 11)
        {
            z1 = -0.1f;
        }
        if (transform.position.z <= -5)
        {
            z1 = 0.1f;
        }
        transform.position = new Vector3(transform.position.x+x1,transform.position.y,transform.position.z+z1);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            voice.GetComponent<AudioSource>().Play();
            WeopenType.weopen = "Heavy Machince Gun";
            WeopenType.bullet = 200;
        }
    }
}
