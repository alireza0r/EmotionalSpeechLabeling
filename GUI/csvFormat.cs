using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace GUI
{
    [Serializable]
    class csvFormat
    {
        //[CsvColumn(Name = "FileName", FieldIndex = 1, OutputFormat = "dd-MM-yyyy HH:mm")]
        //public DateTime FileName { get; set; }

        //[CsvColumn(Name = "FileName", FieldIndex = 1, OutputFormat = "C")]

        [CsvColumn(Name = "FileName", FieldIndex = 1)]
        public string FileName { get; set; }

        [CsvColumn(Name = "StrongEmotion", FieldIndex = 2)]
        public string StrongEmotion { get; set; }

        [CsvColumn(Name = "WeakEmotion", FieldIndex = 3)]
        public string WeakEmotion { get; set; }

        [CsvColumn(Name = "FirstName", FieldIndex = 4)]
        public string FirstName { get; set; }

        [CsvColumn(Name = "LastName", FieldIndex = 5)]
        public string LastName { get; set; }

        [CsvColumn(Name = "Gender", FieldIndex = 6)]
        public string Gender { get; set; }

        [CsvColumn(Name = "Age", FieldIndex = 7)]
        public string Age { get; set; }

        [CsvColumn(Name = "Date", FieldIndex = 8, OutputFormat = "dd-MM-yyyy HH:mm:ss")]
        public DateTime Date { get; set; }
    }
}
