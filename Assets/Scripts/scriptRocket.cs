﻿using System.Collections;
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

    public void chamasupport()
    {
        rigidbodyComponent.velocity = new Vector3(-4f, 0, 0);
        Invoke("addSupport", 4f);
    }
    //Add support rocket
    private void addSupport()
    {
        rigidbodyComponent.velocity = new Vector3(-8f, 0, 0);
        GameObject.Find("Arm").GetComponent<MeshRenderer>().enabled = true;
    }

    public void chamaVidro()
    {
        Invoke("addVidro", 2f);
    }

    //Add vidro
    private void addVidro()
    {
         GameObject.Find("nute").GetComponent<MeshRenderer>().enabled = true;
         GameObject.Find("win-frem").GetComponent<MeshRenderer>().enabled = true;
         GameObject.Find("win.001").GetComponent<MeshRenderer>().enabled = true;

    }

    public void chamaCor()
    {
        rigidbodyComponent.velocity = new Vector3(-8f, 0, 0);
        Invoke("Cor", 4f);
    }

    //Muda a cor
    private void Cor()
    {
        GameObject Rocket = GameObject.Find("boddy");
        var RocketRenderer = Rocket.GetComponent<Renderer>();
        RocketRenderer.material.color = Color.white;
        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(-10f, 0, 0);
    }
    public void changeObject()
    {
        Invoke("changeEffectObject", 2f);

    }

    public void changeEffectObject()
    {
        rigidbodyComponent = GameObject.Find("RocketBody").GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(0, 0, -15f);
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
