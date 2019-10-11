namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var blackBoxIntType = typeof(BlackBoxInteger);

            var blackBoxConstructor = blackBoxIntType.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);

            var blackBoxInstance = blackBoxConstructor.Invoke(null);

            var blackBoxMethods = blackBoxIntType
                .GetMethods
                (
                    BindingFlags.Instance | BindingFlags.NonPublic
                );

            FieldInfo innerValueField = blackBoxIntType
                .GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);

            string userCommand = Console.ReadLine();

            while (userCommand != "END")
            {
                string[] commandArguments = userCommand.Split("_");

                string methodToCallName = commandArguments[0];
                int commandArgument = int.Parse(commandArguments[1]);

                MethodInfo methodToCall = blackBoxMethods
                    .FirstOrDefault(m => m.Name == methodToCallName);

                methodToCall.Invoke(blackBoxInstance, new object[] { commandArgument });

                int innerValue = (int)innerValueField.GetValue(blackBoxInstance);

                Console.WriteLine(innerValue);

                userCommand = Console.ReadLine();
            }
        }
    }
}
