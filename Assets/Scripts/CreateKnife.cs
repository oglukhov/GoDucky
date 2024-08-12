using UnityEngine;
using System.Collections;

public class CreateKnife : MonoBehaviour
{
    public GameObject knife;
    private bool isSpawn;
    public float waitTime = 1f;

    private void Update()
    {
        if (StartGame.isStart && !isSpawn)
        {
            StartCoroutine(spawnKnives());
            isSpawn = true;
        }
    }

    IEnumerator spawnKnives()
    {
        while (StartGame.isStart == true)
        {
            Instantiate(
                knife, 
                new Vector2(6.17f, 
                    Random.Range(-3.27f, -1f)), Quaternion.Euler(new Vector3(0, 0, -45)));
            yield return new WaitForSeconds(waitTime);
        }
    }
}
