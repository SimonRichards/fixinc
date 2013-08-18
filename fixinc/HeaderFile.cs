using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixInc {
    class HeaderFile {

        public HeaderFile() {
            SymbolsDeclared = new List<Symbol>();
        }

        public readonly IList<Symbol> SymbolsDeclared;
    }
}
