using System.Collections.Generic;
using UnityEngine;

public class TarefasController : MonoBehaviour
{
    private Dictionary<int, GameObject> _tarefas;
    private int lastId;
    [SerializeField] private GameObject _areaTarefas;
    [SerializeField] private GameObject _cardTarefaPrefab;

    public static TarefasController Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake() => Instance = this;

    void Start()
    {
        lastId = 0;
    }

    public void CreateCard(string textoInput, int horasInput, int minutosInput)
    {
        GameObject tarefa = Instantiate(_cardTarefaPrefab, _areaTarefas.transform);
        tarefa.transform.GetComponent<Tarefa>().CreateTarefa(textoInput,lastId, horasInput, minutosInput);
        _tarefas.Add(lastId, tarefa);
    }

}
