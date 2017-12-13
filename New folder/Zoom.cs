using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Zoom : MonoBehaviour {
    private float speed = 50.0f;
    public Button zin;
    public Button zout;
    public Button zright;
    public Button zleft;
    void Start()
    {
        Button btn1 = zin.GetComponent<Button>();
        Button btn2 = zout.GetComponent<Button>();
        Button btn3 = zright.GetComponent<Button>();
        Button btn4 = zleft.GetComponent<Button>();
        btn1.onClick.AddListener(Onclick1);
        btn2.onClick.AddListener(Onclick2);
        btn3.onClick.AddListener(Onclick3);
        btn4.onClick.AddListener(Onclick4);

    }
    public void Onclick1()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    public void Onclick2()
    {
        transform.position += -transform.forward * speed * Time.deltaTime;
    }
    public void Onclick3()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    public void Onclick4()
    {
        transform.position += -transform.right * speed * Time.deltaTime;
    }
}
