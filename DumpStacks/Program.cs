using var dumpReader = new DumpStacks.DumpReader(Environment.GetCommandLineArgs().First());

if (dumpReader.IsExceptionStream())
    Console.WriteLine("Has Exception Stream");
else
    Console.WriteLine("Does not have Exception Stream");
