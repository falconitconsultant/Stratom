(function () {
    window.QuillFunctions = {
        createQuill: function (quillElement) {
            var option = {
                debug: 'info',
                modules: {
                    toolbar: '#toolbar'
                },
                placeholder: 'Type here',
                readOnly: false,
                theme: 'snow'
            };
            new Quill(quillElement, options);
        },
        getQuillContent: function (quillControl) {
            return JSON.stringify(quillControl.__quill.getContent());
        },
        getQuillText: function (quillControl) {
            return quillControl.__quill.getText();
        },
        getQuillHtml: function (quillControl) {
            return quillControl.__quill.root.innerHTML;
        },
        loadQuillContent: function (quillControl, quillContent) {
            content = JSON.parse(quillContent);
            return quillControl.__quill.setContents(content,'api');
        },
    },

})();