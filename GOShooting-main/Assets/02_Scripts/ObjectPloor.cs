using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPloor : MonoBehaviour
{
[SerializeField] GameObject prefab;
[SerializeField] int poolSIze =10;
List<GameObject> prefabsList = new List<GameObject>();
    void Start()
    {
     for(int i=0; i<poolSIze; i++)
     {
       GameObject obj =Instantiate(prefab);
       obj.SetActive(false);
       prefabsList.Add(obj);
     }   
    }

    void Update()
    {
        
    } 
    public GameObject SpawnObjec(Vector3 position, Quaternion rotation)
    {
    GameObject newObj;
    if(prefabsList.Count>0)
    {
     newObj = prefabsList[0];
     prefabsList.RemoveAt(0);
    }
    else
    {
newObj =Instantiate(prefab);
    }
    newObj.SetActive(true);
    newObj.transform.position =position;
    newObj.transform.rotation =rotation;
    return newObj;
    }
    public void ReturnObject(GameObject returnObj)
    {
        returnObj.SetActive(false);
        prefabsList.Add(returnObj);
    }
}
