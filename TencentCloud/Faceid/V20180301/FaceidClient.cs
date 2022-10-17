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

namespace TencentCloud.Faceid.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Faceid.V20180301.Models;

   public class FaceidClient : AbstractClient{

       private const string endpoint = "faceid.tencentcloudapi.com";
       private const string version = "2018-03-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FaceidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 每次调用活体服务前，需要先调用本接口获取Token，需要保存此Token用来发起核验流程，并且在核验完成后获取结果信息。
        /// </summary>
        /// <param name="req"><see cref="ApplyLivenessTokenRequest"/></param>
        /// <returns><see cref="ApplyLivenessTokenResponse"/></returns>
        public async Task<ApplyLivenessTokenResponse> ApplyLivenessToken(ApplyLivenessTokenRequest req)
        {
             JsonResponseModel<ApplyLivenessTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyLivenessToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyLivenessTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用活体服务前，需要先调用本接口获取Token，需要保存此Token用来发起核验流程，并且在核验完成后获取结果信息。
        /// </summary>
        /// <param name="req"><see cref="ApplyLivenessTokenRequest"/></param>
        /// <returns><see cref="ApplyLivenessTokenResponse"/></returns>
        public ApplyLivenessTokenResponse ApplyLivenessTokenSync(ApplyLivenessTokenRequest req)
        {
             JsonResponseModel<ApplyLivenessTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyLivenessToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyLivenessTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用Web核验服务前，需要先调用本接口获取Token，需要保存此Token用来发起核验流程，并且在核验完成后获取结果信息。
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public async Task<ApplySdkVerificationTokenResponse> ApplySdkVerificationToken(ApplySdkVerificationTokenRequest req)
        {
             JsonResponseModel<ApplySdkVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplySdkVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySdkVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用Web核验服务前，需要先调用本接口获取Token，需要保存此Token用来发起核验流程，并且在核验完成后获取结果信息。
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public ApplySdkVerificationTokenResponse ApplySdkVerificationTokenSync(ApplySdkVerificationTokenRequest req)
        {
             JsonResponseModel<ApplySdkVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplySdkVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySdkVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用Web核验服务前，需要先调用本接口获取BizToken，需要保存此BizToken用来发起核验流程，并且在核验完成后获取结果信息。
        /// </summary>
        /// <param name="req"><see cref="ApplyWebVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplyWebVerificationTokenResponse"/></returns>
        public async Task<ApplyWebVerificationTokenResponse> ApplyWebVerificationToken(ApplyWebVerificationTokenRequest req)
        {
             JsonResponseModel<ApplyWebVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyWebVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyWebVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用Web核验服务前，需要先调用本接口获取BizToken，需要保存此BizToken用来发起核验流程，并且在核验完成后获取结果信息。
        /// </summary>
        /// <param name="req"><see cref="ApplyWebVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplyWebVerificationTokenResponse"/></returns>
        public ApplyWebVerificationTokenResponse ApplyWebVerificationTokenSync(ApplyWebVerificationTokenRequest req)
        {
             JsonResponseModel<ApplyWebVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyWebVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyWebVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名和银行卡号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public async Task<BankCard2EVerificationResponse> BankCard2EVerification(BankCard2EVerificationRequest req)
        {
             JsonResponseModel<BankCard2EVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCard2EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard2EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名和银行卡号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public BankCard2EVerificationResponse BankCard2EVerificationSync(BankCard2EVerificationRequest req)
        {
             JsonResponseModel<BankCard2EVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCard2EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard2EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于输入银行卡号、姓名、开户证件号、开户手机号，校验信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public async Task<BankCard4EVerificationResponse> BankCard4EVerification(BankCard4EVerificationRequest req)
        {
             JsonResponseModel<BankCard4EVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCard4EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard4EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于输入银行卡号、姓名、开户证件号、开户手机号，校验信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public BankCard4EVerificationResponse BankCard4EVerificationSync(BankCard4EVerificationRequest req)
        {
             JsonResponseModel<BankCard4EVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCard4EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCard4EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于银行卡号、姓名、开户证件号信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
        public async Task<BankCardVerificationResponse> BankCardVerification(BankCardVerificationRequest req)
        {
             JsonResponseModel<BankCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BankCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于银行卡号、姓名、开户证件号信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
        public BankCardVerificationResponse BankCardVerificationSync(BankCardVerificationRequest req)
        {
             JsonResponseModel<BankCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BankCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BankCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 银行卡基础信息查询
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public async Task<CheckBankCardInformationResponse> CheckBankCardInformation(CheckBankCardInformationRequest req)
        {
             JsonResponseModel<CheckBankCardInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBankCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 银行卡基础信息查询
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public CheckBankCardInformationResponse CheckBankCardInformationSync(CheckBankCardInformationRequest req)
        {
             JsonResponseModel<CheckBankCardInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBankCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于轮询E证通H5场景EidToken验证状态。
        /// </summary>
        /// <param name="req"><see cref="CheckEidTokenStatusRequest"/></param>
        /// <returns><see cref="CheckEidTokenStatusResponse"/></returns>
        public async Task<CheckEidTokenStatusResponse> CheckEidTokenStatus(CheckEidTokenStatusRequest req)
        {
             JsonResponseModel<CheckEidTokenStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckEidTokenStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckEidTokenStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于轮询E证通H5场景EidToken验证状态。
        /// </summary>
        /// <param name="req"><see cref="CheckEidTokenStatusRequest"/></param>
        /// <returns><see cref="CheckEidTokenStatusResponse"/></returns>
        public CheckEidTokenStatusResponse CheckEidTokenStatusSync(CheckEidTokenStatusRequest req)
        {
             JsonResponseModel<CheckEidTokenStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckEidTokenStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckEidTokenStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入身份证人像面照片，识别身份证照片上的信息，并将姓名、身份证号、身份证人像照片与权威库的证件照进行比对，是否属于同一个人，从而验证身份证信息的真实性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardInformationRequest"/></param>
        /// <returns><see cref="CheckIdCardInformationResponse"/></returns>
        public async Task<CheckIdCardInformationResponse> CheckIdCardInformation(CheckIdCardInformationRequest req)
        {
             JsonResponseModel<CheckIdCardInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIdCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入身份证人像面照片，识别身份证照片上的信息，并将姓名、身份证号、身份证人像照片与权威库的证件照进行比对，是否属于同一个人，从而验证身份证信息的真实性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardInformationRequest"/></param>
        /// <returns><see cref="CheckIdCardInformationResponse"/></returns>
        public CheckIdCardInformationResponse CheckIdCardInformationSync(CheckIdCardInformationRequest req)
        {
             JsonResponseModel<CheckIdCardInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIdCardInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdCardInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名、身份证号、身份证有效期的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdNameDateRequest"/></param>
        /// <returns><see cref="CheckIdNameDateResponse"/></returns>
        public async Task<CheckIdNameDateResponse> CheckIdNameDate(CheckIdNameDateRequest req)
        {
             JsonResponseModel<CheckIdNameDateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIdNameDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdNameDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名、身份证号、身份证有效期的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdNameDateRequest"/></param>
        /// <returns><see cref="CheckIdNameDateResponse"/></returns>
        public CheckIdNameDateResponse CheckIdNameDateSync(CheckIdNameDateRequest req)
        {
             JsonResponseModel<CheckIdNameDateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIdNameDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdNameDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手机号二要素核验接口用于校验手机号和姓名的真实性和一致性，支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="CheckPhoneAndNameRequest"/></param>
        /// <returns><see cref="CheckPhoneAndNameResponse"/></returns>
        public async Task<CheckPhoneAndNameResponse> CheckPhoneAndName(CheckPhoneAndNameRequest req)
        {
             JsonResponseModel<CheckPhoneAndNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckPhoneAndName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckPhoneAndNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 手机号二要素核验接口用于校验手机号和姓名的真实性和一致性，支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="CheckPhoneAndNameRequest"/></param>
        /// <returns><see cref="CheckPhoneAndNameResponse"/></returns>
        public CheckPhoneAndNameResponse CheckPhoneAndNameSync(CheckPhoneAndNameRequest req)
        {
             JsonResponseModel<CheckPhoneAndNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckPhoneAndName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckPhoneAndNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成一个临时的UploadUrl用于上传资源文件，客户需要使用HTTP PUT方法上传，上传完成后将ResourceUrl传给TargetAction对应接口完成资源传递（具体字段由使用场景确定）。
        /// 数据存储于Region参数对应地域的腾讯云COS Bucket，存储有效期2小时。
        /// </summary>
        /// <param name="req"><see cref="CreateUploadUrlRequest"/></param>
        /// <returns><see cref="CreateUploadUrlResponse"/></returns>
        public async Task<CreateUploadUrlResponse> CreateUploadUrl(CreateUploadUrlRequest req)
        {
             JsonResponseModel<CreateUploadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUploadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUploadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成一个临时的UploadUrl用于上传资源文件，客户需要使用HTTP PUT方法上传，上传完成后将ResourceUrl传给TargetAction对应接口完成资源传递（具体字段由使用场景确定）。
        /// 数据存储于Region参数对应地域的腾讯云COS Bucket，存储有效期2小时。
        /// </summary>
        /// <param name="req"><see cref="CreateUploadUrlRequest"/></param>
        /// <returns><see cref="CreateUploadUrlResponse"/></returns>
        public CreateUploadUrlResponse CreateUploadUrlSync(CreateUploadUrlRequest req)
        {
             JsonResponseModel<CreateUploadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUploadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUploadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用人脸核身SaaS化服务前，需先调用本接口获取BizToken，用来串联核身流程，在验证完成后，用于获取验证结果信息。
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
        public async Task<DetectAuthResponse> DetectAuth(DetectAuthRequest req)
        {
             JsonResponseModel<DetectAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用人脸核身SaaS化服务前，需先调用本接口获取BizToken，用来串联核身流程，在验证完成后，用于获取验证结果信息。
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
        public DetectAuthResponse DetectAuthSync(DetectAuthRequest req)
        {
             JsonResponseModel<DetectAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用活体比对（光线）SDK生成的数据包检测活体，并和传入的图片进行比对。
        /// 图片和SDK生成的数据内容必须存储在腾讯云COS，COS Bucket所在的Region需要和本接口请求的Region保持一致，推荐使用生成上传链接接口来完成资源传递。
        /// </summary>
        /// <param name="req"><see cref="DetectReflectLivenessAndCompareRequest"/></param>
        /// <returns><see cref="DetectReflectLivenessAndCompareResponse"/></returns>
        public async Task<DetectReflectLivenessAndCompareResponse> DetectReflectLivenessAndCompare(DetectReflectLivenessAndCompareRequest req)
        {
             JsonResponseModel<DetectReflectLivenessAndCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectReflectLivenessAndCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectReflectLivenessAndCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用活体比对（光线）SDK生成的数据包检测活体，并和传入的图片进行比对。
        /// 图片和SDK生成的数据内容必须存储在腾讯云COS，COS Bucket所在的Region需要和本接口请求的Region保持一致，推荐使用生成上传链接接口来完成资源传递。
        /// </summary>
        /// <param name="req"><see cref="DetectReflectLivenessAndCompareRequest"/></param>
        /// <returns><see cref="DetectReflectLivenessAndCompareResponse"/></returns>
        public DetectReflectLivenessAndCompareResponse DetectReflectLivenessAndCompareSync(DetectReflectLivenessAndCompareRequest req)
        {
             JsonResponseModel<DetectReflectLivenessAndCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectReflectLivenessAndCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectReflectLivenessAndCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性，入参支持明文、MD5和SHA256加密传输。
        /// </summary>
        /// <param name="req"><see cref="EncryptedPhoneVerificationRequest"/></param>
        /// <returns><see cref="EncryptedPhoneVerificationResponse"/></returns>
        public async Task<EncryptedPhoneVerificationResponse> EncryptedPhoneVerification(EncryptedPhoneVerificationRequest req)
        {
             JsonResponseModel<EncryptedPhoneVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EncryptedPhoneVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptedPhoneVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性，入参支持明文、MD5和SHA256加密传输。
        /// </summary>
        /// <param name="req"><see cref="EncryptedPhoneVerificationRequest"/></param>
        /// <returns><see cref="EncryptedPhoneVerificationResponse"/></returns>
        public EncryptedPhoneVerificationResponse EncryptedPhoneVerificationSync(EncryptedPhoneVerificationRequest req)
        {
             JsonResponseModel<EncryptedPhoneVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EncryptedPhoneVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EncryptedPhoneVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据活体比对（光线）SDK采集的机器信息生成适合的光线序列，将光线序列传入SDK后开启核身。
        /// SDK生成的数据内容必须存储在腾讯云COS，COS Bucket所在的Region需要和本接口请求的Region保持一致，推荐使用生成上传链接接口来完成资源传递。
        /// </summary>
        /// <param name="req"><see cref="GenerateReflectSequenceRequest"/></param>
        /// <returns><see cref="GenerateReflectSequenceResponse"/></returns>
        public async Task<GenerateReflectSequenceResponse> GenerateReflectSequence(GenerateReflectSequenceRequest req)
        {
             JsonResponseModel<GenerateReflectSequenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateReflectSequence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateReflectSequenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据活体比对（光线）SDK采集的机器信息生成适合的光线序列，将光线序列传入SDK后开启核身。
        /// SDK生成的数据内容必须存储在腾讯云COS，COS Bucket所在的Region需要和本接口请求的Region保持一致，推荐使用生成上传链接接口来完成资源传递。
        /// </summary>
        /// <param name="req"><see cref="GenerateReflectSequenceRequest"/></param>
        /// <returns><see cref="GenerateReflectSequenceResponse"/></returns>
        public GenerateReflectSequenceResponse GenerateReflectSequenceSync(GenerateReflectSequenceRequest req)
        {
             JsonResponseModel<GenerateReflectSequenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateReflectSequence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateReflectSequenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用动作活体检测模式前，需调用本接口获取动作顺序。
        /// </summary>
        /// <param name="req"><see cref="GetActionSequenceRequest"/></param>
        /// <returns><see cref="GetActionSequenceResponse"/></returns>
        public async Task<GetActionSequenceResponse> GetActionSequence(GetActionSequenceRequest req)
        {
             JsonResponseModel<GetActionSequenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetActionSequence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetActionSequenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用动作活体检测模式前，需调用本接口获取动作顺序。
        /// </summary>
        /// <param name="req"><see cref="GetActionSequenceRequest"/></param>
        /// <returns><see cref="GetActionSequenceResponse"/></returns>
        public GetActionSequenceResponse GetActionSequenceSync(GetActionSequenceRequest req)
        {
             JsonResponseModel<GetActionSequenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetActionSequence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetActionSequenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoRequest"/></param>
        /// <returns><see cref="GetDetectInfoResponse"/></returns>
        public async Task<GetDetectInfoResponse> GetDetectInfo(GetDetectInfoRequest req)
        {
             JsonResponseModel<GetDetectInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDetectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoRequest"/></param>
        /// <returns><see cref="GetDetectInfoResponse"/></returns>
        public GetDetectInfoResponse GetDetectInfoSync(GetDetectInfoRequest req)
        {
             JsonResponseModel<GetDetectInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDetectInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoEnhancedRequest"/></param>
        /// <returns><see cref="GetDetectInfoEnhancedResponse"/></returns>
        public async Task<GetDetectInfoEnhancedResponse> GetDetectInfoEnhanced(GetDetectInfoEnhancedRequest req)
        {
             JsonResponseModel<GetDetectInfoEnhancedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDetectInfoEnhanced");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoEnhancedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoEnhancedRequest"/></param>
        /// <returns><see cref="GetDetectInfoEnhancedResponse"/></returns>
        public GetDetectInfoEnhancedResponse GetDetectInfoEnhancedSync(GetDetectInfoEnhancedRequest req)
        {
             JsonResponseModel<GetDetectInfoEnhancedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDetectInfoEnhanced");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDetectInfoEnhancedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用EidToken调用本接口获取结果信息，EidToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetEidResultRequest"/></param>
        /// <returns><see cref="GetEidResultResponse"/></returns>
        public async Task<GetEidResultResponse> GetEidResult(GetEidResultRequest req)
        {
             JsonResponseModel<GetEidResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetEidResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEidResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用EidToken调用本接口获取结果信息，EidToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetEidResultRequest"/></param>
        /// <returns><see cref="GetEidResultResponse"/></returns>
        public GetEidResultResponse GetEidResultSync(GetEidResultRequest req)
        {
             JsonResponseModel<GetEidResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetEidResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEidResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用E证通服务前，需先调用本接口获取EidToken，用来串联E证通流程，在验证完成后，用于获取E证通结果信息。
        /// </summary>
        /// <param name="req"><see cref="GetEidTokenRequest"/></param>
        /// <returns><see cref="GetEidTokenResponse"/></returns>
        public async Task<GetEidTokenResponse> GetEidToken(GetEidTokenRequest req)
        {
             JsonResponseModel<GetEidTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetEidToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEidTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用E证通服务前，需先调用本接口获取EidToken，用来串联E证通流程，在验证完成后，用于获取E证通结果信息。
        /// </summary>
        /// <param name="req"><see cref="GetEidTokenRequest"/></param>
        /// <returns><see cref="GetEidTokenResponse"/></returns>
        public GetEidTokenResponse GetEidTokenSync(GetEidTokenRequest req)
        {
             JsonResponseModel<GetEidTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetEidToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEidTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取结果信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultRequest"/></param>
        /// <returns><see cref="GetFaceIdResultResponse"/></returns>
        public async Task<GetFaceIdResultResponse> GetFaceIdResult(GetFaceIdResultRequest req)
        {
             JsonResponseModel<GetFaceIdResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFaceIdResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取结果信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultRequest"/></param>
        /// <returns><see cref="GetFaceIdResultResponse"/></returns>
        public GetFaceIdResultResponse GetFaceIdResultSync(GetFaceIdResultRequest req)
        {
             JsonResponseModel<GetFaceIdResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFaceIdResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取验证结果信息，该token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenResponse"/></returns>
        public async Task<GetFaceIdTokenResponse> GetFaceIdToken(GetFaceIdTokenRequest req)
        {
             JsonResponseModel<GetFaceIdTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFaceIdToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取验证结果信息，该token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenResponse"/></returns>
        public GetFaceIdTokenResponse GetFaceIdTokenSync(GetFaceIdTokenRequest req)
        {
             JsonResponseModel<GetFaceIdTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFaceIdToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFaceIdTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用数字活体检测模式前，需调用本接口获取数字验证码。
        /// </summary>
        /// <param name="req"><see cref="GetLiveCodeRequest"/></param>
        /// <returns><see cref="GetLiveCodeResponse"/></returns>
        public async Task<GetLiveCodeResponse> GetLiveCode(GetLiveCodeRequest req)
        {
             JsonResponseModel<GetLiveCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLiveCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLiveCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用数字活体检测模式前，需调用本接口获取数字验证码。
        /// </summary>
        /// <param name="req"><see cref="GetLiveCodeRequest"/></param>
        /// <returns><see cref="GetLiveCodeResponse"/></returns>
        public GetLiveCodeResponse GetLiveCodeSync(GetLiveCodeRequest req)
        {
             JsonResponseModel<GetLiveCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLiveCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLiveCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成活体检测流程后，用核验令牌（SdkToken）调用本接口查询对应核验结果信息。Token申请后2小时内有效，可多次调用。
        /// </summary>
        /// <param name="req"><see cref="GetLivenessResultRequest"/></param>
        /// <returns><see cref="GetLivenessResultResponse"/></returns>
        public async Task<GetLivenessResultResponse> GetLivenessResult(GetLivenessResultRequest req)
        {
             JsonResponseModel<GetLivenessResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLivenessResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLivenessResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成活体检测流程后，用核验令牌（SdkToken）调用本接口查询对应核验结果信息。Token申请后2小时内有效，可多次调用。
        /// </summary>
        /// <param name="req"><see cref="GetLivenessResultRequest"/></param>
        /// <returns><see cref="GetLivenessResultResponse"/></returns>
        public GetLivenessResultResponse GetLivenessResultSync(GetLivenessResultRequest req)
        {
             JsonResponseModel<GetLivenessResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLivenessResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLivenessResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取微信实名认证结果
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthResultRequest"/></param>
        /// <returns><see cref="GetRealNameAuthResultResponse"/></returns>
        public async Task<GetRealNameAuthResultResponse> GetRealNameAuthResult(GetRealNameAuthResultRequest req)
        {
             JsonResponseModel<GetRealNameAuthResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRealNameAuthResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取微信实名认证结果
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthResultRequest"/></param>
        /// <returns><see cref="GetRealNameAuthResultResponse"/></returns>
        public GetRealNameAuthResultResponse GetRealNameAuthResultSync(GetRealNameAuthResultRequest req)
        {
             JsonResponseModel<GetRealNameAuthResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRealNameAuthResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口仅限微信公众号中使用，传入姓名和身份证号获取回调URL，在微信公众号中打开验证姓名和身份证号与微信实名的信息是否一致。
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthTokenRequest"/></param>
        /// <returns><see cref="GetRealNameAuthTokenResponse"/></returns>
        public async Task<GetRealNameAuthTokenResponse> GetRealNameAuthToken(GetRealNameAuthTokenRequest req)
        {
             JsonResponseModel<GetRealNameAuthTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRealNameAuthToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口仅限微信公众号中使用，传入姓名和身份证号获取回调URL，在微信公众号中打开验证姓名和身份证号与微信实名的信息是否一致。
        /// </summary>
        /// <param name="req"><see cref="GetRealNameAuthTokenRequest"/></param>
        /// <returns><see cref="GetRealNameAuthTokenResponse"/></returns>
        public GetRealNameAuthTokenResponse GetRealNameAuthTokenSync(GetRealNameAuthTokenRequest req)
        {
             JsonResponseModel<GetRealNameAuthTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRealNameAuthToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRealNameAuthTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成Sdk核验流程后，用核验令牌（Token）调用本接口查询对应核验结果信息。Token申请后三天内有效，可多次调用。
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public async Task<GetSdkVerificationResultResponse> GetSdkVerificationResult(GetSdkVerificationResultRequest req)
        {
             JsonResponseModel<GetSdkVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSdkVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSdkVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成Sdk核验流程后，用核验令牌（Token）调用本接口查询对应核验结果信息。Token申请后三天内有效，可多次调用。
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public GetSdkVerificationResultResponse GetSdkVerificationResultSync(GetSdkVerificationResultRequest req)
        {
             JsonResponseModel<GetSdkVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSdkVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSdkVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信渠道服务（微信小程序、微信原生H5、微信普通H5）的账单明细及计费状态。
        /// </summary>
        /// <param name="req"><see cref="GetWeChatBillDetailsRequest"/></param>
        /// <returns><see cref="GetWeChatBillDetailsResponse"/></returns>
        public async Task<GetWeChatBillDetailsResponse> GetWeChatBillDetails(GetWeChatBillDetailsRequest req)
        {
             JsonResponseModel<GetWeChatBillDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetWeChatBillDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWeChatBillDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询微信渠道服务（微信小程序、微信原生H5、微信普通H5）的账单明细及计费状态。
        /// </summary>
        /// <param name="req"><see cref="GetWeChatBillDetailsRequest"/></param>
        /// <returns><see cref="GetWeChatBillDetailsResponse"/></returns>
        public GetWeChatBillDetailsResponse GetWeChatBillDetailsSync(GetWeChatBillDetailsRequest req)
        {
             JsonResponseModel<GetWeChatBillDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetWeChatBillDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWeChatBillDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成Web核验流程后，用核验令牌（BizToken）调用本接口查询对应核验结果信息。BizToken申请后三天内（3\*24\*3,600秒）有效，可多次调用。
        /// </summary>
        /// <param name="req"><see cref="GetWebVerificationResultRequest"/></param>
        /// <returns><see cref="GetWebVerificationResultResponse"/></returns>
        public async Task<GetWebVerificationResultResponse> GetWebVerificationResult(GetWebVerificationResultRequest req)
        {
             JsonResponseModel<GetWebVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetWebVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWebVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 完成Web核验流程后，用核验令牌（BizToken）调用本接口查询对应核验结果信息。BizToken申请后三天内（3\*24\*3,600秒）有效，可多次调用。
        /// </summary>
        /// <param name="req"><see cref="GetWebVerificationResultRequest"/></param>
        /// <returns><see cref="GetWebVerificationResultResponse"/></returns>
        public GetWebVerificationResultResponse GetWebVerificationResultSync(GetWebVerificationResultRequest req)
        {
             JsonResponseModel<GetWebVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetWebVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWebVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名和身份证号的真实性和一致性，您可以通过输入姓名和身份证号或传入身份证人像面照片提供所需验证信息。
        /// </summary>
        /// <param name="req"><see cref="IdCardOCRVerificationRequest"/></param>
        /// <returns><see cref="IdCardOCRVerificationResponse"/></returns>
        public async Task<IdCardOCRVerificationResponse> IdCardOCRVerification(IdCardOCRVerificationRequest req)
        {
             JsonResponseModel<IdCardOCRVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IdCardOCRVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdCardOCRVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验姓名和身份证号的真实性和一致性，您可以通过输入姓名和身份证号或传入身份证人像面照片提供所需验证信息。
        /// </summary>
        /// <param name="req"><see cref="IdCardOCRVerificationRequest"/></param>
        /// <returns><see cref="IdCardOCRVerificationResponse"/></returns>
        public IdCardOCRVerificationResponse IdCardOCRVerificationSync(IdCardOCRVerificationRequest req)
        {
             JsonResponseModel<IdCardOCRVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IdCardOCRVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdCardOCRVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入姓名和身份证号，校验两者的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="IdCardVerificationRequest"/></param>
        /// <returns><see cref="IdCardVerificationResponse"/></returns>
        public async Task<IdCardVerificationResponse> IdCardVerification(IdCardVerificationRequest req)
        {
             JsonResponseModel<IdCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IdCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入姓名和身份证号，校验两者的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="IdCardVerificationRequest"/></param>
        /// <returns><see cref="IdCardVerificationResponse"/></returns>
        public IdCardVerificationResponse IdCardVerificationSync(IdCardVerificationRequest req)
        {
             JsonResponseModel<IdCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IdCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IdCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入照片和身份信息，判断该照片与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="ImageRecognitionRequest"/></param>
        /// <returns><see cref="ImageRecognitionResponse"/></returns>
        public async Task<ImageRecognitionResponse> ImageRecognition(ImageRecognitionRequest req)
        {
             JsonResponseModel<ImageRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入照片和身份信息，判断该照片与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="ImageRecognitionRequest"/></param>
        /// <returns><see cref="ImageRecognitionResponse"/></returns>
        public ImageRecognitionResponse ImageRecognitionSync(ImageRecognitionRequest req)
        {
             JsonResponseModel<ImageRecognitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImageRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 活体检测
        /// </summary>
        /// <param name="req"><see cref="LivenessRequest"/></param>
        /// <returns><see cref="LivenessResponse"/></returns>
        public async Task<LivenessResponse> Liveness(LivenessRequest req)
        {
             JsonResponseModel<LivenessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Liveness");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 活体检测
        /// </summary>
        /// <param name="req"><see cref="LivenessRequest"/></param>
        /// <returns><see cref="LivenessResponse"/></returns>
        public LivenessResponse LivenessSync(LivenessRequest req)
        {
             JsonResponseModel<LivenessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Liveness");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和照片，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public async Task<LivenessCompareResponse> LivenessCompare(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和照片，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public LivenessCompareResponse LivenessCompareSync(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和身份信息，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessRecognitionRequest"/></param>
        /// <returns><see cref="LivenessRecognitionResponse"/></returns>
        public async Task<LivenessRecognitionResponse> LivenessRecognition(LivenessRecognitionRequest req)
        {
             JsonResponseModel<LivenessRecognitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LivenessRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和身份信息，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessRecognitionRequest"/></param>
        /// <returns><see cref="LivenessRecognitionResponse"/></returns>
        public LivenessRecognitionResponse LivenessRecognitionSync(LivenessRecognitionRequest req)
        {
             JsonResponseModel<LivenessRecognitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LivenessRecognition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessRecognitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过传入手机号或姓名和身份证号，结合权威数据源和腾讯健康守护可信模型，判断该信息是否真实且年满18周岁。腾讯健康守护可信模型覆盖了上十亿手机库源，覆盖率高、准确率高，如果不在库中的手机号，还可以通过姓名+身份证进行兜底验证。
        /// </summary>
        /// <param name="req"><see cref="MinorsVerificationRequest"/></param>
        /// <returns><see cref="MinorsVerificationResponse"/></returns>
        public async Task<MinorsVerificationResponse> MinorsVerification(MinorsVerificationRequest req)
        {
             JsonResponseModel<MinorsVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MinorsVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MinorsVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过传入手机号或姓名和身份证号，结合权威数据源和腾讯健康守护可信模型，判断该信息是否真实且年满18周岁。腾讯健康守护可信模型覆盖了上十亿手机库源，覆盖率高、准确率高，如果不在库中的手机号，还可以通过姓名+身份证进行兜底验证。
        /// </summary>
        /// <param name="req"><see cref="MinorsVerificationRequest"/></param>
        /// <returns><see cref="MinorsVerificationResponse"/></returns>
        public MinorsVerificationResponse MinorsVerificationSync(MinorsVerificationRequest req)
        {
             JsonResponseModel<MinorsVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MinorsVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MinorsVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询手机号在网时长，输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileNetworkTimeVerificationRequest"/></param>
        /// <returns><see cref="MobileNetworkTimeVerificationResponse"/></returns>
        public async Task<MobileNetworkTimeVerificationResponse> MobileNetworkTimeVerification(MobileNetworkTimeVerificationRequest req)
        {
             JsonResponseModel<MobileNetworkTimeVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MobileNetworkTimeVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileNetworkTimeVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询手机号在网时长，输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileNetworkTimeVerificationRequest"/></param>
        /// <returns><see cref="MobileNetworkTimeVerificationResponse"/></returns>
        public MobileNetworkTimeVerificationResponse MobileNetworkTimeVerificationSync(MobileNetworkTimeVerificationRequest req)
        {
             JsonResponseModel<MobileNetworkTimeVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MobileNetworkTimeVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileNetworkTimeVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于验证手机号的状态，您可以输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileStatusRequest"/></param>
        /// <returns><see cref="MobileStatusResponse"/></returns>
        public async Task<MobileStatusResponse> MobileStatus(MobileStatusRequest req)
        {
             JsonResponseModel<MobileStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MobileStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于验证手机号的状态，您可以输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileStatusRequest"/></param>
        /// <returns><see cref="MobileStatusResponse"/></returns>
        public MobileStatusResponse MobileStatusSync(MobileStatusRequest req)
        {
             JsonResponseModel<MobileStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MobileStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MobileStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解析SDK获取到的证件NFC数据，接口传入SDK返回的ReqId，返回证件信息（个别字段为特定证件类型特有）。SDK生成的ReqId五分钟内有效，重复查询仅收一次费。支持身份证类证件（二代身份证、港澳居住证、台湾居住证、外国人永居证）以及旅行类证件（港澳通行证、台湾通行证、台胞证、回乡证）的NFC识别及核验。
        /// </summary>
        /// <param name="req"><see cref="ParseNfcDataRequest"/></param>
        /// <returns><see cref="ParseNfcDataResponse"/></returns>
        public async Task<ParseNfcDataResponse> ParseNfcData(ParseNfcDataRequest req)
        {
             JsonResponseModel<ParseNfcDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseNfcData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseNfcDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解析SDK获取到的证件NFC数据，接口传入SDK返回的ReqId，返回证件信息（个别字段为特定证件类型特有）。SDK生成的ReqId五分钟内有效，重复查询仅收一次费。支持身份证类证件（二代身份证、港澳居住证、台湾居住证、外国人永居证）以及旅行类证件（港澳通行证、台湾通行证、台胞证、回乡证）的NFC识别及核验。
        /// </summary>
        /// <param name="req"><see cref="ParseNfcDataRequest"/></param>
        /// <returns><see cref="ParseNfcDataResponse"/></returns>
        public ParseNfcDataResponse ParseNfcDataSync(ParseNfcDataRequest req)
        {
             JsonResponseModel<ParseNfcDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ParseNfcData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseNfcDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性。支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationRequest"/></param>
        /// <returns><see cref="PhoneVerificationResponse"/></returns>
        public async Task<PhoneVerificationResponse> PhoneVerification(PhoneVerificationRequest req)
        {
             JsonResponseModel<PhoneVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PhoneVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性。支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationRequest"/></param>
        /// <returns><see cref="PhoneVerificationResponse"/></returns>
        public PhoneVerificationResponse PhoneVerificationSync(PhoneVerificationRequest req)
        {
             JsonResponseModel<PhoneVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PhoneVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验中国移动手机号、姓名和身份证号的真实性和一致性。中国移动支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCMCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCMCCResponse"/></returns>
        public async Task<PhoneVerificationCMCCResponse> PhoneVerificationCMCC(PhoneVerificationCMCCRequest req)
        {
             JsonResponseModel<PhoneVerificationCMCCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PhoneVerificationCMCC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationCMCCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验中国移动手机号、姓名和身份证号的真实性和一致性。中国移动支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCMCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCMCCResponse"/></returns>
        public PhoneVerificationCMCCResponse PhoneVerificationCMCCSync(PhoneVerificationCMCCRequest req)
        {
             JsonResponseModel<PhoneVerificationCMCCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PhoneVerificationCMCC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationCMCCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验中国电信手机号、姓名和身份证号的真实性和一致性。中国电信支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCTCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCTCCResponse"/></returns>
        public async Task<PhoneVerificationCTCCResponse> PhoneVerificationCTCC(PhoneVerificationCTCCRequest req)
        {
             JsonResponseModel<PhoneVerificationCTCCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PhoneVerificationCTCC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationCTCCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验中国电信手机号、姓名和身份证号的真实性和一致性。中国电信支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCTCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCTCCResponse"/></returns>
        public PhoneVerificationCTCCResponse PhoneVerificationCTCCSync(PhoneVerificationCTCCRequest req)
        {
             JsonResponseModel<PhoneVerificationCTCCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PhoneVerificationCTCC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationCTCCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验中国联通手机号、姓名和身份证号的真实性和一致性。中国联通支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCUCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCUCCResponse"/></returns>
        public async Task<PhoneVerificationCUCCResponse> PhoneVerificationCUCC(PhoneVerificationCUCCRequest req)
        {
             JsonResponseModel<PhoneVerificationCUCCResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PhoneVerificationCUCC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationCUCCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验中国联通手机号、姓名和身份证号的真实性和一致性。中国联通支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCUCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCUCCResponse"/></returns>
        public PhoneVerificationCUCCResponse PhoneVerificationCUCCSync(PhoneVerificationCUCCRequest req)
        {
             JsonResponseModel<PhoneVerificationCUCCResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PhoneVerificationCUCC");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PhoneVerificationCUCCResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和照片地址，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="VideoLivenessCompareRequest"/></param>
        /// <returns><see cref="VideoLivenessCompareResponse"/></returns>
        public async Task<VideoLivenessCompareResponse> VideoLivenessCompare(VideoLivenessCompareRequest req)
        {
             JsonResponseModel<VideoLivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VideoLivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoLivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 传入视频和照片地址，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="VideoLivenessCompareRequest"/></param>
        /// <returns><see cref="VideoLivenessCompareResponse"/></returns>
        public VideoLivenessCompareResponse VideoLivenessCompareSync(VideoLivenessCompareRequest req)
        {
             JsonResponseModel<VideoLivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VideoLivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoLivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
