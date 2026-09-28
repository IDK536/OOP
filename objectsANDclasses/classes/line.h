#pragma once

#include <iostream>
#include "point.h"

class Line {
    public:
        Line() : _p1(nullptr), _p2(nullptr) {
            std::cout << "default constructor Line: " << '\n';
        }
        Line(Point *p1, Point *p2) : _p1(p1), _p2(p2) {
            std::cout << "init constructor Line" << '\n';
        }
        Line(Line &l) {
            this->_p1 = l._p1;
            this->_p2 = l._p2;
            std::cout << "copy constructor Line" << '\n';
        }

        Point* getP1() {
            return _p1;
        }

        Point* getP2() {
            return _p2;
        }

        void set(Point *p1, Point *p2) {
            this->_p1 = p1;
            this->_p2 = p2;
        }

        void print() {
            std::cout << "Line: " << _p1->getX() << " " << _p1->getY() << ", " << _p2->getX() << " " << _p2->getY() << '\n';
        }

        ~Line(){
            std::cout << "destructor Line" << '\n';
        }

    private:
        Point *_p1;
        Point *_p2;

};