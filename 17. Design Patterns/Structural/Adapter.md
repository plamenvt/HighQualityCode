# Structural patterns
---
### Adapter/Адаптор
---
+ Преобразува интерфейса на даден клас, така че да може да бъде използван от клиента.
+ Позволява на класове с несъвместими интерфейси да работят заедно.

 Използването на адаптор се налага при наличието на несъвместими интерфейси. Клиентът иска да извика даден метод, но не може, защото интефейсът, който могат да ползват обектите на клиента не е наличен в кода, чийто методи искаме да извикаме. В зависимост от употребата на адаптера, шаблонът е наричан още wrapper и translator.
 ### Клас диаграма
 ![alt text](https://camo.githubusercontent.com/b7b35baa96b1e85cbab12e1d429faa064704eb13/687474703a2f2f7777772e646f666163746f72792e636f6d2f696d616765732f6469616772616d732f6e65742f616461707465722e676966 "Клас диаграма")

Компоненти:

+ **Target**: Дефинира специфичния интерфейс, който клиентът използва.
+ **Adapter**: Приспособява интерфейса Adaptee към интерфейса Target.
+ **Adaptee**: Дефинира съществуващ интерфейс, който се нуждае от адаптиране.
+ **Client**: Работи с обекти, подчиняващи се на интерфейса Target.

Примерен код:

```
using System;

namespace Adapter
{
  class MainApp
  {
    static void Main()
    {
      // Create adapter and place a request
      Target target = new Adapter();
      target.Request();

      // Wait for user
      Console.ReadKey();
    }
  }

  class Target
  {
    public virtual void Request()
    {
      Console.WriteLine("Called Target Request()");
    }
  }

  class Adapter : Target
  {
    private Adaptee _adaptee = new Adaptee();

    public override void Request()
    {
      // Possibly do some other work
      //  and then call SpecificRequest
      _adaptee.SpecificRequest();
    }
  }

  class Adaptee
  {
    public void SpecificRequest()
    {
      Console.WriteLine("Called SpecificRequest()");
    }
  }
}
```
My GitHub page: [link](https://github.com/plamenvt/HighQualityCode/tree/master/17.%20Design%20Patterns)