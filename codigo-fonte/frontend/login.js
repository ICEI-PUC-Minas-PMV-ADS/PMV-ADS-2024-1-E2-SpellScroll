document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault();

    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    if (email === "user@example.com" && password === "admin") {
    
        window.location.href = "../../index.html";
    } else {

        alert("E-mail ou senha incorretos!");
    }
});