using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour
{

    private Animator _animator;
    public float moveSpeed = 6.0f;
    public float rotSpeed = 5.0f;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        float translation = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", true);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", false);
        }

        else if (Utility.isWon)
        {
            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", true);
            _animator.SetBool("isDead", false);
        }

        else if (Utility.isDead)
        {
            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", true);
        }

        else if (Utility.didKillEnemy)
        {
            Utility.didKillEnemy = false;
            _animator.SetBool("isIdle", false);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", true);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", false);
        }

        else
        {
            _animator.SetBool("isIdle", true);
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isVictory", false);
            _animator.SetBool("isDead", false);
        }

    }
}
