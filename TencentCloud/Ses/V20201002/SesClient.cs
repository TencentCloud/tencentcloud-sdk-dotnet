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
       private const string sdkVersion = "SDK_NET_3.0.1201";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SesClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 您可以通过此API批量发送TEXT或者HTML邮件，适用于营销类、通知类邮件。默认仅支持使用模板发送邮件。批量发送之前，需先创建收件人列表，和收件人地址，并通过收件人列表id来进行发送。批量发送任务支持定时发送和周期重复发送，定时发送需传TimedParam，周期重复发送需传CycleParam
        /// </summary>
        /// <param name="req"><see cref="BatchSendEmailRequest"/></param>
        /// <returns><see cref="BatchSendEmailResponse"/></returns>
        public Task<BatchSendEmailResponse> BatchSendEmail(BatchSendEmailRequest req)
        {
            return InternalRequestAsync<BatchSendEmailResponse>(req, "BatchSendEmail");
        }

        /// <summary>
        /// 您可以通过此API批量发送TEXT或者HTML邮件，适用于营销类、通知类邮件。默认仅支持使用模板发送邮件。批量发送之前，需先创建收件人列表，和收件人地址，并通过收件人列表id来进行发送。批量发送任务支持定时发送和周期重复发送，定时发送需传TimedParam，周期重复发送需传CycleParam
        /// </summary>
        /// <param name="req"><see cref="BatchSendEmailRequest"/></param>
        /// <returns><see cref="BatchSendEmailResponse"/></returns>
        public BatchSendEmailResponse BatchSendEmailSync(BatchSendEmailRequest req)
        {
            return InternalRequestAsync<BatchSendEmailResponse>(req, "BatchSendEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加自定义黑名单
        /// </summary>
        /// <param name="req"><see cref="CreateCustomBlacklistRequest"/></param>
        /// <returns><see cref="CreateCustomBlacklistResponse"/></returns>
        public Task<CreateCustomBlacklistResponse> CreateCustomBlacklist(CreateCustomBlacklistRequest req)
        {
            return InternalRequestAsync<CreateCustomBlacklistResponse>(req, "CreateCustomBlacklist");
        }

        /// <summary>
        /// 添加自定义黑名单
        /// </summary>
        /// <param name="req"><see cref="CreateCustomBlacklistRequest"/></param>
        /// <returns><see cref="CreateCustomBlacklistResponse"/></returns>
        public CreateCustomBlacklistResponse CreateCustomBlacklistSync(CreateCustomBlacklistRequest req)
        {
            return InternalRequestAsync<CreateCustomBlacklistResponse>(req, "CreateCustomBlacklist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在验证了发信域名之后，您需要一个发信地址来发送邮件。例如发信域名是mail.qcloud.com，那么发信地址可以为 service@mail.qcloud.com。如果您想要收件人在收件箱列表中显示您的别名，例如"腾讯云邮件通知"。那么发信地址为： 别名 空格 尖括号 邮箱地址。请注意中间需要有空格
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public Task<CreateEmailAddressResponse> CreateEmailAddress(CreateEmailAddressRequest req)
        {
            return InternalRequestAsync<CreateEmailAddressResponse>(req, "CreateEmailAddress");
        }

        /// <summary>
        /// 在验证了发信域名之后，您需要一个发信地址来发送邮件。例如发信域名是mail.qcloud.com，那么发信地址可以为 service@mail.qcloud.com。如果您想要收件人在收件箱列表中显示您的别名，例如"腾讯云邮件通知"。那么发信地址为： 别名 空格 尖括号 邮箱地址。请注意中间需要有空格
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public CreateEmailAddressResponse CreateEmailAddressSync(CreateEmailAddressRequest req)
        {
            return InternalRequestAsync<CreateEmailAddressResponse>(req, "CreateEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在使用身份发送电子邮件之前，您需要有一个电子邮件域名，该域名可以是您的网站或者移动应用的域名。您首先必须进行验证，证明自己是该域名的所有者，并且授权给腾讯云SES发送许可，才可以从该域名发送电子邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public Task<CreateEmailIdentityResponse> CreateEmailIdentity(CreateEmailIdentityRequest req)
        {
            return InternalRequestAsync<CreateEmailIdentityResponse>(req, "CreateEmailIdentity");
        }

        /// <summary>
        /// 在使用身份发送电子邮件之前，您需要有一个电子邮件域名，该域名可以是您的网站或者移动应用的域名。您首先必须进行验证，证明自己是该域名的所有者，并且授权给腾讯云SES发送许可，才可以从该域名发送电子邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public CreateEmailIdentityResponse CreateEmailIdentitySync(CreateEmailIdentityRequest req)
        {
            return InternalRequestAsync<CreateEmailIdentityResponse>(req, "CreateEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建模板，该模板可以是TXT或者HTML，请注意如果HTML不要包含外部文件的CSS。模板中的变量使用 {{变量名}} 表示。
        /// 注意：模板需要审核通过才可以使用。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public Task<CreateEmailTemplateResponse> CreateEmailTemplate(CreateEmailTemplateRequest req)
        {
            return InternalRequestAsync<CreateEmailTemplateResponse>(req, "CreateEmailTemplate");
        }

        /// <summary>
        /// 创建模板，该模板可以是TXT或者HTML，请注意如果HTML不要包含外部文件的CSS。模板中的变量使用 {{变量名}} 表示。
        /// 注意：模板需要审核通过才可以使用。
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public CreateEmailTemplateResponse CreateEmailTemplateSync(CreateEmailTemplateRequest req)
        {
            return InternalRequestAsync<CreateEmailTemplateResponse>(req, "CreateEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建收件人列表，收件人列表是发送批量邮件的目标邮件地址列表。创建列表后，需要上传收件人邮箱地址。之后创建发送任务，关联列表，便可以实现批量发送邮件的功能
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverRequest"/></param>
        /// <returns><see cref="CreateReceiverResponse"/></returns>
        public Task<CreateReceiverResponse> CreateReceiver(CreateReceiverRequest req)
        {
            return InternalRequestAsync<CreateReceiverResponse>(req, "CreateReceiver");
        }

        /// <summary>
        /// 创建收件人列表，收件人列表是发送批量邮件的目标邮件地址列表。创建列表后，需要上传收件人邮箱地址。之后创建发送任务，关联列表，便可以实现批量发送邮件的功能
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverRequest"/></param>
        /// <returns><see cref="CreateReceiverResponse"/></returns>
        public CreateReceiverResponse CreateReceiverSync(CreateReceiverRequest req)
        {
            return InternalRequestAsync<CreateReceiverResponse>(req, "CreateReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在创建完收件人列表后，向这个收件人列表中批量增加收件人邮箱地址，一次最大支持2万，异步完成处理。数据量比较大的时候，上传可能需要一点时间，可以通过查询收件人列表了解上传状态和上传数量。本接口与接口CreateReceiverDetailWithData的功能特性基本一致，只是不支持上传发信时的模板参数。用户首先调用创建收件人列表接口-CreateReceiver后，然后调用本接口传入收件人地址，最后使用批量发送邮件接口-BatchSendEmail，即可完成批量发信。本接口也支持追加收件人地址，也不支持去重，需要用户自己保证收件人地址不重复。本接口一次请求的收件人地址数量限制为2W条，但收件人列表中收件人地址的总量不能超过一定的数量，目前是限制5万条。
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailResponse"/></returns>
        public Task<CreateReceiverDetailResponse> CreateReceiverDetail(CreateReceiverDetailRequest req)
        {
            return InternalRequestAsync<CreateReceiverDetailResponse>(req, "CreateReceiverDetail");
        }

        /// <summary>
        /// 在创建完收件人列表后，向这个收件人列表中批量增加收件人邮箱地址，一次最大支持2万，异步完成处理。数据量比较大的时候，上传可能需要一点时间，可以通过查询收件人列表了解上传状态和上传数量。本接口与接口CreateReceiverDetailWithData的功能特性基本一致，只是不支持上传发信时的模板参数。用户首先调用创建收件人列表接口-CreateReceiver后，然后调用本接口传入收件人地址，最后使用批量发送邮件接口-BatchSendEmail，即可完成批量发信。本接口也支持追加收件人地址，也不支持去重，需要用户自己保证收件人地址不重复。本接口一次请求的收件人地址数量限制为2W条，但收件人列表中收件人地址的总量不能超过一定的数量，目前是限制5万条。
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailResponse"/></returns>
        public CreateReceiverDetailResponse CreateReceiverDetailSync(CreateReceiverDetailRequest req)
        {
            return InternalRequestAsync<CreateReceiverDetailResponse>(req, "CreateReceiverDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加收件人地址附带模板参数，使用本接口在添加收件人地址的同时传入模板参数，使每一个收件人地址在发信的时候使用的模板变量取值不同。用户首先调用创建收件人列表接口-CreateReceiver后，然后调用本接口传入收件人地址和发信时的模板参数，最后使用批量发送邮件接口-BatchSendEmail，即可完成批量发信。需要注意的是在使用本接口后BatchSendEmail接口中的Template参数不需再传。用户也可以在控制台上邮件发送-收件人列表菜单中，通过导入文件的方式，导入收件人地址和模板变量和参数值。本接口一次请求的收件人地址数量限制为2W条，本接口同时也可以用来向已经上传完成的收件人列表追加收件人地址，但收件人列表中收件人地址的总量不能超过一定的数量，目前是限制5万条。本接口不支持去除重复的收件人地址，用户需要自己保证上传和追加地址不重复，不与之前上传的地址重复。
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailWithDataRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailWithDataResponse"/></returns>
        public Task<CreateReceiverDetailWithDataResponse> CreateReceiverDetailWithData(CreateReceiverDetailWithDataRequest req)
        {
            return InternalRequestAsync<CreateReceiverDetailWithDataResponse>(req, "CreateReceiverDetailWithData");
        }

        /// <summary>
        /// 添加收件人地址附带模板参数，使用本接口在添加收件人地址的同时传入模板参数，使每一个收件人地址在发信的时候使用的模板变量取值不同。用户首先调用创建收件人列表接口-CreateReceiver后，然后调用本接口传入收件人地址和发信时的模板参数，最后使用批量发送邮件接口-BatchSendEmail，即可完成批量发信。需要注意的是在使用本接口后BatchSendEmail接口中的Template参数不需再传。用户也可以在控制台上邮件发送-收件人列表菜单中，通过导入文件的方式，导入收件人地址和模板变量和参数值。本接口一次请求的收件人地址数量限制为2W条，本接口同时也可以用来向已经上传完成的收件人列表追加收件人地址，但收件人列表中收件人地址的总量不能超过一定的数量，目前是限制5万条。本接口不支持去除重复的收件人地址，用户需要自己保证上传和追加地址不重复，不与之前上传的地址重复。
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailWithDataRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailWithDataResponse"/></returns>
        public CreateReceiverDetailWithDataResponse CreateReceiverDetailWithDataSync(CreateReceiverDetailWithDataRequest req)
        {
            return InternalRequestAsync<CreateReceiverDetailWithDataResponse>(req, "CreateReceiverDetailWithData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 邮箱被拉黑之后，用户如果确认收件邮箱有效或者已经处于激活状态，可以从腾讯云地址库中删除该黑名单之后继续投递。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public Task<DeleteBlackListResponse> DeleteBlackList(DeleteBlackListRequest req)
        {
            return InternalRequestAsync<DeleteBlackListResponse>(req, "DeleteBlackList");
        }

        /// <summary>
        /// 邮箱被拉黑之后，用户如果确认收件邮箱有效或者已经处于激活状态，可以从腾讯云地址库中删除该黑名单之后继续投递。
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public DeleteBlackListResponse DeleteBlackListSync(DeleteBlackListRequest req)
        {
            return InternalRequestAsync<DeleteBlackListResponse>(req, "DeleteBlackList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自定义黑名单邮箱地址
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomBlackListRequest"/></param>
        /// <returns><see cref="DeleteCustomBlackListResponse"/></returns>
        public Task<DeleteCustomBlackListResponse> DeleteCustomBlackList(DeleteCustomBlackListRequest req)
        {
            return InternalRequestAsync<DeleteCustomBlackListResponse>(req, "DeleteCustomBlackList");
        }

        /// <summary>
        /// 删除自定义黑名单邮箱地址
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomBlackListRequest"/></param>
        /// <returns><see cref="DeleteCustomBlackListResponse"/></returns>
        public DeleteCustomBlackListResponse DeleteCustomBlackListSync(DeleteCustomBlackListRequest req)
        {
            return InternalRequestAsync<DeleteCustomBlackListResponse>(req, "DeleteCustomBlackList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除发信人地址
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public Task<DeleteEmailAddressResponse> DeleteEmailAddress(DeleteEmailAddressRequest req)
        {
            return InternalRequestAsync<DeleteEmailAddressResponse>(req, "DeleteEmailAddress");
        }

        /// <summary>
        /// 删除发信人地址
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public DeleteEmailAddressResponse DeleteEmailAddressSync(DeleteEmailAddressRequest req)
        {
            return InternalRequestAsync<DeleteEmailAddressResponse>(req, "DeleteEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除发信域名，删除后，将不可再使用该域名进行发信
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public Task<DeleteEmailIdentityResponse> DeleteEmailIdentity(DeleteEmailIdentityRequest req)
        {
            return InternalRequestAsync<DeleteEmailIdentityResponse>(req, "DeleteEmailIdentity");
        }

        /// <summary>
        /// 删除发信域名，删除后，将不可再使用该域名进行发信
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public DeleteEmailIdentityResponse DeleteEmailIdentitySync(DeleteEmailIdentityRequest req)
        {
            return InternalRequestAsync<DeleteEmailIdentityResponse>(req, "DeleteEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除发信模板
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public Task<DeleteEmailTemplateResponse> DeleteEmailTemplate(DeleteEmailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEmailTemplateResponse>(req, "DeleteEmailTemplate");
        }

        /// <summary>
        /// 删除发信模板
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public DeleteEmailTemplateResponse DeleteEmailTemplateSync(DeleteEmailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEmailTemplateResponse>(req, "DeleteEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据收件id删除收件人列表,同时删除列表中的所有收件邮箱
        /// </summary>
        /// <param name="req"><see cref="DeleteReceiverRequest"/></param>
        /// <returns><see cref="DeleteReceiverResponse"/></returns>
        public Task<DeleteReceiverResponse> DeleteReceiver(DeleteReceiverRequest req)
        {
            return InternalRequestAsync<DeleteReceiverResponse>(req, "DeleteReceiver");
        }

        /// <summary>
        /// 根据收件id删除收件人列表,同时删除列表中的所有收件邮箱
        /// </summary>
        /// <param name="req"><see cref="DeleteReceiverRequest"/></param>
        /// <returns><see cref="DeleteReceiverResponse"/></returns>
        public DeleteReceiverResponse DeleteReceiverSync(DeleteReceiverRequest req)
        {
            return InternalRequestAsync<DeleteReceiverResponse>(req, "DeleteReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某个发信域名的配置详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public Task<GetEmailIdentityResponse> GetEmailIdentity(GetEmailIdentityRequest req)
        {
            return InternalRequestAsync<GetEmailIdentityResponse>(req, "GetEmailIdentity");
        }

        /// <summary>
        /// 获取某个发信域名的配置详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public GetEmailIdentityResponse GetEmailIdentitySync(GetEmailIdentityRequest req)
        {
            return InternalRequestAsync<GetEmailIdentityResponse>(req, "GetEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据模板ID获取模板详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public Task<GetEmailTemplateResponse> GetEmailTemplate(GetEmailTemplateRequest req)
        {
            return InternalRequestAsync<GetEmailTemplateResponse>(req, "GetEmailTemplate");
        }

        /// <summary>
        /// 根据模板ID获取模板详情
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public GetEmailTemplateResponse GetEmailTemplateSync(GetEmailTemplateRequest req)
        {
            return InternalRequestAsync<GetEmailTemplateResponse>(req, "GetEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取邮件发送状态。仅支持查询30天之内的数据
        /// </summary>
        /// <param name="req"><see cref="GetSendEmailStatusRequest"/></param>
        /// <returns><see cref="GetSendEmailStatusResponse"/></returns>
        public Task<GetSendEmailStatusResponse> GetSendEmailStatus(GetSendEmailStatusRequest req)
        {
            return InternalRequestAsync<GetSendEmailStatusResponse>(req, "GetSendEmailStatus");
        }

        /// <summary>
        /// 获取邮件发送状态。仅支持查询30天之内的数据
        /// </summary>
        /// <param name="req"><see cref="GetSendEmailStatusRequest"/></param>
        /// <returns><see cref="GetSendEmailStatusResponse"/></returns>
        public GetSendEmailStatusResponse GetSendEmailStatusSync(GetSendEmailStatusRequest req)
        {
            return InternalRequestAsync<GetSendEmailStatusResponse>(req, "GetSendEmailStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取近期发送的统计情况，包含发送量、送达率、打开率、退信率等一系列数据。
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public Task<GetStatisticsReportResponse> GetStatisticsReport(GetStatisticsReportRequest req)
        {
            return InternalRequestAsync<GetStatisticsReportResponse>(req, "GetStatisticsReport");
        }

        /// <summary>
        /// 获取近期发送的统计情况，包含发送量、送达率、打开率、退信率等一系列数据。
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public GetStatisticsReportResponse GetStatisticsReportSync(GetStatisticsReportRequest req)
        {
            return InternalRequestAsync<GetStatisticsReportResponse>(req, "GetStatisticsReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云发送的邮件一旦被收件方判断为硬退(Hard Bounce)，腾讯云会拉黑该地址，并不允许所有用户向该地址发送邮件。成为邮箱黑名单。如果业务方确认是误判，可以从黑名单中删除。
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public Task<ListBlackEmailAddressResponse> ListBlackEmailAddress(ListBlackEmailAddressRequest req)
        {
            return InternalRequestAsync<ListBlackEmailAddressResponse>(req, "ListBlackEmailAddress");
        }

        /// <summary>
        /// 腾讯云发送的邮件一旦被收件方判断为硬退(Hard Bounce)，腾讯云会拉黑该地址，并不允许所有用户向该地址发送邮件。成为邮箱黑名单。如果业务方确认是误判，可以从黑名单中删除。
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public ListBlackEmailAddressResponse ListBlackEmailAddressSync(ListBlackEmailAddressRequest req)
        {
            return InternalRequestAsync<ListBlackEmailAddressResponse>(req, "ListBlackEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取自定义黑名单列表
        /// </summary>
        /// <param name="req"><see cref="ListCustomBlacklistRequest"/></param>
        /// <returns><see cref="ListCustomBlacklistResponse"/></returns>
        public Task<ListCustomBlacklistResponse> ListCustomBlacklist(ListCustomBlacklistRequest req)
        {
            return InternalRequestAsync<ListCustomBlacklistResponse>(req, "ListCustomBlacklist");
        }

        /// <summary>
        /// 获取自定义黑名单列表
        /// </summary>
        /// <param name="req"><see cref="ListCustomBlacklistRequest"/></param>
        /// <returns><see cref="ListCustomBlacklistResponse"/></returns>
        public ListCustomBlacklistResponse ListCustomBlacklistSync(ListCustomBlacklistRequest req)
        {
            return InternalRequestAsync<ListCustomBlacklistResponse>(req, "ListCustomBlacklist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取发信地址列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public Task<ListEmailAddressResponse> ListEmailAddress(ListEmailAddressRequest req)
        {
            return InternalRequestAsync<ListEmailAddressResponse>(req, "ListEmailAddress");
        }

        /// <summary>
        /// 获取发信地址列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public ListEmailAddressResponse ListEmailAddressSync(ListEmailAddressRequest req)
        {
            return InternalRequestAsync<ListEmailAddressResponse>(req, "ListEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前发信域名列表，包含已验证通过与未验证的域名
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public Task<ListEmailIdentitiesResponse> ListEmailIdentities(ListEmailIdentitiesRequest req)
        {
            return InternalRequestAsync<ListEmailIdentitiesResponse>(req, "ListEmailIdentities");
        }

        /// <summary>
        /// 获取当前发信域名列表，包含已验证通过与未验证的域名
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public ListEmailIdentitiesResponse ListEmailIdentitiesSync(ListEmailIdentitiesRequest req)
        {
            return InternalRequestAsync<ListEmailIdentitiesResponse>(req, "ListEmailIdentities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前邮件模板列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public Task<ListEmailTemplatesResponse> ListEmailTemplates(ListEmailTemplatesRequest req)
        {
            return InternalRequestAsync<ListEmailTemplatesResponse>(req, "ListEmailTemplates");
        }

        /// <summary>
        /// 获取当前邮件模板列表
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public ListEmailTemplatesResponse ListEmailTemplatesSync(ListEmailTemplatesRequest req)
        {
            return InternalRequestAsync<ListEmailTemplatesResponse>(req, "ListEmailTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据收件人列表id查询收件人列表中的所有收件人邮箱地址，分页查询，可以根据收件邮箱地址来过滤查询
        /// </summary>
        /// <param name="req"><see cref="ListReceiverDetailsRequest"/></param>
        /// <returns><see cref="ListReceiverDetailsResponse"/></returns>
        public Task<ListReceiverDetailsResponse> ListReceiverDetails(ListReceiverDetailsRequest req)
        {
            return InternalRequestAsync<ListReceiverDetailsResponse>(req, "ListReceiverDetails");
        }

        /// <summary>
        /// 根据收件人列表id查询收件人列表中的所有收件人邮箱地址，分页查询，可以根据收件邮箱地址来过滤查询
        /// </summary>
        /// <param name="req"><see cref="ListReceiverDetailsRequest"/></param>
        /// <returns><see cref="ListReceiverDetailsResponse"/></returns>
        public ListReceiverDetailsResponse ListReceiverDetailsSync(ListReceiverDetailsRequest req)
        {
            return InternalRequestAsync<ListReceiverDetailsResponse>(req, "ListReceiverDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据条件查询收件人列表，支持分页，模糊查询，状态查询
        /// </summary>
        /// <param name="req"><see cref="ListReceiversRequest"/></param>
        /// <returns><see cref="ListReceiversResponse"/></returns>
        public Task<ListReceiversResponse> ListReceivers(ListReceiversRequest req)
        {
            return InternalRequestAsync<ListReceiversResponse>(req, "ListReceivers");
        }

        /// <summary>
        /// 根据条件查询收件人列表，支持分页，模糊查询，状态查询
        /// </summary>
        /// <param name="req"><see cref="ListReceiversRequest"/></param>
        /// <returns><see cref="ListReceiversResponse"/></returns>
        public ListReceiversResponse ListReceiversSync(ListReceiversRequest req)
        {
            return InternalRequestAsync<ListReceiversResponse>(req, "ListReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询批量发送邮件任务，包含即时发送任务，定时发送任务，周期重复发送任务，查询发送情况，包括请求数量，已发数量，缓存数量，任务状态等信息
        /// </summary>
        /// <param name="req"><see cref="ListSendTasksRequest"/></param>
        /// <returns><see cref="ListSendTasksResponse"/></returns>
        public Task<ListSendTasksResponse> ListSendTasks(ListSendTasksRequest req)
        {
            return InternalRequestAsync<ListSendTasksResponse>(req, "ListSendTasks");
        }

        /// <summary>
        /// 分页查询批量发送邮件任务，包含即时发送任务，定时发送任务，周期重复发送任务，查询发送情况，包括请求数量，已发数量，缓存数量，任务状态等信息
        /// </summary>
        /// <param name="req"><see cref="ListSendTasksRequest"/></param>
        /// <returns><see cref="ListSendTasksResponse"/></returns>
        public ListSendTasksResponse ListSendTasksSync(ListSendTasksRequest req)
        {
            return InternalRequestAsync<ListSendTasksResponse>(req, "ListSendTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您可以通过此API发送HTML或者TEXT邮件，适用于触发类邮件（验证码、交易类）。默认仅支持使用模板发送邮件。
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public Task<SendEmailResponse> SendEmail(SendEmailRequest req)
        {
            return InternalRequestAsync<SendEmailResponse>(req, "SendEmail");
        }

        /// <summary>
        /// 您可以通过此API发送HTML或者TEXT邮件，适用于触发类邮件（验证码、交易类）。默认仅支持使用模板发送邮件。
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public SendEmailResponse SendEmailSync(SendEmailRequest req)
        {
            return InternalRequestAsync<SendEmailResponse>(req, "SendEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新自定义黑名单
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomBlackListRequest"/></param>
        /// <returns><see cref="UpdateCustomBlackListResponse"/></returns>
        public Task<UpdateCustomBlackListResponse> UpdateCustomBlackList(UpdateCustomBlackListRequest req)
        {
            return InternalRequestAsync<UpdateCustomBlackListResponse>(req, "UpdateCustomBlackList");
        }

        /// <summary>
        /// 更新自定义黑名单
        /// </summary>
        /// <param name="req"><see cref="UpdateCustomBlackListRequest"/></param>
        /// <returns><see cref="UpdateCustomBlackListResponse"/></returns>
        public UpdateCustomBlackListResponse UpdateCustomBlackListSync(UpdateCustomBlackListRequest req)
        {
            return InternalRequestAsync<UpdateCustomBlackListResponse>(req, "UpdateCustomBlackList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 您已经成功配置好了您的DNS，接下来请求腾讯云验证您的DNS配置是否正确
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public Task<UpdateEmailIdentityResponse> UpdateEmailIdentity(UpdateEmailIdentityRequest req)
        {
            return InternalRequestAsync<UpdateEmailIdentityResponse>(req, "UpdateEmailIdentity");
        }

        /// <summary>
        /// 您已经成功配置好了您的DNS，接下来请求腾讯云验证您的DNS配置是否正确
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public UpdateEmailIdentityResponse UpdateEmailIdentitySync(UpdateEmailIdentityRequest req)
        {
            return InternalRequestAsync<UpdateEmailIdentityResponse>(req, "UpdateEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置邮箱的smtp密码。若要通过smtp发送邮件，必须为邮箱设置smtp密码。初始时，邮箱没有设置smtp密码，不能使用smtp的方式发送邮件。设置smtp密码后，可以修改密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailSmtpPassWordRequest"/></param>
        /// <returns><see cref="UpdateEmailSmtpPassWordResponse"/></returns>
        public Task<UpdateEmailSmtpPassWordResponse> UpdateEmailSmtpPassWord(UpdateEmailSmtpPassWordRequest req)
        {
            return InternalRequestAsync<UpdateEmailSmtpPassWordResponse>(req, "UpdateEmailSmtpPassWord");
        }

        /// <summary>
        /// 设置邮箱的smtp密码。若要通过smtp发送邮件，必须为邮箱设置smtp密码。初始时，邮箱没有设置smtp密码，不能使用smtp的方式发送邮件。设置smtp密码后，可以修改密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailSmtpPassWordRequest"/></param>
        /// <returns><see cref="UpdateEmailSmtpPassWordResponse"/></returns>
        public UpdateEmailSmtpPassWordResponse UpdateEmailSmtpPassWordSync(UpdateEmailSmtpPassWordRequest req)
        {
            return InternalRequestAsync<UpdateEmailSmtpPassWordResponse>(req, "UpdateEmailSmtpPassWord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新邮件模板，更新后需再次审核
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public Task<UpdateEmailTemplateResponse> UpdateEmailTemplate(UpdateEmailTemplateRequest req)
        {
            return InternalRequestAsync<UpdateEmailTemplateResponse>(req, "UpdateEmailTemplate");
        }

        /// <summary>
        /// 更新邮件模板，更新后需再次审核
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public UpdateEmailTemplateResponse UpdateEmailTemplateSync(UpdateEmailTemplateRequest req)
        {
            return InternalRequestAsync<UpdateEmailTemplateResponse>(req, "UpdateEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
