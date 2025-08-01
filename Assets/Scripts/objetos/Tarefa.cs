public class Tarefa
{
    private int id;
    private string tarefa;

    public Tarefa(int id, string tarefa)
    {
        this.id = id;
        this.tarefa = tarefa;
    }

    public int getId()
    {
        return this.id;
    }

    public string getTarefa()
    {
        return this.tarefa;
    }
}
