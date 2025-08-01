using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CanvasService : MonoBehaviour
{
    List<Tarefa> tarefas = new List<Tarefa> { };
    public Text TarefaInput;

    public Canvas canvasTarefa;
    public Canvas canvasList;

    public void createTarefa()
    {
        int coutTarefas = tarefas.Count;
        Tarefa tarefa = new Tarefa(coutTarefas + 1, TarefaInput.text);
        tarefas.Add(tarefa);
        canvasTarefa.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = TarefaInput.text;
        Instantiate(canvasTarefa, canvasList.transform);
    }

    public void listAll()
    {
        foreach (Tarefa tarefa in tarefas)
        {
            Debug.Log(tarefa.getTarefa());
        }
    }
}
