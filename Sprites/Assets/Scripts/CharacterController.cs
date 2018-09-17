using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public Animator m_animator;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Do Something 
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Do something else
        }
        else
        {
            //Do some default thing...
        }

    }
}
