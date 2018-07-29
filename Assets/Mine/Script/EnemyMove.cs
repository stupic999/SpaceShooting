using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public DontGoOut dontGoOut;
    public int tilt;
    public float moveSpd;
    public Vector2 moveRange;

    public Vector2 startWait;
    public Vector2 moveWait;
    public Vector2 endWait;
    
    public Rigidbody EmyRB;

    public float currentSpd;
    private float movePoint;


    private void Start()
    {
        StartCoroutine(EmyMove());
    }

    IEnumerator EmyMove ()
    {
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));
        while (true)
        {
            movePoint = (Random.Range(moveRange.x, moveRange.y)) * -Mathf.Sign(transform.position.x);
            yield return new WaitForSeconds(Random.Range(moveWait.x, moveWait.y));
            movePoint = 0;
            yield return new WaitForSeconds(Random.Range(endWait.x, endWait.y));
        }
    }

    private void FixedUpdate()
    {
        float MovePower = Mathf.MoveTowards(EmyRB.velocity.x, movePoint, moveSpd*Time.deltaTime);
        EmyRB.velocity = new Vector3(MovePower,0f,currentSpd);
        EmyRB.position = new Vector3(
            Mathf.Clamp(EmyRB.position.x, dontGoOut.xMin, dontGoOut.xMax),
            10f,
            Mathf.Clamp(EmyRB.position.z, dontGoOut.zMin, dontGoOut.zMax)
            );
        EmyRB.rotation = Quaternion.Euler(0, 0, EmyRB.velocity.x * -tilt);
    }


}
