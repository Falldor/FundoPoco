using TMPro;
using UnityEngine;

public class Tarefa : MonoBehaviour
{


    [SerializeField] private TextMeshProUGUI _textoTarefa;
    [SerializeField] private int _id;
    [SerializeField] private int _horas;
    [SerializeField] private int _minutos;

    public void CreateTarefa(string textoTarefa, int id, int horas, int minutos)
    {
        this._textoTarefa.text = textoTarefa;
        this._id = id;
        this._horas = horas;
        this._minutos = minutos;
    }

    void FixedUpdate()
    {
        Debug.Log(Time.time);
        if (Time.time < 60 &&  Time.time > 61)
        {
            Debug.Log("1min");
        }
    }

}
