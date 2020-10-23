//fetch("http://localhost:52270/api/user/signin", {

//    headers: {"Content-type":"aplication/json"}
//  method: "POST", //post posho pravime sighnIn
//  body: JSON.stringify({
//      //mora da se pretvori vo string bidejkji bodito e prima objekt,

//    username: "test1",
//    password: "123456",
//  }),
//})
//  .then()
//  .then()
//  .catch((err) => console.log(err));



// fetch("http://localhost:5000/api/Product/getall", {
//   headers: { "Content-type": "aplication/json" },
//   method: "GET",
// })
//   .then((res) => res.json())
//   .then((data) => console.log(data))
//   .catch((err) => console.log(err));

fetch("https://localhost:5001/api/blog/getAll", {
    headers: { "Content-type": "aplication/json" },
    method: "GET",
  
})
    .then((res) => res.json())
    .then((data) => console.log(data))
    .catch((err) => console.log(err));
