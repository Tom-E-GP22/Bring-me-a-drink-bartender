using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enem : MonoBehaviour
{
    public float time;
    public bool dead = false;

    private void Start()
    {
        StartCoroutine("PopDownTimer");
    }

    private IEnumerator PopDownTimer()
    {
        yield return new WaitForSeconds(time);
        GetComponent<Animator>().SetTrigger("PopDown");
    }

    public void Shoot()
    {
        if (!dead)
        {
            Debug.Log("Pow haha");

            DuckHunt_Master.Instance.health--;
        }           
        else
            Debug.Log("I'm too dead to shoot:(");
    }

    public void SetUnactive()
    {
        this.gameObject.SetActive(false);
    }
}
