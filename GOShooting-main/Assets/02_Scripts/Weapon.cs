
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    GameObject projectilePrefabs;
    [SerializeField]
    ObjectPloor bulletPooler;
    float attackRate = 0.1f;
    private void Start(){
        bulletPooler =GetComponent<ObjectPloor>();
    }

    public void StartFriring()
    {
        StartCoroutine("TryAttack");
    }

    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }

    IEnumerator TryAttack()
    {
        while (true)
        {
           //Instantiate(projectilePrefabs, transform.position, Quaternion.identity);
           bulletPooler.SpawnObjec(transform.position, Quaternion.identity);
            yield return new WaitForSeconds(attackRate);
        }
    }
}
