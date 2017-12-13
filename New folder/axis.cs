using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject targetObject;
    private float targetAngle = 0;
    const float rotationAmount = 1.5f;
    public float rDistance = 1.0f;
    public float rSpeed = 1.0f;
    public Button zright;
    public Button zleft;

    void Start()
    {
        Button btn3 = zright.GetComponent<Button>();
        Button btn4 = zleft.GetComponent<Button>();
        
        btn3.onClick.AddListener(Onclick3);
        btn4.onClick.AddListener(Onclick4);

    }
    public void Onclick3()
    {
        targetAngle -= 90.0f;
    }
    public void Onclick4()
    {
        targetAngle += 90.0f;
    }
    void Update()
    {
        // Trigger functions if Rotate is requested
        if (targetAngle != 0)
        {
            Rotate();
        }
    }

    protected void Rotate()
    {

        float step = rSpeed * Time.deltaTime;
        float orbitCircumfrance = 2F * rDistance * Mathf.PI;
        float distanceDegrees = (rSpeed / orbitCircumfrance) * 360;
        float distanceRadians = (rSpeed / orbitCircumfrance) * 2 * Mathf.PI;

        if (targetAngle > 0)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, -rotationAmount);
            targetAngle -= rotationAmount;
        }
        else if (targetAngle < 0)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, rotationAmount);
            targetAngle += rotationAmount;
        }

    }
}