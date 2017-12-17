using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    private readonly float speed = 1.2f;
    private readonly int damage = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	    transform.position += transform.up * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Monster")
        {
            Debug.Log("damaged monster!!");
            coll.gameObject.GetComponent<MonsterController>().SetDamaged(damage);
            Destroy(gameObject);
        }
        else if (coll.gameObject.name.StartsWith("Wall"))
        {
            Destroy(gameObject);
        }


    }
}
