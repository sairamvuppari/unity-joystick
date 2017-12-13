using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewModel : MonoBehaviour
{
  
    public GameObject Cube;
    public void Slider_Changed(float newValue)
    {
        Vector3 pos = Cube.transform.position;
        pos.y = newValue;
        Cube.transform.position = pos;
    }
}