function ready(){
	var addToCartButtons = document.getElementsByClassName("store-item-button");

	for(var i = 0; i < addToCartButtons.length; i++){
		addToCartButtons[i].addEventListener('click', addToCartClicked);
	}
}

function CheckboxFunction(){
			// Get the select-all checkbox{parent}
			var parentCheckBox = document.getElementById('select-all');
			// Get all the checkboxes {select-store-item-class}
			var checkboxes = document.getElementsByClassName('select-store-item');
			//Loop thru all the checkboxes{select-store-item 1 nad
			//mark it to whatever is the value of the parent(select-all)}
			for(var i=0; i < checkboxes.length; i++){
				checkboxes[i].checked = parentCheckBox.checked;
			}
	}

function RemoveSelectedCheckbox(){
	var confirmation = confirm("Are you sure?");

	if(confirmation){
		//Get all the checkboxes select-stor-item1{}

		var checkboxes = document.getElementsByClassName('select-store-item');
		// var price = document.getElementsByClassName('cart-item-price');
		//from all the checkboxes, get only those marked as checked and store it in a variable
		var price = document.getElementsByClassName('cart-item-price');
		var checkedHolder = [];
			var counter = 0;
		for(var i =0; i < checkboxes.length; i++){
			if(checkboxes[i].checked){
				checkedHolder[counter] = checkboxes[i].parentElement.parentElement;
				// PriceHolder[counter] = price[i].parentElement;
				counter++;
			}
		} 


		// Using the variable created, use remove function

		for(var i = 0; i < checkedHolder.length; i++){

			var cartitem = checkedHolder[i].parentElement.parentElement;

			var total_price = document.getElementsByClassName('cart-total-price')[0];
			var price_total = parseFloat(total_price.innerHTML.replace('Php', ''));

			var priceElement = cartitem.getElementsByClassName('cart-item-price')[0];
			var price = parseFloat(priceElement.innerHTML.replace('Php', ''));

			var total = price_total - price;

			document.getElementsByClassName('cart-total-price')[0].innerHTML = "Php" + total + ".00";
			console.log(price);
			checkedHolder[i].remove();
		}
		///////////



		////////////
		document.getElementById('select-all').checked = false;
	}

}



function removeCartitem(event){
	var button = event.target;
	button.parentElement.parentElement.remove();
	updateCartTotalPrice();
	
}

function quantityChanged(event){
	var input = event.target;
	console.log(input.value);

	var cartItem = input.parentElement.parentElement;
	var priceElement = cartItem.getElementsByClassName('cart-item-price-base')[0];
	var price = parseFloat(priceElement.innerHTML.replace('Php', ''));

	var value = (input.value * price);

	cartItem.getElementsByClassName('cart-item-price')[0].innerHTML = "Php " + value;

	updateCartTotalPrice();

}

function updateCartTotalPrice(){
	//get the parent of cart item == cart items

	var cartItems = document.getElementsByClassName('cart-items')[0];
	var cartItemList = cartItems.getElementsByClassName('cart-item');
	
	var total = 0;
	for(var i=0; i < cartItemList.length; i++){
		var priceElement = cartItemList[i].getElementsByClassName('cart-item-price')[0];
		// var quantityElement = cartItemList[i].getElementsByClassName('cart-item-quantity-input')[0];
		var price = parseFloat(priceElement.innerHTML.replace('Php', ''));
		//price * quantity

		total += price;
	}

	console.log(total);
	document.getElementsByClassName('cart-total-price')[0].innerHTML = "Php " + total;
}

function totalPrice(){
	var total = sessionStorage.getItem("cart-total-price");
	var cartTotalPrice = sessionStorage.getItem('cart-total-price');

	document.getElementsByClassName("cart-total-price").innerHTML = "Php" + total; 
}

function updateDetailsS1(){

		var desc = document.getElementsByClassName('danish')[0];

		var movie = document.getElementsByClassName('movieModalDiv')[0];

	movie.getElementsByClassName('movieTitle')[0].innerHTML = desc.getElementsByClassName('movTitle')[0].innerHTML;
	movie.getElementsByClassName('movieDesc')[0].innerHTML = desc.getElementsByClassName('movDesc')[0].innerHTML;

}



function updateDetailsS2(){

		var desc = document.getElementsByClassName('blue')[0];

		var movie = document.getElementsByClassName('movieModalDiv')[0];

	movie.getElementsByClassName('movieTitle')[0].innerHTML = desc.getElementsByClassName('movTitle')[0].innerHTML;
	movie.getElementsByClassName('movieDesc')[0].innerHTML = desc.getElementsByClassName('movDesc')[0].innerHTML;

}

function updateDetailsS3(){

		var desc = document.getElementsByClassName('donut')[0];

		var movie = document.getElementsByClassName('movieModalDiv')[0];

	movie.getElementsByClassName('movieTitle')[0].innerHTML = desc.getElementsByClassName('movTitle')[0].innerHTML;
	movie.getElementsByClassName('movieDesc')[0].innerHTML = desc.getElementsByClassName('movDesc')[0].innerHTML;

}

function updateDetailsS4(){

		var desc = document.getElementsByClassName('sausage')[0];

		var movie = document.getElementsByClassName('movieModalDiv')[0];

	movie.getElementsByClassName('movieTitle')[0].innerHTML = desc.getElementsByClassName('movTitle')[0].innerHTML;
	movie.getElementsByClassName('movieDesc')[0].innerHTML = desc.getElementsByClassName('movDesc')[0].innerHTML;

}

function updateDetailsS5(){

		var desc = document.getElementsByClassName('tuna')[0];

		var movie = document.getElementsByClassName('movieModalDiv')[0];

	movie.getElementsByClassName('movieTitle')[0].innerHTML = desc.getElementsByClassName('movTitle')[0].innerHTML;
	movie.getElementsByClassName('movieDesc')[0].innerHTML = desc.getElementsByClassName('movDesc')[0].innerHTML;

}

function updateDetailsS6(){

		var desc = document.getElementsByClassName('croissant')[0];

		var movie = document.getElementsByClassName('movieModalDiv')[0];

	movie.getElementsByClassName('movieTitle')[0].innerHTML = desc.getElementsByClassName('movTitle')[0].innerHTML;
	movie.getElementsByClassName('movieDesc')[0].innerHTML = desc.getElementsByClassName('movDesc')[0].innerHTML;

}
function disableButoon(title, price, imageSrc){
	var cartItems = document.getElementsByClassName("cart-items")[0];
	//check if the item is alerady existing in the cart items
	var cartItemTitles = cartItems.getElementsByClassName('cart-item-title');

	if(cartItemTitles=cartItems.getElementsByClassName('cart-item-title')){
	document.getElementById('checkout').disabled = false;
	}else{ document.getElementById('checkout').disabled = true;

	}
}

function PurchaseFunction(){
//get the parent that holds all the cart items (cart-item-price)
	var cartItems = document.getElementsByClassName("cart-items")[0];

// get all the cart-items
 var cartItemList = cartItems.getElementsByClassName("cart-item");

 var movieList = [];
//loop thru all the cart-item to get the title and price
 for (var i = 0; i < cartItemList.length; i++) {
		var title = cartItemList[i].getElementsByClassName("cart-item-title")[0].innerHTML;
		var image = cartItemList[i].getElementsByClassName("cart-item-image")[0].src;
		var price = cartItemList[i].getElementsByClassName("cart-item-price")[0].innerHTML;
		var quantity = cartItemList[i].getElementsByClassName("cart-item-quantity-input")[0].value;
		movieList[i] = {titleValue: title, imagevalue: image, priceValue: price, quantityvalue: quantity};
	}

	console.log(movieList);

	sessionStorage.setItem("movieList", JSON.stringify(movieList));

	window.location.href = "orderform.html";

}



function totalPrice(){
	var cartItems = document.getElementsByClassName("cart-items")[0];
 	var cartItemList = cartItems.getElementsByClassName("cart-item");
 	var total = 0;
		for(var i =0; i<cartItemList.length; i++){
 			var price = cartItemList[i].getElementsByClassName("cart-item-price")[0];
 			var price = parseFloat(priceElement.innerHTML.replace('Php', ''));

 			total += price;

			}
	console.log(total);
	document.getElementsByClassName('cart-total-price')[0].innerHTML = "Php " + total;
}


function onLoadItemsRedirectPage(){

	var movieList = JSON.parse(sessionStorage.getItem("movieList"));

	var itemPurchased = document.getElementsByClassName("item-purchased")[0];

	for (var i = 0; i < movieList.length; i++) {

		var title = movieList[i].titleValue;
		var image = movieList[i].imagevalue
		var price = movieList[i].priceValue;
		var quantity = movieList[i].quantityvalue;
		var cartRow = document.createElement('div');
 	cartRow.classList.add('cart-item');
 	cartRow.classList.add('row');

 	var cartRowContents = `<br><div class="col">
				<span class="cart-item-title">${title}</span>
			</div>

			<div class="col">
				<img class="cart-item-image" src="${image}" style="width: 100px; height: 100px;">
			</div>

			<div class="col">
				<span class="cart-item-price">${price}</span>
			</div>

			<div class="col">
				<span class="cart-item-quantity-input">${quantity}</span>
			</div>
			`

		cartRow.innerHTML = cartRowContents;

		//Add event of buttons in cartRow

		itemPurchased.append(cartRow);
	}
}





function addToCartClicked(event){
	// alert("Show")
	var button = event.target;
	var storeItem = button.parentElement.parentElement;
	var title = storeItem.getElementsByClassName("store-item-title")[0].innerHTML;
	var price = storeItem.getElementsByClassName("store-item-price")[0].innerHTML;
	var imageSrc = storeItem.getElementsByClassName("store-item-image")[0].src;
	console.log(title);
	console.log(price);
	console.log(imageSrc);
	addItemToCartItems(title, price, imageSrc);
	updateCartTotalPrice();
}


function addItemToCartItems(title, price, imageSrc){
	//Get the parent of all cart items
	var cartItems = document.getElementsByClassName("cart-items")[0];

	//check if the item is alerady existing in the cart items
	var cartItemTitles = cartItems.getElementsByClassName('cart-item-title');
	for(var i = 0; i < cartItemTitles.length; i++){
		if (cartItemTitles[i].innerHTML == title) {
			alert("This item is already added to cart.")
			return;
		}
	}

	//Create new element -- row cart item
 	var cartRow = document.createElement('div');
 	cartRow.classList.add('cart-item');
 	cartRow.classList.add('row');

 	var cartRowContents = `
 	<div class = "col">
				<input type="checkbox" name="cart-item" value="cart-item">
				<img class="cart-item-image" src="${imageSrc}">
				<span class="cart-item-title">${title}</span>
				</div>
 		
				<div class="col">
				<span class="cart-item-price">${price}</span>
				<span class="cart-item-price-base">${price}</span>

				</div>
				<div class="col cart-item-details">
				<input class="cart-item-quantity-input" type="number" name="" value="1">
				<button class="btn btn-danger">REMOVE</button>
				</div>`

		cartRow.innerHTML = cartRowContents

		//Add event of buttons in cartRow
		cartRow.getElementsByClassName('cart-item-quantity-input')[0].addEventListener('change', quantityChanged);
		cartRow.getElementsByClassName('btn-danger')[0].addEventListener('click', removeCartitem);

		cartItems.append(cartRow);

}


function placeOrderFunction(){

	var details = [];

	var fname = document.getElementById('fname').value;
	var lname = document.getElementById('lname').value;
	var addr = document.getElementById('addr1').value;
	var ship = document.getElementById('ship').innerHTML;
	details = {fnamevalue: fname, lnamevalue: lname, addrvalue: addr, shipvalue: ship};

	console.log(details);

	sessionStorage.setItem("details", JSON.stringify(details));
	window.location.href = "orderconfirm.html";
}

function onLoadRedirectNew(){

	var movieList = JSON.parse(sessionStorage.getItem("movieList"));
	var details = JSON.parse(sessionStorage.getItem("details"));
	var itemPurchased = document.getElementsByClassName("item-purchased")[0];

	var cartRow = document.createElement('div');
 	cartRow.classList.add('cart-item');
 	cartRow.classList.add('row');

	var fname = details.fnamevalue;
	var lname = details.lnamevalue;
	var addr = details.addrvalue;
	var ship = details.shipvalue;


for (var i = 0; i < movieList.length; i++) {

		var title = movieList[i].titleValue;
		var image = movieList[i].imagevalue
		var price = movieList[i].priceValue;
		var quantity = movieList[i].quantityvalue;
	}

 	var cartRowContents = 
 	`	<br>
 		
 		<div class="col">
		<span class="fname">${fname}</span>
		</div>

		 <div class="col">
		<span class="lname">${lname}</span>
		</div>

		 <div class="col">
		<span class="addr">${addr}</span>
		</div>

		<div class="col">
		<span class="addr">${ship}</span>
		</div>
		
		<br><br>

	
		<div class="col">
		<span class="cart-item-title">${title}</span>
		</div>

		<div class="col">
		<img class="cart-item-image" src="${image}" style="width: 100px; height: 100px;">
		</div>
		<div class="col">
		<span class="cart-item-price">${price}</span>
		</div>

		<div class="col">
		<span class="cart-item-quantity-input">${quantity}</span>
		</div>	`


	cartRow.innerHTML = cartRowContents;

		//Add event of buttons in cartRow

		itemPurchased.append(cartRow);
}



function logOutFunction(){
	var confirmation = confirm("You want to Logout?");

	if(confirmation){
		window.location.href = "landing.html";
	}
}

function sameAsUser(){

	var fname = document.getElementById('fname').value = "hotdog";
	var lname = document.getElementById('lname').value = "Cold dog";
	var addr = document.getElementById('addr1').value = "1234 Bahay ng nanay mo St. Manila"
}

function sameAsUser1(){
	var fname = document.getElementById('fname').value = "";
	var lname = document.getElementById('lname').value = "";
	var addr = document.getElementById('addr1').value = "";
}
