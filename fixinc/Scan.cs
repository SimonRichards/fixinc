using System;
using System.Collections.Generic;
using System.Linq;
using ClangSharp;

namespace FixInc {
    class Scan {

        public Index Index { get; private set; }

        public IList<SourceFile> Sources { get; private set; }

        public IList<HeaderFile> Headers { get; private set; }

        private readonly IEnumerable<TranslationUnit> _sources;
        private readonly object _headerLock = new object();
        private HashSet<string> _parsedHeaders = new HashSet<string>();

        private static HashSet<CursorKind> _breakOn = new HashSet<CursorKind> {
            CursorKind.FunctionDecl
        };

        private Scan(IEnumerable<TranslationUnit> sources) {
            _sources = sources;
            Sources = new List<SourceFile>();
            Headers = new List<HeaderFile>();
            Index = new Index();
        }

        public static void Run(Project project) {
            using (var index = new ClangSharp.Index()) {
                var scan = new Scan(project.Sources.AsParallel().Select(s =>
                    index.CreateTranslationUnit(s,
                        project.PreprocessorDefines.Select(d => "-D" + d).Concat(
                        project.IncludePaths.Select(p => "-I" + p)).ToArray())));
                scan.VisitAll();
                scan.BuildIndex();
            }
        }

        private bool ShouldParseHeader(string path) {
            lock (_headerLock) {
                if (_parsedHeaders.Contains(path)) {
                    return false;
                }
                _parsedHeaders.Add(path);
                return true;
            }
        }

        private void Visit(TranslationUnit tu) {
            var result = new SourceFile();
            tu.Cursor.VisitChildren((cursor, parent) => {
                if (!cursor.Location.IsValid) {
                    return Cursor.ChildVisitResult.Continue;
                }
                if (cursor.IsDeclaration) {
                    Console.WriteLine("Declaration: " + cursor);
                }
                if (cursor.IsDefinition) {
                    Console.WriteLine("Definition: " + cursor);
                }
                return _breakOn.Contains(cursor.Kind) ?
                    Cursor.ChildVisitResult.Break :
                    Cursor.ChildVisitResult.Recurse;
            });
        }

        private void VisitAll() {
            foreach (var tu in _sources) {
                Visit(tu);
                tu.Dispose();
            }
        }

        private void BuildIndex() {
        }
    }
}
