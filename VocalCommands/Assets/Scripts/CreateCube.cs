using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour {

    public GameObject cursor;
    public GameObject prefab;

    public void generateCube()
    {
        GameObject block = Instantiate(prefab, cursor.transform.position, Camera.main.transform.rotation);
        block.gameObject.tag = "Item";
    }

}

