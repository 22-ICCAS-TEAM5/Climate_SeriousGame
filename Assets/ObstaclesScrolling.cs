using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesScrolling : MonoBehaviour
{
    public float ospeed = 4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * ospeed * Time.deltaTime);
    }
}

