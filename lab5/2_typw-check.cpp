#include <iostream>
#include <string>

class Base {
    public:
        Base() {
            std::cout << "Base::Base()" << '\n';
        }
        
        virtual std::string className() {
            return "Base";
        }
        virtual bool isA(std::string className) {
            if (className == "Base") {
                return true;
            }
            return false;
        }

        virtual void virtualMethod() {
            std::cout << "Base::virtualMethod()" << '\n';
        }

        ~Base() {
            std::cout << "Base::~Base()" << '\n';
        }
};

class Desc: public Base {
    public:
        Desc() {
            std::cout << "Desc::Desc()" << '\n';
        }

        std::string className() override {
            return "Desc";
        }
        bool isA(std::string className) override{
            if (className == "Desc") {
                return true;
            }
            return Base::isA(className);
        }

        void virtualMethod() override {
            std::cout << "Desc::virtualMethod()" << '\n';
        }

        ~Desc() {
            std::cout << "Desc::~Desc()" << '\n';
        }
};

void staticCheck() {
    std::cout << "-------------------------" << '\n';

    Base *base = new Base();

    Desc *desc = static_cast<Desc*>(base);

    desc->virtualMethod();

    delete base;
}

void dynamicCheck() {
    std::cout << "-------------------------" << '\n';

    Base *base = new Base();
    // Base *base = new Desc();

    Desc *desc = dynamic_cast<Desc*>(base);

    if (desc == nullptr) {
        std::cout << "dynamic_cast failed" << '\n';
    } else {
        std::cout << "dynamic_cast succeeded" << '\n';
        desc->virtualMethod();
    }

    delete base;
}

void isACheck() {
    std::cout << "-------------------------" << '\n';

    Base *base = new Base();
    Base *base1 = new Desc();
    Desc *desc = new Desc();

    if (base->isA("Base")) {
        std::cout << "base is a Base" << '\n';
    } else {
        std::cout << "base is not a Base" << '\n';
    }

    if (base1->isA("Desc")) {
        std::cout << "base1 is a Desc" << '\n';
        Desc *desc1 = static_cast<Desc*>(base1);
        desc1->virtualMethod();
    } else {
        std::cout << "base1 is not a Desc" << '\n';
    }

    if (desc->isA("Desc")) {
        std::cout << "desc is a Desc" << '\n';
    } else {
        std::cout << "desc is not a Desc" << '\n';
    }

    delete base;
    delete base1;
    delete desc;
}

int main() {
    // staticCheck();

    // dynamicCheck();

    // isACheck();
}
