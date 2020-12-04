using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptRocket : MonoBehaviour
{

    private Rigidbody rigidbodyComponent;
    public int count;
    public GameObject presenteF;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        count = 0;
    }
    //Add support rocket
    public void unsnappedZone()
    {
        GameObject.Find("Arm").GetComponent<MeshRenderer>().enabled = true;
        rigidbodyComponent.velocity = new Vector3(-8, 0, 0);

    }


    //Add vidro
    public void unsnappedZone2()
    {
         GameObject.Find("nute").GetComponent<MeshRenderer>().enabled = true;
         GameObject.Find("win-frem").GetComponent<MeshRenderer>().enabled = true;
         GameObject.Find("win.001").GetComponent<MeshRenderer>().enabled = true;

    }

    //Muda a cor
    public void unsnappedZone3()
    {
        GameObject Rocket = GameObject.Find("boddy");
        var RocketRenderer = Rocket.GetComponent<Renderer>();
        RocketRenderer.material.color = Color.white;
        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(-12, 0, 0);
    }


    private void goToEnd()
    {
        rigidbodyComponent.velocity = new Vector3(-8, 0, 0);

    }

    public void changeObject()
    {
        rigidbodyComponent = GameObject.Find("RocketBody").GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(0, 0, -18);
        Invoke("presente", 1);
        Invoke("destroy", 1);
    }

    private void destroy()
    {

        GameObject Rocket = GameObject.Find("boddy");
        var RocketRenderer = Rocket.GetComponent<Renderer>();
        RocketRenderer.material.color = new Color(1.0f, 0.27f, 0.0f);
        GameObject.Find("RocketBody").GetComponent<Transform>().localPosition = new Vector3(0.7f, -0.4f, 3);
        GameObject.Find("Arm").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("nute").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("win-frem").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("win.001").GetComponent<MeshRenderer>().enabled = false;
    }


    public void presente()
    {

        count++;
        Instantiate(presenteF, GameObject.Find("RocketBody").transform.position, Quaternion.identity);
        GameObject.Find("RocketText").GetComponent<TextMesh>().text = "Foguetão: " + count;
        GameObject.Find("Total").GetComponent<updateTotal>().total += 1;

    }








}
