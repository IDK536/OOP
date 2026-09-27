#include <iostream>
#include <Point.h>

class Line {
    public:
        Line() : _p1(nullptr), _p2(nullptr) {
            std::cout << "default constructor Line: " << '\n';
        }
        Line(const Point *p1, const Point *p2) : _p1(p1), _p2(p2) {
            std::cout << "init constructor Line" << '\n';
        }
        Line(const Line &l) {
            this->_p1 = l._p1;
            this->_p2 = l._p2;
            std::cout << "copy constructor Line" << '\n';
        }

        int* getP1() {
            return _p1;
        }

        int* getP2() {
            return _p2;
        }

        void set(const Point *p1, const Point *p2) {
            this->_p1 = p1;
            this->_p2 = p2;
        }

        ~Line(){
            std::cout << "destructor Line" << '\n';
        }
    private:
        Point *_p1;
        Point *_p2;

}