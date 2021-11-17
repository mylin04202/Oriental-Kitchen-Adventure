using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBowlOpen : MonoBehaviour
{

    public Animator _bluebowlAnim;

    private void OnTriggerEnter(Collider other)
    {
        _bluebowlAnim.SetBool("open", true);
    }

    private void OnTriggerExit(Collider other)
    {
        _bluebowlAnim.SetBool("open", false);
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
