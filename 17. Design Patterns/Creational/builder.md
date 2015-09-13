  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1><a id="user-content-builder-pattern" class="anchor" href="#builder-pattern" aria-hidden="true"><span class="octicon octicon-link"></span></a>Builder Pattern</h1>

<h2><a id="user-content-Мотивация" class="anchor" href="#Мотивация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Мотивация</h2>

<ul>
<li>Служи за  създаване на обекти, при които е важна последователността на инициализиране на различните компоненти на обекта. </li>
<li>В общия случай различните компоненти са взаимно зависими, което налага определена последователност при създаването им. </li>
<li>Създаването на различните компоненти се осъществява чрез методи, които са дефинирани в интерфейс. Това позволява на всеки наследник на съответния интерфейс да имплементира по свой начин създаването на компонентите. </li>
<li>Следващата стъпка е създаването на клас, който определя необходимите компоненти и последователността на създаването им. </li>
<li>Това означава, че както можем да имаме различни имплементации на методологиите за създаване на компоненти, така можем да имаме и различни имплементации за композирането им.</li>
</ul>

<h2><a id="user-content-Цел" class="anchor" href="#Цел" aria-hidden="true"><span class="octicon octicon-link"></span></a>Цел</h2>

<ul>
<li>Създаване на обекти, при които е важна последователността на инициализиране на различните компоненти на обекта.</li>
</ul>

<h2><a id="user-content-Приложение" class="anchor" href="#Приложение" aria-hidden="true"><span class="octicon octicon-link"></span></a>Приложение</h2>

<ul>
<li><p>Нека изясня всико казано с един пример:</p>

<p>Искаме да произвеждаме коли. Създаваме интерфейс, който дефинира всички методи, които ще ни създават съставните части на колата. Следващата стъпка е да създадем класове производители на колите - Мерцедес, БМВ(класове, които имплементират интерфейса). Всеки производител, ще произведе компонентите на колите по свой собствен начин. Съответно накрая ще имаме една машина, която сглобава елементите в определен ред(клас CarConstructor. Евентуално може и всеки производител да има свой собствен CarConstructor). Примерът не е напълно адекватен, защото със сигурност БМВ и Мерцедес използват различни части за конструирането на колите си и съответно ще ползват различни Builder интерфейси, но с учебна цел забравяме за това :)</p></li>
</ul>

<h2><a id="user-content-Известни-употреби" class="anchor" href="#Известни-употреби" aria-hidden="true"><span class="octicon octicon-link"></span></a>Известни употреби</h2>

<ul>
<li>конструирането на HTML докимент</li>
</ul>

<h2><a id="user-content-Имплментация" class="anchor" href="#Имплментация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Имплментация</h2>

<pre><code>using System;
using System.Collections;

  public class MainApp
  {
    public static void Main()
    { 
      // Create director and builders 
      Director director = new Director();

      Builder b1 = new ConcreteBuilder1();
      Builder b2 = new ConcreteBuilder2();

      // Construct two products 
      director.Construct(b1);
      Product p1 = b1.GetResult();
      p1.Show();

      director.Construct(b2);
      Product p2 = b2.GetResult();
      p2.Show();

      // Wait for user 
      Console.Read();
    }
  }

  // "Director" 
  class Director
  {
    // Builder uses a complex series of steps 
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }

  // "Builder" 
  abstract class Builder
  {
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
  }

  // "ConcreteBuilder1" 
  class ConcreteBuilder1 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartA");
    }

    public override void BuildPartB()
    {
      product.Add("PartB");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "ConcreteBuilder2" 
  class ConcreteBuilder2 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartX");
    }

    public override void BuildPartB()
    {
      product.Add("PartY");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "Product" 
  class Product
  {
    ArrayList parts = new ArrayList();

    public void Add(string part)
    {
      parts.Add(part);
    }

    public void Show()
    {
      Console.WriteLine("\nProduct Parts -------");
      foreach (string part in parts)
        Console.WriteLine(part);
    }
  }
</code></pre>

<h2><a id="user-content-Последствия" class="anchor" href="#Последствия" aria-hidden="true"><span class="octicon octicon-link"></span></a>Последствия</h2>

<ul>
<li>Дава ясна представа какво трябва да се имплементира от клиента </li>
<li>Осигурява цялостния модел на обекта</li>
</ul>

<h2><a id="user-content-Сродни-модели" class="anchor" href="#Сродни-модели" aria-hidden="true"><span class="octicon octicon-link"></span></a>Сродни модели</h2>

<ul>
<li>Factory method</li>
<li>Abstract Factory</li>
</ul>

<h2><a id="user-content-Проблеми" class="anchor" href="#Проблеми" aria-hidden="true"><span class="octicon octicon-link"></span></a>Проблеми</h2>

<ul>
<li>Създава сложен обект, който ако не удовлетворява изискванията на повече от един ползватели, е безпредметно да се използва. С други думи, ако кодът, който ни създава обект няма никаква перспектива да се използва за създаване на други обекти, съставени от същите компоненти, нямаме нужда от него. По-просто би било да създадем логиката за създаване на обекта в самия клас, който го представлява.</li>
</ul>

<h2><a id="user-content-uml--диаграма" class="anchor" href="#uml--диаграма" aria-hidden="true"><span class="octicon octicon-link"></span></a>UML  диаграма</h2>

<p><a href="https://camo.githubusercontent.com/3cfc6e533c64a2352cee588021966ab39c686496/687474703a2f2f7777772e6170776562636f2e636f6d2f696d616765732f4275696c6465722e6a7067253232" target="_blank"><img src="https://camo.githubusercontent.com/3cfc6e533c64a2352cee588021966ab39c686496/687474703a2f2f7777772e6170776562636f2e636f6d2f696d616765732f4275696c6465722e6a7067253232" alt="alt text" data-canonical-src="http://www.apwebco.com/images/Builder.jpg%22" style="max-width:100%;"></a></p>
</article>
  </div>

</div>