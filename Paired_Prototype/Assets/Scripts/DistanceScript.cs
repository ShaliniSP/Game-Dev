using System.Collections;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DistanceScript : MonoBehaviour
{
    public Transform target;
    public GameObject greenDot;
    public float dotThreshold = 0.75f;
    public float dotDistance = 2.0f;
    public TextMeshPro distanceText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToTarget = (target.position - transform.position).normalized;
        float dotProduct = Vector3.Dot(transform.forward, directionToTarget);
        if (dotProduct >= dotThreshold)
        {
            // Show the green dot when facing the target
            greenDot.SetActive(true);
            Vector3 dotPosition = transform.position + directionToTarget * dotDistance;
            dotPosition.y = transform.position.y;
            greenDot.transform.position = dotPosition;

            float distanceToTarget = Vector3.Distance(transform.position, target.position);
            distanceText.text = distanceToTarget.ToString("F1") + "m";
            distanceText.transform.position = greenDot.transform.position + Vector3.up * 0.5f;

            distanceText.transform.LookAt(Camera.main.transform);
            distanceText.transform.Rotate(0, 180, 0);
            greenDot.transform.LookAt(Camera.main.transform);

        }

        else
        {
            // Hide the green dot when not facing the target
            greenDot.SetActive(false);
            distanceText.text = "";
        }

    }
}
