using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CanvasService : MonoBehaviour
{
    List<Tarefa> tarefas;
    List<Canvas> CardsTarefas;
    public Text TarefaInput;

    public Canvas canvasTarefa;
    public Canvas canvasList;

    void Start()
    {   
        tarefas = new List<Tarefa> { };
        CardsTarefas = new List<Canvas> { };
    }

    void FixedUpdate()
    {
        if (tarefas.Count != CardsTarefas.Count)
        {
            listAll();
        }
    }

    public void createTarefa()
    {
        int coutTarefas = tarefas.Count;
        Tarefa tarefa = new Tarefa(coutTarefas + 1, TarefaInput.text);
        tarefas.Add(tarefa);
    }

    public void listAll()
    {
        foreach (Tarefa tarefa in tarefas)
        {
            canvasTarefa.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = tarefa.getTarefa();
            //canvasTarefa.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = tarefa.getId().ToString();
            tarefa.SetVisualizado(true);
            CardsTarefas.Add(Instantiate(canvasTarefa, canvasList.transform));
        }
    }

    public void Edit(TextMeshProUGUI ID)
    {
        Debug.Log(ID.text);
    }

     public void Delete(TextMeshProUGUI ID)
    {
        Debug.Log(ID.text);
    }

    


}
