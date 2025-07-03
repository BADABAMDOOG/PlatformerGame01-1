using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
//아이템 스크립트를 사용하면 오브젝트가 늘어나더라도,
//점수가 다른 아이템은 쉽게 늘릴 수 있다.
public class item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"OnCollisionEnter2D:{collision.gameObject.name}");
        if (collision.gameObject.name == "player")
           
            {

            collision.GetComponent<Dynamic>().score ++;
            //collision.GetComponent<Dynamic>().score+=score;
                //Destroy(collision.gameObject);
                Destroy(this.gameObject );
            }
    }

}



