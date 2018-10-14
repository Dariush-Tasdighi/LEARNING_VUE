Vue.component('display-error-messages', {

	props: ['messages'],

	template:
		`
		<div class="alert alert-danger" v-if="messages && messages.length > 0">
			<ul>
				<li v-for="item in messages">{{ item }}</li>
			</ul>
		</div>
		`,

})

Vue.component('display-information-messages', {

	props: ['messages'],

	template:
		`
		<div class="alert alert-info" v-if="messages && messages.length > 0">
			<ul>
				<li v-for="item in messages">{{ item }}</li>
			</ul>
		</div>
		`,

})

Vue.component('dtx-modal', {

	data: function () {

		return {

			showModal: true,

		}

	},

	template:
		`
		<div class="modal modal-mask" style="display: block">
			<div class="modal-dialog" role="document">
				<div class="modal-content">
					<div class="modal-header">
						<slot name="header"></slot>
					</div>

					<div class="modal-body">
						<slot name="body"></slot>
					</div>

					<div class="modal-footer">
						<slot name="footer"></slot>
					</div>
				</div>
			</div>
		</div>
		`,

	methods: {

		openModal() {

			this.showModal = true;

		},

		closeModal() {

			this.showModal = false;

		},

		submitAndClose() {
		}

	}

})

//Vue.component('dtx-loading-modal', {

//	data: function () {

//		return {

//			showModal: true,

//		}

//	},

//	template:
//		`
//		<dtx-modal>
//			<h3 slot="header" class="modal-title">
//				Loading...
//			</h3>

//			<div slot="body">
//				Please Wait!
//			</div>
//		</dtx-modal>
//		`,

//	methods: {

//		openModal() {

//			this.showModal = true;

//		},

//		closeModal() {

//			this.showModal = false;

//		},

//		submitAndClose() {
//		}

//	}

//})
