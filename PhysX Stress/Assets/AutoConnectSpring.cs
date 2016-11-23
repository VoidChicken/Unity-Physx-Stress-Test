using UnityEngine;
using System.Collections;

public class AutoConnectSpring : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<SpringJoint>().connectedBody =
            GameObject.Find("Emitter").
            transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
