using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	Transform _transform = null;

	// Use this for initialization
	void Start () {
		_transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		_transform.Rotate( Time.deltaTime * 360.0f * Vector3.up );
	}
}