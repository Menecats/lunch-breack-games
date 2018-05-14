using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour {
	public GameObject projectlePrefab;
	public Transform firePoint;

	public float modifier = 1f;

	Camera camera;

	void Start() {
		camera = GetComponentInChildren<Camera>();
	}
	
	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
        	Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
			if (Physics.Raycast(ray, out hit)) {
				Transform objectHit = hit.transform;

				ThrowItem(objectHit.position);
			}
		}
	}

	void ThrowItem(Vector3 target) {
		GameObject projectle = Instantiate(projectlePrefab, firePoint.position, firePoint.rotation);
		Rigidbody rb = projectle.GetComponent<Rigidbody>();

		Vector3 dir = target - projectle.transform.position;

		rb.AddForce(target * modifier, ForceMode.VelocityChange);
	}
}
