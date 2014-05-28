using UnityEngine;
using System.Collections;

public class DEBUG_BroadcastMyPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Current Position of Ball " + rigidbody.position.ToString());
	
	}
}
