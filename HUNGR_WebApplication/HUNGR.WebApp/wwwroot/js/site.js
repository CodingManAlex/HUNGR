// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function scriptAlert(truckId) {
    alert("Script Alert " + truckId);
}

function getRating(rating) {
    var realRating = rating;
    $("#rateValue").text(realRating);
    $("#reviewRating").val(realRating);
    checkReview();
}



function checkReview() {
    var title = $("#reviewTitle").val();
    var body = $("#reviewBody").val();
    var rating = $("#reviewRating").val();

    console.log(title)
    console.log("Title length : " + title.length)

    console.log(body)
    console.log("Body length : " + body.length)
    console.log(rating)
    if (rating > 0) {
        console.log("Rating Greater")
    } else {
        console.log("Rating Less")
    }



    if (title.length > 0 && body.length > 0 && rating > 0) {
        $("#submitReviewButton").removeAttr("disabled");
        $("#submitReviewButton").removeClass("btn-secondary").addClass("btn-success");


    } else {
        $("#submitReviewButton").attr("disabled", true);
        $("#submitReviewButton").removeClass("btn-success").addClass("btn-secondary");
    }
}

/**
 * Submits the review to the Controller via Ajax
 * @param {any} truckId the foodTrucksId
 * @param {any} userId the id of the user making the review.
 */
function submitReview(truckId,userId, userPic) {
    var title = $("#reviewTitle").val();
    var body = $("#reviewBody").val();
    var rating = $("#reviewRating").val();

    console.log("truckId : " + truckId)
    console.log("userId : " + userId)
    console.log("title : " + title)
    console.log("body : " + body)
    console.log("rating : " + rating)
    console.log("Pic : " + userPic)

    



    //$("#trucksReviews").prepend("<li class=\"border my-1\" style=\"list-style-type: none;\">" +
    //    "<div class=\"d-flex flex-row d-flex align-items-center\">" +
    //    "<div class=\"align-self-center pl-2\">" +
    //    "<h3>" + title + "</h3>" +
    //    "</div>" +
    //    "<div class=\" align-self-center pl-2\">" + ratingSymbol + "</div>" +
    //    "</div>" +
    //    "<hr />" +

    //    "<div class=\"row\">" +
    //    "<div class=\"col offset-1\">" +
    //    "<p>" + body + "</p>" +
    //    "</div>" +
    //    "</div></li >");




    $.ajax({
        type: "POST",
        url: "/Reviews/CreateReviewAjax",
        data: {
            userId: userId,
            foodTruckId: truckId,
            reviewTitle: title,
            reviewBody: body,
            reviewRating: rating,
            userProfilePic: userPic
        },
        dataType: "json",
        success: function (data) {
            //For the Stars
            var ratingSymbol = "";
            for (i = 1; i < 6; i++) {
                if (i <= rating) {
                    ratingSymbol += "<i class=\"fa fa-star fa-2x\" style=\"color: #ffca08;\" aria-hidden=\"true\"></i> ";
                } else {
                    ratingSymbol += "<i class=\"fa fa-star fa-2x\"></i> ";
                }
            }
            console.log(userPic);
            console.log(data.userProfilePic);

            $("#trucksReviews").prepend("<li class=\"border my-1\" style=\"list-style-type: none;\">" +
                "<div class=\"d-flex flex-row d-flex align-items-center\">" +
                "<div class=\"col-1\">" +
                "<a asp-action=\"UserProfile\" asp-controller=\"User\" asp-route-UserId=\"" + userId + "\">" +
                "<img src=\"" + userPic +"\" class=\"img-thumbnail\" alt=\"ProfileImage\" asp-append-version=\"true\">"+
                "</a>" +
                "</div>"+
                "<div class=\"align-self-center pl-2\">" +
                "<h3>" + data.title + "</h3>" +
                "</div>" +
                "<div class=\" align-self-center pl-2\">" + ratingSymbol + "</div>" +
                "</div>" +
                "<hr />" +

                "<div class=\"row\">" +
                "<div class=\"col offset-1\">" +
                "<p>" + data.body + "</p>" +
                "</div>" +
                "</div></li >");

            resetReviewForm();
            //alert("Submission Success!")
            //$("#trucksReviews").prepend("<li class=\"border my-1\" style=\"list-style-type: none; \">< div class=\"row\" ><div class=\"col-1\"><a asp-action=\"UserProfile\" asp-controller=\"User\" asp-route-UserId="+data.userId+"><img src=\"@reviewPhotoPath\" class=\"img-thumbnail\" alt=\"ProfileImage\" asp-append-version=\"true\"></a></div><div class=\"col-11 align-self-center\"><h3>"+data.title+"</h3></div></div><div class=\"row\"><div class=\"col offset-1\"><p>"+data.title+"</p></div></div><div class=\"row\"><div class=\"col offset-1\"><p>Rating: "+data.title+"</p></div></div></li >");
        },
        failure: function () {
            alert("Something happened with the review. Please try again!")
        },
        error: function (response) {
            
        }
    });
}

function resetReviewForm() {
    $("#reviewTitle").val("");
    $("#reviewBody").val("");
    $("#reviewRating").val("");
    $("input:radio").prop("checked", false);
    $("#submitReviewButton").attr("disabled", true);
    $("#submitReviewButton").removeClass("btn-success").addClass("btn-secondary");
}

function filterEvents() {
    var filterTerm = $("#filterBar").val();
    console.log(filterTerm)
    var names = $("h2").toArray();

    var str = "";
    var parentTag = $(".card");
    $('h2').each(function () {

        if ($(this).text().toLowerCase().includes(filterTerm.toLowerCase())) {
            $(this).parent(parentTag).parent().show()
        } else {
            $(this).parent(parentTag).parent().hide()
        }
    })

};