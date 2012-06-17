#pragma once
#include "stdafx.h"

namespace clang_wrap {

class TranslationUnit {
    CXTranslationUnit _tu;
    CXIndex _index;
public:
    TranslationUnit(std::string path);
    ~TranslationUnit();
};

}