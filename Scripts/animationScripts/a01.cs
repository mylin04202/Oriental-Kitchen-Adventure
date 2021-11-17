using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a01 : MonoBehaviour
{

    public Animator _noodleAnim;

    private void OnTriggerEnter(Collider other)
    {
        _noodleAnim.SetBool("open", true);
    }

    private void OnTriggerExit(Collider other)
    {
        _noodleAnim.SetBool("open", false);
    }



    // Start is called before the first frame update



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}