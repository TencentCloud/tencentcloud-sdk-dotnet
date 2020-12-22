/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ses.V20201002
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ses.V20201002.Models;

   public class SesClient : AbstractClient{

       private const string endpoint = "ses.tencentcloudapi.com";
       private const string version = "2020-10-02";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SesClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SesClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 在验证了发信域名之后，您需要一个发信地址来发送邮件。例如发信域名是mail.qcloud.com，那么发信地址可以为 service@mail.qcloud.com。如果您想要收件人在收件箱列表中显示您的别名，例如"腾讯云邮件通知"。那么发信地址为： 别名 空格 尖括号 邮箱地址。请注意中间需要有空格
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public async Task<CreateEmailAddressResponse> CreateEmailAddress(CreateEmailAddressRequest req)
        {
             JsonResponseModel<CreateEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在验证了发信域名之后，您需要一个发信地址来发送邮件。例如发信域名是mail.qcloud.com，那么发信地址可以为 service@mail.qcloud.com。如果您想要收件人在收件箱列表中显示您的别名，例如"腾讯云邮件通知"。那么发信地址为： 别名 空格 尖括号 邮箱地址。请注意中间需要有空格
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public CreateEmailAddressResponse CreateEmailAddressSync(CreateEmailAddressRequest req)
        {
             JsonResponseModel<CreateEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在使用身份发送电子邮件之前，您需要有一个电子邮件域名，该域名可以是您的网站或者移动应用的域名。您首先必须进行验证，证明自己是该域名的所有者，并且授权给腾讯云SES发送许可，才可以从该域名发送电子邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public async Task<CreateEmailIdentityResponse> CreateEmailIdentity(CreateEmailIdentityRequest req)
        {
             JsonResponseModel<CreateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在使用身份发送电子邮件之前，您需要有一个电子邮件域名，该域名可以是您的网站或者移动应用的域名。您首先必须进行验证，证明自己是该域名的所有者，并且授权给腾讯云SES发送许可，才可以从该域名发送电子邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public CreateEmailIdentityResponse CreateEmailIdentitySync(CreateEmailIdentityRequest req)
        {
             JsonResponseModel<CreateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模板，该模板可以是TXT或者HTML，请注意如果HTML不要包含外部文件的CSS。模板中的变量使用 {{变量名}} 表示。
        /// 注意：模版需要审核通过才可以使用。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public async Task<CreateEmailTemplateResponse> CreateEmailTemplate(CreateEmailTemplateRequest req)
        {
             JsonResponseModel<CreateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建模板，该模板可以是TXT或者HTML，请注意如果HTML不要包含外部文件的CSS。模板中的变量使用 {{变量名}} 表示。
        /// 注意：模版需要审核通过才可以使用。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public CreateEmailTemplateResponse CreateEmailTemplateSync(CreateEmailTemplateRequest req)
        {
             JsonResponseModel<CreateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 邮箱被拉黑之后，用户如果确认收件邮箱有效或者已经处于激活状态，可以从腾讯云地址库中删除该黑名单之后继续投递。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public async Task<DeleteBlackListResponse> DeleteBlackList(DeleteBlackListRequest req)
        {
             JsonResponseModel<DeleteBlackListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBlackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 邮箱被拉黑之后，用户如果确认收件邮箱有效或者已经处于激活状态，可以从腾讯云地址库中删除该黑名单之后继续投递。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public DeleteBlackListResponse DeleteBlackListSync(DeleteBlackListRequest req)
        {
             JsonResponseModel<DeleteBlackListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBlackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除发信人地址
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public async Task<DeleteEmailAddressResponse> DeleteEmailAddress(DeleteEmailAddressRequest req)
        {
             JsonResponseModel<DeleteEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除发信人地址
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public DeleteEmailAddressResponse DeleteEmailAddressSync(DeleteEmailAddressRequest req)
        {
             JsonResponseModel<DeleteEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除发信域名，删除后，将不可再使用该域名进行发信
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public async Task<DeleteEmailIdentityResponse> DeleteEmailIdentity(DeleteEmailIdentityRequest req)
        {
             JsonResponseModel<DeleteEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除发信域名，删除后，将不可再使用该域名进行发信
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public DeleteEmailIdentityResponse DeleteEmailIdentitySync(DeleteEmailIdentityRequest req)
        {
             JsonResponseModel<DeleteEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除发信模版
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public async Task<DeleteEmailTemplateResponse> DeleteEmailTemplate(DeleteEmailTemplateRequest req)
        {
             JsonResponseModel<DeleteEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除发信模版
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public DeleteEmailTemplateResponse DeleteEmailTemplateSync(DeleteEmailTemplateRequest req)
        {
             JsonResponseModel<DeleteEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个发信域名的配置详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public async Task<GetEmailIdentityResponse> GetEmailIdentity(GetEmailIdentityRequest req)
        {
             JsonResponseModel<GetEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个发信域名的配置详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public GetEmailIdentityResponse GetEmailIdentitySync(GetEmailIdentityRequest req)
        {
             JsonResponseModel<GetEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据模板ID获取模板详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public async Task<GetEmailTemplateResponse> GetEmailTemplate(GetEmailTemplateRequest req)
        {
             JsonResponseModel<GetEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据模板ID获取模板详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public GetEmailTemplateResponse GetEmailTemplateSync(GetEmailTemplateRequest req)
        {
             JsonResponseModel<GetEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取近期发送的统计情况，包含发送量、送达率、打开率、退信率等一系列数据。最大跨度为14天。
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public async Task<GetStatisticsReportResponse> GetStatisticsReport(GetStatisticsReportRequest req)
        {
             JsonResponseModel<GetStatisticsReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetStatisticsReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStatisticsReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取近期发送的统计情况，包含发送量、送达率、打开率、退信率等一系列数据。最大跨度为14天。
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public GetStatisticsReportResponse GetStatisticsReportSync(GetStatisticsReportRequest req)
        {
             JsonResponseModel<GetStatisticsReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetStatisticsReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStatisticsReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云发送的邮件一旦被收件方判断为硬退(Hard Bounce)，腾讯云会拉黑该地址，并不允许所有用户向该地址发送邮件。成为邮箱黑名单。如果业务方确认是误判，可以从黑名单中删除。
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public async Task<ListBlackEmailAddressResponse> ListBlackEmailAddress(ListBlackEmailAddressRequest req)
        {
             JsonResponseModel<ListBlackEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListBlackEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListBlackEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 腾讯云发送的邮件一旦被收件方判断为硬退(Hard Bounce)，腾讯云会拉黑该地址，并不允许所有用户向该地址发送邮件。成为邮箱黑名单。如果业务方确认是误判，可以从黑名单中删除。
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public ListBlackEmailAddressResponse ListBlackEmailAddressSync(ListBlackEmailAddressRequest req)
        {
             JsonResponseModel<ListBlackEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListBlackEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListBlackEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取发信地址列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public async Task<ListEmailAddressResponse> ListEmailAddress(ListEmailAddressRequest req)
        {
             JsonResponseModel<ListEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取发信地址列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public ListEmailAddressResponse ListEmailAddressSync(ListEmailAddressRequest req)
        {
             JsonResponseModel<ListEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前发信域名列表，包含已验证通过与未验证的域名
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public async Task<ListEmailIdentitiesResponse> ListEmailIdentities(ListEmailIdentitiesRequest req)
        {
             JsonResponseModel<ListEmailIdentitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEmailIdentities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailIdentitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前发信域名列表，包含已验证通过与未验证的域名
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public ListEmailIdentitiesResponse ListEmailIdentitiesSync(ListEmailIdentitiesRequest req)
        {
             JsonResponseModel<ListEmailIdentitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEmailIdentities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailIdentitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前邮件模板列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public async Task<ListEmailTemplatesResponse> ListEmailTemplates(ListEmailTemplatesRequest req)
        {
             JsonResponseModel<ListEmailTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEmailTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前邮件模板列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public ListEmailTemplatesResponse ListEmailTemplatesSync(ListEmailTemplatesRequest req)
        {
             JsonResponseModel<ListEmailTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEmailTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 您可以通过此API发送TEXT或者HTML邮件，默认仅支持使用模板发送邮件，如需发送自定义内容，请单独联系商务开通此功能。
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public async Task<SendEmailResponse> SendEmail(SendEmailRequest req)
        {
             JsonResponseModel<SendEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 您可以通过此API发送TEXT或者HTML邮件，默认仅支持使用模板发送邮件，如需发送自定义内容，请单独联系商务开通此功能。
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public SendEmailResponse SendEmailSync(SendEmailRequest req)
        {
             JsonResponseModel<SendEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 您已经成功配置好了您的DNS，接下来请求腾讯云验证您的DNS配置是否正确
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public async Task<UpdateEmailIdentityResponse> UpdateEmailIdentity(UpdateEmailIdentityRequest req)
        {
             JsonResponseModel<UpdateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 您已经成功配置好了您的DNS，接下来请求腾讯云验证您的DNS配置是否正确
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public UpdateEmailIdentityResponse UpdateEmailIdentitySync(UpdateEmailIdentityRequest req)
        {
             JsonResponseModel<UpdateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新邮件模板，更新后需再次审核
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public async Task<UpdateEmailTemplateResponse> UpdateEmailTemplate(UpdateEmailTemplateRequest req)
        {
             JsonResponseModel<UpdateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新邮件模板，更新后需再次审核
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public UpdateEmailTemplateResponse UpdateEmailTemplateSync(UpdateEmailTemplateRequest req)
        {
             JsonResponseModel<UpdateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
