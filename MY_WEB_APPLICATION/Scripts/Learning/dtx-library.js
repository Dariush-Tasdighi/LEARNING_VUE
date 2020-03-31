Vue.component(`dtx-header`, {

	props: [`message`],

	template:
		`<h3>
			{{ message }}
		</h3>`,

})

Vue.component(`dtx-list-index`, {

	props: [`text`],

	template:
		`<li>{{ text }}</li>`,

})

Vue.component(`dtx-error-messages`, {

	props: [`result`],

	template:
		`<div class="alert alert-danger" v-if="result?.errorMessages?.length > 0">
			<ul>
				<dtx-list-index v-for="(item, index) in result.errorMessages" v-bind:key="index" v-bind:text="item"></dtx-list-index>
			</ul>
		</div>`,

})

Vue.component(`dtx-information-messages`, {

	props: [`result`],

	template:
		`<div class="alert alert-info" v-if="result?.informationMessages?.length > 0">
			<ul>
				<dtx-list-index v-for="(item, index) in result.informationMessages" v-bind:key="index" v-bind:text="item"></dtx-list-index>
			</ul>
		</div>`,

})

Vue.component(`dtx-modal`, {

	template:
		`<div id="loadingModal" class="modal" tabindex="-1" role="dialog">
			<div class="modal-dialog" role="document">
				<div class="modal-content">
					<div class="modal-header">
						<h5 class="modal-title">
							Loading...
						</h5>
					</div>
					<div class="modal-body">
						<p class="text-danger">
							Please Wait!
						</p>
					</div>
				</div>
			</div>
		</div>`,

})

Vue.component(`dtx-numberic-select`, {

	props: [`value`, `min`, `max`],

	data: function () {

		return ({

			validated: false,

		})

	},

	created: function () {

		this.validated = false

		if (this.min === undefined) {

			console.error(`[dtx-numberic-select]: The 'min' can not be 'undefined'!`)
			return;

		}

		if (this.min === null) {

			console.error(`[dtx-numberic-select]: The 'min' can not be 'null'!`)
			return;

		}

		if (Number.isInteger(this.min) === false) {

			console.error(`[dtx-numberic-select]: The 'min' (${this.min}) should be an integer!`)
			return;

		}

		if (this.max === undefined) {

			console.error(`[dtx-numberic-select]: The 'max' can not be 'undefined'!`)
			return;

		}

		if (this.max === null) {

			console.error(`[dtx-numberic-select]: The 'max' can not be 'null'!`)
			return;

		}

		if (Number.isInteger(this.max) === false) {

			console.error(`[dtx-numberic-select]: The 'max' (${this.max}) should be an integer!`)
			return;

		}

		if (this.min > this.max) {

			console.error(`[dtx-numberic-select]: The 'min' (${this.min}) should be less than or equal to 'max' (${this.max})!`)
			return;

		}

		if (this.value === undefined) {

			console.error(`[dtx-numberic-select]: The 'value' can not be 'undefined'!`)
			return;

		}

		if (this.value !== null) {

			if (Number.isInteger(this.value) === false) {

				console.error(`[dtx-numberic-select]: The 'value' (${this.value}) should be an integer!`)
				return;

			}

			if (this.value < this.min) {

				console.error(`[dtx-numberic-select]: The 'value' (${this.value}) should be greater than or equal to 'min' (${this.min})!`)
				return;

			}

			if (this.value > this.max) {

				console.error(`[dtx-numberic-select]: The 'value' (${this.value}) should be less than or equal to 'max' (${this.max})!`)
				return;

			}

		}

		this.validated = true

	},

	template:
		`<select
			class="form-control"
			v-if="validated"
			v-bind:value="value"
			v-on:input="doSomething($event.target.value)"
			>
			<option v-bind:value="null"></option>
			<option v-for="(item, index) in getNumbers" v-bind:value="item" v-bind:key="index">{{ item }}</option>
		</select>`,

	methods: {

		doSomething: function (e) {

			this.$emit(`input`, e)

		},

	},

	computed: {

		getNumbers: function () {

			let numbers = []

			if (this.validated) {

				for (let index = this.min; index <= this.max; index++) {

					numbers.push(index)

				}

			}

			return numbers

		},

	},

})

Vue.component(`dtx-persian-calendar`, {

	props: [`value`, `minYear`, `maxYear`],

	data: function () {

		return ({

			validated: false,

		})

	},

	created: function () {

		this.validated = false

		if (this.minYear === undefined) {

			console.error(`[dtx-persian-calendar]: The 'minYear' can not be 'undefined'!`)
			return;

		}

		if (this.minYear === null) {

			console.error(`[dtx-persian-calendar]: The 'minYear' can not be 'null'!`)
			return;

		}

		if (Number.isInteger(this.minYear) === false) {

			console.error(`[dtx-persian-calendar]: The 'minYear' (${this.minYear}) should be an integer!`)
			return;

		}

		if (this.maxYear === undefined) {

			console.error(`[dtx-persian-calendar]: The 'maxYear' can not be 'undefined'!`)
			return;

		}

		if (this.maxYear === null) {

			console.error(`[dtx-persian-calendar]: The 'maxYear' can not be 'null'!`)
			return;

		}

		if (Number.isInteger(this.maxYear) === false) {

			console.error(`[dtx-persian-calendar]: The 'maxYear' (${this.maxYear}) should be an integer!`)
			return;

		}

		if (this.minYear > this.maxYear) {

			console.error(`[dtx-persian-calendar]: The 'minYear' (${this.minYear}) should be less than or equal to 'maxYear' (${this.maxYear})!`)
			return;

		}

		if (this.value === undefined) {

			console.error(`[dtx-persian-calendar]: The 'value' can not be 'undefined'!`)
			return;

		}

		if (this.value === null) {

			console.error(`[dtx-persian-calendar]: The 'value' can not be 'null'!`)
			return;

		}

		if (this.value.year === undefined) {

			console.error(`[dtx-persian-calendar]: The 'value.year' can not be 'undefined'!`)
			return;

		}

		if (this.value.month === undefined) {

			console.error(`[dtx-persian-calendar]: The 'value.month' can not be 'undefined'!`)
			return;

		}

		if (this.value.day === undefined) {

			console.error(`[dtx-persian-calendar]: The 'value.day' can not be 'undefined'!`)
			return;

		}

		this.validated = true

	},

	template:
		`<div class="row" v-if="validated">
			<div class="col-6">
				<dtx-numberic-select v-model="value.year" v-bind:min="minYear" v-bind:max="maxYear"></dtx-numberic-select>
			</div>
			<div class="col-3">
				<dtx-numberic-select v-model="value.month" v-bind:min="1" v-bind:max="12"></dtx-numberic-select>
			</div>
			<div class="col-3">
				<dtx-numberic-select v-model="value.day" v-bind:min="1" v-bind:max="31"></dtx-numberic-select>
			</div>
		</div>`,

})
