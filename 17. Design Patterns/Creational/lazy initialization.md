  <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1><a id="user-content-lazy-initialization-pattern" class="anchor" href="#lazy-initialization-pattern" aria-hidden="true"><span class="octicon octicon-link"></span></a>Lazy initialization Pattern</h1>

<h2><a id="user-content-Мотивация" class="anchor" href="#Мотивация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Мотивация</h2>

<ul>
<li>В много случаи се достъпват данни или създават обекти, от които или нямаме нужда веднага или никога не използваме. Този проблем се решава с така наречният шаблон за дизайн 'Lazy initialization pattern', който предотвратява излишно използване на ресурси от програмата ни.</li>
</ul>

<h2><a id="user-content-Цел" class="anchor" href="#Цел" aria-hidden="true"><span class="octicon octicon-link"></span></a>Цел</h2>

<ul>
<li>Служи за  използване на данните в момента, в който имаме нужда от тях</li>
</ul>

<h2><a id="user-content-Приложение" class="anchor" href="#Приложение" aria-hidden="true"><span class="octicon octicon-link"></span></a>Приложение</h2>

<ul>
<li>Пример 1:</li>
</ul>

<p>Нека имаме база с данни. В нея имаме таблица, която се грижи за данните на един студент в училище. Студентът има поредица от курсове, учители, домашни, изпити, оценки и т.н. Използвайки 'Entity Framework' ние имаме възможността да работим с класа 'Student' като всеки един обект от този клас ни представлява запис от базата с данни. Какво би станало ако имаме нужда от оценките на студентите. Ще издърпаме висчки данни за всеки един студент и освен оценките му ще имаме и всичката друга ненужна информация, която хем ще заеме излишна памет, хем ще забави преноса на данни заради обема си. Това би било така, ако 'Entity framework' е писан от студенти преди изпит по КПК :D Но тъй като не е, при създаването на навигационни property-та(това са полета, които сочат към други таблици - например 'курсове', 'учители') те са дефинират като 'virtual' такива и дават възможност вътрешно 'EF' да създава 'proxy' класове, които представляват основните класове(Student)и доставят данните само, когато имаме нужда от тях или с други думи, когато напишем 'currentStudent.grades' и активираме 'get'-a на полето.</p>

<h2><a id="user-content-Известни-употреби" class="anchor" href="#Известни-употреби" aria-hidden="true"><span class="octicon octicon-link"></span></a>Известни употреби</h2>

<ul>
<li>Entity Framework</li>
<li>Singleton design pattern</li>
<li>IQueryable интерфейс - позволява филтрацията да се извършва в базата с данни, след което да се материализира в RAM паметта при нуждата от данните(lazy loading)</li>
</ul>

<h2><a id="user-content-Имплментация" class="anchor" href="#Имплментация" aria-hidden="true"><span class="octicon octicon-link"></span></a>Имплментация</h2>

<pre><code>public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    private IEnumerable&lt;Order&gt; _orders;

    public IEnumerable&lt;Order&gt; Orders
    {
        get
        {
            if (_orders == null)
            {
                _orders = OrdersDatabase.GetOrders(CustomerID);
            }
            return _orders;
        }
    }

    // Constructor
    public Customer(int id, string name)
    {
        CustomerID = id;
        Name = name;
    }
} 
</code></pre>

<h2><a id="user-content-Последствия" class="anchor" href="#Последствия" aria-hidden="true"><span class="octicon octicon-link"></span></a>Последствия</h2>

<ul>
<li>Спестява използвани ресурси.</li>
<li>Предотвратява наличието на излишна и ненужна информация</li>
</ul>

<h2><a id="user-content-Сродни-модели" class="anchor" href="#Сродни-модели" aria-hidden="true"><span class="octicon octicon-link"></span></a>Сродни модели</h2>

<ul>
<li>Не мисля, че има</li>
</ul>

<h2><a id="user-content-Проблеми" class="anchor" href="#Проблеми" aria-hidden="true"><span class="octicon octicon-link"></span></a>Проблеми</h2>

<ul>
<li>Неправилното му използване. При достъпът до скромни ресурси, няма нужда излишно да усложняваме кода ни.</li>
</ul>
</article>
  </div>

</div>