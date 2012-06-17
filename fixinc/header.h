#pragma once
#include "stdafx.h"
#include "file.h"

namespace fixinc {

class Header : public File {
public:
    Header(boost::filesystem::path filePath) : File(filePath) {
    }
};

}