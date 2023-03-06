using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//object pooling class
public class SimpleObjcetPool : MonoBehaviour
{
    // the prefab that this object pool returns instances of //instanceof -> check type?
    public GameObject prefab;

    //collection of currently inactive instances of the prefab
    private Stack<GameObject> inactiveInstances = new Stack<GameObject> (); 

    public GameObject GetObject()
    {
        GameObject spawnedGameObject;
    }

}
