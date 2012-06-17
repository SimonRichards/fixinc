#pragma once
#include "stdafx.h"
#include "file.h"

namespace fixinc {

class Cpp : public File {
public:
    Cpp(boost::filesystem::path filePath) : File(filePath) {
    }
};

}