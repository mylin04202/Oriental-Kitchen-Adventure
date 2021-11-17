using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotpot : MonoBehaviour
{
    public Animator _hotpotAnim;

    private void OnTriggerEnter(Collider other)
    {
        _hotpotAnim.SetBool("open", true);
    }

    private void OnTriggerExit(Collider other)
    {
        _hotpotAnim.SetBool("open", false);
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
