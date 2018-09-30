# LEARNING_VUE

See LearningDtxGridVueController Controller and Views for learning DtxGridVue

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

You can see all of samples and features in Learn_0100 to Learn_1100 actiions and views!
