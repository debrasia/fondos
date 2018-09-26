using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceManager : MonoBehaviour {

    public GameObject Prefab;

    public void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition.x);
            Debug.Log(Input.mousePosition.y);
            Vector3 v = new Vector3(0, 0, 3.5f);
                Instantiate(Prefab, v, Quaternion.identity);
        }
    }
}
