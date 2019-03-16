using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class fire : MonoBehaviour
{
    // Start is called before the first frame update
    private TilemapRenderer tmr;
    private Tilemap tm;
    private bool burned = false;
    [SerializeField]
    private float burntime;
    [SerializeField]
    private Tilemap goop;
    void Start()
    {
        tmr = gameObject.GetComponent<TilemapRenderer>();
        tm = gameObject.GetComponent<Tilemap>();

        tmr.sortingLayerName = "Default";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!burned)
        {
            //LightFire();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    public void LightFire()
    {
        if (!burned)
        {
            tmr.sortingLayerName = "EnemyFront";
            StartCoroutine(FireTime());
        }
    }
    private IEnumerator FireTime()
    {
        yield return new WaitForSeconds(burntime);
        tmr.sortingLayerName = "Default";
        burned = true;
        goop.gameObject.SetActive(false);
    }



}
