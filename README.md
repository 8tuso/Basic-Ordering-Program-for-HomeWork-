<header>
<H1>BASIC-ORDERING-PROGRAM</H1>
<h6>Made for HomeWork</h6>
</header>
<body>
<section name="about" id="about">
  
<H3>About</H3>
<hr>
<p>
  This repository is a small program that helps the <b>Customer</b> to navigate into the program 
  for ordering Multipule Items into the customer chart. I've made this Program only using C#, for
  my university HomeWork at "<a href="https://www.aau.edu.jo/en">AAU</a>". 
</p>
What you'll be able to do? <br></br>
<ul>
    <li>
      Create Accont : Name, Address, and you will have by default an Order Number
    </li>
    <li>
      Adding Orders : You can type up to <i>10</i> Orders for each user
    </li>
    <li>
      Fetching Information : Tax, Price, Weight, And adding more of the same Item
    </li>
</ul>
</section>

<section name="start" id="start">

<H3>How to start?</H3>
  <hr>
  <p>This .Net Program need to be run through your <i>VisualStuido</i> Runner.
  You should Note that this program has no <b>GUI</b> for the memont, so you will run this
  Code based on the opitions that I have select on the (Main) code.</p>

<p> As first You will be treated this: </p>
<pre>Type (1) For ordering: </pre>

<p>After selecting (1) from your KeyBoard you will be able to conitue throught the program</p>

<pre>Please type your (Name) :
Please type your (Address) :</pre>
</section>

<section name="information" id="information">
  <H3>Infromation About the Code</H3>
  <hr>
  <p>In this file we use several sits of <b>Class</b>, that uses various approaches with each other
  To be able to run this program and fetch, store, Calcalute data.</p>

<pre>
  class Customer 
  class Order
  class OrderDetail
  class Item
  class Payment
  class Cash : Payment
  class Check : Payment
  class Credit : Payment
</pre>

<P>Inside the program It has two Files One contains the classes of the whole program <code>Ordering.cs</code>, and other one only has the Main functions along with the calls <code>Program.cs</code></P>

<p><i>(This project has been made from the UML structer that been given inside the HomeWork to help the students)</i></p>

<img src="https://i.ibb.co/qCdGDwK/Hw-UMl.png" alt="uml-img" name="uml-img"></img>
</section>

<section name="problems" id="problems">
<h3>Issues may appear?</h3>
  <hr>
<p>This program wasn't intened to be a full stand project, but I wanted to put alot of effort into it.</p>
You May Face :
  <br></br>
<ul>
  <li>
    Wrong Date: the program may create an order in a wrong date
  </li>
  <li>
     filtering Items name : there isn't a fully adaptive techinque to fitler the items names,
    so you can pass any type of (string) into it
  </li>
  <li>
    Multiple Acc : You can't actully add another Acc for the memont in the same run
  </li>
</ul>
  
</section>

<section name="future" id="future">
  <h3>Potential Upadtes</h3>
  <hr>
  <p>
    In the futrue I might be adding <b>(GUI)</b> for this program, and A database for storing 
    users, Items and etc.., along with solving all current issues.
  </p>
</section>

<footer>
  
  <br></br>
  <br></br>
  <h10>thank you :3</h10>
</footer>


  
</body>
