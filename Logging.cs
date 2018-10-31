using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 
namespace Logtest.Log
{
    class Logging
    {
        // Variables



        public Logging(string log) {


            // do smth

            // csv helper, read whole file into an enumerable, with list
            var csv = new CsvReader(textReader);
            var records = csv.GetRecords<MyClass>().ToList();


        }




    }
}
