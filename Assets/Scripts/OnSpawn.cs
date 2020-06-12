using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSpawn : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        GameObject inst = Instantiate(prefab) as GameObject;
    }

}
