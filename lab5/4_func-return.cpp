#include <iostream>

class Base {
public:
    Base() {
        std::cout << "Base::Base()\n";
    }

    Base(Base &base) {
        std::cout << "Base::Base(const Base &base) copy constructor\n";
    }

    ~Base() {
        std::cout << "Base::~Base()\n";
    }
};

Base func1() {
    std::cout << "func1()\n";

    Base base;

    return base;
}

// Base* func2() {
//     std::cout << "func2()\n";

//     Base base;

//     return &base;
// }

// Base& func3() {
//     std::cout << "func3()\n";

//     Base base;

//     return base;
// }

Base func4() {
    std::cout << "func4()\n";

    Base *base = new Base();

    Base copy = *base;

    return copy;
}

Base* func5() {
    std::cout << "func5()\n";

    Base *base = new Base();

    return base;
}

Base& func6() {
    std::cout << "func6()\n";

    Base *base = new Base();

    return *base;
}

int main() {
    std::cout << "----------------------\n";

    Base base1 = func1();
    std::cout << "----------------------\n";

    // Base *base2 = func2();
    // std::cout << "----------------------\n";

    // Base &base3 = func3();
    // std::cout << "----------------------\n";

    Base base4 = func4();
    std::cout << "----------------------\n";

    Base *base5 = func5();
    std::cout << "----------------------\n";

    Base &base6 = func6();
    std::cout << "----------------------\n";

    delete base5;
    delete &base6;
}