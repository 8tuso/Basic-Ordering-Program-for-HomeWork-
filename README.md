<header>
<H1>BASIC-ORDERING-PROGRAM</H1>
<h6>Made for HomeWork</h6>
</header>
<body>
<form name="about" id="about">
  
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
      Adding Orders : You can type up to <itlac>10</itlac> Orders for each user
    </li>
    <li>
      Fetching Information : Tax, Price, Weight, And adding more of the same Item
    </li>
</ul>
</form>

<form name="start" id="start">

<H3>How to start?</H3>
  <hr>
  <p>This .Net Program need to be run through your <italic>VisualStuido</italic> Runner.
  You should Note that this program has no <b>GUI</b> for the memont, so you will run this
  Code based on the opitions that I have select on the (Main) code.</p>

<p> As first You will be treated this: </p>
<pre>Type (1) For ordering: </pre>

<p>After selecting (1) from your KeyBoard you will be able to conitue throught the program</p>

<pre>Please type your (Name) :
Please type your (Address) :</pre>
</form>

<form name="information" id="information">
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

<p>This project has been made from the UML structer that been given inside the HomeWork to
help the students</p>

<img src="https://i.ibb.co/qCdGDwK/Hw-UMl.png"></img>
</form>

  
</body>
