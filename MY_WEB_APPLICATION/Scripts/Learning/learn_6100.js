const app = new Vue({

	el: `#app`,

	data: {

		result: null,

		person: {
			lastName: null,
			firstName: null
		}

	},

	methods: {

		doSomething: function () {

			this.result = null;

			$(`div#loadingModal`).modal({ backdrop: false, keyboard: false, });

			let url =
				`/NewLearning/GetPersonDetails_3`;

			axios.post(url, this.person)

				.then(response => {

					this.result = response.data;

					this.result.hiddenMessages.forEach(item => {

						console.log(item);

					});

				})
				.catch(error => {

					console.error(error);

				})
				.finally(() => {

					$(`div#loadingModal`).modal(`hide`);

				});

		}

	}

});
