var today = new Date();
(function (today) {
    var days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];

    var months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];

    Date.prototype.getMonthName = function () {
        return months[this.getMonth()];
    };
    Date.prototype.getDayName = function () {
        return days[this.getDay()];
    };

    var output = "[[[Today is ]]]" + today.getDayName();
     var second = "[[[Today is " + today.getDayName()]]];
    console.log(output);
    console.log(second);
    console.log("This will not be translated");
})(today);