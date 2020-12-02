using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    private Transform transformComponent;

    private Vector3 scaleChange;

    public GameObject presenteC;


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

        GameObject.Find("RocketBody").transform.localPosition = new Vector3(-2, 0,2);


        rigidbodyComponent = GetComponent<Rigidbody>();
        Invoke("goToFinish", 2f);

    }

    private void goToFinish()
    {
        rigidbodyComponent.velocity = new Vector3(-8, 0, 0);

    }


    public void changeScale()
    {


        scaleChange = new Vector3(-0.2f, -0.2f, -0.2f);
        GameObject.Find("Police_car").transform.localScale += scaleChange;

    }

    public void changeObject()
    {
       
        Debug.Log("entrei change Carro!!!!!!!!!!!!");

        // var A = Instantiate(presenteC, GameObject.Find("Police_car").transform.position, Quaternion.identity);
        //Destroy(GameObject.Find("Police_car"));
        //GameObject.Find("PresenteC").GetComponent<presenteCarro>().embrulho();
        
        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(0, 0, -18);

        Invoke("presente", 1); 

        Invoke("destroy", 1);
        
        

    }

    private void destroy()
    {

        Destroy(GameObject.Find("Police_car"));

    }


   public void presente()
    {


        Debug.Log("Presente");
        var A = Instantiate(presenteC, GameObject.Find("Police_car").transform.position, Quaternion.identity);
    }

   


}
