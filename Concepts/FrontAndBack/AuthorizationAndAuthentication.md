**Authorization and Authentication**
***

Two other concepts we’ll want our server-side logic to handle are authentication and authorization.

***Authentication*** is the process of validating the identity of a user. One technique for authentication is to use logins with usernames and passwords. These credentials need to be securely stored in the back-end on a database and checked upon each visit. Web applications can also use external resources for authentication. You’ve likely logged into a website or application using your Facebook, Google, or Github credentials; that’s also an authentication process.

***Authorization*** controls which users have access to which resources and actions. Certain application views, like the page to edit a social media personal profile, are only accessible to that user. Other activities, like deleting a post, are often similarly restricted.

When building a robust web application back-end, we need to incorporate both authentication (Who is this user? Are they who they claim to be?) and authorization (Who is allowed to do and see what?) into our server-side logic to make sure we’re creating secure, personalized, and dynamic content.
