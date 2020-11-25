using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Wander : MonoBehaviour {
    private Vector3 targetPosition;

    private float movementSpeed = 7.0f;
    private float rotationSpeed = 2.0f;
    private float targetPositionTolerance = 3.0f;
    private float minX;
    private float maxX;
    private float minZ;
    private float maxZ;
    
    void Start() {
//Positiion of box, box where AI's stay inside
        minX = -72.03f;
        maxX = 23.25f;

        minZ = -38.042f;
        maxZ = 58.0f;

//Get Wander Position
        GetNextPosition();
    }

    void Update() {
        if (Vector3.Distance(targetPosition, transform.position) <= targetPositionTolerance) {
            GetNextPosition();
        }

        Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.Translate(new Vector3(0, 0, movementSpeed * Time.deltaTime));
    }
    
    void GetNextPosition() {
//-16 is height of the AI's 
        targetPosition = new Vector3(Random.Range(minX, maxX), -16.0f, Random.Range(minZ, maxZ));
    }
}