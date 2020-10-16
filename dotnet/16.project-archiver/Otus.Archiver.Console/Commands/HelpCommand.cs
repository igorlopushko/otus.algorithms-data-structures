using System.Threading.Tasks;
using Otus.Archiver.Console.Base;

namespace Otus.Archiver.Console.Commands
{
    public class HelpCommand : ICommand
    {
        public async Task Execute()
        {
            await Task.Run(() => {
                System.Console.WriteLine();
                System.Console.WriteLine("Use the following pattern \"app --[command] --[options]\"");
                System.Console.WriteLine();
                System.Console.WriteLine("Here are the base commands:");
                System.Console.WriteLine("\t{0, -30}: {1}", $"-{CommandInfo.HelpCommandShortTag}, --{CommandInfo.HelpCommandTag}", CommandInfo.HelpCommandDescription);
                System.Console.WriteLine("\t{0, -30}: {1}", $"-{CommandInfo.ArchiveCommandShortTag}, --{CommandInfo.ArchiveCommandTag}", CommandInfo.ArchiveCommandDescription);
                System.Console.WriteLine("\t{0, -30}: {1}", $"-{CommandInfo.UnArchiveCommandShortTag}, --{CommandInfo.UnArchiveCommandTag}", CommandInfo.UnArchiveCommandDescription);
                System.Console.WriteLine();
                System.Console.WriteLine("Here is the list of options:");
                System.Console.WriteLine("\t{0, -30}: {1}", $"-{CommandInfo.SourceOptionShortTag}, --{CommandInfo.SourceOptionTag} <FILE PATH>", CommandInfo.SourceOptionDescription);
                System.Console.WriteLine("\t{0, -30}: {1}", $"-{CommandInfo.TargetOptionShortTag}, --{CommandInfo.TargetOptionTag} <FILE PATH>", CommandInfo.TargetOptionDescription);
                System.Console.WriteLine("\t{0, -30}: {1}", $"-{CommandInfo.MethodOptionShortTag}, --{CommandInfo.MethodOptionTag} <VALUE>", CommandInfo.MethodOptionDescription);
                System.Console.WriteLine("Here is the list of implemented archive methods:");
                System.Console.WriteLine("\t{0, -30}: Huffman codes.", "[huffman]");
                System.Console.WriteLine("\t{0, -30}: LZW algorithm.", "[lzw]");
                System.Console.WriteLine();
            });
        }
    }
}