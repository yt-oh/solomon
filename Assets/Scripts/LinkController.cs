using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour {

    private float speed = 1f;
    private float rotateSpeed = 360f;

    // Use this for initialization
    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.x -= Mathf.Abs(Time.deltaTime * speed);
            position.y += Mathf.Abs(Time.deltaTime * speed);
            this.transform.position = position;
            Debug.Log("character left/up");

        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.x -= Mathf.Abs(Time.deltaTime * speed);
            position.y -= Mathf.Abs(Time.deltaTime * speed);
            this.transform.position = position;
            Debug.Log("character left/down");

        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.x += Mathf.Abs(Time.deltaTime * speed);
            position.y += Mathf.Abs(Time.deltaTime * speed);
            this.transform.position = position;
            Debug.Log("character right/up");

        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.x += Mathf.Abs(Time.deltaTime * speed);
            position.y -= Mathf.Abs(Time.deltaTime * speed);
            this.transform.position = position;
            Debug.Log("character right/down");

        }
        else
        {   
            if (Input.GetKey(KeyCode.W) == true)
            {
                Vector3 position = this.transform.position;
                position.y += Time.deltaTime * speed;
                this.transform.position = position;
                Debug.Log("character up");
            }

            if (Input.GetKey(KeyCode.S) == true)
            {
                Vector3 position = this.transform.position;
                position.y -= Time.deltaTime * speed;
                this.transform.position = position;
                Debug.Log("character down");
            }

            if (Input.GetKey(KeyCode.A) == true)
            {
                Vector3 position = this.transform.position;
                position.x -= Time.deltaTime * speed;
                this.transform.position = position;
                Debug.Log("character left");
            }

            if (Input.GetKey(KeyCode.D) == true)
            {
                Vector3 position = this.transform.position;
                position.x += Time.deltaTime * speed;
                this.transform.position = position;
                Debug.Log("character right");
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Vector3 rotate = this.transform.eulerAngles;
                rotate.z += Time.deltaTime * rotateSpeed;
                this.transform.eulerAngles = rotate;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 rotate = this.transform.eulerAngles;
                rotate.z -= Time.deltaTime * rotateSpeed;
                this.transform.eulerAngles = rotate;
            }
        }
   }
}
