<h1>README: Mvc Movie Web App Toutorial</h1>
<br>
This repo includes the code utilized to make a ASP .NET web app using a MVC framework. MVC is an acronym for Model-View-Controller and is a pattern in software design that is used when developing an application's user interfaces, data, and controlling logic.<br>
<br>
<b>Model</b>
: Manages data and business logic 
<br><br>
<b>View</b>
: Handles layout and display 
<br><br>
<b>Controller</b>
: Routes commands to the model and view parts 
<br><br>
See below for a diagram representing the MVC architecture. 
<br><br>

![MCV Diagram](https://www.visual-paradigm.com/servlet/editor-content/guide/uml-unified-modeling-language/what-is-model-view-control-mvc/sites/7/2019/09/model-view-controller.png)

<br><br>
<h3>Passing Data from Controller to View</h3>

The actions of the controller are dictated by the URL. It is from the URL where the inputs are provided to the controller and subsequently passes them to the relevant controller class which then:<br>
<ol>
<li>retrieves the data from a source</li>
<li>determines which view to utilize to format a HTML response to the browser</li>
</ol>
Where the controller connects to the source and, through the encoded logic, determines what view to use, the view template renders the response by providing the HTML reponse. 
<br><br>
Therefore, view templates should <b>not</b>: 
<ul>
<li>Do business logic</li>
<li>Interact with a database directly</li>
</ul><br>
Keeping this clear boundary between the view and the controller wensures that the code is clean, testable, and maintainable. <br>
<br>
<i><h4>Usual Pathway (without model)</h4></i>
URL ->MVC Model Binder -> Controller -> ViewData Dictionary -> View -> HTML

