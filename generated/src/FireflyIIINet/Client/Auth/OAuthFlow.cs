/*
 * Firefly III API v2.0.2
 *
 * This is the documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. You may use the \"Authorize\" button to try the API below. This file was last generated on 2023-05-17T04:54:43+00:00 
 *
 * The version of the OpenAPI document: 2.0.2
 * Contact: james@firefly-iii.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace FireflyIIINet.Client.Auth
{
    /// <summary>
    /// Available flows for OAuth2 authentication
    /// </summary>
    public enum OAuthFlow
    {
        /// <summary>Authorization code flow</summary>
        ACCESS_CODE,
        /// <summary>Implicit flow</summary>
        IMPLICIT,
        /// <summary>Password flow</summary>
        PASSWORD,
        /// <summary>Client credentials flow</summary>
        APPLICATION
    }
}