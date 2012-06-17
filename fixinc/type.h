#pragma once
#include "stdafx.h"

class File;

namespace fixinc {

struct Type {
    File *DefinedIn;
    std::string QualifiedName;
};

}
