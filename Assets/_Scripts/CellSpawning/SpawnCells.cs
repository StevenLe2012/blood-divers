using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CellSpawning
{
    public class SpawnCells : MonoBehaviour
    {
        [SerializeField] private Transform[] spawnPoints;
        [SerializeField] private GameObject[] cellTypes;
        [SerializeField] private float averageTimeToSpawn = 1f;
        [SerializeField] private Vector3 velocity;
        [SerializeField] private float speed;
        [SerializeField] private Quaternion rotation;
        


        public float HeartBeatNum;

        private float normalizedHeartBeatMultiplier = 1f;

        private const float NORMAL_ARDUINO_HEARTBEAT_NUM = 100;

        private void Start()
        {
            StartCoroutine(SpawnEnemyCoroutine());
        }

        private IEnumerator SpawnEnemyCoroutine()
        {
            // set to while game running
            while (true)
            {
                var timeBetweenNextSpawn = averageTimeToSpawn * normalizedHeartBeatMultiplier;
                yield return new WaitForSeconds(timeBetweenNextSpawn);
                SpawnCell();
            }
        }
        
        private void SpawnCell()
        {
            if (spawnPoints.Length != 0)
            {
                var spawnPointIndex = Random.Range(0, spawnPoints.Length);
                var cellTypeIndex = RandomBloodTypeIndex();
                // if cellTypeIndex out of bounds
                if (cellTypeIndex >= cellTypes.Length) return;
                
                var spawnLocation = spawnPoints[spawnPointIndex];
                var cellType = cellTypes[cellTypeIndex];
                // cellType.transform.position = spawnLocation.transform.position;
                var cell = Instantiate(cellType, spawnLocation.transform);
                // cell.GetComponent<CellMovement>().SetVelocity(velocity);
                cell.GetComponent<CellMovement>().SetSpeed(speed);
                // cell.GetComponent<CellMovement>().SetRotation(rotation);
                cell.GetComponent<Rigidbody>().freezeRotation = false;
                // cell.GetComponent<Rigidbody>().freezePosition = false;
            }
        }
        
        // HARD CODED PROBABILITIES FOR CELLS
        // 1% white blood cells
        // 1% platelets
        // 45% red blood cells
        // 53% plasma and such
        private int RandomBloodTypeIndex()
        {
            var index = Random.Range(0, 100);
            if (index == 0)
            {
                return 0;
            }
            else if (index == 1)
            {
                return 1;
            }
            else if (2 <= index && index <= 46)
            {
                return 2;
            }
            else
            {
                return 3;
            }
            
        }
    }
}

