# FireflyIIINet.Model.RecurrenceTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** |  | 
**Amount** | **string** | Amount of the transaction. | 
**ForeignAmount** | **string** | Foreign amount of the transaction. | [optional] 
**CurrencyId** | **string** | Submit either a currency_id or a currency_code. | [optional] 
**CurrencyCode** | **string** | Submit either a currency_id or a currency_code. | [optional] 
**CurrencySymbol** | **string** |  | [optional] [readonly] 
**CurrencyDecimalPlaces** | **int** | Number of decimals in the currency | [optional] [readonly] 
**ForeignCurrencyId** | **string** | Submit either a foreign_currency_id or a foreign_currency_code, or neither. | [optional] 
**ForeignCurrencyCode** | **string** | Submit either a foreign_currency_id or a foreign_currency_code, or neither. | [optional] 
**ForeignCurrencySymbol** | **string** |  | [optional] [readonly] 
**ForeignCurrencyDecimalPlaces** | **int?** | Number of decimals in the currency | [optional] [readonly] 
**BudgetId** | **string** | The budget ID for this transaction. | [optional] 
**BudgetName** | **string** | The name of the budget to be used. If the budget name is unknown, the ID will be used or the value will be ignored. | [optional] [readonly] 
**CategoryId** | **string** | Category ID for this transaction. | [optional] 
**CategoryName** | **string** | Category name for this transaction. | [optional] 
**SourceId** | **string** | ID of the source account. Submit either this or source_name. | [optional] 
**SourceName** | **string** | Name of the source account. Submit either this or source_id. | [optional] 
**SourceIban** | **string** |  | [optional] [readonly] 
**SourceType** | **AccountTypeProperty** |  | [optional] 
**DestinationId** | **string** | ID of the destination account. Submit either this or destination_name. | [optional] 
**DestinationName** | **string** | Name of the destination account. Submit either this or destination_id. | [optional] 
**DestinationIban** | **string** |  | [optional] [readonly] 
**DestinationType** | **AccountTypeProperty** |  | [optional] 
**Tags** | **List&lt;string&gt;** | Array of tags. | [optional] 
**PiggyBankId** | **string** | Optional. Use either this or the piggy_bank_name | [optional] 
**PiggyBankName** | **string** | Optional. Use either this or the piggy_bank_id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

