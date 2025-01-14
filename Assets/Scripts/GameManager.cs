using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public List<Transform> spawnPoints;
    public int spawnPointIndex;

    /*
    public List<Transform> spawnGrids;
    public int spawnGridsIndex;
    */

    private void Awake()
    {
        GM = this;

        foreach(GameObject sp in GameObject.FindGameObjectsWithTag("SpawnPoint"))
        {
            spawnPoints.Add(sp.transform);
        }
        spawnPointIndex = PlayerPrefs.GetInt("SpawnPoints", 0);
        spawnPoints.Sort((x, y) => x.name.CompareTo(y.name));

        /*
        foreach(GameObject sp in GameObject.FindGameObjectsWithTag("SpawnGrids"))
        {
            spawnGrids.Add(sp.transform);
        }
        spawnGridsIndex = PlayerPrefs.GetInt("SpawnGrids", 0);
        spawnGrids.Sort((x, y) => x.name.CompareTo(y.name));
        */
    }

    public void SetSpawnPoint(Transform sp)
    {
        PlayerPrefs.SetInt("SpawnPoints", spawnPoints.IndexOf(sp));
        spawnPointIndex = PlayerPrefs.GetInt("SpawnPoints", 0);
    }
    /*
    public void SetGrid(Transform sp)
    {
        PlayerPrefs.SetInt("SpawnGrids", spawnGrids.IndexOf(sp));
        spawnGridsIndex = PlayerPrefs.GetInt("SpawnGrids", 0);
    }
    */
}
