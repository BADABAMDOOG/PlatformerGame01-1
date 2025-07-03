using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour
{

    public bool isJump;
    public float speed = 1;
    public float jumpPower = 60;
    public float time;

    public bool isTimmer;

    IEnumerator ProcessTimer()
    {
        Debug.Log("ProcessTimer() start");
        yield return new WaitForSeconds(time);
        Debug.Log("ProcessTimer() end");
        isTimmer = true;
        Debug.Log("ProcessTimer() end");
    }

    void Start()
    
    {
        

    }

    void Update()
    {
        if(isJump)
        transform.position += Vector3.left * speed * Time.deltaTime;   

        
    }


    void Jump()
   
    
    {

        if (isJump == false)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
            isJump = true;

        }
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        isJump = false;
        StartCoroutine(ProcessTimer());

    }

}