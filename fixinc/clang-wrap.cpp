#include "stdafx.h"
#include "clang-wrap.h"

namespace clang_wrap {

TranslationUnit::TranslationUnit(std::string path) {
    _index = clang_createIndex(0, 0);
    _tu = clang_parseTranslationUnit(
        _index, 
        path.c_str(),
        nullptr,
        0,
        nullptr,
        0,
        0);

    clang_
}

TranslationUnit::~TranslationUnit() {
    clang_disposeTranslationUnit(_tu);
    clang_disposeIndex(_index); 
}

}
