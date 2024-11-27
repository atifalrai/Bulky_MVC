Webform in 2002
        2006 .net mvc
        .netcore


        A controller must have name followed by controller keyword i.e HomeController, BookController, OrderController etc
		For some of the request Modal is not necessary. It will just go to controller and send the data. (modal is not always needed)
		There must be the same name in the view as it is in controller. i.e. in the above example we will have Home, Book and Order views.
		Action inside the controller will return the same view as the action name. that is why we said that view should have the same name as controller. If you want to show different view then we need to write the name of that view in the action method. i.e. following index action will return the privacy view instead of index.
        public IActionResult Index ()
        {
        return View(“Privacy”);
        }

		_Layout is the master page of the application.
		Partial views are the views that are corporates with some main view
		_viewstart file tells that which is the master page of the application.
		_ViewImport we will write the tag helper here and these will be available in all the views.U can say it is a global import file @using statement mentioned here will be used in all the views.
    We may need to create a new class to established a connection with db.
	When ever u want to rigster new u have to do this in program.cs just like we have creaea dbcontextcs and established db connection we have to register that in program.cs and we will add all the serveces to the cotainer
