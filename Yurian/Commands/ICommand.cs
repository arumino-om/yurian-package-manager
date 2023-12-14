namespace Yurian.Commands;

public interface ICommand
{
    public bool Execute(string[] args);
    public string GetHelp();
}