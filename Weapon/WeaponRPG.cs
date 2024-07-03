using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponRPG : MonoBehaviour
{
    [SerializeField] private GameObject buletPlayerl;
    [SerializeField] private Transform firePos;
    [SerializeField] private float TimeBwFire = 0.2f;
    [SerializeField] private float bulletForce;
    private float timeBtfire;
    // public Transform player;

    public float ammo = 40f;
    public Text txt;


    public Transform player;
    public SpriteRenderer weaponSprite;
    public Transform bulletPrefab; // Reference to your bullet prefab
    public float offset = 1.0f; // Distance between weapon and character
    public float bulletSpeed = 10.0f; // Speed of the bullet

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && ammo != 40)
        {
            ammo = 300;
        }

        txt.text = ammo.ToString();


        this.RotaGun();
        timeBtfire -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeBtfire < 0 && ammo > 0)
        {
            ammo -= 1;
            this.Bulet();
            this.RotaGun();
        }

    }
    public void RotaGun()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction vector from weapon to mouse
        Vector3 aimDirection = mousePos - transform.position;

        // Calculate the desired rotation angle
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        // Rotate the weapon based on the angle
        transform.rotation = Quaternion.Euler(0, 0, angle);

        // Optional: Adjust position based on player direction (if attached)
        if (player)
        {
            transform.position = player.position + aimDirection.normalized;
        }

    }



    public void Bulet()
    {


        timeBtfire = TimeBwFire;
        GameObject bullettmp = Instantiate(buletPlayerl, firePos.position, Quaternion.identity);
        Rigidbody2D rb = bullettmp.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
        SoundController.instance.PlayerRPG();
        if (transform.eulerAngles.z > 90 && transform.eulerAngles.z < 270)
        {
            transform.localScale = new Vector3(0.2f, -0.2f, 0f);
        }
        else
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 0f);
        }


    }

}
