var exam = {
    currentId: 0,
    themeId: 0,
    questionCount: 0,
    position: 0,

    init: function () {
        this.initEventHandlers();
        this.themeId = $("#themeId").val();
        this.questionCount = $("#questionCount").val();
    },

    initEventHandlers: function () {
        var that = this;
        $("#start-exam").on("click", function () {
            that.startExamEvent();
        });
    },

    startExamEvent: function () {
        var that = this;
        if (this.position==this.questionCount) {
            alert("End");
        }
        else {
            $.ajax({
                type: 'GET',
                url: "/Exam/NextQuestion?themeId=" + this.themeId + "&currentId=" + this.currentId,
                dataType: "text",
                contentType: "text/html",

            }).success(function (data, status) {
                $("#question-content").remove();
                $("#question-container").append(data);
                that.currentId = $("#current-question-id").val();
                that.position += 1;
            });
        }
        
    },



};

$(document).ready(function () {
    exam.init();
});