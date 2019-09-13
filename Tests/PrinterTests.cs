using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
         public class PrinterTests
         {
                  [Fact]
                  public void CreacionCorrectaDeUnTagConDosParamos()
                  {
                           Printer printer = new Printer();
                           List<string> listaString = new List<string>();
                           listaString.Add("PrimerTag");
                           listaString.Add("SegundoTag");
                           listaString.Add("ClaveAtributo");
                           listaString.Add("ValorAtributo");
                  }
         }
}
