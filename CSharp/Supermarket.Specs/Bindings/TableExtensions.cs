using System;
using TechTalk.SpecFlow;

namespace Supermarket.Specs.Bindings
{
    public static class TableExtensions
    {
        public static void MapValue(this Table table, string column, Func<string, string> mapping)
        {
            foreach (var row in table.Rows)
            {
                row[column] = mapping(row[column]);
            }
        }
    }
}