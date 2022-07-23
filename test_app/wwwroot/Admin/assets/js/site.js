showInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            $("#form-modal .modal-body").html(data);
            $("#form-modal .modal-title").html(title);
            $("#form-modal").modal("show");
        }
    })
}
$(document).ready(function () {
    userDatatable();
});
userDatatable = () => {
    $("#customerDatatable").DataTable({
        processing: true,
        serverSide: true,
        filter: true,
        responsive: true,
        paging: true,
        info: true,
        lengthChange: true,
        searching: true,
        ordering: true,
        lengthMenu: [10, 25, 50, 100],
        // dom: 'Blfrtip',
        dom:
            '<"row"<"col-sm-12"<"col-sm-12"B>>>' + '<"row"<"col-sm-12 col-md-6"l>' + '<"col-sm-12 col-md-6"f>>' +
            '<"row"<"col-sm-12"tr>><"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        // buttons: [
        //     { extend: 'copy', className: 'btn btn-primary glyphicon glyphicon-duplicate' },
        //     { extend: 'csv', className: 'btn btn-primary glyphicon glyphicon-list-alt' },
        //     { extend: 'excel', className: 'btn btn-primary glyphicon glyphicon-file' },
        //     { extend: 'pdf', className: 'btn btn-primary glyphicon glyphicon-file' },
        //     { extend: 'print', className: 'btn btn-primary glyphicon glyphicon-print' }
        // ],
        buttons: [
            {
                text: '<i class="bx bx-plus me-sm-2"></i><span class="d-none d-sm-inline-block">Add New Record</span>',
                className: 'dt-button create-new btn btn-primary m-2',
                action: function (e, dt, node, config) {
                    alert('Button activated');
                },
            },
            {
                extend: 'collection',
                className: 'class="dt-button buttons-collection btn btn-label-primary dropdown-toggle me-2"',
                text: 'Export',
                buttons: [
                    {
                    extend: 'copy',
                    className: 'dt-button buttons-print dropdown-item',
                    text: 'Copy',
                    exportOptions: {
                        columns: ':visible'
                    }
                },
              
                {
                    extend: 'pdf',
                    className: 'dt-button buttons-print dropdown-item',
                    text: 'PDF',
                    exportOptions: {
                        columns: ':visible'
                    }
                },
                {
                    extend: 'excel',
                    className: 'dt-button buttons-print dropdown-item',
                    text: 'Excel',
                    exportOptions: {
                        columns: ':visible'
                    }
                },
                {
                    extend: 'csv',
                    className: 'dt-button buttons-print dropdown-item',
                    text: 'CSV',
                    exportOptions: {
                        columns: ':visible'
                    }
                },
                {
                    extend: 'print',
                    className: 'dt-button buttons-print dropdown-item',
                    text: 'Print',
                    exportOptions: {
                        columns: ':visible'
                    }
                }

            
            

                ]
            }

        ],
        ajax: {
            "url": "/Admin/Users/GetUserData",
            "type": "POST",
            "datatype": "json"
        },
        columnDefs: [{
            "targets": [0],
            "visible": true,
            "searchable": true
        }],
        columns: [
            { "data": "id", "name": "Id", "autoWidth": true },
            { "data": "name", "name": "name", "autoWidth": true },

        ]
    });
}

jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                console.log("dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd " + res.isValid + res.html + " dddddddddddddddddddddd");
                if (res.status == "success") {
                    $('#view-all').html(res.html)
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');
                    userDatatable();
                    $('#successToast .successToastTitle').html("إضافة المستخدم");
                    $('#successToast .successToastBody').html("تمت إضافة المستخدم بنجاح");
                    new bootstrap.Toast(document.getElementById('successToast')).show();

                }
                else if (res.status == "validation-error") {
                    $('#form-modal .modal-body').html(res.html);
                }
                else {
                    console.log("Error");
                    $('#view-all').html(res.html)
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');
                    userDatatable();
                    $('#errorToast .errorToastTitle').html("إضافة المستخدم");
                    $('#errorToast .errorToastBody').html("حدث خطأ أثناء إضافة المستخدم");
                    new bootstrap.Toast(document.getElementById('errorToast')).show();
                }
            },
            error: function (err) {
                console.log(err)
            }
        })
        //to prevent default form submit event
        return false;
    } catch (ex) {
        console.log(ex)
    }
}

jQueryAjaxDelete = form => {
    if (confirm('Are you sure to delete this record ?')) {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    $('#view-all').html(res.html);
                },
                error: function (err) {
                    console.log(err)
                }
            })
        } catch (ex) {
            console.log(ex)
        }
    }

    //prevent default form submit event
    return false;
}

