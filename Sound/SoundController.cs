using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;
    [SerializeField] private AudioClip Bullet, enemy, gun , RPG;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PlayerBullet()
    {
        AudioSource.PlayClipAtPoint(Bullet, transform.position);
    }

    public void PlayerGun()
    {
        AudioSource.PlayClipAtPoint(gun, transform.position);
    }
    public void PlayerRPG()
    {
        AudioSource.PlayClipAtPoint(RPG, transform.position);
    }
}
