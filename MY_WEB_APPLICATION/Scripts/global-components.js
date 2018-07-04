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
