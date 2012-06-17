#include "stdafx.h"
#include "project.h"

using namespace fixinc;

int main(int argc, char* argv[]) {
    if (argc != 2) {
        std::cerr << "USAGE: fixinc <project-location>" << std::endl;
    }
    Project project(argv[1]);
    project.describe();
	return 0;
}

