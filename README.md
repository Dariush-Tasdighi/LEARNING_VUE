# Learning DtxGridVue (DTX Web Data Grid VUEJS)

### A very simple and powerful Web Data Grid based on VUEJS!

![dtxgridvue](https://user-images.githubusercontent.com/8329347/46918358-44471a80-cfde-11e8-9ffc-3067e4e7d08f.jpg)

See LearningDtxGridVueController and its related Views for learning DtxGridVue

	<div id="app">
		<div class="container">
			<dtx-grid-vue v-bind:settings="settings"></dtx-grid-vue>
		</div>
	</div>
  
	<script>

		new Vue({

			el: '#app',

			data: {

				// New!
				settings: {

					cultrue: dtxGridVueCulture,
					url: '/LearningDtxGridVue/GetData',

					columns: [
						{ fieldName: 'firstName', title: 'First Name', },
						{ fieldName: 'lastName', title: 'Last Name', },
						{ fieldName: 'age', title: 'Age', },
						{ fieldName: 'salary', title: 'Salary', },
					],

				}

			},

		})

	</script>

![01](https://user-images.githubusercontent.com/8329347/46260289-c882a380-c4f0-11e8-86b8-4622abeaf0b5.jpg)

You can see all of samples and features in Learn_0100 to Learn_1700 actiions and views!

### Full Features in English:

![dtxgridvue 001](https://user-images.githubusercontent.com/8329347/46918428-08f91b80-cfdf-11e8-8fe0-29ae8ff19fe1.jpg)

### Full Features in Persian (Farsi):

![dtxgridvue 002](https://user-images.githubusercontent.com/8329347/46918460-64c3a480-cfdf-11e8-8cb3-4d2417915a57.jpg)
