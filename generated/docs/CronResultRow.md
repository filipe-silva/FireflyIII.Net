# FireflyIIINet.Model.CronResultRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobFired** | **bool?** | This value tells you if this specific cron job actually fired. It may not fire. Some cron jobs only fire every 24 hours, for example.  | [optional] 
**JobSucceeded** | **bool?** | This value tells you if this specific cron job actually did something. The job may fire but not change anything.  | [optional] 
**JobErrored** | **bool?** | If the cron job ran into some kind of an error, this value will be true. | [optional] 
**Message** | **string** | If the cron job ran into some kind of an error, this value will be the error message. The success message if the job actually ran OK.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

