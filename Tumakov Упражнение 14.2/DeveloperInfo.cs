using System;

namespace Tumakov_Упражнение_14._2
{
    class DeveloperInfo : Attribute
    {
        public string DeveloperName { get; set; }
        public DateTime Date { get; set; }

        public DeveloperInfo(string developer_name, string date)
        {
            DeveloperName = developer_name;
            Date = DateTime.Parse(date);
        }
    }
}
