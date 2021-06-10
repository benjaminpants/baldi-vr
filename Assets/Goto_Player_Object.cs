using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goto_Player_Object : MonoBehaviour
{
    public GameObject PlayerObject;
    public Vector3 offset;
    public Vector3 rotational_offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.transform.position = PlayerObject.transform.position - offset;
        base.transform.eulerAngles = rotational_offset;
    }
}
