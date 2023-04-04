using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyMovement : MonoBehaviour
{
    public Transform collectableItem;
    public float speed = 2f;
    public float distance = 1.5f;

    private void Update()
    {
        // Get the direction to the collectable item
        Vector3 direction = collectableItem.position - transform.position;

        // Move towards the collectable item if it is too far away
        if (direction.magnitude > distance)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }

        // Rotate towards the collectable item
        transform.LookAt(collectableItem);
    }
}
