// Version: 1.1.2

Vue.component('dtx-grid-column', {

	props: ['settings', 'parameters', 'column'],

	template:
		`
		<th @click="sort()" v-bind:style="getHeaderStyle()">
			{{ column.title }}
			<span v-html="displayArrow()"></span>
			<span class="glyphicon glyphicon glyphicon-cog" aria-hidden="true"
				v-if="settings.displayColumnSettings"
				v-on:click="$parent.$parent.openColumnSettingsModal"
				></span>
		</th>
		`,

	methods: {

		getHeaderStyle: function () {

			if (this.column.isSortable) {

				return { cursor: 'pointer' }

			}
			else {

				return null

			}

		},

		displayArrow: function () {

			// **************************************************
			if ((this.column.isSortable === undefined) ||
				(this.column.isSortable === null) ||
				(this.column.isSortable !== true)
			) {

				this.column.isSortable = false
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
			if ((this.column.isSortable === undefined) ||
				(this.column.isSortable === null) ||
				(this.column.isSortable !== true)
			) {

				this.column.isSortable = false
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
				<span class="glyphicon glyphicon glyphicon-cog" aria-hidden="true"
					v-if="settings.displayColumnSettings"
					v-on:click="$parent.openColumnSettingsModal"
					></span>
			</th>

			<th v-if="settings.isSelectable">
				{{ this.settings.cultrue.select }}
				<span class="glyphicon glyphicon glyphicon-cog" aria-hidden="true"
					v-if="settings.displayColumnSettings"
					v-on:click="$parent.openColumnSettingsModal"
					></span>
			</th>

			<dtx-grid-column
				v-if="$parent.displayColumn(column)"
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

						<button type="button" v-on:click="$parent.exportToExcel" v-bind:title="this.settings.cultrue.exportToExcel">
							<span class="glyphicon glyphicon-export" aria-hidden="true"></span>
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
								<select v-model="settings.pageSize" v-on:change="$parent.changePageSize" class="form-control" style="height: 30px;padding-top: 0px;padding-bottom: 0px;">
									<option v-for="item in settings.pageSizes" v-bind:value="item">{{ item }}</option>
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
					<td
						v-if="settings.displayRowNumber"
						>
						{{ (parameters.pageIndex * settings.pageSize) + index + 1 }}
					</td>

					<td
						v-if="settings.isSelectable"
						>
						<input type="checkbox" v-model="item.isSelected" />
					</td>

					<td
						v-if="$parent.displayColumn(column)"
						v-for="column in settings.columns"
						>
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

				if (column.isCheckbox === true) {

					if ((result === 1) || (result === true)) {

						//result = '<input type="checkbox" disabled="disabled" checked="checked" />'
						result = '<span class="glyphicon glyphicon-check" aria-hidden="true"></span>'

					}
					else {

						//result = '<input type="checkbox" disabled="disabled" />'
						result = '<span class="glyphicon glyphicon-unchecked" aria-hidden="true"></span>'

					}

				}

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

				responseData: null,

				displayLoadingModal: false,
				displayColumnSettingsModal: false,

				pageIndex: 0,
				recordCount: 0,
				lastPageIndex: 0,

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

				<dtx-modal v-if="parameters.displayColumnSettingsModal">
					<h3 slot="header" class="modal-title">
						{{ this.settings.cultrue.columns }}
					</h3>

					<div slot="body">
						<ul>
							<li style="cursor: pointer;"
								v-for="column in settings.columns"
								v-on:click="toggleColumnVisibility(column)">
								<span v-html="displayCheckbox(column)"></span>
								{{ column.title }}
							</li>
						</ul>
					</div>

					<div slot="footer">
						<button type="button" v-on:click="closeColumnSettingsModal">{{ this.settings.cultrue.close }}</button>
					</div>
				</dtx-modal>

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
					v-bind:messages="settings.errorMessages"
					>
				</display-error-messages>

				<display-information-messages
					v-if="settings.displayInformationMessages"
					v-bind:messages="settings.informationMessages"
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
									v-for="(item, index) in settings.items"
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

		openColumnSettingsModal: function (event) {

			this.parameters.displayColumnSettingsModal = true

			if (event.stopPropagation) {

				event.stopPropagation()

			} else {

				event.cancelBubble = true

			}

		},

		closeColumnSettingsModal: function () {

			this.parameters.displayColumnSettingsModal = false

		},

		displayCheckbox: function (column) {

			if (column.isHidden) {

				return '<span class="glyphicon glyphicon glyphicon-unchecked" aria-hidden="true"></span>'

			}
			else {

				return '<span class="glyphicon glyphicon glyphicon glyphicon-check" aria-hidden="true"></span>'

			}

		},

		toggleColumnVisibility: function (column) {

			column.isHidden = !column.isHidden

		},

		displayColumn: function (column) {

			return !column.isHidden

		},

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

			this.settings.items = null
			this.settings.isSuccess = false

			this.settings.errorMessages = null
			this.settings.hiddenMessages = null
			this.settings.informationMessages = null

			this.parameters.recordCount = 0

			this.parameters.displayLoadingModal = true
			this.parameters.displayColumnSettingsModal = false

			this.requestData.pageSize = this.settings.pageSize
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

					this.settings.isSuccess = response.data.isSuccess
					this.settings.errorMessages = response.data.errorMessages
					this.settings.hiddenMessages = response.data.hiddenMessages
					this.settings.informationMessages = response.data.informationMessages

					if ((this.settings.hiddenMessages !== undefined) &&
						(this.settings.hiddenMessages !== null)) {

						for (let index = 0; index <= this.settings.hiddenMessages.length - 1; index++) {

							console.log(this.settings.hiddenMessages[index])

						}

					}

					if (this.settings.isSuccess) {

						this.settings.items = response.data.items
						this.parameters.recordCount = response.data.count

						// **************************************************
						for (let index = 0; index <= this.settings.items.length - 1; index++) {

							let item = this.settings.items[index]

							if ((item.isSelected === undefined) ||
								(item.isSelected === null)) {

								Vue.set(item, 'isSelected', false)

							}
							else {

								if ((item.isSelected !== true) && (item.isSelected !== false)) {

									column.isSelected = false

								}

							}
						}
						// **************************************************

						// **************************************************
						this.parameters.lastPageIndex =
							Math.floor(this.parameters.recordCount / this.settings.pageSize)

						if (this.parameters.recordCount % this.settings.pageSize === 0) {

							this.parameters.lastPageIndex--

						}

						if (this.parameters.lastPageIndex < 0) {

							this.parameters.lastPageIndex = 0

						}
						// **************************************************

					}

				})
				.catch(error => {

					console.log(error)

				})
				.finally(() => {

					this.parameters.displayLoadingModal = false

				})

		},

		exportToExcel: function () {

			// Actual delimiter characters for CSV format
			let colDelim
			let rowDelim = '\r\n'

			let BOM = "\uFEFF"

			// NOK
			//let csv = ''

			// OK
			//let csv = BOM

			// NOK
			//let csv = BOM + 'sep=,' + rowDelim

			// So So!
			//let csv = BOM + rowDelim + 'sep=,' + rowDelim

			// NOK
			//let csv = 'sep=,' + BOM + rowDelim

			// So So!
			//let csv = BOM + ' ' + 'sep=,' + rowDelim

			// NOK
			//let csv = BOM + '\t'

			let csv = ''

			if (this.settings.rtl) {

				csv = BOM
				colDelim = '؛'

			}
			else {

				colDelim = ','
				csv = 'sep=,' + rowDelim

			}

			// **************************************************
			let columns =
				this.settings.columns

			let headingsArray = []

			for (i = 0; i < columns.length; i++) {

				let column = columns[i]

				if (column.isHidden === false) {

					headingsArray.push('"' + column.title + '"')

				}

			}

			csv += headingsArray.join(colDelim) + rowDelim
			// **************************************************

			// **************************************************
			let items =
				this.settings.items

			for (i = 0; i < items.length; i++) {

				let item = items[i]

				let columnsArray = []

				for (j = 0; j < columns.length; j++) {

					let column = columns[j]

					if (column.isHidden === false) {

						columnsArray.push('"' + item[column.fieldName] + '"')

					}

				}

				csv += columnsArray.join(colDelim) + rowDelim

			}
			// **************************************************

			// Data URI
			let csvData =
				'data:application/csv;charset=utf-8,' + encodeURIComponent(csv)

			//this trick will generate a temp <a /> tag
			let link = document.createElement('a')
			link.href = csvData

			//set the visibility hidden so it will not effect on your web-layout
			link.style = "visibility:hidden"
			link.download = 'export.csv'

			//this part will append the anchor tag and remove it after automatic click
			document.body.appendChild(link)
			link.click()
			document.body.removeChild(link)

		},

	},

	beforeCreate: function () {

		//console.log('Before Created!')

		// Cannot read property 'settings' of undefined
		//if (this.settings.loadFirstPageAutomatically) {

		//	this.parameters.pageIndex = 0
		//	this.getData()
		//}

	},

	created: function () {

		//console.log('Created!')

		// **************************************************
		if (this.settings.pageSizes === undefined) {

			Vue.set(this.settings, 'pageSizes', [10, 20, 50, 100, 200, 500, 1000])

		}
		// **************************************************

		// **************************************************
		if (this.settings.pageSize === undefined) {

			Vue.set(this.settings, 'pageSize', this.settings.pageSizes[0])

		}
		// **************************************************

		// **************************************************
		if (this.settings.items === undefined) {

			Vue.set(this.settings, 'items', null)

		}
		// **************************************************

		// **************************************************
		if (this.settings.isSuccess === undefined) {

			Vue.set(this.settings, 'isSuccess', false)

		}
		else {

			if (!(this.settings.isSuccess === true || this.settings.isSuccess === false)) {

				this.settings.isSuccess = false

			}

		}
		// **************************************************

		// **************************************************
		if (this.settings.rtl === undefined) {

			Vue.set(this.settings, 'rtl', false)

		}
		else {

			if (!(this.settings.rtl === true || this.settings.rtl === false)) {

				this.settings.rtl = false

			}

		}
		// **************************************************

		// **************************************************
		if (this.settings.errorMessages === undefined) {

			Vue.set(this.settings, 'errorMessages', null)

		}
		// **************************************************

		// **************************************************
		if (this.settings.hiddenMessages === undefined) {

			Vue.set(this.settings, 'hiddenMessages', null)

		}
		// **************************************************

		// **************************************************
		if (this.settings.informationMessages === undefined) {

			Vue.set(this.settings, 'informationMessages', null)

		}
		// **************************************************

		// **************************************************
		if (this.settings.isSelectable === undefined) {

			Vue.set(this.settings, 'isSelectable', false)

		}
		else {

			if (!(this.settings.isSelectable === true || this.settings.isSelectable === false)) {

				this.settings.isSelectable = false

			}

		}
		// **************************************************

		// **************************************************
		if (this.settings.displayRowNumber === undefined) {

			Vue.set(this.settings, 'displayRowNumber', false)

		}
		else {

			if (!(this.settings.displayRowNumber === true || this.settings.displayRowNumber === false)) {

				this.settings.displayRowNumber = false

			}

		}
		// **************************************************

		// **************************************************
		if (this.settings.loadFirstPageAutomatically === undefined) {

			Vue.set(this.settings, 'loadFirstPageAutomatically', false)

		}
		else {

			if (!(this.settings.loadFirstPageAutomatically === true || this.settings.loadFirstPageAutomatically === false)) {

				this.settings.loadFirstPageAutomatically = false

			}

		}
		// **************************************************

		// **************************************************
		if (this.settings.displayErrorMessages === undefined) {

			Vue.set(this.settings, 'displayErrorMessages', false)

		}
		else {

			if (!(this.settings.displayErrorMessages === true || this.settings.displayErrorMessages === false)) {

				this.settings.displayErrorMessages = false

			}

		}
		// **************************************************

		// **************************************************
		if (this.settings.displayColumnSettings === undefined) {

			Vue.set(this.settings, 'displayColumnSettings', false)

		}
		else {

			if (!(this.settings.displayColumnSettings === true || this.settings.displayColumnSettings === false)) {

				this.settings.displayColumnSettings = false

			}

		}
		// **************************************************

		// **************************************************
		if (this.settings.displayInformationMessages === undefined) {

			Vue.set(this.settings, 'displayInformationMessages', false)

		}
		else {

			if (!(this.settings.displayInformationMessages === true || this.settings.displayInformationMessages === false)) {

				this.settings.displayInformationMessages = false

			}

		}
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		for (let index = 0; index <= this.settings.columns.length - 1; index++) {

			let column = this.settings.columns[index]

			// **************************************************
			if (column.isHidden === undefined) {

				Vue.set(column, 'isHidden', false)

			}
			else {

				if (!(column.isHidden === true || column.isHidden === false)) {

					column.isHidden = false

				}

			}
			// **************************************************

			// **************************************************
			if (column.isCheckbox === undefined) {

				Vue.set(column, 'isCheckbox', false)

			}
			else {

				if (!(column.isCheckbox === true || column.isCheckbox === false)) {

					column.isCheckbox = false

				}

			}
			// **************************************************

			// **************************************************
			if (column.isSortable === undefined) {

				Vue.set(column, 'isSortable', false)

			}
			else {

				if (!(column.isSortable === true || column.isSortable === false)) {

					column.isSortable = false

				}

			}
			// **************************************************
		}
		// **************************************************
		// **************************************************
		// **************************************************

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
