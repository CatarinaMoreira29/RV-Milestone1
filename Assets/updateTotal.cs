using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateTotal : MonoBehaviour
{

    public int total;
    // Start is called before the first frame update
    void Start()
    {
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = "Total: " + total;
    }
}
