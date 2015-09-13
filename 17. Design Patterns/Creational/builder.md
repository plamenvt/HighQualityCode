# Builder Pattern
2	
3	## ���������
4	
5	 * ����� ��  ��������� �� ������, ��� ����� � ����� ������������������ �� �������������� �� ���������� ���������� �� ������. 
6	 * � ����� ������ ���������� ���������� �� ������� ��������, ����� ������ ���������� ���������������� ��� ����������� ��. 
7	 * ����������� �� ���������� ���������� �� ����������� ���� ������, ����� �� ���������� � ���������. ���� ��������� �� ����� ��������� �� ���������� ��������� �� ������������ �� ���� ����� ����������� �� ������������. 
8	 * ���������� ������ � ����������� �� ����, ����� �������� ������������ ���������� � ������������������ �� ����������� ��. 
9	 * ���� ��������, �� ����� ����� �� ����� �������� ������������� �� ������������� �� ��������� �� ����������, ���� ����� �� ����� � �������� ������������� �� ������������� ��.
10	 
11	
12	## ���
13	
14	 * ��������� �� ������, ��� ����� � ����� ������������������ �� �������������� �� ���������� ���������� �� ������.
15	
16	## ����������
17	
18	* ���� ������ ����� ������ � ���� ������:
19	 
20	 	������ �� ������������ ����. ��������� ���������, ����� �������� ������ ������, ����� �� �� �������� ���������� ����� �� ������. ���������� ������ � �� �������� ������� ������������� �� ������ - ��������, ���(�������, ����� ������������� ����������). ����� ������������, �� ��������� ������������ �� ������ �� ���� �������� �����. ��������� ������ �� ����� ���� ������, ����� �������� ���������� � ��������� ���(���� CarConstructor. ���������� ���� � ����� ������������ �� ��� ���� �������� CarConstructor). �������� �� � ������� ���������, ������ ��� ��������� ��� � �������� ��������� �������� ����� �� �������������� �� ������ �� � ��������� �� ������� �������� Builder ����������, �� � ������ ��� ��������� �� ���� :)
21	    
22	## �������� ��������
23	* �������������� �� HTML ��������
24	
25	## ������������ 
26	
27	```
28	using System;
29	using System.Collections;
30	
31	  public class MainApp
32	  {
33	    public static void Main()
34	    { 
35	      // Create director and builders 
36	      Director director = new Director();
37	
38	      Builder b1 = new ConcreteBuilder1();
39	      Builder b2 = new ConcreteBuilder2();
40	
41	      // Construct two products 
42	      director.Construct(b1);
43	      Product p1 = b1.GetResult();
44	      p1.Show();
45	
46	      director.Construct(b2);
47	      Product p2 = b2.GetResult();
48	      p2.Show();
49	
50	      // Wait for user 
51	      Console.Read();
52	    }
53	  }
54	
55	  // "Director" 
56	  class Director
57	  {
58	    // Builder uses a complex series of steps 
59	    public void Construct(Builder builder)
60	    {
61	      builder.BuildPartA();
62	      builder.BuildPartB();
63	    }
64	  }
65	
66	  // "Builder" 
67	  abstract class Builder
68	  {
69	    public abstract void BuildPartA();
70	    public abstract void BuildPartB();
71	    public abstract Product GetResult();
72	  }
73	
74	  // "ConcreteBuilder1" 
75	  class ConcreteBuilder1 : Builder
76	  {
77	    private Product product = new Product();
78	
79	    public override void BuildPartA()
80	    {
81	      product.Add("PartA");
82	    }
83	
84	    public override void BuildPartB()
85	    {
86	      product.Add("PartB");
87	    }
88	
89	    public override Product GetResult()
90	    {
91	      return product;
92	    }
93	  }
94	
95	  // "ConcreteBuilder2" 
96	  class ConcreteBuilder2 : Builder
97	  {
98	    private Product product = new Product();
99	
100	    public override void BuildPartA()
101	    {
102	      product.Add("PartX");
103	    }
104	
105	    public override void BuildPartB()
106	    {
107	      product.Add("PartY");
108	    }
109	
110	    public override Product GetResult()
111	    {
112	      return product;
113	    }
114	  }
115	
116	  // "Product" 
117	  class Product
118	  {
119	    ArrayList parts = new ArrayList();
120	
121	    public void Add(string part)
122	    {
123	      parts.Add(part);
124	    }
125	
126	    public void Show()
127	    {
128	      Console.WriteLine("\nProduct Parts -------");
129	      foreach (string part in parts)
130	        Console.WriteLine(part);
131	    }
132	  }
133	  ```
134	
135	## �����������
136	* ���� ���� ��������� ����� ������ �� �� ������������ �� ������� 
137	* ��������� ��������� ����� �� ������
138	
139	## ������ ������
140	* Factory method
141	* Abstract Factory
142	
143	## ��������
144	* ������� ������ �����, ����� ��� �� ������������� ������������ �� ������ �� ���� ����������, � ������������ �� �� ��������. � ����� ����, ��� �����, ����� �� ������� ����� ���� ������� ����������� �� �� �������� �� ��������� �� ����� ������, ��������� �� ������ ����������, ������ ����� �� ����. ��-������ �� ���� �� �������� �������� �� ��������� �� ������ � ����� ����, ����� �� ������������.
## UML  ��������
147	
148	![alt text](http://www.apwebco.com/images/Builder.jpg")