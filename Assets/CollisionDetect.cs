using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public bool inHole = false;   
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "food")
        {
            Destoroy(other.gameObject);
        }
    }
     void OnTriggerStay(Collider other){
       if(other.gameObject.tag == "hole"){
        if(Input.GetKeyDown(KeyCode.Enter) && !inHole){
            inHole = true;
        }
        else if(Input.GetKeyDown(KeyCode.Enter) && inHole){
            inHole = false;
        }
        
       } 
    }
     void OnTriggerExit(Collider other){
        
    }

}
