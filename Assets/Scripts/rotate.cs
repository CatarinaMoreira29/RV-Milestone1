using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        
    }
    
    void Update()
    {
        
        var angles = GameObject.Find("U_Axis_3").transform.rotation.eulerAngles;
        angles.x += Time.deltaTime * 3;
        GameObject.Find("U_Axis_3").transform.rotation = Quaternion.Euler(angles);

        var angles2 = GameObject.Find("U_Axis_33").transform.rotation.eulerAngles;
        angles2.x += Time.deltaTime * 3;
        GameObject.Find("U_Axis_33").transform.rotation = Quaternion.Euler(angles2);

        var angles3 = GameObject.Find("bracoAzul").transform.rotation.eulerAngles;
        angles3.y += Time.deltaTime * 15;
        GameObject.Find("bracoAzul").transform.rotation = Quaternion.Euler(angles3);
    }
    
}
