using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera Camera1;
    public Camera Camera2;

    void Start()
    {
        
    }
    void Update()
    {
        FirstPersonCamera();
    }
     public void FirstPersonCamera()
    {
         
         
        if (Input.GetKeyDown(KeyCode.P))
       {
            if ( Camera2.enabled == true )
            {
                Camera1.enabled = true;
                Camera2.enabled = false; 
                return;
            }else if (Camera1.enabled == true)
                {
                    Camera2.enabled = true;
                    Camera1.enabled = false;
                    return;
                } 
       }
    } 

} 
