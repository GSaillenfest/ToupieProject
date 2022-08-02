using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    [SerializeField] GameObject enemies;
    [SerializeField] GameObject player;
    [SerializeField] GameObject[] enemyTypes;
    [SerializeField] Vector3[] spawnPos;

    int i = 1;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (count == 0)
        {
            for (int j = 0; j < i; j++)
            {
                int indexSpawnPos = Random.Range(0, spawnPos.Length);
                if ((spawnPos[indexSpawnPos] - player.transform.position).magnitude < 5)
                {
                    j--;
                    return;
                }
                int index = Random.Range(0, enemyTypes.Length);
                Instantiate(enemyTypes[index], spawnPos[indexSpawnPos], Quaternion.identity, enemies.transform);
            }
            i++;
        }
    }


}
