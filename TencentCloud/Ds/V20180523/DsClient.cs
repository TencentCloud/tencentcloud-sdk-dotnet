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

namespace TencentCloud.Ds.V20180523
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ds.V20180523.Models;

   public class DsClient : AbstractClient{

       private const string endpoint = "ds.tencentcloudapi.com";
       private const string version = "2018-05-23";
       private const string sdkVersion = "SDK_NET_3.0.1035";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 检测验证码接口。此接口用于企业电子合同平台通过给用户发送短信验证码，以短信授权方式签署合同。此接口配合发送验证码接口使用。
        /// 
        /// 用户在企业电子合同平台输入收到的验证码后，由企业电子合同平台调用该接口向腾讯云提交确认受托签署合同验证码命令。验证码验证正确时，本次合同签署的授权成功。
        /// </summary>
        /// <param name="req"><see cref="CheckVcodeRequest"/></param>
        /// <returns><see cref="CheckVcodeResponse"/></returns>
        public Task<CheckVcodeResponse> CheckVcode(CheckVcodeRequest req)
        {
            return InternalRequestAsync<CheckVcodeResponse>(req, "CheckVcode");
        }

        /// <summary>
        /// 检测验证码接口。此接口用于企业电子合同平台通过给用户发送短信验证码，以短信授权方式签署合同。此接口配合发送验证码接口使用。
        /// 
        /// 用户在企业电子合同平台输入收到的验证码后，由企业电子合同平台调用该接口向腾讯云提交确认受托签署合同验证码命令。验证码验证正确时，本次合同签署的授权成功。
        /// </summary>
        /// <param name="req"><see cref="CheckVcodeRequest"/></param>
        /// <returns><see cref="CheckVcodeResponse"/></returns>
        public CheckVcodeResponse CheckVcodeSync(CheckVcodeRequest req)
        {
            return InternalRequestAsync<CheckVcodeResponse>(req, "CheckVcode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口适用于：客户平台通过上传PDF文件作为合同，以备未来进行签署。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="CreateContractByUploadRequest"/></param>
        /// <returns><see cref="CreateContractByUploadResponse"/></returns>
        public Task<CreateContractByUploadResponse> CreateContractByUpload(CreateContractByUploadRequest req)
        {
            return InternalRequestAsync<CreateContractByUploadResponse>(req, "CreateContractByUpload");
        }

        /// <summary>
        /// 此接口适用于：客户平台通过上传PDF文件作为合同，以备未来进行签署。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="CreateContractByUploadRequest"/></param>
        /// <returns><see cref="CreateContractByUploadResponse"/></returns>
        public CreateContractByUploadResponse CreateContractByUploadSync(CreateContractByUploadRequest req)
        {
            return InternalRequestAsync<CreateContractByUploadResponse>(req, "CreateContractByUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为企业电子合同平台的最终企业用户进行开户。在企业电子合同平台进行操作的企业用户，企业电子合同平台向腾讯云发送企业用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的企业用户生成一张数字证书。
        /// </summary>
        /// <param name="req"><see cref="CreateEnterpriseAccountRequest"/></param>
        /// <returns><see cref="CreateEnterpriseAccountResponse"/></returns>
        public Task<CreateEnterpriseAccountResponse> CreateEnterpriseAccount(CreateEnterpriseAccountRequest req)
        {
            return InternalRequestAsync<CreateEnterpriseAccountResponse>(req, "CreateEnterpriseAccount");
        }

        /// <summary>
        /// 为企业电子合同平台的最终企业用户进行开户。在企业电子合同平台进行操作的企业用户，企业电子合同平台向腾讯云发送企业用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的企业用户生成一张数字证书。
        /// </summary>
        /// <param name="req"><see cref="CreateEnterpriseAccountRequest"/></param>
        /// <returns><see cref="CreateEnterpriseAccountResponse"/></returns>
        public CreateEnterpriseAccountResponse CreateEnterpriseAccountSync(CreateEnterpriseAccountRequest req)
        {
            return InternalRequestAsync<CreateEnterpriseAccountResponse>(req, "CreateEnterpriseAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为企业电子合同平台的最终个人用户进行开户。在企业电子合同平台进行操作的个人用户，企业电子合同平台向腾讯云发送个人用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的个人用户生成一张数字证书。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonalAccountRequest"/></param>
        /// <returns><see cref="CreatePersonalAccountResponse"/></returns>
        public Task<CreatePersonalAccountResponse> CreatePersonalAccount(CreatePersonalAccountRequest req)
        {
            return InternalRequestAsync<CreatePersonalAccountResponse>(req, "CreatePersonalAccount");
        }

        /// <summary>
        /// 为企业电子合同平台的最终个人用户进行开户。在企业电子合同平台进行操作的个人用户，企业电子合同平台向腾讯云发送个人用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的个人用户生成一张数字证书。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonalAccountRequest"/></param>
        /// <returns><see cref="CreatePersonalAccountResponse"/></returns>
        public CreatePersonalAccountResponse CreatePersonalAccountSync(CreatePersonalAccountRequest req)
        {
            return InternalRequestAsync<CreatePersonalAccountResponse>(req, "CreatePersonalAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于客户电子合同平台增加某用户的印章图片。客户平台可以调用此接口增加某用户的印章图片。
        /// </summary>
        /// <param name="req"><see cref="CreateSealRequest"/></param>
        /// <returns><see cref="CreateSealResponse"/></returns>
        public Task<CreateSealResponse> CreateSeal(CreateSealRequest req)
        {
            return InternalRequestAsync<CreateSealResponse>(req, "CreateSeal");
        }

        /// <summary>
        /// 此接口用于客户电子合同平台增加某用户的印章图片。客户平台可以调用此接口增加某用户的印章图片。
        /// </summary>
        /// <param name="req"><see cref="CreateSealRequest"/></param>
        /// <returns><see cref="CreateSealResponse"/></returns>
        public CreateSealResponse CreateSealSync(CreateSealRequest req)
        {
            return InternalRequestAsync<CreateSealResponse>(req, "CreateSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除企业电子合同平台的最终用户。调用该接口后，腾讯云将删除该用户账号。删除账号后，已经签名的合同不受影响。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount");
        }

        /// <summary>
        /// 删除企业电子合同平台的最终用户。调用该接口后，腾讯云将删除该用户账号。删除账号后，已经签名的合同不受影响。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除印章接口，删除指定账号的某个印章
        /// </summary>
        /// <param name="req"><see cref="DeleteSealRequest"/></param>
        /// <returns><see cref="DeleteSealResponse"/></returns>
        public Task<DeleteSealResponse> DeleteSeal(DeleteSealRequest req)
        {
            return InternalRequestAsync<DeleteSealResponse>(req, "DeleteSeal");
        }

        /// <summary>
        /// 删除印章接口，删除指定账号的某个印章
        /// </summary>
        /// <param name="req"><see cref="DeleteSealRequest"/></param>
        /// <returns><see cref="DeleteSealResponse"/></returns>
        public DeleteSealResponse DeleteSealSync(DeleteSealRequest req)
        {
            return InternalRequestAsync<DeleteSealResponse>(req, "DeleteSeal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口使用于：客户平台可使用该接口查询任务执行状态或者执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus");
        }

        /// <summary>
        /// 接口使用于：客户平台可使用该接口查询任务执行状态或者执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeTaskStatusResponse>(req, "DescribeTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载合同接口。调用该接口可以下载签署中和签署完成的合同。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="DownloadContractRequest"/></param>
        /// <returns><see cref="DownloadContractResponse"/></returns>
        public Task<DownloadContractResponse> DownloadContract(DownloadContractRequest req)
        {
            return InternalRequestAsync<DownloadContractResponse>(req, "DownloadContract");
        }

        /// <summary>
        /// 下载合同接口。调用该接口可以下载签署中和签署完成的合同。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="DownloadContractRequest"/></param>
        /// <returns><see cref="DownloadContractResponse"/></returns>
        public DownloadContractResponse DownloadContractSync(DownloadContractRequest req)
        {
            return InternalRequestAsync<DownloadContractResponse>(req, "DownloadContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送验证码接口。此接口用于：企业电子合同平台需要腾讯云发送验证码对其用户进行验证时调用，腾讯云将向其用户联系手机(企业电子合同平台为用户开户时通过接口传入)发送验证码，以验证码授权方式签署合同。用户验证工作由企业电子合同平台自身完成。
        /// </summary>
        /// <param name="req"><see cref="SendVcodeRequest"/></param>
        /// <returns><see cref="SendVcodeResponse"/></returns>
        public Task<SendVcodeResponse> SendVcode(SendVcodeRequest req)
        {
            return InternalRequestAsync<SendVcodeResponse>(req, "SendVcode");
        }

        /// <summary>
        /// 发送验证码接口。此接口用于：企业电子合同平台需要腾讯云发送验证码对其用户进行验证时调用，腾讯云将向其用户联系手机(企业电子合同平台为用户开户时通过接口传入)发送验证码，以验证码授权方式签署合同。用户验证工作由企业电子合同平台自身完成。
        /// </summary>
        /// <param name="req"><see cref="SendVcodeRequest"/></param>
        /// <returns><see cref="SendVcodeResponse"/></returns>
        public SendVcodeResponse SendVcodeSync(SendVcodeRequest req)
        {
            return InternalRequestAsync<SendVcodeResponse>(req, "SendVcode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口提供详细的PDF文档签名坐标进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignContractByCoordinateRequest"/></param>
        /// <returns><see cref="SignContractByCoordinateResponse"/></returns>
        public Task<SignContractByCoordinateResponse> SignContractByCoordinate(SignContractByCoordinateRequest req)
        {
            return InternalRequestAsync<SignContractByCoordinateResponse>(req, "SignContractByCoordinate");
        }

        /// <summary>
        /// 此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口提供详细的PDF文档签名坐标进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignContractByCoordinateRequest"/></param>
        /// <returns><see cref="SignContractByCoordinateResponse"/></returns>
        public SignContractByCoordinateResponse SignContractByCoordinateSync(SignContractByCoordinateRequest req)
        {
            return InternalRequestAsync<SignContractByCoordinateResponse>(req, "SignContractByCoordinate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口对PDF合同文档按照关键字和坐标进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignContractByKeywordRequest"/></param>
        /// <returns><see cref="SignContractByKeywordResponse"/></returns>
        public Task<SignContractByKeywordResponse> SignContractByKeyword(SignContractByKeywordRequest req)
        {
            return InternalRequestAsync<SignContractByKeywordResponse>(req, "SignContractByKeyword");
        }

        /// <summary>
        /// 此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口对PDF合同文档按照关键字和坐标进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignContractByKeywordRequest"/></param>
        /// <returns><see cref="SignContractByKeywordResponse"/></returns>
        public SignContractByKeywordResponse SignContractByKeywordSync(SignContractByKeywordRequest req)
        {
            return InternalRequestAsync<SignContractByKeywordResponse>(req, "SignContractByKeyword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
