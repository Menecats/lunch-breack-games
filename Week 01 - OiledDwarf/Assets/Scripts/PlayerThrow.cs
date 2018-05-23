using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    public GameObject projectlePrefab;
    public Transform firePoint;

    public float modifier = 3f;
    public float adjustAngle = 30f;

    Camera mainCamera;
    public LayerMask collisionMask = -1;

    void Start()
    {
        mainCamera = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f, collisionMask.value))
            {
                ThrowItem(hit.point);
            }
        }
    }

    void ThrowItem(Vector3 target)
    {
        GameObject projectle = Instantiate(projectlePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = projectle.GetComponent<Rigidbody>();

        float indensity = (target - projectle.transform.position).magnitude;
        Quaternion adjust = Quaternion.AngleAxis(-adjustAngle, Vector3.right);

        projectle.transform.LookAt(target);
        projectle.transform.rotation = projectle.transform.rotation * adjust;

        rb.AddForce((projectle.transform.rotation * Vector3.forward) * modifier * indensity, ForceMode.VelocityChange);
    }
}
