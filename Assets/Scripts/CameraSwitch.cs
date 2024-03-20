using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera Camera2;

    public void ShowCamera2View()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Camera2.enabled = true; 
        }
    }
}
