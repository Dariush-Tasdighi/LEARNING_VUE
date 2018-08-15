Vue.component('display-error-messages', {

	props: ['messages'],

	template:
		`<div class="alert alert-danger" v-if="messages && messages.length > 0">
	<ul>
		<li v-for="item in messages">{{ item }}</li>
	</ul>
</div>`,

})

Vue.component('display-information-messages', {

	props: ['messages'],

	template:
		`<div class="alert alert-info" v-if="messages && messages.length > 0">
	<ul>
		<li v-for="item in messages">{{ item }}</li>
	</ul>
</div>`,

})

Vue.component('loading-modal', {

	template:
		`<div id="myLoadingModal" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myLoadingModalLabel">
			<div class="modal-dialog" role="document">
				<div class="modal-content">
					<div class="modal-header">
						<h4 class="modal-title" id="myLoadingModalLabel">Loading!</h4>
					</div>

					<div class="modal-body">
						Please Wait...
					</div>
				</div>
			</div>
		</div>`,

})
