using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour
{

    public static Animator _animator;
    public float moveSpeed = 6.0f;
    public float rotSpeed = 5.0f;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        { //running

            float translation = Input.GetAxis("Vertical") * moveSpeed;
            float rotation = Input.GetAxis("Horizontal") * rotSpeed;
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;
            transform.Translate(0, 0, translation);
            transform.Rotate(0, rotation, 0);

            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", true);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", false);
        }

        else if (Input.GetKey(KeyCode.Z)) // is happy
        {
            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", true);
            _animator.SetBool("isDead", false);
        }

        else if (Input.GetKey(KeyCode.X)) //dies 
        {
            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", true);
        }

        else if (Input.GetKey(KeyCode.C)) //jumps
        {
            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", true);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", false);
        }

        else //idle
        {
            _animator.SetBool("isIdle", true);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", false);
        }

    }
}
