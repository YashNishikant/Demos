using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontroller : MonoBehaviour
{

    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            cube.GetComponent<Animation>().Play();

            sphere.GetComponent<Animation>().Play();
        }
    }
}
