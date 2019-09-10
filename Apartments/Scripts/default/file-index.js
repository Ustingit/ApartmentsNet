function FileIndex() {
    _this = this;

    this.ajaxFileUpload = "/Aps/Upload";

    this.init = function () {
        $('#UploadImage').fineUploader({
            request: {
                endpoint: _this.ajaxFileUpload
            },
        }).on('error', function (event, id, name, reason) {
            //do something
        })
      .on('complete', function (event, id, name, responseJSON) {
          alert(responseJSON);
      });
    }
}

var fileIndex = null;

$().ready(function () {
    fileIndex = new FileIndex();
    fileIndex.init();
});