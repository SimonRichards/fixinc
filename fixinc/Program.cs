using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixInc {
    class Program {
        static void Main(string[] args) {
            const string projectDir = "C:/code/fixinc/fakeProject/";
            var project = new Project {
                IncludePaths = new string[0],
                PreprocessorDefines = new string[0],
                Sources = new [] { "fake-class.cpp", "fake-main.cpp" }.Select(s => projectDir + s).ToArray()
            };
            Scan.Run(project);
        }
    }
}
