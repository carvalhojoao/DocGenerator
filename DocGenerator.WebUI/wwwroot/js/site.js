$(document).ready(function () {
    const useDarkMode = window.matchMedia('(prefers-color-scheme: dark)').matches;

    tinymce.init({
        selector: '#txtDoc',
        //language: 'pt_BR',
        width: '100%',
        height: 800,
        plugins: [
            'advlist', 'autolink', 'link', 'image', 'lists', 'charmap', 'preview', 'anchor', 'pagebreak',
            'searchreplace', 'wordcount', 'visualblocks', 'code', 'fullscreen', 'insertdatetime', 'media',
            'table', 'emoticons', 'template', 'codesample', 'quickbars'
        ],
        toolbar: 'undo redo | blocks fontfamily fontsize | bold italic underline | forecolor backcolor | align numlist bullist | outdent indent lineheight | table media | ' +
            'code emoticons | print preview fullscreen ',
        quickbars_selection_toolbar: 'bold italic underline | quicklink blockquote ',
        menubar: 'favs file edit view insert format tools table',
        toolbar_mode: 'sliding',
        skin: useDarkMode ? 'oxide-dark' : 'oxide',
        content_css: 'default',
        content_style: 'body{font-family:Helvetica,Arial,sans-serif; font-size:16px}',
        setup: function (editor) {
            editor.on('init', initializeDocExample);
        }
    });

    initializeDocExample();
});

$('#btnPrint').click(function () {
    let text = tinymce.get('txtDoc').getContent();
    $.post('/Home/PrintDocument', { text }, function (data) {
        $('#printDoc').html(data);
    });
});


//Usar estrutura do Texto Pré

function initializeDocExample() {
    //preencher com propriedades do modelo
    let sla = `<h1 style="text-align: center;">Invoice&nbsp;</h1>
<p style="text-align: left;">DocGenerator, Inc.</p>
<p style="text-align: left;">12345 Sunny Road</p>
<p style="text-align: left;">Sunnyville, TX 3245</p>
<p style="text-align: left;">&nbsp;</p>
<p style="text-align: left;">{ClientName} {ClientDocument}</p>
<p style="text-align: left;">{ClientAdress}</p>
<p>&nbsp;</p>
<p>Items:</p>
<p>{ItemsList}</p>`;
    tinymce.get('txtDoc').setContent(sla);
}