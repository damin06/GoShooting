using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroy : MonoBehaviour
{
    [SerializeField] StageData stageData;
    float destroyWeight = 2f;
ObjectPloor bulletPlooer;
ObjectPloor enemylooler;
  private void Start()
    {
        enemylooler=GameObject.Find("Enemy").GetComponent<ObjectPloor>();
        bulletPlooer=GameObject.FindGameObjectWithTag("Playerbullet").GetComponent<ObjectPloor>();
    }
    private void LateUpdate()
    {
        if(transform.position.x > stageData.LimitMax.x + destroyWeight || 
           transform.position.x < stageData.LimitMin.x - destroyWeight ||
           transform.position.y > stageData.LimitMax.y + destroyWeight || 
           transform.position.y < stageData.LimitMin.y - destroyWeight )
           {
            if(gameObject.CompareTag("Playerbullet"))
            {
                bulletPlooer.ReturnObject(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
           }
              
            
    }
}
