
// -------------------------------Js Form Login---------------------------------------
// Style display login
var myBtnLogin=document.getElementById("login");
var myModalLogin=document.getElementById("Modal-login");
var myCloseLogin=document.getElementById("close-login");

myBtnLogin.onclick=function(){
  myModalLogin.style.display="block";
}

myCloseLogin.onclick=function(){
  myModalLogin.style.display="none";
}

// Show pass login
var myEyeLogin=document.getElementById("icon-eye-login");
var myShowPassLogin=document.getElementById("show-pass-login");
myEyeLogin.onclick=function(){
  if(myShowPassLogin.type === "password"){
    myShowPassLogin.type = "text";
    this.classList.remove("fa-eye-slash");
    this.classList.add("fa-eye");
  }
  else{
    myShowPassLogin.type = "password";
    this.classList.remove("fa-eye");
    this.classList.add("fa-eye-slash");
  } 
}

// Form login link to register
var linkToRegister=document.getElementById("form__login-link-to-register");
linkToRegister.onclick=function(){
  myModalLogin.style.display="none";
  myModalRegister.style.display="block";
}

// -----------------------------------Js Form Register---------------------------------------
// Style display register
var myBtnRegister=document.getElementById("register");
var myModalRegister=document.getElementById("Modal-register");
var myCloseRegister=document.getElementById("close-register");

myBtnRegister.onclick=function(){
  myModalRegister.style.display="block";
}

myCloseRegister.onclick=function(){
  myModalRegister.style.display="none";
}
// Show pass register
var myEyeRegister1=document.getElementById("icon-eye-register1");
var myEyeRegister2=document.getElementById("icon-eye-register2");
var myShowPassRegister1=document.getElementById("show-pass-register1");
var myShowPassRegister2=document.getElementById("show-pass-register2");

myEyeRegister1.onclick=function(){
  if(myShowPassRegister1.type === "password"){
    myShowPassRegister1.type = "text";
    this.classList.remove("fa-eye-slash");
    this.classList.add("fa-eye");
  }else{
    myShowPassRegister1.type = "password";
    this.classList.remove("fa-eye");
    this.classList.add("fa-eye-slash");
  }
}

myEyeRegister2.onclick=function(){
  if(myShowPassRegister2.type === "password"){
    myShowPassRegister2.type = "text";
    this.classList.remove("fa-eye-slash");
    this.classList.add("fa-eye");
  }else{
    myShowPassRegister2.type = "password";
    this.classList.remove("fa-eye");
    this.classList.add("fa-eye-slash");
  }
}
// Form register link to login
var linkToLogin=document.getElementById("form__register-link-to-login");
linkToLogin.onclick=function(){
  myModalRegister.style.display="none";
  myModalLogin.style.display="block";
}