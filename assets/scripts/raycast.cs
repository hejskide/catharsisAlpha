using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour {

    /*public float raydist = 10;

    private void Update()
    {
        RaycastHit hit;
        float dist;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * raydist;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            dist = hit.distance;
            print(dist + " " + hit.collider.gameObject.name);
        }
    }*/

    /*public float maxRay = 1f;

    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, Vector3.forward);
        RaycastHit hit;

        Debug.DrawLine(transform.position, transform.position + Vector3.forward * maxRay, Color.red);

        if(Physics.Raycast(ray, out hit, maxRay))
        {
            Debug.Log("you hit a ray");
        }
    }*/

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);

        if(Physics.Raycast(ray, out hit, 1f))
        {
            Debug.Log("abrir " + hit.transform.name + "?");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log(hit.transform.name);
            Debug.Log("abriste " + hit.transform.name);
        }
    }
}
