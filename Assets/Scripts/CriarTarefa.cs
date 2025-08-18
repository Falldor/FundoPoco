using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CriarTarefa : MonoBehaviour
{
    [SerializeField] private TMP_InputField _textoTarefaInput;
    [SerializeField] private TMP_InputField _horasInput;
    [SerializeField] private TMP_InputField _minutosInput;

    void Start()
    {
        gameObject.SetActive(false);
        _horasInput.text = "0";
        _minutosInput.text = "0";
    }

    public void submit()
    {
        TarefasController.Instance.CreateCard(_textoTarefaInput.text, int.Parse(_horasInput.text), int.Parse(_minutosInput.text));
    }


    public void AddHoras()
    {
        if (int.Parse(_horasInput.text) < 24)
        {
            _horasInput.text = (int.Parse(_horasInput.text) + 1).ToString();
        }
    }

    public void SubHoras()
    {
        if (int.Parse(_horasInput.text) > 0)
        {
            _horasInput.text = (int.Parse(_horasInput.text) - 1).ToString();
        }
    }

    public void AddMinutos()
    {
        if (int.Parse(_minutosInput.text) < 60)
        {
            _minutosInput.text = (int.Parse(_minutosInput.text) + 1).ToString();
        }
        else
        {
            _minutosInput.text = 0.ToString();
            _horasInput.text = (int.Parse(_horasInput.text) + 1).ToString();
        }
    }

    public void SubMinutos()
    {
        if (int.Parse(_minutosInput.text) > 0)
        {
            _minutosInput.text = (int.Parse(_minutosInput.text) - 1).ToString();
        }
        else if (int.Parse(_horasInput.text) > 0)
        {
            _minutosInput.text = 60.ToString();
            _horasInput.text = (int.Parse(_horasInput.text) - 1).ToString();
        }
    }
    
    //tem que ver no caso de inserir por teclado 

}
