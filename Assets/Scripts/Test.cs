using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    


    void OnCollisionEnter(Collision other)
    {
        if(gameObject.tag == "Buildable")
        {
            Debug.Log(other.gameObject.name);
            float x = (other.gameObject.transform.localScale.x) * 0.5f;
            float y = (other.gameObject.transform.localScale.y) * 0.5f;
            float z = (other.gameObject.transform.localScale.z) * 0.5f;




            GameObject NewComponent = Instantiate(other.gameObject, transform.position + new Vector3(0, 0, -z), Quaternion.identity);
            Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }
}
