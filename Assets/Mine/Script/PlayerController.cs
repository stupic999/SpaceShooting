using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DontGoOut
{
    public float xMin, xMax, zMax, zMin;
}

public class PlayerController : MonoBehaviour {
    
    public Rigidbody PlayerRb;
    public float speed;
    public float tilt;
    public DontGoOut dontGoOut;

    void FixedUpdate() {
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(HorizontalMovement, 0f, VerticalMovement);
        PlayerRb.velocity = movement * speed;
        PlayerRb.position = new Vector3
       (
            Mathf.Clamp(PlayerRb.position.x, dontGoOut.xMin, dontGoOut.xMax),
            10f,
            Mathf.Clamp(PlayerRb.position.z, dontGoOut.zMin, dontGoOut.zMax)
       );
        PlayerRb.rotation = Quaternion.Euler(0f, 0f, PlayerRb.velocity.x*-tilt);
	}
}
