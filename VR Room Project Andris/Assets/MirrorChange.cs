using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorChange : MonoBehaviour
{
    public Material Clear;
    public Material Mirror;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetMirrorClear()
    {
        GetComponent<Renderer>().material = Clear;
    }

    public void SetMirrorMat()
    {
        GetComponent<Renderer>().material = Mirror;
    }
    // Update is called once per frame
  
}
