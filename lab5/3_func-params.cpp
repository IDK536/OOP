#include <iostream>

class Base {
public:
    Base() {
        std::cout << "Base::Base()" << '\n';
    }

    Base(const Base &base) {
        std::cout << "Base::Base(const Base &other) copy constructor" << '\n';
    }

    Base(const Base *base) {
        std::cout << "Base::Base(const Base *other) pointer constructor" << '\n';
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

    Desc(const Desc &desc) {
        std::cout << "Desc::Desc(const Desc &other) copy constructor" << '\n';
    }

    Desc(const Desc *desc) {
        std::cout << "Desc::Desc(const Desc *other) pointer constructor" << '\n';
    }

    ~Desc() override {
        std::cout << "Desc::~Desc()" << '\n';
    }
};

void func1(Base obj) {
    std::cout << "func1(Base obj)" << '\n';

    Desc *desc = dynamic_cast<Desc*>(&obj);

    if (desc == nullptr) {
        std::cout << "func1::dynamic_cast failed" << '\n';
    } else {
        std::cout << "func1::dynamic_cast succeeded" << '\n';
    }

    
}

void func2(Base *obj) {
    std::cout << "func2(Base *obj)" << '\n';

    Desc *desc = dynamic_cast<Desc*>(obj);

    if (desc == nullptr) {
        std::cout << "func2::dynamic_cast failed" << '\n';
    } else {
        std::cout << "func2::dynamic_cast succeeded" << '\n';
    }

}

void func3(Base &obj) {
    std::cout << "func3(Base &obj)" << '\n';

    Desc *desc = dynamic_cast<Desc*>(&obj);

    if (desc == nullptr) {
        std::cout << "func3::dynamic_cast failed" << '\n';
    } else {
        std::cout << "func3::dynamic_cast succeeded" << '\n';
    }

}

int main() {

    std::cout << "Base:\n\n";

    {
        Base base;
        
        std::cout << "-------------------------" << '\n';

        func1(base);
        std::cout << "-------------------------" << '\n';

        func2(&base);
        std::cout << "-------------------------" << '\n';

        func3(base);

        std::cout << "-------------------------" << '\n';
    }

    std::cout << "\n=========================\n\n";
    std::cout << "Desc:\n\n";

    {
        Desc desc;

        std::cout << "-------------------------" << '\n';

        func1(desc);
        std::cout << "-------------------------" << '\n';

        func2(&desc);
        std::cout << "-------------------------" << '\n';

        func3(desc);

        std::cout << "-------------------------" << '\n';
    }

}