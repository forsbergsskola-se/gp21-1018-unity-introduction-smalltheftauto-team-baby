using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ShottingSO : MonoBehaviour
{
  //Gun Stats
  public int damage;
  public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
  public int magazineSize, bulletsPerTap;
  public bool allowButtonHold;
  private int bulletsLeft, bulletShot;
  public float bulletForce = 20f;


  private bool shooting, readyToShoot, realoding;
  
  //Ref
  
  public Transform firePoint;
  public LayerMask whatIsEnemy;
  public GameObject bulletPrefab;


  public void Awake()
  {
    bulletsLeft = magazineSize;
    readyToShoot = true;
  }

  private void Update()
  {
    MyInput();
  }

  private void MyInput()
  {
    if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
    else shooting = Input.GetKeyDown(KeyCode.Mouse0);
    
    if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !realoding) Reload();
    //shoot
    if (readyToShoot && shooting && !realoding && bulletsLeft > 0)
    {
      bulletShot = bulletsPerTap;
      Shoot();
    }
    
  }

  private void Shoot()
  {
    readyToShoot = false;

    GameObject bullet =  Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Rigidbody2D rb= bullet.GetComponent<Rigidbody2D>(); 
    
    rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    
    
    bulletsLeft--;
    bulletShot--;
    Invoke("ResetShot", timeBetweenShooting);
    
    if(bulletShot > 0 && bulletsLeft > 0)
    Invoke("Shoot", timeBetweenShots);
  } 
  
  

  private void ResetShot()
  {
    readyToShoot = true;
  }
  
  
  
  
  private void Reload()
  {
    realoding = true;
      Invoke("ReloadFinished",reloadTime);
  }

  private void ReloadFinished()
  {
    bulletsLeft = magazineSize;
    realoding = false;

  }
  
}
