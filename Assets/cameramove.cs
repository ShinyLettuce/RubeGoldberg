using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(22.5f, 7.5f, 15f);
        transform.rotation = Quaternion.Euler(0,-90,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup > 8)
        {
            transform.position = new Vector3(-2.2f, 21.5f, 5.7f);
            transform.rotation = Quaternion.Euler(90, -90, 0);
        }
        if (Time.realtimeSinceStartup > 14)
        {
            transform.position = new Vector3(-17.8f, 11.5f, -26.3f);
            transform.rotation = Quaternion.Euler(38.3f, 0, 0);
        }
        if (Time.realtimeSinceStartup > 20)
        {
            transform.position = new Vector3(-12.9f, -11f, -12.9f);
            transform.rotation = Quaternion.Euler(47.1f, 0, 0);
        }
        if (Time.realtimeSinceStartup > 23)
        {
            transform.position = new Vector3(-12.9f, -56.6f, -16.9f);
            transform.rotation = Quaternion.Euler(-46.2f, 0, 0);
        }
        if (Time.realtimeSinceStartup > 25)
        {
            transform.position = new Vector3(-5f, -56.6f, 0);
            transform.rotation = Quaternion.Euler(90f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Application.Quit();
        }
    }
}
