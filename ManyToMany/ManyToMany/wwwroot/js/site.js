const name = document.querySelector(".name")
const adress = document.querySelector(".adress")
const btn = document.querySelector(".myBtn")
const phone = document.querySelector(".phone")

var formData = new FormData();
const handleRequest = (ev) => {
    ev.preventDefault();
    formData.append("Name", name.value)
    formData.append("Adress", adress.value)
    formData.append("Phone", phone.value)
    axios.post("/home/create", formData);
    swal("Good job!", "You clicked the button!", "success");
    
}

btn.addEventListener("click",handleRequest)
