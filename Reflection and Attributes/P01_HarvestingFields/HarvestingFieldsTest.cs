 namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var fieldsType = typeof(HarvestingFieldsTest)
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == "HarvestingFields");

            string userCommand = Console.ReadLine();

            while (userCommand != "HARVEST")
            {
                switch (userCommand)
                {
                    case "all":
                        var allFields = fieldsType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

                        PrintFields(allFields);
                        break;

                    case "private":
                        var privateFields = fieldsType
                            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                            .Where(f => f.Attributes.ToString().ToLower() == userCommand);

                        PrintFields(privateFields);
                        break;

                    case "protected":
                        var protectedFields = fieldsType
                            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                            .Where(f => f.IsFamily);

                        PrintFields(protectedFields);
                        break;

                    case "public":
                        var publicFields = fieldsType
                            .GetFields()
                            .Where(f => f.IsPublic);

                        PrintFields(publicFields);
                        break;
                }

                userCommand = Console.ReadLine();
            }
        }

        private static void PrintFields(IEnumerable<FieldInfo> privateFields)
        {
            foreach (var field in privateFields)
            {
                string attribute = field.Attributes.ToString().ToLower();

                if (attribute == "family")
                {
                    attribute = "protected";
                }

                string fieldType = field.FieldType.Name;
                string fieldName = field.Name;

                Console.WriteLine($"{attribute} {fieldType} {fieldName}");
            }
        }
    }
}
