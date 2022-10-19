using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/***
 * Author: Cristian Misla
 * Created: 10/19/2022
 * Modified: 10/19/2022
 * Description: Open Door Animation
 ***/

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;
    Animator anim; //References the animator 
    public string animParam; //reference to the animator parametor 

    // Start is called before the first frame update
    void Start()
    {
        anim = door.GetComponent<Animator>();
        Debug.Log(anim.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animParam, true);
            Debug.Log("entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool(animParam, false);
            Debug.Log("exited");
        }
    }
}
