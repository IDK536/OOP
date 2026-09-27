#include <iostream>
#include "classes/point.h"

void checkCopyPoint(Point p) {}

void checkPoint() {
    Point p;
    std::cout << "p: " << p.getX() << ", " << p.getY() << '\n';

    Point p1(10, 20);
    std::cout << "p1: " << p1.getX() << ", " << p1.getY() << '\n';

    Point p2(p1);
    std::cout << "p2: " << p2.getX() << ", " << p2.getY() << '\n';

    p2.set(15, 30);
    std::cout << "p1: " << p1.getX() << ", " << p1.getY() << '\n';
    std::cout << "p2: " << p2.getX() << ", " << p2.getY() << '\n';

    checkCopyPoint(p);
    
    delete p;
    delete p1;
}

int main() {
    checkPoint();

}

