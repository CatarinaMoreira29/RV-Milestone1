using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;

    private Vector3 scaleChange;

    public GameObject presenteC;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        //Find rigidbody
        rigidbodyComponent = GetComponent<Rigidbody>();
        count = 0;

    }

    public void goToAddRodas()
    {
        //Add velocity
        rigidbodyComponent.velocity = new Vector3(-7, 0, 0);
        //Timer 
        Invoke("addRodas", 4);
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
        rigidbodyComponent.velocity = new Vector3(-7, 0, 0);
        Invoke("pintar", 4);
    }

    public void pintar()
    {

        GameObject car = GameObject.Find("body");
        var CarRenderer = car.GetComponent<Renderer>();
        CarRenderer.material.color = Color.white;
        rigidbodyComponent = GetComponent<Rigidbody>();
        Invoke("goToFinish", 2);
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
        Invoke("changeEffectObject", 1);

    }

    public void changeEffectObject()
    {
               
        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(0, 0, -15);
        Invoke("presente", 1); 
        Invoke("destroy", 1);
    }

    private void destroy()
    {

        GameObject.Find("roda1").GetComponent<SkinnedMeshRenderer>().enabled = false;
        GameObject.Find("roda2").GetComponent<SkinnedMeshRenderer>().enabled = false;
        GameObject.Find("roda3").GetComponent<SkinnedMeshRenderer>().enabled = false;
        GameObject.Find("roda4").GetComponent<SkinnedMeshRenderer>().enabled = false;
        GameObject car = GameObject.Find("body");
        var CarRenderer = car.GetComponent<Renderer>();
        CarRenderer.material.color = Color.blue;
        scaleChange = new Vector3(0.2f, 0.2f, 0.2f);
        GameObject.Find("Police_car").transform.localScale += scaleChange;
        GameObject.Find("Police_car").GetComponent<Transform>().localPosition = new Vector3(0.118f, -0.317f, 14.416f);
    }


   public void presente()
    {

        count++;
        Instantiate(presenteC, GameObject.Find("Police_car").transform.position, Quaternion.identity);
        GameObject.Find("CarText").GetComponent<TextMesh>().text = "Carro: " + count;
        GameObject.Find("Total").GetComponent<updateTotal>().total += 1;


    }




}
