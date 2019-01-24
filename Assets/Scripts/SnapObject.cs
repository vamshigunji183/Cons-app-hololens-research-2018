using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour {

	void onCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        float x = (other.gameObject.transform.localScale.x) / 2;
        float y = (other.gameObject.transform.localScale.y) / 2;
        float z = (other.gameObject.transform.localScale.z) / 2;




        GameObject NewComponent = Instantiate(other.gameObject, transform.position + new Vector3(x, 0, 0), Quaternion.identity);
        Destroy(gameObject);
    }
}
