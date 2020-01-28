using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	public float smoothSpeed;
	public Vector3 offset;
	private LevelGeneration level;

	private void Start() {
		level = GameObject.FindGameObjectWithTag("Generator").GetComponent<LevelGeneration>();
	}

	void LateUpdate(){
		if(level.playerSpawned)
		{
			target = GameObject.FindGameObjectWithTag("Player").transform;
			Vector3 desiredPosition = target.position + offset;
			Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPos;
		}
	}
}
