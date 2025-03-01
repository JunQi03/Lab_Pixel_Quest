using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GeoControllers : MonoBehaviour
{
    string String = "Hello";
    int var = 3;
    public string nextlevel = "Scene_1";

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Death":
                {
                    Debug.Log("Player has died");

                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);

                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }
    }

    private Rigidbody2D rb;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        /*
        Debug.Log("Hello World");
        string Stringtwo = "World";
        Debug.Log(String + Stringtwo);
        */
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        //Debug.Log(xInput);
        rb.velocity = new Vector2 (xInput * speed, rb.velocity.y);

        /*

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }
        */
    }
}     
       

        /*
        if (Input.GetKeyDown(KeyCode.W))

        {
            transform.position += new Vector3(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        
        Debug.Log(var);
        var++;
        //transform.position += new Vector3(0.005f, 0, 0);
    }
}
        */