using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch44Control : MonoBehaviour
{
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Jump");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _animator.SetTrigger("Punch");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetBool("Dancing", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("Dancing", false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetTrigger("HK");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetTrigger("FPC");
        }

    }

}
