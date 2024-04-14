**What is an API?**
***

When a user navigates to a specific item for sale on an e-commerce site, the price listed for that item is stored in a database, and when they purchase it, the database will need to be updated with the correct inventory for that item type. In fact, much of what the back-end entails is reading, updating, or deleting information stored in a database.

In order to have consistent ways of interacting with data, a back-end will often include a web API. **API** stands for ***Application Programming Interface*** and can mean a lot of different things, but a web API is a collection of predefined ways of, or rules for, interacting with a web application’s data, often through an HTTP request-response cycle. Unlike the HTTP requests a client makes when a user navigates to a website’s URL, this type of request indicates how it would like to interact with a web application’s data (create new data, read existing data, update existing data, or delete existing data), and it receives some data back as a response.

Let’s walk through the example of making an online purchase again, but this time, we’ll imagine how the application’s web API might be used. When a user presses the button to submit an order, that will trigger a request to send them to a different view of the website, an order confirmation page, but an additional request will be triggered from the front-end, unseen by the user, to the web API so that the database can be updated with the information from the order.

Some web APIs are open to the public. Instagram, for example, has an API that other developers can use to access some of the data Instagram stores. Others are only used by the web application internally— Codecademy, for example, has a web API that employees use to accomplish internal tasks.
