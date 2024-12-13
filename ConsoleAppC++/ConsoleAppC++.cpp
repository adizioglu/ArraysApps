#include <iostream>
#include <string>
#include <vector>
#include <sstream>

int main() {
    // 0-based counting - 0,1,2,3,4
    // 1-based counting - 1,2,3,4,5

    // std::vector<std::string> firstNames(5);

    // firstNames[0] = "Tim";
    // firstNames[1] = "Sue";
    // firstNames[2] = "Bob";
    // firstNames[4] = "Jane";

    // std::cout << "The firstNames are " << firstNames[0] << ", " << firstNames[1] << ", " << firstNames[2] << ", " << firstNames[4] << std::endl;

    // firstNames[0] = "Timothy";

    // std::cout << firstNames[0] << std::endl;

    // firstNames[5] = "Robert";

    // single quote identifies a char
    // double quotes identifies a string
    std::string data = "Tim,Sue,Bob,Jane,Frank";
    std::vector<std::string> firstNames;
    std::stringstream ss(data);
    std::string item;

    while (std::getline(ss, item, ',')) {
        firstNames.push_back(item);
    }

    std::cout << firstNames[firstNames.size() - 1] << std::endl;

    std::cout << firstNames.size() << std::endl;

    std::vector<std::string> lastNames = { "Corey", "Smith", "Jones" };

    std::vector<int> ages = { 2, 3, 4 };

    return 0;
}
