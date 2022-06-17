$(document).ready(function () {
    function a(text_one, text_two) {
        if (text_one.indexOf(text_two) != -1) return true;
    }
    $('Search').keyup(function () {
        var searchText = $('Search').val.toLowerCase();
        $('Search').each(function a() {
            if (!$(this).text.toLowerCase(), searchText){
                $(this).hide;
            }
            else $(this).show();
        })
    });
});
