using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AnimatorControllingScript : MonoBehaviour
{
    public GameObject avatar;
    private PhotonView view;
    public bool isAvatarLoaded = false;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAvatarLoaded && view.IsMine)
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
