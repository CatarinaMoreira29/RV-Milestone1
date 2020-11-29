using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
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
        Destroy(GameObject.Find("backpack"));
        GameObject.Find("Backpack1").GetComponent<SkinnedMeshRenderer>().enabled = true;

    }

    public void addGun()
    {
        Destroy(GameObject.Find("Gun"));
        GameObject.Find("AssaultRifle").GetComponent<SkinnedMeshRenderer>().enabled = true;

    }

}
