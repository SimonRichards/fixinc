#include "stdafx.h"
#include "type.h"

namespace fixinc {

bool operator== (Type &left, Type &right) {
    return left.QualifiedName == right.QualifiedName;
}

}
