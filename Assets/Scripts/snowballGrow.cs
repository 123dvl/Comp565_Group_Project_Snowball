using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballGrow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int growrate = 1;
    void Start()
    {
        Debug.Log("Snowball Grow script loaded.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.localScale = new Vector3(transform.localScale.x + (Time.deltaTime * growrate), transform.localScale.y + (Time.deltaTime * growrate), transform.localScale.z + (Time.deltaTime * growrate));
            Debug.Log($"The Ball is Growing");
        }

    }
}
