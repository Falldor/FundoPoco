public class Tarefa
{
    private int id;
    private string tarefa;
    private bool vizualizada;

    public Tarefa(int id, string tarefa)
    {
        this.id = id;
        this.tarefa = tarefa;
        this.vizualizada = false;
    }

    public int getId()
    {
        return this.id;
    }

    public string getTarefa()
    {
        return this.tarefa;
    }

    public bool isVisualizado()
    {
        return this.vizualizada;
    }

    public void SetVisualizado(bool valor)
    {
        this.vizualizada = valor;
    }
}
