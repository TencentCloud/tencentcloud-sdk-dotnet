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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 检测验证码接口。此接口用于企业电子合同平台通过给用户发送短信验证码，以短信授权方式签署合同。此接口配合发送验证码接口使用。
        /// 
        /// 用户在企业电子合同平台输入收到的验证码后，由企业电子合同平台调用该接口向腾讯云提交确认受托签署合同验证码命令。验证码验证正确时，本次合同签署的授权成功。
        /// </summary>
        /// <param name="req"><see cref="CheckVcodeRequest"/></param>
        /// <returns><see cref="CheckVcodeResponse"/></returns>
        public async Task<CheckVcodeResponse> CheckVcode(CheckVcodeRequest req)
        {
             JsonResponseModel<CheckVcodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckVcode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckVcodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CheckVcode接口的同步版本，检测验证码接口。此接口用于企业电子合同平台通过给用户发送短信验证码，以短信授权方式签署合同。此接口配合发送验证码接口使用。
        /// 
        /// 用户在企业电子合同平台输入收到的验证码后，由企业电子合同平台调用该接口向腾讯云提交确认受托签署合同验证码命令。验证码验证正确时，本次合同签署的授权成功。
        /// </summary>
        /// <param name="req">参考<see cref="CheckVcodeRequest"/></param>
        /// <returns>参考<see cref="CheckVcodeResponse"/>实例</returns>
        public CheckVcodeResponse CheckVcodeSync(CheckVcodeRequest req)
        {
             JsonResponseModel<CheckVcodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckVcode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckVcodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口适用于：客户平台通过上传PDF文件作为合同，以备未来进行签署。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="CreateContractByUploadRequest"/></param>
        /// <returns><see cref="CreateContractByUploadResponse"/></returns>
        public async Task<CreateContractByUploadResponse> CreateContractByUpload(CreateContractByUploadRequest req)
        {
             JsonResponseModel<CreateContractByUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContractByUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContractByUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateContractByUpload接口的同步版本，此接口适用于：客户平台通过上传PDF文件作为合同，以备未来进行签署。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req">参考<see cref="CreateContractByUploadRequest"/></param>
        /// <returns>参考<see cref="CreateContractByUploadResponse"/>实例</returns>
        public CreateContractByUploadResponse CreateContractByUploadSync(CreateContractByUploadRequest req)
        {
             JsonResponseModel<CreateContractByUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateContractByUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContractByUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为企业电子合同平台的最终企业用户进行开户。在企业电子合同平台进行操作的企业用户，企业电子合同平台向腾讯云发送企业用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的企业用户生成一张数字证书。
        /// </summary>
        /// <param name="req"><see cref="CreateEnterpriseAccountRequest"/></param>
        /// <returns><see cref="CreateEnterpriseAccountResponse"/></returns>
        public async Task<CreateEnterpriseAccountResponse> CreateEnterpriseAccount(CreateEnterpriseAccountRequest req)
        {
             JsonResponseModel<CreateEnterpriseAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEnterpriseAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnterpriseAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateEnterpriseAccount接口的同步版本，为企业电子合同平台的最终企业用户进行开户。在企业电子合同平台进行操作的企业用户，企业电子合同平台向腾讯云发送企业用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的企业用户生成一张数字证书。
        /// </summary>
        /// <param name="req">参考<see cref="CreateEnterpriseAccountRequest"/></param>
        /// <returns>参考<see cref="CreateEnterpriseAccountResponse"/>实例</returns>
        public CreateEnterpriseAccountResponse CreateEnterpriseAccountSync(CreateEnterpriseAccountRequest req)
        {
             JsonResponseModel<CreateEnterpriseAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEnterpriseAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEnterpriseAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为企业电子合同平台的最终个人用户进行开户。在企业电子合同平台进行操作的个人用户，企业电子合同平台向腾讯云发送个人用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的个人用户生成一张数字证书。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonalAccountRequest"/></param>
        /// <returns><see cref="CreatePersonalAccountResponse"/></returns>
        public async Task<CreatePersonalAccountResponse> CreatePersonalAccount(CreatePersonalAccountRequest req)
        {
             JsonResponseModel<CreatePersonalAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePersonalAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonalAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreatePersonalAccount接口的同步版本，为企业电子合同平台的最终个人用户进行开户。在企业电子合同平台进行操作的个人用户，企业电子合同平台向腾讯云发送个人用户的信息，提交开户命令。腾讯云接到请求后，自动为企业电子合同平台的个人用户生成一张数字证书。
        /// </summary>
        /// <param name="req">参考<see cref="CreatePersonalAccountRequest"/></param>
        /// <returns>参考<see cref="CreatePersonalAccountResponse"/>实例</returns>
        public CreatePersonalAccountResponse CreatePersonalAccountSync(CreatePersonalAccountRequest req)
        {
             JsonResponseModel<CreatePersonalAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePersonalAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonalAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于客户电子合同平台增加某用户的印章图片。客户平台可以调用此接口增加某用户的印章图片。
        /// </summary>
        /// <param name="req"><see cref="CreateSealRequest"/></param>
        /// <returns><see cref="CreateSealResponse"/></returns>
        public async Task<CreateSealResponse> CreateSeal(CreateSealRequest req)
        {
             JsonResponseModel<CreateSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateSeal接口的同步版本，此接口用于客户电子合同平台增加某用户的印章图片。客户平台可以调用此接口增加某用户的印章图片。
        /// </summary>
        /// <param name="req">参考<see cref="CreateSealRequest"/></param>
        /// <returns>参考<see cref="CreateSealResponse"/>实例</returns>
        public CreateSealResponse CreateSealSync(CreateSealRequest req)
        {
             JsonResponseModel<CreateSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除企业电子合同平台的最终用户。调用该接口后，腾讯云将删除该用户账号。删除账号后，已经签名的合同不受影响。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public async Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
             JsonResponseModel<DeleteAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteAccount接口的同步版本，删除企业电子合同平台的最终用户。调用该接口后，腾讯云将删除该用户账号。删除账号后，已经签名的合同不受影响。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAccountRequest"/></param>
        /// <returns>参考<see cref="DeleteAccountResponse"/>实例</returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
             JsonResponseModel<DeleteAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除印章接口，删除指定账号的某个印章
        /// </summary>
        /// <param name="req"><see cref="DeleteSealRequest"/></param>
        /// <returns><see cref="DeleteSealResponse"/></returns>
        public async Task<DeleteSealResponse> DeleteSeal(DeleteSealRequest req)
        {
             JsonResponseModel<DeleteSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteSeal接口的同步版本，删除印章接口，删除指定账号的某个印章
        /// </summary>
        /// <param name="req">参考<see cref="DeleteSealRequest"/></param>
        /// <returns>参考<see cref="DeleteSealResponse"/>实例</returns>
        public DeleteSealResponse DeleteSealSync(DeleteSealRequest req)
        {
             JsonResponseModel<DeleteSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口使用于：客户平台可使用该接口查询任务执行状态或者执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeTaskStatusResponse"/></returns>
        public async Task<DescribeTaskStatusResponse> DescribeTaskStatus(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTaskStatus接口的同步版本，接口使用于：客户平台可使用该接口查询任务执行状态或者执行结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTaskStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeTaskStatusResponse"/>实例</returns>
        public DescribeTaskStatusResponse DescribeTaskStatusSync(DescribeTaskStatusRequest req)
        {
             JsonResponseModel<DescribeTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载合同接口。调用该接口可以下载签署中和签署完成的合同。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req"><see cref="DownloadContractRequest"/></param>
        /// <returns><see cref="DownloadContractResponse"/></returns>
        public async Task<DownloadContractResponse> DownloadContract(DownloadContractRequest req)
        {
             JsonResponseModel<DownloadContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DownloadContract接口的同步版本，下载合同接口。调用该接口可以下载签署中和签署完成的合同。接口返回任务号，可调用DescribeTaskStatus接口查看任务执行结果。
        /// </summary>
        /// <param name="req">参考<see cref="DownloadContractRequest"/></param>
        /// <returns>参考<see cref="DownloadContractResponse"/>实例</returns>
        public DownloadContractResponse DownloadContractSync(DownloadContractRequest req)
        {
             JsonResponseModel<DownloadContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送验证码接口。此接口用于：企业电子合同平台需要腾讯云发送验证码对其用户进行验证时调用，腾讯云将向其用户联系手机(企业电子合同平台为用户开户时通过接口传入)发送验证码，以验证码授权方式签署合同。用户验证工作由企业电子合同平台自身完成。
        /// </summary>
        /// <param name="req"><see cref="SendVcodeRequest"/></param>
        /// <returns><see cref="SendVcodeResponse"/></returns>
        public async Task<SendVcodeResponse> SendVcode(SendVcodeRequest req)
        {
             JsonResponseModel<SendVcodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendVcode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendVcodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SendVcode接口的同步版本，发送验证码接口。此接口用于：企业电子合同平台需要腾讯云发送验证码对其用户进行验证时调用，腾讯云将向其用户联系手机(企业电子合同平台为用户开户时通过接口传入)发送验证码，以验证码授权方式签署合同。用户验证工作由企业电子合同平台自身完成。
        /// </summary>
        /// <param name="req">参考<see cref="SendVcodeRequest"/></param>
        /// <returns>参考<see cref="SendVcodeResponse"/>实例</returns>
        public SendVcodeResponse SendVcodeSync(SendVcodeRequest req)
        {
             JsonResponseModel<SendVcodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendVcode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendVcodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口提供详细的PDF文档签名坐标进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignContractByCoordinateRequest"/></param>
        /// <returns><see cref="SignContractByCoordinateResponse"/></returns>
        public async Task<SignContractByCoordinateResponse> SignContractByCoordinate(SignContractByCoordinateRequest req)
        {
             JsonResponseModel<SignContractByCoordinateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SignContractByCoordinate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignContractByCoordinateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SignContractByCoordinate接口的同步版本，此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口提供详细的PDF文档签名坐标进行签署。
        /// </summary>
        /// <param name="req">参考<see cref="SignContractByCoordinateRequest"/></param>
        /// <returns>参考<see cref="SignContractByCoordinateResponse"/>实例</returns>
        public SignContractByCoordinateResponse SignContractByCoordinateSync(SignContractByCoordinateRequest req)
        {
             JsonResponseModel<SignContractByCoordinateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SignContractByCoordinate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignContractByCoordinateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口对PDF合同文档按照关键字和坐标进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignContractByKeywordRequest"/></param>
        /// <returns><see cref="SignContractByKeywordResponse"/></returns>
        public async Task<SignContractByKeywordResponse> SignContractByKeyword(SignContractByKeywordRequest req)
        {
             JsonResponseModel<SignContractByKeywordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SignContractByKeyword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignContractByKeywordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// SignContractByKeyword接口的同步版本，此接口适用于：客户平台在创建好合同后，由合同签署方对创建的合同内容进行确认，无误后再进行签署。客户平台使用该接口对PDF合同文档按照关键字和坐标进行签署。
        /// </summary>
        /// <param name="req">参考<see cref="SignContractByKeywordRequest"/></param>
        /// <returns>参考<see cref="SignContractByKeywordResponse"/>实例</returns>
        public SignContractByKeywordResponse SignContractByKeywordSync(SignContractByKeywordRequest req)
        {
             JsonResponseModel<SignContractByKeywordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SignContractByKeyword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignContractByKeywordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
