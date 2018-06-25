using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DIRECCION { FRONT, BACK , LEFT , RIGHT}

public class controller : MonoBehaviour
{
    DIRECCION dir;
    Vector3 pos;
    int angle;
    public float speed = 2;


    private void Start()
    {
        dir = DIRECCION.FRONT;
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
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + pos, speed * Time.deltaTime);

    }

    void MoverPersonaje()
    {

        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            angle = 0;
            pos += Vector3.forward;
            //Debug.Log("arriba");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            angle = 180;
            pos += Vector3.back;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            angle = 270;
            pos += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            angle = 90;
            pos += Vector3.right;
        }*/

        

        /*if (targetDirection != Vector3.zero)
        {
            if (Mathf.Abs(targetDirection.y) > Mathf.Abs(targetDirection.z))
            {
                if (targetDirection.y > 0)
                {
                    pos += Vector3.right;
                }
                else
                {
                    pos += Vector3.left;
                }
            }
            else
            {
                if (targetDirection.z > 0)
                {
                    pos += Vector3.forward;
                }
                else
                {
                    pos += Vector3.back;
                }
            }

        }*/

    }
    
}
