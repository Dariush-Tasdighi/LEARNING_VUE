Vue.component('dtx-grid-column', {

	props: ['settings', 'column'],

	data: function () {

		return {



		}

	},

	template: '<th>{{ column.title }}</th>',

})

Vue.component('dtx-grid-header', {

	props: ['settings'],

	data: function () {

		return {



		}

	},

	template:
		`<tr>
					<th v-if="settings.displayRowNumber">#</th>
					<dtx-grid-column v-for="column in settings.columns" v-bind:settings="settings" v-bind:column="column"></dtx-grid-column>
				</tr>`,

})

Vue.component('dtx-grid-footer', {

	props: ['settings', 'parameters'],

	data: function () {

		return {



		}

	},

	//  v-if="parameters.items && parameters.length > 0"

	template:
		`
				<div class="row">
					<div class="col-xs-2">
						<button type="button" v-on:click="displayFirst" title="First"><span class="glyphicon glyphicon-step-backward" aria-hidden="true"></span></button>
						<button type="button" v-on:click="displayPrevious" title="Previous"><span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span></button>
						<button type="button" v-on:click="displayNext" title="Next"><span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span></button>
						<button type="button" v-on:click="displayLast" title="Last"><span class="glyphicon glyphicon-step-forward" aria-hidden="true"></span></button>
					</div>

					<div class="col-xs-4">
						<div class="row">
							<div class="col-sm-6">
								Page Size
							</div>
							<div class="col-sm-6">
								<select v-model="parameters.pageSize" v-on:change="changePageSize" class="form-control" style="height: 23px;padding: 2px 12px">
									<option v-for="item in parameters.pageSizes" v-bind:value="item">{{ item }}</option>
								</select>
							</div>
						</div>
					</div>

					<div class="col-xs-3">
						Page
						{{ parameters.pageIndex + 1 }}
						of
						{{ parameters.lastPageIndex + 1 }}
					</div>

					<div class="col-xs-3">
						Record Count:
						{{ parameters.recordCount }}
					</div>
				</div>
				`,

	methods: {

		changePageSize: function () {

			this.displayFirst()

		},

		displayFirst: function () {

			this.parameters.pageIndex = 0
			this.$parent.getData()

		},

		displayPrevious: function () {

			if (this.parameters.pageIndex > 0) {

				this.parameters.pageIndex--
				this.$parent.getData()

			}

		},

		displayNext: function () {

			if (this.parameters.pageIndex < this.parameters.lastPageIndex) {

				this.parameters.pageIndex++
				this.$parent.getData()

			}

		},

		displayLast: function () {

			this.parameters.pageIndex = this.parameters.lastPageIndex
			this.$parent.getData()

		},

	}

})

Vue.component('dtx-grid-row', {

	props: ['settings', 'parameters', 'item', 'index'],

	data: function () {

		return {



		}

	},

	template:
		`
				<tr>
					<td v-if="settings.displayRowNumber">
						{{ (parameters.pageIndex * parameters.pageSize) + index + 1 }}
					</td>

					<td v-for="column in settings.columns">
						{{ item[column.name] }}
					</td>
				</tr>
				`,

})

Vue.component('dtx-grid-vue', {

	props: ['settings'],

	data: function () {

		return {

			parameters: {

				isSuccess: false,
				responseData: null,
				errorMessages: null,
				informationMessages: null,
				displayLoadingModal: false,

				items: null,

				pageSize: 5,
				pageIndex: 0,
				recordCount: 0,
				lastPageIndex: 0,
				pageSizes: [5, 10, 20, 50, 100],

			},

		}

	},

	template:
		`
				<div class="row">
					<div class="col-xs-12">

						<dtx-loading-modal v-if="parameters.displayLoadingModal"></dtx-loading-modal>
						<display-error-messages v-bind:messages="parameters.errorMessages"></display-error-messages>
						<display-information-messages v-bind:messages="parameters.informationMessages"></display-information-messages>

						<div class= "row">
							<div class="col-xs-12 table-responsive">
								<table class="table table-bordered table-condensed table-striped table-hover">
									<thead>
										<dtx-grid-header v-bind:settings="settings" v-bind:parameters="parameters"></dtx-grid-header>
									</thead>

									<tbody>
										<dtx-grid-row v-for="(item, index) in parameters.items" v-bind:settings="settings" v-bind:parameters="parameters" v-bind:item="item" v-bind:index="index" v-bind:key="item.id"></dtx-grid-row>
									</tbody>
								</table>
							</div>
						</div>

						<dtx-grid-footer v-bind:settings="settings" v-bind:parameters="parameters"></dtx-grid-footer>

					</div>
				</div>

				`,

	methods: {

		getData: function () {

			this.parameters.items = null
			this.parameters.recordCount = 0

			this.parameters.isSuccess = false
			this.parameters.errorMessages = null
			this.parameters.informationMessages = null

			this.parameters.displayLoadingModal = true

			var requestData = {

				pageSize: this.parameters.pageSize,
				pageIndex: this.parameters.pageIndex,

				//lastName: this.searchItems.lastName,
				//firstName: this.searchItems.firstName,

			}

			var requestUrl = this.settings.url

			axios.post(requestUrl, requestData)

				.then(response => {

					this.parameters.isSuccess = response.data.isSuccess
					this.parameters.errorMessages = response.data.errorMessages
					this.parameters.informationMessages = response.data.informationMessages

					if (this.parameters.isSuccess) {

						this.parameters.items = response.data.items
						this.parameters.recordCount = response.data.count

						if (this.parameters.recordCount % this.parameters.pageSize === 0) {

							this.parameters.lastPageIndex =
								Math.floor(this.parameters.recordCount / this.parameters.pageSize) - 1

						}
						else {

							this.parameters.lastPageIndex =
								Math.floor(this.parameters.recordCount / this.parameters.pageSize)

						}

					}

				})
				.catch(error => {

					console.log(error)

				})
				.finally(() => {

					this.parameters.displayLoadingModal = false

				})

		},

	},

	beforeCreate: function () {

		console.log('Before Created!')

		// Cannot read property 'settings' of undefined
		//if (this.settings.loadFirstPageAutomatically) {

		//	this.parameters.pageIndex = 0
		//	this.getData()
		//}

	},

	created: function () {

		console.log('Created!')

		// Cannot read property 'settings' of undefined
		if (this.settings.loadFirstPageAutomatically) {

			this.parameters.pageIndex = 0
			this.getData()
		}

	},

	beforeMount: function () {

		console.log('Before Mount!')

	},

	mounted: function () {

		console.log('Mounted!')

	},

	beforeUpdate: function () {

		console.log('Before Update!')

	},

	updated: function () {

		console.log('Updated!')

	},

	beforeDestroy: function () {

		console.log('Before Destroy!')

	},

	destroyed: function () {

		console.log('Destroyed!')

	},

})
