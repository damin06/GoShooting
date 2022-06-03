using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{
    [SerializeField] StageData stageData;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTime = 0.7f;
    ObjectPloor enemyPooler;

    void Start()
    {
        enemyPooler = GetComponent<ObjectPloor>();
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float positionX = Random.Range(stageData.LimitMin.x, stageData.LimitMax.x);
            Vector3 pos = new Vector3(positionX, stageData.LimitMax.y + 1f, 0);
            //Instantiate(enemyPrefab, pos, Quaternion.identity);
           enemyPooler.SpawnObjec(transform.position,Quaternion.identity);
           GameObject enemytrue =GameObject.Find("Enemy");
           //enemytrue.transform.position=pos;
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
