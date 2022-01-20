using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSort : MonoBehaviour
{
	// Start is called before the first frame update

	public GameObject[] Spheres;
	public int NumberOfSpheres = 10;
	void Start()
	{
		InitializeRandom();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void InitializeRandom()
	{
		Spheres = new GameObject[NumberOfSpheres];
		int position = 0;


		for (int i = 0; i < NumberOfSpheres; i++)
		{
			int randomSize = Random.Range(1, NumberOfSpheres + 1);
			GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

			sphere.transform.localScale = new Vector3(x: randomSize, y: randomSize, z: randomSize);
			sphere.transform.localPosition = new Vector3(x: position, y: position, z: 0);

			Spheres[i] = sphere;

			position += 5;
		}
	}

}
