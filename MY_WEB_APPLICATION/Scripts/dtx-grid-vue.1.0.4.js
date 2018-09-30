Vue.component('dtx-grid-column', {

	props: ['settings', 'parameters', 'column'],

	template:
		`
		<th @click="sort()">
			{{ column.title }} <span v-html="displayArrow()"></span>
		</th>
		`,

	methods: {

		displayArrow: function () {

			// **************************************************
			if ((this.column.sortable === undefined) ||
				(this.column.sortable === null) ||
				(this.column.sortable !== true)
			) {

				this.column.sortable = false
				return null

			}
			// **************************************************

			// **************************************************
			if ((this.parameters === undefined) ||
				(this.parameters === null) ||
				(this.parameters.sort === undefined) ||
				(this.parameters.sort === null) ||
				(this.parameters.sort.fieldName === undefined) ||
				(this.parameters.sort.fieldName === null) ||
				(this.parameters.sort.direction === undefined) ||
				(this.parameters.sort.direction === null)
			) {

				this.parameters.sort.fieldName = null
				this.parameters.sort.direction = null

				return null

			}
			// **************************************************

			// **************************************************
			if ((this.column.sortFieldName === undefined) ||
				(this.column.sortFieldName === null)
			) {

				this.column.sortFieldName = this.column.fieldName

			}
			// **************************************************

			// **************************************************
			if ((this.parameters.sort.fieldName !== this.column.sortFieldName)) {

				return null

			}
			// **************************************************

			// **************************************************
			if (this.parameters.sort.direction === 0) {

				return '<span class="glyphicon glyphicon glyphicon-sort-by-attributes" aria-hidden="true"></span>'

			}
			else {

				return '<span class="glyphicon glyphicon glyphicon glyphicon-sort-by-attributes-alt" aria-hidden="true"></span>'

			}
			// **************************************************

		},

		sort: function () {

			// **************************************************
			if ((this.column.sortable === undefined) ||
				(this.column.sortable === null) ||
				(this.column.sortable !== true)
			) {

				this.column.sortable = false
				return

			}
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			if ((this.parameters.sort.fieldName === undefined) ||
				(this.parameters.sort.fieldName === null)) {

				this.parameters.sort.fieldName = null
				this.parameters.sort.direction = null

			}
			// **************************************************

			// **************************************************
			if (this.parameters.sort.direction === undefined) {

				this.parameters.sort.direction = null

			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			if ((this.column.sortFieldName === undefined) ||
				(this.column.sortFieldName === null)
			) {

				this.column.sortFieldName = this.column.fieldName

			}
			// **************************************************

			// **************************************************
			let firstSortDirection

			if ((this.column.firstSortDirection === undefined) ||
				(this.column.firstSortDirection === null)
			) {

				firstSortDirection = 0

			}
			else {

				if ((this.column.firstSortDirection === 0) ||
					(this.column.firstSortDirection === 1)
				) {

					firstSortDirection = this.column.firstSortDirection

				}
				else {

					firstSortDirection = 0

				}
			}
			// **************************************************

			// **************************************************
			if (this.parameters.sort.fieldName !== this.column.sortFieldName) {

				this.parameters.sort.direction = firstSortDirection
				this.parameters.sort.fieldName = this.column.sortFieldName

			}
			else {

				if (this.parameters.sort.direction === null) {

					this.parameters.sort.direction = firstSortDirection

				}
				else {

					if (this.parameters.sort.direction === firstSortDirection) {

						if (firstSortDirection === 0) {

							this.parameters.sort.direction = 1

						}
						else {

							this.parameters.sort.direction = 0

						}

					}
					else {

						this.parameters.sort.fieldName = null
						this.parameters.sort.direction = null

					}

				}

			}
			// **************************************************

			//console.log('Sort Field Name: [' + this.parameters.sort.fieldName + ']')
			//console.log('Sort Direction: [' + this.parameters.sort.direction + ']')

			this.$parent.$parent.displayFirst()

		},

	},

})

Vue.component('dtx-grid-header', {

	props: ['settings', 'parameters'],

	template:
		`<tr>
			<th v-if="settings.displayRowNumber">
				{{ this.settings.cultrue.rowNumberTitle }}
			</th>

			<dtx-grid-column
				v-for="column in settings.columns"
				v-bind:settings="settings"
				v-bind:parameters="parameters"
				v-bind:column="column"
				>
			</dtx-grid-column>
		</tr>`,

})

Vue.component('dtx-grid-footer', {

	props: ['settings', 'parameters'],

	template:
		`
				<div class="row">
					<div class="col-xs-3">

						<button type="button" v-on:click="$parent.refresh" v-bind:title="this.settings.cultrue.refresh">
							<span class="glyphicon glyphicon-refresh" aria-hidden="true"></span>
						</button>

						<template v-if="settings.rtl">
							<button type="button" v-on:click="$parent.displayFirst" v-bind:title="this.settings.cultrue.first">
								<span class="glyphicon glyphicon-step-forward" aria-hidden="true"></span>
							</button>

							<button type="button" v-on:click="$parent.displayPrevious" v-bind:title="this.settings.cultrue.previous">
								<span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
							</button>

							<button type="button" v-on:click="$parent.displayNext" v-bind:title="this.settings.cultrue.next">
								<span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
							</button>

							<button type="button" v-on:click="$parent.displayLast" v-bind:title="this.settings.cultrue.last">
								<span class="glyphicon glyphicon-step-backward" aria-hidden="true"></span>
							</button>
						</template>

						<template v-else>
							<button type="button" v-on:click="$parent.displayFirst" v-bind:title="this.settings.cultrue.first">
								<span class="glyphicon glyphicon-step-backward" aria-hidden="true"></span>
							</button>

							<button type="button" v-on:click="$parent.displayPrevious" v-bind:title="this.settings.cultrue.previous">
								<span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
							</button>

							<button type="button" v-on:click="$parent.displayNext" v-bind:title="this.settings.cultrue.next">
								<span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
							</button>

							<button type="button" v-on:click="$parent.displayLast" v-bind:title="this.settings.cultrue.last">
								<span class="glyphicon glyphicon-step-forward" aria-hidden="true"></span>
							</button>
						</template>

					</div>

					<div class="col-xs-3">
						<div class="row">
							<div class="col-sm-6">
								{{ this.settings.cultrue.pageSize }}
							</div>
							<div class="col-sm-6">
								<select v-model="parameters.pageSize" v-on:change="$parent.changePageSize" class="form-control" style="height: 26px;padding-top: 1px;padding-bottom: 1px;">
									<option v-for="item in parameters.pageSizes" v-bind:value="item">{{ item }}</option>
								</select>
							</div>
						</div>
					</div>

					<div class="col-xs-3">
						{{ this.settings.cultrue.page }}
						{{ parameters.pageIndex + 1 }}
						{{ this.settings.cultrue.pages }}
						{{ parameters.lastPageIndex + 1 }}
					</div>

					<div class="col-xs-3">
						{{ this.settings.cultrue.recordCount }}
						{{ parameters.recordCount }}
					</div>
				</div>
				`,

})

Vue.component('dtx-grid-row', {

	props: ['settings', 'parameters', 'item', 'index'],

	template:
		`
				<tr>
					<td v-if="settings.displayRowNumber">
						{{ (parameters.pageIndex * parameters.pageSize) + index + 1 }}
					</td>

					<td v-for="column in settings.columns">
						<span v-html="getCellValue(column)"></span>
					</td>
				</tr>
				`,

	methods: {

		getCellValue: function (column) {

			//let result = this.item[column.fieldName]
			//return result

			//if (typeof column.template !== "undefined") {
			//}

			let result = null

			if (typeof column.template === "function") {

				result =
					column.template(this.item)

			}
			else {

				result =
					this.item[column.fieldName]

			}

			return result

		}

	},

})

Vue.component('dtx-grid-vue', {

	props: ['settings'],

	data: function () {

		return {

			parameters: {

				isSuccess: false,
				responseData: null,
				displayLoadingModal: false,

				errorMessages: null,
				hiddenMessages: null,
				informationMessages: null,

				items: null,

				pageSize: 5,
				pageIndex: 0,
				recordCount: 0,
				lastPageIndex: 0,
				pageSizes: [5, 10, 20, 50, 100],

				sort: {

					fieldName: null,
					direction: null,

				}

			},

			requestData: {

				pageSize: 0,
				pageIndex: 0,
				sortFieldName: null,
				sortDirection: null,

			},

		}

	},

	template:
		`
		<div class="row">
			<div class="col-xs-12">

				<dtx-modal v-if="parameters.displayLoadingModal">
					<h3 slot="header" class="modal-title">
						{{ this.settings.cultrue.loading }}
					</h3>

					<div slot="body">
						{{ this.settings.cultrue.wait }}
					</div>
				</dtx-modal>

				<display-error-messages
					v-if="settings.displayErrorMessages"
					v-bind:messages="parameters.errorMessages"
					>
				</display-error-messages>

				<display-information-messages
					v-if="settings.displayInformationMessages"
					v-bind:messages="parameters.informationMessages"
					>
				</display-information-messages>

				<slot name="search"></slot>

				<div class= "row">
					<div class="col-xs-12 table-responsive">
						<table class="table table-bordered table-condensed table-striped table-hover">
							<thead>
								<dtx-grid-header
									v-bind:settings="settings"
									v-bind:parameters="parameters"
									>
								</dtx-grid-header>
							</thead>

							<tbody>
								<dtx-grid-row
									v-for="(item, index) in parameters.items"
									v-bind:settings="settings"
									v-bind:parameters="parameters"
									v-bind:item="item"
									v-bind:index="index"
									v-bind:key="item.id"
									>
								</dtx-grid-row>
							</tbody>
						</table>
					</div>
				</div>

				<dtx-grid-footer
					v-bind:settings="settings"
					v-bind:parameters="parameters"
					>
				</dtx-grid-footer>
			</div>
		</div>

		`,

	methods: {

		changePageSize: function () {

			this.displayFirst()

		},

		refresh: function () {

			this.getData()

		},

		displayFirst: function () {

			//if (this.parameters.pageIndex != 0) {

			this.parameters.pageIndex = 0
			this.getData()

			//}

		},

		displayPrevious: function () {

			if (this.parameters.pageIndex > 0) {

				this.parameters.pageIndex--
				this.getData()

			}

		},

		displayNext: function () {

			if (this.parameters.pageIndex < this.parameters.lastPageIndex) {

				this.parameters.pageIndex++
				this.getData()

			}

		},

		displayLast: function () {

			//if (this.parameters.pageIndex != this.parameters.lastPageIndex) {

			this.parameters.pageIndex = this.parameters.lastPageIndex
			this.getData()

			//}

		},

		getData: function () {

			this.parameters.items = null
			this.parameters.recordCount = 0
			this.parameters.isSuccess = false

			this.parameters.errorMessages = null
			this.parameters.hiddenMessages = null
			this.parameters.informationMessages = null

			this.parameters.displayLoadingModal = true

			this.requestData.pageSize = this.parameters.pageSize
			this.requestData.pageIndex = this.parameters.pageIndex

			this.requestData.sortFieldName = this.parameters.sort.fieldName
			this.requestData.sortDirection = this.parameters.sort.direction

			if ((this.settings.searchItems !== undefined) && (this.settings.searchItems !== null)) {

				let searchItems =
					this.settings.searchItems

				Object.keys(searchItems).forEach(e => {

					this.requestData[e] = searchItems[e]

				})

			}

			axios.post(this.settings.url, this.requestData)

				.then(response => {

					this.parameters.isSuccess = response.data.isSuccess
					this.parameters.errorMessages = response.data.errorMessages
					this.parameters.hiddenMessages = response.data.hiddenMessages
					this.parameters.informationMessages = response.data.informationMessages

					if ((this.parameters.hiddenMessages !== undefined) &&
						(this.parameters.hiddenMessages !== null)) {

						for (let index = 0; index <= this.parameters.hiddenMessages.length - 1; index++) {

							console.log(this.parameters.hiddenMessages[index])

						}

					}

					if (this.parameters.isSuccess) {

						this.parameters.items = response.data.items
						this.parameters.recordCount = response.data.count

						//if (this.parameters.recordCount % this.parameters.pageSize === 0) {

						//	this.parameters.lastPageIndex =
						//		Math.floor(this.parameters.recordCount / this.parameters.pageSize) - 1

						//}
						//else {

						//	this.parameters.lastPageIndex =
						//		Math.floor(this.parameters.recordCount / this.parameters.pageSize)

						//}

						this.parameters.lastPageIndex =
							Math.floor(this.parameters.recordCount / this.parameters.pageSize)

						if (this.parameters.recordCount % this.parameters.pageSize === 0) {

							this.parameters.lastPageIndex--

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

	//beforeCreate: function () {

	//	//console.log('Before Created!')

	//	// Cannot read property 'settings' of undefined
	//	//if (this.settings.loadFirstPageAutomatically) {

	//	//	this.parameters.pageIndex = 0
	//	//	this.getData()
	//	//}

	//},

	created: function () {

		//console.log('Created!')

		// Cannot read property 'settings' of undefined
		if (this.settings.loadFirstPageAutomatically) {

			this.parameters.pageIndex = 0
			this.getData()
		}

	},

	//beforeMount: function () {

	//	//console.log('Before Mount!')

	//},

	//mounted: function () {

	//	//console.log('Mounted!')

	//},

	//beforeUpdate: function () {

	//	//console.log('Before Update!')

	//},

	//updated: function () {

	//	//console.log('Updated!')

	//},

	//beforeDestroy: function () {

	//	//console.log('Before Destroy!')

	//},

	//destroyed: function () {

	//	//console.log('Destroyed!')

	//},

})
