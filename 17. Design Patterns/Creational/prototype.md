# Prototype Pattern
2	
3	## Мотивация
4	
5	 * Служи за  клониране на вече създадени обекти.
6	 * Ползват се, когато създаването на нов обект(копие) използва много повече ресурси, отколкото, ако го клонираме. 
7	 *  При класове, които се инстанцират по време на изпълнение на програмата
8	 
9	## Цел
10	
11	 * Създава нови обекти като клонира вече създадени такива.
12	
13	## Приложение
14	
15	* Пример 1:
16	
17	 Нека имаме игра 'лабиринт' с различни нива. Всеки един лабиринт има нужда от елемент играч, врата, стена, живот, бонус и т.н. подадени като параметър на обекта 'лабиринт'. Вместо за всяко едно ниво да инстанцираме всеки един елемент наново при подаването му в констуктора ла 'лабиринт' е по-подходящо да ги клонираме и да подаваме копията като параметър.
18	 
19	 * Пример 2:
20	
21	Нека имаме игра, в която след всяко едно ниво, тя трябва да запомня state-a си и при евентуално умиране на играча или crash на играта да се връща в последното си запазено състояние, вместо в началото. Това може да се постигне с клониране на обекта 'game' и запазването му в накакъв файл.
22	
23	* Пример 3:
24	
25	Нека кажем, че създаваме библиотека. Ако при създаването на обектите, не искаме да бъде ясно на клиента как точно става това, можем да направим констуктора на дадения клас 'internal' и съответно да предоставим възможност за клонирането на готов такъв обект.
26	
27	
28	
29	## Известни употреби
30	
31	* клониране на всякакви данни, до които ще ни струва скъпо да достъпим отново(например от база с данни)
32	
33	
34	## Имплментация 
35	
36	```
37	using System;
38	 
39	namespace PrototypeExample
40	{
41	  class MainApp
42	  {
43	    static void Main()
44	    {
45	      // Create two instances and clone each
46	 
47	      ConcretePrototype1 p1 = new ConcretePrototype1("I");
48	      ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
49	      Console.WriteLine("Cloned: {0}", c1.Id);
50	 
51	      ConcretePrototype2 p2 = new ConcretePrototype2("II");
52	      ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
53	      Console.WriteLine("Cloned: {0}", c2.Id);
54	 
55	      // Wait for user
56	      Console.ReadKey();
57	    }
58	  }
59	 
60	  abstract class Prototype
61	  {
62	    private string _id;
63	
64	    public Prototype(string id)
65	    {
66	      this._id = id;
67	    }
68	 
69	    // Gets id
70	    public string Id
71	    {
72	      get { return _id; }
73	    }
74	 
75	    public abstract Prototype Clone();
76	  }
77	 
78	  class ConcretePrototype1 : Prototype
79	  {
80	    public ConcretePrototype1(string id)
81	      : base(id)
82	    {
83	    }
84	 
85	    // Returns a shallow copy
86	    public override Prototype Clone()
87	    {
88	      return (Prototype)this.MemberwiseClone();
89	    }
90	  }
91	
92	  class ConcretePrototype2 : Prototype
93	  {
94	  
95	    public ConcretePrototype2(string id)
96	      : base(id)
97	    {
98	    }
99	 
100	    // Returns a shallow copy
101	    public override Prototype Clone()
102	    {
103	      return (Prototype)this.MemberwiseClone();
104	    }
105	  }
106	}
107	  ```
108	
109	## Последствия
110	* Спестява използвани ресурси.
111	* Улеснява значително създаването на нови обекти
112	
113	## Сродни модели
114	* Factory method
115	* Abstract Factory
116	
117	## Проблеми
118	
119	* Използването на този шаблон изисква всички класове, които трябва да бъдат копирани да наследяват ICloneable(ако ползваме вградения в .NET интерфейс) или да имат свой собствен метод Clone(). В случаите, когато това не е изпълнено, клонирането става по-трудно.
120	* Трябва да се внимава при имлементирането на методите, защото методът 'MemberwiseClone()'(когато става въпрос за референтни типове) копира референцията им, което води до създаването на 'shallow copy'.
121	
122	## UML  диаграма
123	
124	![alt text](http://www.apwebco.com/images/Prototype.jpg")
