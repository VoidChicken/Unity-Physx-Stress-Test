using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public float speed;
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Sin(Time.time* speed), 0, Mathf.Cos(Time.time * speed))*19;
        transform.LookAt(Vector3.zero);
	}
}
