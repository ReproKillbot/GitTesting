using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(Time.deltaTime * 10f, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(Time.deltaTime * -10f, 0);
        }
    }
}
