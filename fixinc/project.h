#pragma once
#include "stdafx.h"
#include "header.h"
#include "cpp.h"

namespace fixinc {

class Project {
    std::vector<Header> _headerFiles;
    std::vector<Cpp> _cppFiles;
    std::set<Type> _types;
public:
    Project(const char * directory);
    void describe();
};

}