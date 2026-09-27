#include <iostream>

class Point {
    public:
        Point() : _x(0), _y(0) {
            std::cout << "default constructor" << '\n';
        }
        Point(int x, int y) : _x(x), _y(y) {
            std::cout << "init constructor: x=" << _x << ", y=" << _y << '\n';
        }
        Point(const Point& p ) {
            this->_x = p._x;
            this->_y = p._y;
            std::cout << "copy constructor: x=" << _x << ", y=" << _y << '\n';
        }

        int getX() {
            return _x;
        }
        int getY() {
            return _y;
        }

    private:
        int _x;
        int _y;

};