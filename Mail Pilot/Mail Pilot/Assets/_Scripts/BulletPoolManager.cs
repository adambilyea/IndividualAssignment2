using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets

    Queue<GameObject> Pool;
    public int bulletPoolSize;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        Pool = new Queue<GameObject>();

        for (int i = 0; i < bulletPoolSize; i++)
        {
            GameObject obj = Instantiate(bullet);
            obj.SetActive(false);
            Pool.Enqueue(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet(Vector3 position)
    {
        GameObject objectToSpawn = Pool.Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        
        return objectToSpawn;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        Pool.Enqueue(bullet);
    }    

}
