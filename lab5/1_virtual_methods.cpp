#include <iostream>

class Base {
public:

    Base() {
        std::cout << "Base::Base()" << '\n';
    }

    void unVirtualMethod() {
        std::cout << "Base::unVirtual()" << '\n';
    }

    virtual void virtualMethod() {
        std::cout << "Base::virtualMethod()" << '\n';
    }

    void method() {
        std::cout << "Base::method()" << '\n';
        this->virtualMethod();
        this->unVirtualMethod();
    }

     virtual ~Base() {
        std::cout << "Base::~Base()" << '\n';
    }

};

class Desc: public Base {
    public:
    Desc() {
        std::cout << "Desc::Desc()" << '\n';
    }

    void unVirtualMethod() {
        std::cout << "Desc::unVirtual()" << '\n';
    }
     void  virtualMethod() override {
        std::cout << "Desc::virtualMethod()" << '\n';
    }

    ~Desc() override {
        std::cout << "Desc::~Desc()" << '\n';
    }
};

void check0() {
    std::cout << "-------------------------" << '\n';

    Base bace;
    bace.unVirtualMethod();
    bace.virtualMethod();
}

void check1() {
    std::cout << "-------------------------" << '\n';

    Desc desc;
    desc.unVirtualMethod();
    desc.virtualMethod();
}

void check2() {
    std::cout << "-------------------------" << '\n';


    Base* base = new Desc();
    base->unVirtualMethod();
    base->virtualMethod();

    delete base;
}

void check3() {
    std::cout << "-------------------------" << '\n';

    Desc* desc = new Desc();

    desc->unVirtualMethod();
    desc->virtualMethod();

    delete desc;
}

void check4() {
    std::cout << "-------------------------" << '\n';

    Base* base = new Base();
    base->unVirtualMethod();
    base->virtualMethod();

    delete base;
}

void check5() {
    std::cout << "-------------------------" << '\n';

    Base* base = new Base();
    base->method();

    delete base;
}

int main() {

    // check0();

    // check1();

    check2();

    check3();

    // check4();

    // check5();
}