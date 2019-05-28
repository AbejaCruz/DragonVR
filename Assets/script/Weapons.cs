using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour {
    //Manos
    GameObject rightHand, leftHand;
    //posiciones para los poderes 
    Vector3 lastPositionRight, lastPositionLeft;
    //gameboject para las armas y los pñuntos donde sale los poderes
    public GameObject rightWeapon, leftWeapon, rightWeaponAlt, magicLaunchPoint;
    //poderes
    public GameObject fireMagic;
    //tiempo de espera entre cambios de armas y poderes
    public float weaponCooldown, magicCooldown=0.0f;
    //cooldown
    public const float WEAPON_COOLDOWN_TIME = 0.5f;
    public const float MAGICN_COOLDOWN_TIME = 2.0f;

    //Activar escudo
    public bool shieldActive = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
