using System;
using UnityEngine;

public class MonsterController : MonoBehaviour
{

    private readonly float speed = 1.1f;
    private GameObject link;

    private int hp = 10;

    // Use this for initialization
    void Start()
    {
        link = GameObject.Find("Link");
    }

    // Update is called once per frame
    void Update()
    {

        /*
        Vector3 link_position = link.transform.position;
        Vector3 monster_position = this.transform.position;
        Vector3 direction = (link_position - monster_position).normalized;
        Vector3 move_position = monster_position + direction * Time.deltaTime * speed;
        transform.position = move_position;
        */

        //(link.transform.position - this.transform.position).magnitude
        //float dist = Vector3.Distance(link.transform.position, this.transform.position);
        
        transform.up = (link.transform.position - this.transform.position).normalized;
        transform.position += transform.up * Time.deltaTime * speed;


        /*
        Debug.Log("monster_position : "+ monster_position.x + ", " + monster_position.y);


        Vector3 new_monster_position = new Vector3();

        int upDownDirection = 1; // up : true, down : false
        int leftRightDirection = 1; // right: true, left : false

        if ((link_position.x - monster_position.x) >= 0)
        {
            upDownDirection = 1;
        }
        else
        {
            upDownDirection = -1;
        }


        if ((link_position.y - monster_position.y) >= 0)
        {
            leftRightDirection = 1;
        }
        else
        {
            leftRightDirection = -1;
        }

        new_monster_position.x = leftRightDirection * Time.deltaTime * speed;
        new_monster_position.y = upDownDirection* Time.deltaTime * speed;


        transform.position = new_monster_position;
        */
    }

    public void SetDamaged(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Debug.Log("dead!");
            return;
        }

        Debug.Log("damaged!");
    }
}