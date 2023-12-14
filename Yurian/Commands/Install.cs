namespace Yurian.Commands;

public class Install : ICommand
{
    public bool Execute(string[] args)
    {
        var installablePackages = args.Where(RepositoryManager.ExistsPackage).ToList();
        //TODO: このあとの処理を実装

        return true;
    }

    public string GetHelp()
    {
        return "Install package(s).";
    }
}