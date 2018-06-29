using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    Vector3 pos;
    float angle;
    public float smooth = 4;
    public float speed = 2;


    private void Start()
    {
    }

    void Update()
    {

        Vector3 pos = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));


        if (pos != Vector3.zero)
        {

            if (Mathf.Abs(pos.x) > Mathf.Abs(pos.z))
            {
                if (pos.x > 0)
                {
                    angle = 90;
                }
                else
                {
                    angle = 270;
                }
            }
            else if (Mathf.Abs(pos.x) == Mathf.Abs(pos.z)) {

                if (pos.x > 0 && pos.z > 0)
                {
                    angle = 45;
                }
                else if (pos.x < 0 && pos.z > 0)
                {
                    angle = 315;
                }
                else if (pos.x > 0 && pos.z < 0)
                {
                    angle = 135;
                }
                else
                {
                    angle = 225;
                }
                Quaternion vangle = new Quaternion();

            }
            else
            {
                if (pos.z > 0)
                {
                    angle = 360;
                }
                else
                {
                    angle = 180;
                }
            }

        }


        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.up), smooth * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + pos, speed * Time.deltaTime);

    }

    
}
