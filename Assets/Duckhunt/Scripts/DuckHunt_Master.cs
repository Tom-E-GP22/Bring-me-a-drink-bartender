using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckHunt_Master : MonoBehaviour
{
    public static DuckHunt_Master Instance;

    public int health = 3;

    public float waveCooldown;
    public GameObject[] waves;

    private void Start()
    {
        Instance = this;

        StartCoroutine("WaveGen");
    }

    private IEnumerator WaveGen()
    {
        for (int i = 0; i < waves.Length; i++)
        {
            yield return new WaitForSeconds(waveCooldown);

            waves[i].SetActive(true);
        }

        Debug.Log("Level Cleared");
    }
}
