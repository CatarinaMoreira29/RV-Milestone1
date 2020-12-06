using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    private Transform transformComponent;

    public GameObject presenteR;
    public int count;


    // Start is called before the first frame update
    void Start()
    {
        //Find rigidbody
        rigidbodyComponent = GetComponent<Rigidbody>();
        transformComponent = GetComponent<Transform>();
        count = 0;

    }

    public void goToAddHead()
    {
        //Add velocity
        rigidbodyComponent.velocity = new Vector3(-8.2f, 0, 0);
        //Timer 
        Invoke("addHead", 0.8f);
    }

    private void addHead()
    {
        //Show head
        GameObject.Find("head1").GetComponent<SkinnedMeshRenderer>().enabled = true;
        Invoke("goToAddArms", 1);

    }
    private void goToAddArms()
    {
        rigidbodyComponent.velocity = new Vector3(-8.2f, 0, 0);
        Invoke("addArm", 0.5f);

    }

    private void addArm()
    {
        GameObject.Find("Arm1").GetComponent<SkinnedMeshRenderer>().enabled = true;
        Invoke("goToEnd", 1);
    }

    private void goToEnd()
    {
        rigidbodyComponent.velocity = new Vector3(-8, 0, 0);

    }

    public void addBackpack()
    {
        GameObject.Find("backpack").GetComponent<Transform>().localPosition = new Vector3(-17.892f, 0.603f, -4.288f);
        GameObject.Find("backpack").GetComponent<Transform>().Rotate(0.053f, 180, 77.013f);
        GameObject.Find("Backpack1").GetComponent<SkinnedMeshRenderer>().enabled = true;
    }



    public void changeObject()
    {
        Invoke("changeEffect", 1.5f);

    }

    public void changeEffect()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(0, 0, -15);
        Invoke("presente", 1);
        Invoke("destroy", 1);
    }



    private void destroy()
    {
        GameObject.Find("Backpack1").GetComponent<SkinnedMeshRenderer>().enabled = false;
        GameObject.Find("Arm1").GetComponent<SkinnedMeshRenderer>().enabled = false;
        GameObject.Find("head1").GetComponent<SkinnedMeshRenderer>().enabled = false;
        GameObject.Find("Robot").GetComponent<Transform>().localPosition = new Vector3(0.6965637f, -0.05999994f, 7.32f);
        
    }


    public void presente()
    {
        count++;
        Instantiate(presenteR, GameObject.Find("Robot").transform.position, Quaternion.identity);
        GameObject.Find("RobotText").GetComponent<TextMesh>().text = "Robô: " + count;
        GameObject.Find("Total").GetComponent<updateTotal>().total += 1;


    }


}
