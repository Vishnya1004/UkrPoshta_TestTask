$(document).ready(function () {
    var flagAllMessagesShowed = true;
    $("#showAllMessages").click(function () {
        
        if (flagAllMessagesShowed) {
            $("#messagesView").css("display", "block");
            flagAllMessagesShowed = false;
            $(this).val("HIDE All messages");
            
        }
        else {
            $("#messagesView").css("display", "none");
            flagAllMessagesShowed = true;
            $(this).val("SHOW All messages");
        }  
      
    })

    var flagUserMessagesShowed = true;
    $("#showUserMessangers").click(function () {

        if (flagUserMessagesShowed) {
            $("#userMessagesView").css("display", "block");
            flagUserMessagesShowed = false;
            $(this).val("HIDE users messangers");

        }
        else {
            $("#userMessagesView").css("display", "none");
            flagUserMessagesShowed = true;
            $(this).val("SHOW users messangers");
        }

    })

    $(function () { /* to make sure the script runs after page load */

        $('a.read_more').click(function (event) { /* find all a.read_more elements and bind the following code to them */

            event.preventDefault(); /* prevent the a from changing the url */
            $(this).parents('.item').find('.more_text').show(); /* show the .more_text span */

        });

    });

})