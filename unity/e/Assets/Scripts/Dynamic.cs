using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamic : MonoBehaviour
{
    public int score;
    public float speed = 1;
    public float jumpPower = 6;

    public float jump;
    // Start is called before the first frame update
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))    
        transform.position += Vector3.right * speed * Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftArrow))
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);

       
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 200, 20), "Score:" + score);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"OnCollisionEnter2D:{collision.gameObject.name}");
        if (collision.gameObject.name == "cherry")
        {
            score++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "gem")
        {
            score += 100;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "ball")
        {
            score += 600;
            Destroy(collision.gameObject);
        }
    }


    //아이템이 추가될떄마다 경우의 수가 늘어나고 , 코드를 변경해야한다.

    //private void OnCollisionEnter2D(Collision2D collision)
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log($"OnCollisionEnter2D:{collision.gameObject.name}");
    //    if (collision.gameObject.name == "cherry")
    //        if (collision.gameObject.name == "gem")
    //    {
    //        score++;
    //        Destroy( collision.gameObject );
    //        //Destroy(this.gameObject );
    //    }
    //}
}
