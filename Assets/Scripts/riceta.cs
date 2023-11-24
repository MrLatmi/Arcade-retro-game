using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class riceta : MonoBehaviour
{

	public GameObject objectPrefab;
	public float speed = 5;
	public float rotatingSpeed = 200;
	public GameObject target;


	Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{

		target = GameObject.FindGameObjectWithTag("Player");
		
		rb = GetComponent<Rigidbody2D>();


	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (GameObject.Find("platforma"))
        {
			Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;

			point2Target.Normalize();

			float value = Vector3.Cross(point2Target, transform.right).z;

		/*
		if (value > 0) {

				rb.angularVelocity = rotatingSpeed;
		} else if (value < 0)
				rb.angularVelocity = -rotatingSpeed;
		else
				rotatingSpeed = 0;
		*/

			rb.angularVelocity = rotatingSpeed * value;


			rb.velocity = transform.right * speed;
        }
		


	}


	private void OnTriggerEnter2D(Collider2D collision)
    {
		if(collision.gameObject.CompareTag("Player"))
        {
			GameObject newObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);
			Destroy(newObject, 0.4f);
			Destroy(target);
			SceneManager.LoadScene("loooose");
		}
		

	}



}
