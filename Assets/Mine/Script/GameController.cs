using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Vector3 spawnValue;
    public GameObject[] Stones;
    public int spawnTime;
    public float startTime;
    public float spawnWait;
    public float waveWait;
    public static bool gameOver;
    public GameObject gameOverText;
    public GUIText Wave;

	// Use this for initialization
	void Start () {
       StartCoroutine(Spawn());
        gameOver = false;
    }

    private void Update()
    {
        if (gameOver)
        {
            gameOverText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        else
        {
            gameOverText.SetActive(false);
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startTime);
        for( int j=1; j>0;j++) {
            {
                Wave.text = "Wave:"+j;
                for (int i = 0; i < spawnTime; i++)
                {
                    if (gameOver)
                    {
                        break;
                    }
                    GameObject Stone = Stones[Random.Range(0, Stones.Length)];
                    Vector3 spawnPoint = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    Instantiate(Stone, spawnPoint, spawnRotation);
                    yield return new WaitForSeconds(spawnWait);
                }
                yield return new WaitForSeconds(waveWait);
                if (gameOver)
                {
                    break;
                }
            }
        }
    }
}
