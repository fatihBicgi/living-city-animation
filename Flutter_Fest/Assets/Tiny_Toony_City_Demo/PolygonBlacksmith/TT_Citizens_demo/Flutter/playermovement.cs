using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playermovement : MonoBehaviour
{
    static Animator anim;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    public GameObject phone;
    void Start()
    {
        anim = GetComponent<Animator>();
        phone.SetActive(false);
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 6;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2;
        }

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJumping");
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(0);
        }

        if (translation != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("isTaking", true);
            phone.SetActive(true);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("isTaking", false);
            phone.SetActive(false);
        }

    }
}
