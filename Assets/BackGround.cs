using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
	Vector3 position;



	// Use this for initialization

	void Start()
	{

		position = transform.position;

	}



	// Update is called once per frame

	void Update()
	{

		position.x += 1 * Time.deltaTime;



		transform.position = position;

	}

}