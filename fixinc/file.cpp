#include "stdafx.h"
#include "file.h"
#include "clang-wrap.h"

using namespace clang_wrap;

namespace fixinc {

File::File(boost::filesystem::path &filePath) :
    _filePath(filePath) {
    scanForTypes();
}

void File::scanForTypes() {
    TranslationUnit tu(_filePath.string());
}

}
