using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixInc {
    class SourceFile {

        public SourceFile() {
            ExistingHeaders = new List<string>();
            ForwardDeclarations = new List<Symbol>();
            SymbolsUsed = new List<Symbol>();
            IncompleteTypesUsed = new List<Symbol>();
        }

        public readonly IList<string> ExistingHeaders;
        public readonly IList<Symbol> ForwardDeclarations;
        public readonly IList<Symbol> SymbolsUsed;
        public readonly IList<Symbol> IncompleteTypesUsed;
    }
}
