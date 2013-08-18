using System;
using System.Collections.Generic;

namespace FixInc {
    class Project {

        public IList<string> PreprocessorDefines { get; set; }

        public IList<string> IncludePaths { get; set; }

        public IList<string> Sources { get; set; }
    }
}
