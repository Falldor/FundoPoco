using System.Collections;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class BackgroundService : MonoBehaviour
{
    private GameObject fundoA;
    private GameObject fundoB;
    private GameObject fundoC;
    [SerializeField] private int velocidadeTroca = 1;
    private int IdFundo = 0;

    private Vector2 posFimFila;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fundoA = transform.GetChild(0).gameObject;
        fundoB = transform.GetChild(1).gameObject;
        fundoC = transform.GetChild(2).gameObject;
        posFimFila = new Vector2(fundoC.transform.position.x, fundoC.transform.position.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //-17,82
        Debug.Log(fundoA.transform.position);

    }

    public void TrocaBackGround()
    {
        StartCoroutine(swap());
    }

    private IEnumerator swap()
    {
        while (transform.GetChild(IdFundo).transform.position.x > -17.75)
        {
            fundoA.transform.position = new Vector2(fundoA.transform.position.x - velocidadeTroca * Time.deltaTime, fundoA.transform.position.y);
            fundoB.transform.position = new Vector2(fundoB.transform.position.x - velocidadeTroca * Time.deltaTime, fundoB.transform.position.y);
            fundoC.transform.position = new Vector2(fundoC.transform.position.x - velocidadeTroca * Time.deltaTime, fundoC.transform.position.y);
            yield return null;
        }
        transform.GetChild(IdFundo).transform.position = posFimFila;
        if (IdFundo < 2)
        {
            IdFundo++;
        }
        else
        {
            IdFundo = 0;
        }
    }


}
