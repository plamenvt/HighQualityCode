# Prototype Pattern
2	
3	## ���������
4	
5	 * ����� ��  ��������� �� ���� ��������� ������.
6	 * ������� ��, ������ ����������� �� ��� �����(�����) �������� ����� ������ �������, ���������, ��� �� ���������. 
7	 *  ��� �������, ����� �� ����������� �� ����� �� ���������� �� ����������
8	 
9	## ���
10	
11	 * ������� ���� ������ ���� ������� ���� ��������� ������.
12	
13	## ����������
14	
15	* ������ 1:
16	
17	 ���� ����� ���� '��������' � �������� ����. ����� ���� �������� ��� ����� �� ������� �����, �����, �����, �����, ����� � �.�. �������� ���� ��������� �� ������ '��������'. ������ �� ����� ���� ���� �� ������������ ����� ���� ������� ������ ��� ���������� �� � ����������� �� '��������' � ��-��������� �� �� ��������� � �� �������� ������� ���� ���������.
18	 
19	 * ������ 2:
20	
21	���� ����� ����, � ����� ���� ����� ���� ����, �� ������ �� ������� state-a �� � ��� ���������� ������� �� ������ ��� crash �� ������ �� �� ����� � ���������� �� �������� ���������, ������ � ��������. ���� ���� �� �� �������� � ��������� �� ������ 'game' � ����������� �� � ������� ����.
22	
23	* ������ 3:
24	
25	���� �����, �� ��������� ����������. ��� ��� ����������� �� ��������, �� ������ �� ���� ���� �� ������� ��� ����� ����� ����, ����� �� �������� ����������� �� ������� ���� 'internal' � ��������� �� ����������� ���������� �� ����������� �� ����� ����� �����.
26	
27	
28	
29	## �������� ��������
30	
31	* ��������� �� �������� �����, �� ����� �� �� ������ ����� �� �������� ������(�������� �� ���� � �����)
32	
33	
34	## ������������ 
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
109	## �����������
110	* �������� ���������� �������.
111	* �������� ���������� ����������� �� ���� ������
112	
113	## ������ ������
114	* Factory method
115	* Abstract Factory
116	
117	## ��������
118	
119	* ������������ �� ���� ������ ������� ������ �������, ����� ������ �� ����� �������� �� ���������� ICloneable(��� �������� ��������� � .NET ���������) ��� �� ���� ���� �������� ����� Clone(). � ��������, ������ ���� �� � ���������, ����������� ����� ��-������.
120	* ������ �� �� ������� ��� ��������������� �� ��������, ������ ������� 'MemberwiseClone()'(������ ����� ������ �� ���������� ������) ������ ������������ ��, ����� ���� �� ����������� �� 'shallow copy'.
121	
122	## UML  ��������
123	
124	![alt text](http://www.apwebco.com/images/Prototype.jpg")
