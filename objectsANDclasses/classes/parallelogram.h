class Parallelogram {
    public:
        Parallelogram(): _p1(new Point(0, 0)), _p2(1, 0), _p3(0, 1), _p4(1, 1) {
            std::cout << "default constructor Parallelogram" << '\n';
        }
        Parallelogram(const Point &p1, const Point &p2, const Point &p3, const Point &p4): _p1(new Point(p1)), _p2(p2), _p3(p3), _p4(p4) {
            std::cout << "init constructor Parallelogram" << '\n';
        }
        Parallelogram(const int x1, const int y1, const int x2, const int y2, const int x3, const int y3, const int x4, const int y4) : _p1(new Point(x1, y1)), _p2(x2, y2), _p3(x3, y3), _p4(x4, y4) {
            std::cout << "all constructor Parallelogram" << '\n';

        }
        Parallelogram(const Parallelogram &p) : _p1(new Point(*(p._p1))), _p2(p._p2), _p3(p._p3), _p4(p._p4) {
            std::cout << "copy constructor Parallelogram" << '\n';
        }


        void set(const Point &p1, const Point &p2, const Point &p3, const Point &p4) {
            _p1 = new Point(p1);
            _p2 = p2;
            _p3 = p3;
            _p4 = p4;
        }

        Point* getP1() {
            return _p1;
        }
        Point getP2() {
            return _p2;
        }
        Point getP3() {
            return _p3;
        }
        Point getP4() {
            return _p4;
        }

        void print() {
            std::cout << "Parallelogram: " << '\n';
                std::cout << "Point 1: x=" << _p1->getX() << ", y=" << _p1->getY() << '\n';
                std::cout << "Point 2: x=" << _p2.getX() << ", y=" << _p2.getY() << '\n';
                std::cout << "Point 3: x=" << _p3.getX() << ", y=" << _p3.getY() << '\n';
                std::cout << "Point 4: x=" << _p4.getX() << ", y=" << _p4.getY() << '\n';
        }

        ~Parallelogram() {
            delete _p1;
            std::cout << "destructor Parallelogram" <<  '\n';
        }
    private:
        Point *_p1;
        Point _p2;
        Point _p3;
        Point _p4;
        

};