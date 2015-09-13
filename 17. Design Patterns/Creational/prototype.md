  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1><a id="user-content-prototype-pattern" class="anchor" href="#prototype-pattern" aria-hidden="true"><span class="octicon octicon-link"></span></a>Prototype Pattern</h1>

<h2><a id="user-content-Мотивация" class="anchor" href="#Мотивация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Мотивация</h2>

<ul>
<li>Служи за  клониране на вече създадени обекти.</li>
<li>Ползват се, когато създаването на нов обект(копие) използва много повече ресурси, отколкото, ако го клонираме. </li>
<li> При класове, които се инстанцират по време на изпълнение на програмата</li>
</ul>

<h2><a id="user-content-Цел" class="anchor" href="#Цел" aria-hidden="true"><span class="octicon octicon-link"></span></a>Цел</h2>

<ul>
<li>Създава нови обекти като клонира вече създадени такива.</li>
</ul>

<h2><a id="user-content-Приложение" class="anchor" href="#Приложение" aria-hidden="true"><span class="octicon octicon-link"></span></a>Приложение</h2>

<ul>
<li><p>Пример 1:</p>

<p>Нека имаме игра 'лабиринт' с различни нива. Всеки един лабиринт има нужда от елемент играч, врата, стена, живот, бонус и т.н. подадени като параметър на обекта 'лабиринт'. Вместо за всяко едно ниво да инстанцираме всеки един елемент наново при подаването му в констуктора ла 'лабиринт' е по-подходящо да ги клонираме и да подаваме копията като параметър.</p>

<ul>
<li>Пример 2:</li>
</ul></li>
</ul>

<p>Нека имаме игра, в която след всяко едно ниво, тя трябва да запомня state-a си и при евентуално умиране на играча или crash на играта да се връща в последното си запазено състояние, вместо в началото. Това може да се постигне с клониране на обекта 'game' и запазването му в накакъв файл.</p>

<ul>
<li>Пример 3:</li>
</ul>

<p>Нека кажем, че създаваме библиотека. Ако при създаването на обектите, не искаме да бъде ясно на клиента как точно става това, можем да направим констуктора на дадения клас 'internal' и съответно да предоставим възможност за клонирането на готов такъв обект.</p>

<h2><a id="user-content-Известни-употреби" class="anchor" href="#Известни-употреби" aria-hidden="true"><span class="octicon octicon-link"></span></a>Известни употреби</h2>

<ul>
<li>клониране на всякакви данни, до които ще ни струва скъпо да достъпим отново(например от база с данни)</li>
</ul>

<h2><a id="user-content-Имплментация" class="anchor" href="#Имплментация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Имплментация</h2>

<pre><code>using System;

namespace PrototypeExample
{
  class MainApp
  {
    static void Main()
    {
      // Create two instances and clone each

      ConcretePrototype1 p1 = new ConcretePrototype1("I");
      ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
      Console.WriteLine("Cloned: {0}", c1.Id);

      ConcretePrototype2 p2 = new ConcretePrototype2("II");
      ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
      Console.WriteLine("Cloned: {0}", c2.Id);

      // Wait for user
      Console.ReadKey();
    }
  }

  abstract class Prototype
  {
    private string _id;

    public Prototype(string id)
    {
      this._id = id;
    }

    // Gets id
    public string Id
    {
      get { return _id; }
    }

    public abstract Prototype Clone();
  }

  class ConcretePrototype1 : Prototype
  {
    public ConcretePrototype1(string id)
      : base(id)
    {
    }

    // Returns a shallow copy
    public override Prototype Clone()
    {
      return (Prototype)this.MemberwiseClone();
    }
  }

  class ConcretePrototype2 : Prototype
  {

    public ConcretePrototype2(string id)
      : base(id)
    {
    }

    // Returns a shallow copy
    public override Prototype Clone()
    {
      return (Prototype)this.MemberwiseClone();
    }
  }
}
</code></pre>

<h2><a id="user-content-Последствия" class="anchor" href="#Последствия" aria-hidden="true"><span class="octicon octicon-link"></span></a>Последствия</h2>

<ul>
<li>Спестява използвани ресурси.</li>
<li>Улеснява значително създаването на нови обекти</li>
</ul>

<h2><a id="user-content-Сродни-модели" class="anchor" href="#Сродни-модели" aria-hidden="true"><span class="octicon octicon-link"></span></a>Сродни модели</h2>

<ul>
<li>Factory method</li>
<li>Abstract Factory</li>
</ul>

<h2><a id="user-content-Проблеми" class="anchor" href="#Проблеми" aria-hidden="true"><span class="octicon octicon-link"></span></a>Проблеми</h2>

<ul>
<li>Използването на този шаблон изисква всички класове, които трябва да бъдат копирани да наследяват ICloneable(ако ползваме вградения в .NET интерфейс) или да имат свой собствен метод Clone(). В случаите, когато това не е изпълнено, клонирането става по-трудно.</li>
<li>Трябва да се внимава при имлементирането на методите, защото методът 'MemberwiseClone()'(когато става въпрос за референтни типове) копира референцията им, което води до създаването на 'shallow copy'.</li>
</ul>

<h2><a id="user-content-uml--диаграма" class="anchor" href="#uml--диаграма" aria-hidden="true"><span class="octicon octicon-link"></span></a>UML  диаграма</h2>

<p><a href="https://camo.githubusercontent.com/f5fdbbf99f0f44dad75dfe081defd1c334210f6e/687474703a2f2f7777772e6170776562636f2e636f6d2f696d616765732f50726f746f747970652e6a7067253232" target="_blank"><img src="https://camo.githubusercontent.com/f5fdbbf99f0f44dad75dfe081defd1c334210f6e/687474703a2f2f7777772e6170776562636f2e636f6d2f696d616765732f50726f746f747970652e6a7067253232" alt="alt text" data-canonical-src="http://www.apwebco.com/images/Prototype.jpg%22" style="max-width:100%;"></a></p>
</article>
  </div>

</div>