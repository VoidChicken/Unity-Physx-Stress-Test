using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject prefab;
    public float interval;
    // Use this for initialization
    public int particleCount;
	void Start () {
        StartCoroutine(Spawn());
    }
    GameObject[] particles = new GameObject[900];
    // ill just use the old gui system so its easier
    void OnGUI()
    {
        GUI.Label(new Rect(new Vector2(Screen.width / 20, Screen.height / 20), new Vector2(500, 250)), 
            new GUIContent(particleCount.ToString()));
    }
    int u = 0;
    IEnumerator Spawn()
    {
        if (particleCount < 900) {
            for (int i = 0; i < 10; ++i)

                particles[particleCount+i] =(GameObject) Instantiate(prefab, transform);

            particleCount += 10;
        } else
            for (int i = 0; i < 100; ++i)
            {
             particles[u++].GetComponent<Rigidbody>().AddExplosionForce(143+Random.Range(10, 50), transform.position-new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)),1000);
             if (u > 899) u = 0;
            }
        yield return new WaitForSeconds(interval);
        StartCoroutine(Spawn());
    }
	// Update is called once per frame
	void Update () {
       
	}
}
