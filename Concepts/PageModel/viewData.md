**ViewData**
***
***Profile.cshtml.cs***

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
  public class ProfileModel : PageModel
  {
    public void OnGet()
    {
      ViewData["myName"] = "Arif Iqbal";
      ViewData["username"] = "Aiqbal";
      ViewData["myOccupation"] = "Full-stack Developer";
      ViewData["myAge"] = 49;
      ViewData["currentDate"] = "04/14/24";
    }
  }
}
```

***Profile.cshtml***
***
```
﻿@page
@model MyApp.Namespace.ProfileModel
@{
}

<div class="container">
	<div class="row">
		<div class="col-12">
			<div class="card">
				<div class="card-body">
					<div class="card-title mb-4">
						<div class="d-flex justify-content-start">
							<div class="image-container">
								<img src="http://placehold.it/150x150" id="imgProfile" style="width: 150px; height: 150px" class="img-thumbnail" />
							</div>
							<div class="userData ml-3">
								<h2 class="d-block" style="font-size: 1.5rem; font-weight: bold">
                @ViewData["username"]
                </h2>
							</div>
						</div>
					</div>

					<div class="row">
					  <div class="col-12">
						  <ul class="nav nav-tabs mb-4" id="myTab" role="tablist">
							  <li class="nav-item">
									<a class="nav-link active" href="#">Basic Info</a>
								</li>
							</ul>
              
						  <div class="tab-content ml-1" id="myTabContent">
							  <div class="tab-pane fade show active" id="basicInfo" aria-labelledby="basicInfo-tab">
									<div class="row">
										<div class="col-sm-3 col-md-2 col-5">
											<label style="font-weight:bold;">Full Name</label>
										</div>
                    <div class="col-md-8 col-6">
                       @ViewData["myName"]

                    </div>
									</div>
									<hr />

                  <div class="row">
                    <div class="col-sm-3 col-md-2 col-5">
                      <label style="font-weight:bold;">Age</label>
                    </div>
                    <div class="col-md-8 col-6">
                          @ViewData["myAge"]
                      
                    </div>
                  </div>
									<hr />

                  <div class="row">
                      <div class="col-sm-3 col-md-2 col-5">
                          <label style="font-weight:bold;">Occupation</label>
                      </div>
                      <div class="col-md-8 col-6">
                        @ViewData["myOccupation"]

                      </div>
                  </div>
                  <hr />
                  
                  <div class="row">
                    <div class="col-sm-3 col-md-2 col-5">
                      <label style="font-weight:bold;">Current Date</label>
                    </div>
                      <div class="col-md-8 col-6">
                        @ViewData["currentDate"]

                      </div>
                  </div>
                <hr/>
							</div>
						</div>
					</div>
				</div>
			</div>
    </div>
  </div>
</div>
```