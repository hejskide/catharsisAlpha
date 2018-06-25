using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.Networking;

public class CameraFollow : MonoBehaviour {
	public Transform player;
	public Vector3 posicionRelativa;
	public float smootSpeed = 0.125f;

	// Use this for initialization
	void Start () {
		posicionRelativa = transform.position - player.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		Vector3 desiredPosition = player.position + posicionRelativa;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smootSpeed);
		transform.position = smoothedPosition;
	}
}
