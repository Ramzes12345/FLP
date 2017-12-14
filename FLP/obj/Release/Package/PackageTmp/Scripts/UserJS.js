
function creatOverlay() {
    var docHeight = $(document).height();
    $("<div id='overlay'></div>")
            .appendTo("body")
            .height(docHeight)
            .css({
                'opacity': 0.4,
                'position': 'absolute',
                'top': 0,
                'left': 0,
                'background-color': 'black',
                'width': '100%',
                'z-index': 8000
            });
}

function removeOverlay() {
    $("#overlay").remove();
}

function showModal() {
    $("#ModalDiv").show(); 
    $("#ModalDivsmall").hide();
}

function hideModal() {
    $("#ModalDiv").hide();
    $("#ModalDivsmall").show();
}
function showModalCall() {
    creatOverlay();
    $("#ModalDivCall").show();
}

function hideModalCall() {
    removeOverlay();
    $("#ModalDivCall").hide();
}

function SendMessage() {

    let isValid = ($('#email').val().match(/.+?\@.+/g) || []).length === 1;
    if (!isValid) {
        alert("Enter Valid E-mail");
        retern;
    }
    var phone = $("#phone").val();
    var mail = $("#email").val();
    var text = $("#textSend").val();
    hideModal();
    SendMessageAjax(phone, mail, text, 1);
    alert("Ok");
    $("#textSend").val("");
    $("#phone").val("+380");
    $("#email").val("");
}


function SendMessageCall() {
    let isValid = ($('#emailCall').val().match(/.+?\@.+/g) || []).length === 1;
    if (!isValid) {
        var yy = "ghfghghfh";
        alert("Enter Valid E-mail");
        retern;
    }
    var phone = $("#phoneCall").val();
    var mail = $("#emailCall").val();
    var text = "";
    hideModalCall();
    SendMessageAjax(phone, mail, text, 2);
    alert("Ok");
    $("#phoneCall").val("+380");
    $("#emailCall").val("");
}

function SendMessageAjax(phone, mail, text, type) {

    var serviceURL = '/Materials/AjaxSendMessage';

    $.ajax({
        type: "GET",
        url: serviceURL,
        data: {phone: phone, mail: mail, text: text, type: type},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: successFunc,
        error: function (xhr, textStatus, errorThrown) {
          //  alert('error');
        }
    });

}

function successFunc(data, status) {
   // alert(data);
}
