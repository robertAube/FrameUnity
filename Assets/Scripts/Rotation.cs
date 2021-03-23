using System;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float increment;
    [SerializeField]
    private float maxSpeed;

    private float xSpinning;
    private float ySpinning;
    private float zSpinning;


    private void Start()
    {
        setSpeed(0);
    }
    //FixedUpdate appelé à des temps fixes VS Update dépend du taux de rafraichissement (once by frame)
    void FixedUpdate()
    {
        adjustSpeed();
        transform.Rotate(xSpinning * Time.deltaTime, ySpinning * Time.deltaTime, zSpinning * Time.deltaTime);
    }
    private void adjustSpeed()
    {
        if (Input.GetKey("up"))
        {
            setSpeed(+increment);
        }

        if (Input.GetKey("down"))
        {
            setSpeed(-increment);
        }
    }

    private void setSpeed(float increment = 0)
    {
        if (increment != 0)
        {
            if ((speed <= -maxSpeed && increment > 0)|| (maxSpeed <= speed && increment < 0))
            {
                speed = speed + increment;
            }
            else 
                speed = increment < 0 ? Math.Max(-maxSpeed, speed + increment) : Math.Min(+maxSpeed, speed + increment);
        }
        Debug.Log("speed : " + speed + " - increment : " + increment);
        xSpinning = speed;
        ySpinning = speed;
        zSpinning = speed;
    }
}
