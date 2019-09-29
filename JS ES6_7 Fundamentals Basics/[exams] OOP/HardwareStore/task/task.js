function solve() {
	// Your classes
	"use strict";

	function* ID_Generator() {
		let id = 0;
		yield id++;
	}
	let id = ID_Generator();

	let Validator = {
		String(param, maxLength, minLength) {
			if (typeof (param) !== 'string' || param.length < minLength || param.length > maxLength) {
				Error(`${param} is NOT a STRING or Length is outside ${minLength} to ${maxLength}}`);
			}
		},
		Number(param, min, max) {
			//TODO: Simulate overloading/!has/ for min-max
			if (typeof (param) !== 'number' || !(param > 0) || param < min || param > max) {
				Error(`${param} is NOT a NUMBER; NOT positive, non-zero number or outside ${min} to ${max}`)
			}
		}

	}
	class Product {
		constructor(manufacturer, model, price) {
			//autogen
			this._id = id.next().value;
			//validation section

			this._manufacturer = manufacturer;
			this._model = model;
			this._price = price;
		}

		get id() {}
		get manufacturer() {}
		get model() {}
		get price() {}

		getLabel() {
			return `${this} - ${this._manufacturer} ${this._model} - **${this._price}**`;
			//TODO: String.ToUpper() ??
		}
	}

	class SmartPhone extends Product {
		constructor(screenSize, operatingSystem) {
			super();
			//validation section

			this._screenSize = screenSize;
			this._operatingSystem = operatingSystem;
		}

		get screenSize() {}
		get operatingSystem() {}
	}

	class Charger extends Product {
		constructor(outputVoltage, outputCurrent) {
			super();
			//validation section

			this._outputVoltage = outputVoltage;
			this._outputCurrent = outputCurrent;
		}

		get outputVoltage() {}
		get outputCurrent() {}
	}

	class Router extends Product {
		constructor(wifiRange, lanPorts) {
			super();
			//validation section

			this._lanPorts = lanPorts;
			this._wifiRange = wifiRange;
		}

		get lanPorts() {}
		get wifiRange() {}
	}

	class Headphones extends Product {
		constructor(quality, hasMicrophone) {
			super();
			//validation section

			this._quality = quality;
			this._hasMicrophone = hasMicrophone;
		}
	}

	class HardwareStore {
		constructor(name) {
			//validation section

			this._name = name;
		}

		//Properties
		get name() {

		}
		set name() {

		}

		get products() {

		}
		set products() {

		}

		//Methods
		stock(product, quantity) {}
		sell(productID, quantity) {}
		getSold() {}
		//Single Metod?
		search(pattern) {}
		search(options) {}
	}
	return {
		getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
			// returns SmarhPhone instance
		},
		getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
			// returns Charger instance
		},
		getRouter(manufacturer, model, price, wifiRange, lanPorts) {
			// returns Router instance
		},
		getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
			// returns Headphones instance
		},
		getHardwareStore(name) {
			// returns HardwareStore instance
		}
	};
}

// Submit the code above this line in bgcoder.com
module.exports = solve; // DO NOT SUBMIT THIS LINE