#pragma once
#include <iostream>

class Point {
    public:
        Point() : _x(0), _y(0) {
            std::cout << "default constructor Point: " << '\n';
        }
        Point(int x, int y) : _x(x), _y(y) {
            std::cout << "init constructor Point: x=" << _x << ", y=" << _y << '\n';
        }
        Point(const Point &p) {
            this->_x = p._x;
            this->_y = p._y;
            std::cout << "copy constructor Point: x=" << _x << ", y=" << _y << '\n';
        }

        int getX() {
            return _x;
        }
        int getY() {
            return _y;
        }
        void set(const int x, const int y) {
            this->_x = x;
            this->_y = y;
        }

        ~Point() {
            std::cout << "destructor: x=" << _x << ", y=" << _y << '\n';
        }

    private:
        int _x;
        int _y;

};