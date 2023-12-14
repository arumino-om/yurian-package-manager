void Help()
{
    Console.WriteLine("Yurian Package Manager");
    Console.WriteLine("usage: yurian <COMMAND> [args...]");
    Console.WriteLine("<COMMAND>:");
    Console.WriteLine("  install, uninstall, search, list, add-to-env");
}

if (args.Length == 0)
{
    Help();
    return;
}

switch (args[0])
{
    case "install":
        break;
}