import { required, confirmed, length, max } from "vee-validate/dist/rules";
import { extend } from "vee-validate";

extend("required", {
    ...required,
    message: "Trường dữ liệu bắt buộc."
});

extend("max", {
    ...max,
    message: 'Số lượng ký tự tối đa cho phép là 50'
});

extend("confirmed", {
    ...confirmed,
    message: "This field confirmation does not match"
});

extend("length", {
    ...length,
    message: "This field must have 2 options"
});

extend("greaterthan", value => {
    if(value <= 0){
        return 'Thứ tự phải lớn hơn 0';
    }
    else{
        return true;
    }
})
