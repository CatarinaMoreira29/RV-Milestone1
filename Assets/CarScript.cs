using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    private Transform transformComponent;
    // Start is called before the first frame update
    void Start()
    {
        //Find rigidbody
        rigidbodyComponent = GetComponent<Rigidbody>();
        transformComponent = GetComponent<Transform>();

    }

    public void goToAddRodas()
    {
        //Add velocity
        rigidbodyComponent.velocity = new Vector3(-7f, 0, 0);
        //Timer 
        Invoke("addRodas", 4f);
    }

    private void addRodas()
    {
        //Show head
        GameObject.Find("roda1").GetComponent<SkinnedMeshRenderer>().enabled = true;
        GameObject.Find("roda2").GetComponent<SkinnedMeshRenderer>().enabled = true;
        GameObject.Find("roda3").GetComponent<SkinnedMeshRenderer>().enabled = true;
        GameObject.Find("roda4").GetComponent<SkinnedMeshRenderer>().enabled = true;
        Invoke("goToFinish", 0.8f);

    }

    public void chamaPintar()
    {
        rigidbodyComponent.velocity = new Vector3(-7f, 0, 0);
        Invoke("pintar", 4f);
    }

    public void pintar()
    {
        GameObject car = GameObject.Find("body");

        var CarRenderer = car.GetComponent<Renderer>();

        CarRenderer.material.color = Color.white;

        //GameObject.Find("RocketBody").transform.localPosition = new Vector3(-2, 0,2);
        

        rigidbodyComponent = GetComponent<Rigidbody>();
        Invoke("goToFinish", 2f);


    }

    private void goToFinish()
    {
        rigidbodyComponent.velocity = new Vector3(-8, 0, 0);

    }




}
