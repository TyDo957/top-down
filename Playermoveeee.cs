using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Playermoveeee;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Playermoveeee : MonoBehaviour
{
    // Reference to the weapon GameObject
    private GameObject weaponObject;

    // Vector to store the direction from player to mouse
    private Vector2 direction;

    // Angle for weapon rotation
    private float angle;

    void Start()
    {
        // Get the weapon GameObject from this script's parent (assuming weapon is a child)
        weaponObject = transform.parent.gameObject;
    }

    void Update()
    {
        // Convert mouse position from screen coordinates to world coordinates
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction vector from player to mouse
        direction = new Vector2(mousePosition.x - weaponObject.transform.position.x, mousePosition.y - weaponObject.transform.position.y);

        // Calculate the rotation angle using Mathf.Atan2
        angle = Mathf.Atan2(direction.y, direction.x) * 180f / Mathf.PI;

        // Rotate the weapon based on the calculated angle
        weaponObject.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}