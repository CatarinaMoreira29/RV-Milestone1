﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptRocket : MonoBehaviour
{

    public GameObject RocketArmPrefab;
    public GameObject RocketGlassPrefab;
    private Rigidbody rigidbodyComponent;



    public GameObject presenteF;


    public GameObject prefab;




    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void unsnappedZone()
    {
        RocketArmPrefab = Instantiate<GameObject>(RocketArmPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        
        RocketArmPrefab.transform.rotation = Quaternion.Euler(-90, 0, 0);
        
        RocketArmPrefab.transform.SetParent(GameObject.Find("RocketBody").transform);
        RocketArmPrefab.transform.localPosition = new Vector3(0, 0, 0);
        rigidbodyComponent.velocity = new Vector3(-9, 0, 0);

    }

    public void unsnappedZone2()
    {
      
    RocketGlassPrefab = Instantiate<GameObject>(RocketGlassPrefab, new Vector3(0,0,0), Quaternion.identity);

       RocketGlassPrefab.transform.rotation = Quaternion.Euler(-180, 0, 0);
        RocketGlassPrefab.transform.SetParent(GameObject.Find("RocketBody").transform);
        RocketGlassPrefab.transform.localPosition = new Vector3(0, 0, 0);
    }


    public void unsnappedZone3() {
        

        GameObject Rocket = GameObject.Find("boddy");

        var RocketRenderer = Rocket.GetComponent<Renderer>();

        RocketRenderer.material.color = Color.white;

        //GameObject.Find("RocketBody").transform.localPosition = new Vector3(-2, 0,2);


        rigidbodyComponent = GetComponent<Rigidbody>();
       

        rigidbodyComponent.velocity = new Vector3(-12, 0, 0);


    }


    private void goToEnd()
    {
        Debug.Log("entrei END");
        rigidbodyComponent.velocity = new Vector3(-8, 0, 0);

    }

    public void changeObject() 
    {


        //Instantiate(presenteF, GameObject.Find("RocketBody").transform.position, Quaternion.identity);
        //  Destroy(GameObject.Find("RocketBody"));


        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(0, 0, -18);

        Invoke("presente", 1);

        Invoke("destroy", 1);

    }

    private void destroy()
    {

        Destroy(GameObject.Find("RocketBody"));

    }


    public void presente()
    {


        Debug.Log("Presente");
        var A = Instantiate(presenteF, GameObject.Find("RocketBody").transform.position, Quaternion.identity);
        //A.transform.localPosition = new Vector3(-10, -0.7f, -3.8f);
        
        

    }








}
