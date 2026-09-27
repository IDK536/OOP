#include <iostream>
#include "classes/point.h"

int main() {
    Point p;
    std::cout << p.getX() << ", " << p.getY() << '\n';

    Point p1(10, 20);
    std::cout << p1.getX() << ", " << p1.getY() << '\n';

    Point p2(p1);
    std::cout << p1.getX() << ", " << p1.getY() << '\n';

}