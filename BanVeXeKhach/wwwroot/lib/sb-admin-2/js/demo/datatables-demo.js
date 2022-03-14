// Call the dataTables jQuery plugin
$(document).ready(function() {
    $('#dataTable').DataTable({
        destroy: true,
        order: [[1, "asc"]],
        lengthMenu: [
            [10, 25, 50, 100, 500, 1000, -1],
            [10, 25, 50, 100, 500, 1000, "Tất cả"]
        ],
        "language": {
            "decimal": ",",
            "emptyTable": "Không có dữ liệu",
            "info": "Đang hiển thị mục _START_ đến _END_ trong tổng _TOTAL_ mục",
            "infoEmpty": "Đang hiển thị mục 0 đến 0 trong tổng 0 mục",
            "infoFiltered": "(Được lọc từ _MAX_ mục)",
            "infoPostFix": "",
            "thousands": ".",
            "lengthMenu": "Hiển thị _MENU_ mục",
            "loadingRecords": "Vui lòng đợi...",
            "processing": "Đang xử lý...",
            "search": "Tìm kiếm:",
            "zeroRecords": "Không tìm thấy kết quả",
            "paginate": {
                "first": "Đầu tiên",
                "last": "Cuối cùng",
                "next": "Sau",
                "previous": "Trước"
            },
            "aria": {
                "sortAscending": ": kích hoạt để sắp xếp cột tăng dần",
                "sortDescending": ": kích hoạt để sắp xếp cột giảm dần"
            }
        }
    });
});
