using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    public ProjectileBase prefabProjectile;
    public Transform positionShoot;
    public float timeBetweenShoot = .3f;
    public Transform playerSideReference;

    private Coroutine _currentCoroutine;

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.D))
       {
        _currentCoroutine = StartCoroutine(StartShoot());
       } 

       else if(Input.GetKeyUp(KeyCode.D))
       {
        if(_currentCoroutine != null) StopCoroutine(_currentCoroutine);
       } 
    }

    IEnumerator StartShoot()
    {
        while(true)
        {
        Shoot();
        yield return new WaitForSeconds(timeBetweenShoot);
        }
    }



    private void Shoot()
    {
        var projectile = Instantiate(prefabProjectile);
        projectile.transform.position = positionShoot.position;
        projectile.side = playerSideReference.transform.localScale.x;
    }
}
