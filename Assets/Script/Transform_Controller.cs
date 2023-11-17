using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Controller : MonoBehaviour
{
    float currRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position = new Vector3(0.0f, currRot, 0.0f);
    }

    public void LeftRotate()
    {
        currRot += 30;
    }

    public void RightRotate()
    {
        currRot -= 30;
    }

    public void PlusScale()
    {

    }

    public void MinusScale()
    {

    }
}
