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
$('#btnSubmit').click(function () {
    console.log(tinymce.get('txtDoc').getContent());
});


//Usar estrutura do Texto Pré

function initializeDocExample() {
    //preencher com propriedades do modelo
    let sla = `<h1 style="text-align: center;">Invoice</h1>
<p>&nbsp;</p>
<p>Products:</p>
<table style="border-collapse: collapse; width: 100%;" border="1"><colgroup><col style="width: 11.093%;"><col style="width: 11.093%;"><col style="width: 11.093%;"><col style="width: 11.093%;"><col style="width: 11.093%;"><col style="width: 11.093%;"><col style="width: 11.093%;"><col style="width: 11.093%;"><col style="width: 11.093%;"></colgroup>
<tbody>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
</tbody>
</table>`;
    tinymce.get('txtDoc').setContent(sla);
}