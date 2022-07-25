using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllingScript : MonoBehaviour
{
    public GameObject avatar;
    public bool isAvatarLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAvatarLoaded)
        {
            if (Input.GetKey("w"))
            {
                avatar.GetComponent<Animator>().SetBool("isWalking",true);
                print("W Pressed");
            }
            else
            {
                avatar.GetComponent<Animator>().SetBool("isWalking", false);
            }

            if (Input.GetKey("t"))
            {
                avatar.GetComponent<Animator>().SetBool("isTalking", true);
                print("t Pressed");
            }
            else
            {
                avatar.GetComponent<Animator>().SetBool("isTalking", false);
            }
        }
    }
}
