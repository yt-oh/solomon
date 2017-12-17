using UnityEngine;

namespace Assets.Scripts
{
    [DisallowMultipleComponent]
    public class LinkController : MonoBehaviour
    {

        private readonly float speed = 1f;
        private readonly float rotateSpeed = 360f;
        private Animator _animator;

        public GameObject MissilePrefab;

        // Use this for initialization
        private void Start()
        {

            _animator = GetComponent<Animator>();
            _animator.Play("Player_Down_Idle");
        }

        private void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.name == "Monster")
            {
                //Destroy(gameObject);
                Debug.Log("damaged player!!");
            }
            //Debug.Log(coll.gameObject.name);
        }

        // Update is called once per frame
        private void Update () {


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
                    _animator.Play("Player_Up_Walk");
                    Debug.Log("character up");
                }
                else if (Input.GetKeyUp(KeyCode.W) == true)
                {
                    _animator.Play("Player_Up_Idle");
                }

                if (Input.GetKey(KeyCode.S) == true)
                {
                    Vector3 position = this.transform.position;
                    position.y -= Time.deltaTime * speed;
                    this.transform.position = position;
                    _animator.Play("Player_Down_Walk");
                    Debug.Log("character down");
                }
                else if (Input.GetKeyUp(KeyCode.S) == true)
                {
                    _animator.Play("Player_Down_Idle");
                }

                if (Input.GetKey(KeyCode.A) == true)
                {
                    Vector3 position = this.transform.position;
                    position.x -= Time.deltaTime * speed;
                    this.transform.position = position;
                    _animator.Play("Player_Left_Walk");
                    Debug.Log("character left");
                }
                else if (Input.GetKeyUp(KeyCode.A) == true)
                {
                    _animator.Play("Player_Left_Idle");
                }

                if (Input.GetKey(KeyCode.D) == true)
                {
                    Vector3 position = this.transform.position;
                    position.x += Time.deltaTime * speed;
                    this.transform.position = position;
                    _animator.Play("Player_Right_Walk");
                    Debug.Log("character right");
                }
                else if (Input.GetKeyUp(KeyCode.D) == true)
                {
                    _animator.Play("Player_Right_Idle");
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    GameObject missileObj = Instantiate<GameObject>(MissilePrefab , this.transform.position , Quaternion.Euler(0f,0f,0f));
                    missileObj.SetActive(true);

                }

                //                if (Input.GetKey(KeyCode.LeftArrow))
                //                {
                //                    Vector3 rotate = this.transform.eulerAngles;
                //                    rotate.z += Time.deltaTime * rotateSpeed;
                //                    this.transform.eulerAngles = rotate;
                //                }
                //
                //                if (Input.GetKey(KeyCode.RightArrow))
                //                {
                //                    Vector3 rotate = this.transform.eulerAngles;
                //                    rotate.z -= Time.deltaTime * rotateSpeed;
                //                    this.transform.eulerAngles = rotate;
                //                }
            }
        }
    }
}
