#include <iostream>
#include "classes/point.h"

void checkCopyPoint(Point p) {}

void checkPoint() {
    std::cout << "\n=============checkPoint============\n\n";

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

    Point *pp1 = new Point();
    std::cout << "pp1: " << pp1->getX() << ", " << pp1->getY() << '\n';

    delete pp1;

    Point *pp2 = new Point(1, 3);
    std::cout << "pp2: " << pp2->getX() << ", " << pp2->getY() << '\n';

    Point *pp3 = new Point(*pp2);
    std::cout << "pp3: " << pp3->getX() << ", " << pp3->getY() << '\n';

    checkCopyPoint(*pp2);

    delete pp2;
    delete pp3;
    std::cout << "end" << '\n';
}

int main() {
    checkPoint();

}

