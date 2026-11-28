#include <iostream>
#include <utility>
#include <memory>

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

int main() {
    {
        std::unique_ptr<Base> ptr = std::make_unique<Base>();
        std::cout << "in\n";
    }

    std::cout << "after\n";
    std::cout << "=========================\n";
    {
        // std::unique_ptr<Base> ptr = std::make_unique<Base>();

        // std::unique_ptr<Base> ptr1 = ptr;
    }

    std::cout << "=========================\n";

    {
        std::unique_ptr<Base> ptr = std::make_unique<Base>();
        std::unique_ptr<Base> ptr1 = std::move(ptr);
    }

}