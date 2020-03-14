Vue.component(`dtx-header`, {

	props: [`message`],

	template:
		`<h3>
			{{ message }}
		</h3>`

});

Vue.component(`dtx-list-index`, {

	props: [`text`],

	template:
		`<li>{{ text }}</li>`

});

Vue.component(`dtx-error-messages`, {

	props: [`result`],

	template:
		`<div class="alert alert-danger" v-if="result?.errorMessages?.length > 0">
			<ul>
				<dtx-list-index v-for="(item, index) in result.errorMessages" v-bind:key="index" v-bind:text="item"></dtx-list-index>
			</ul>
		</div>`

});

Vue.component(`dtx-information-messages`, {

	props: [`result`],

	template:
		`<div class="alert alert-info" v-if="result?.informationMessages?.length > 0">
			<ul>
				<dtx-list-index v-for="(item, index) in result.informationMessages" v-bind:key="index" v-bind:text="item"></dtx-list-index>
			</ul>
		</div>`

});

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
		</div>`

});
