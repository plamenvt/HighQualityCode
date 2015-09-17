# Structural patterns
---
### Composite/Композиция
---
+ Позволява комбинирането на различни по тип обекти в дървовидни структури
+ Дава възможност индивидуални обекти или групи от обекти да бъдат третирани еднакво

 Шаблонът Композиция позволява да бъде създадена дървовидна структура, всеки елемент от която може да бъде накаран да изпълни дадена задача. Типичен пример е организационната схема на дадена компания, в която изпълнителният директор е на върха, под него има различни нива на мениджмънт, а най-отдолу са обикновените работници. Композицията позволява всеки елемент от веригата да може да извърши сходна операция.
 ### Клас диаграма
 ![alt text](https://camo.githubusercontent.com/4fd2f665b948b4af13da1ed14e5d25c037c23c11/687474703a2f2f7777772e6465766c616b652e636f6d2f64657369676e2d7061747465726e732f636f6d706f736974652f636f6d706f73697465312e706e67 "Клас диаграма")

Компоненти:

1. IComponent: Този интерфейс или абстрактен клас дефинира методите, които трябва да изпълняват както Leaf, така и Composite класовете. Методът Operation() е общ и може да бъде имплементиран от всички елементи в дървото.
2. Leaf: Елементите от този тип не могат да имат други елементи под себе си съдържат единствено имплементация на общия Operation() метод.
3. Composite: Елементите от този тип могат да имат 0 или повече елементи под себе си. Методите, които поддържа са следните:
 + AddComponent: Добавя нов елемент под дадения
+ GetChild: Връща всички елементи под дадения
+ Operation: Конкретната имплементация на общия за всички елементи метод
+ RemoveComponent: Премахва елемент от тези, които са под дадения

Примерен код:

```
class Program
{
    static void Main()
    {
        Worker worker = new Worker("Worker Pesho", 500);
        Manager firstManager = new Manager("Boss Gosho", 200);
        Manager secondManager = new Manager("Boss Bai Ivan", 5);
        Manager thirdManager = new Manager("Kaka Mara", 120);
        Worker secondWorker = new Worker("Worker Gruyo", 600);

        //set up the relationships
        firstManager.AddSubordinate(worker); //Pesho works for Gosho
        secondManager.AddSubordinate(firstManager); //Gosho works for Bai Ivan
        secondManager.AddSubordinate(thirdManager); //Kaka Mara works for Bai Ivan
        thirdManager.AddSubordinate(secondWorker); //Gruyo works for Kaka Mara

        //Bai Ivan writes some code and asks everyone else to do the same
        if (secondManager is IEmployee)
        {
            (secondManager as IEmployee).WriteSomeCode();
        }
    }
}

public interface IEmployee
{
    void WriteSomeCode();
}

public class Worker : IEmployee
{
    private string name;
    private int linesOfCodeWritten;

    public Worker(string name, int linesOfCodeWritten)
    {
        this.name = name;
        this.linesOfCodeWritten = linesOfCodeWritten;
    }

    void IEmployee.WriteSomeCode()
    {
        Console.WriteLine(name + " wrote " + linesOfCodeWritten + " lines of code.");
    }
}

public class Manager : IEmployee
{
    private string name;
    private int linesOfCodeWritten;

    private List<IEmployee> subordinate = new List<IEmployee>();

    public Manager(string name, int linesOfCodeWritten)
    {
        this.name = name;
        this.linesOfCodeWritten = linesOfCodeWritten;
    }

    void IEmployee.WriteSomeCode()
    {
        Console.WriteLine(name + " wrote " + linesOfCodeWritten + " lines of code.");
        //show all the subordinate's lines of code
        foreach (IEmployee i in subordinate)
            i.WriteSomeCode();
    }

    public void AddSubordinate(IEmployee employee)
    {
        subordinate.Add(employee);
    }
}
```
My GitHub page: [link](https://github.com/plamenvt/HighQualityCode/tree/master/17.%20Design%20Patterns)