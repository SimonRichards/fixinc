#include "stdafx.h"
#include "project.h"

namespace fixinc {

Project::Project(const char *dir) {
    std::string dirName(dir);
    boost::filesystem::path projectRoot(dirName), dotC(".c"), dotCpp(".cpp"), dotH(".h");
    boost::filesystem::directory_iterator it(projectRoot), eod;
    BOOST_FOREACH(boost::filesystem::path const &file, std::make_pair(it, eod)) {
        if (file.extension() == dotCpp || file.extension() == dotC) {
            _cppFiles.push_back(file);
        } else if (file.extension() == dotH) {
            _headerFiles.push_back(file);
            //_types.insert(
        }
    }
}

void Project::describe() {
    BOOST_FOREACH(Cpp &file, _cppFiles) {
        file.describe();
    }
    BOOST_FOREACH(Header &file, _headerFiles) {
        file.describe();
    }
}

}
