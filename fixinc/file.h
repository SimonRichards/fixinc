#pragma once
#include "stdafx.h"
#include "type.h"

namespace fixinc {

class File {
    boost::filesystem::path _filePath;
    void scanForTypes();
public:
    std::set<Type> FullTypesNeeded;
    std::set<Type> ForwardDecsNeeded;
    File(boost::filesystem::path &filePath);
    void describe() {
        std::cout << _filePath << std::endl;
    }
};

}