using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2.0f;
    private float start;
    public float distance = 3f;
    public enum axis: int
    {
        x, y, z
    }
    public axis ax;
    private bool isStopped = false;
    // Start is called before the first frame update
    void Start()
    {
        switch(ax)
        {
            case axis.x:
                start = transform.position.x;
                break;
            case axis.y:
                start = transform.position.y;
                break;
            case axis.z:
                start = transform.position.z;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStopped)
        {
            float newPos = Mathf.PingPong(Time.time * speed, distance*2) - distance ;
            switch (ax)
            {
                case axis.x:
                    transform.position = new Vector3(newPos + start, transform.position.y, transform.position.z);
                    break;
                case axis.y:
                    transform.position = new Vector3(transform.position.x, newPos + start, transform.position.z);
                    break;
                case axis.z:
                    transform.position = new Vector3(transform.position.x, transform.position.y, newPos + start);
                    break;
                default:
                    break;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isStopped = true;
        transform.position = transform.position;
    }
}