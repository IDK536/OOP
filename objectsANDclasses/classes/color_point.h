#pragma once
#include <iostream>
#include "point.h"


class ColorPoint : public Point {
    public:
        ColorPoint() : Point(0, 0), _color("green") {
            std::cout << "default constructor CollorPoint: x=" << _x << ", y=" << _y << ", collor=" << _color << '\n';

        }
        ColorPoint(std::string collor, int x, int y): _color(collor), Point(x, y) {
            std::cout << "init constructor CollorPoint: x=" << _x << ", y=" << _y << ", collor=" << _color << '\n';
        }
        ColorPoint(ColorPoint &cp) : Point(cp), _color(cp._color) {
            std::cout << "copy constructor CollorPoint: x=" << _x << ", y=" << _y << ", collor=" << _color << '\n';
        }

        std::string getColor() {
            return _color;
        }

        void setCollor(const std::string &c) {
            _color = c;
        }

        void print() {
            std::cout << "color cpoint: " << _color << '\n';
        }

        ~ColorPoint() {
            std::cout << "destructor ColorPoint" <<  '\n';
        }

    private:
        std::string _color;
};