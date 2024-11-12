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
       private const string sdkVersion = "SDK_NET_3.0.1121";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口用于校验姓名和银行卡号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public Task<BankCard2EVerificationResponse> BankCard2EVerification(BankCard2EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard2EVerificationResponse>(req, "BankCard2EVerification");
        }

        /// <summary>
        /// 本接口用于校验姓名和银行卡号的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public BankCard2EVerificationResponse BankCard2EVerificationSync(BankCard2EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard2EVerificationResponse>(req, "BankCard2EVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于输入银行卡号、姓名、开户证件号、开户手机号，校验信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public Task<BankCard4EVerificationResponse> BankCard4EVerification(BankCard4EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard4EVerificationResponse>(req, "BankCard4EVerification");
        }

        /// <summary>
        /// 本接口用于输入银行卡号、姓名、开户证件号、开户手机号，校验信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public BankCard4EVerificationResponse BankCard4EVerificationSync(BankCard4EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard4EVerificationResponse>(req, "BankCard4EVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于银行卡号、姓名、开户证件号信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
        public Task<BankCardVerificationResponse> BankCardVerification(BankCardVerificationRequest req)
        {
            return InternalRequestAsync<BankCardVerificationResponse>(req, "BankCardVerification");
        }

        /// <summary>
        /// 本接口用于银行卡号、姓名、开户证件号信息的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
        public BankCardVerificationResponse BankCardVerificationSync(BankCardVerificationRequest req)
        {
            return InternalRequestAsync<BankCardVerificationResponse>(req, "BankCardVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 银行卡基础信息查询
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public Task<CheckBankCardInformationResponse> CheckBankCardInformation(CheckBankCardInformationRequest req)
        {
            return InternalRequestAsync<CheckBankCardInformationResponse>(req, "CheckBankCardInformation");
        }

        /// <summary>
        /// 银行卡基础信息查询
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public CheckBankCardInformationResponse CheckBankCardInformationSync(CheckBankCardInformationRequest req)
        {
            return InternalRequestAsync<CheckBankCardInformationResponse>(req, "CheckBankCardInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于轮询E证通H5场景EidToken验证状态。
        /// </summary>
        /// <param name="req"><see cref="CheckEidTokenStatusRequest"/></param>
        /// <returns><see cref="CheckEidTokenStatusResponse"/></returns>
        public Task<CheckEidTokenStatusResponse> CheckEidTokenStatus(CheckEidTokenStatusRequest req)
        {
            return InternalRequestAsync<CheckEidTokenStatusResponse>(req, "CheckEidTokenStatus");
        }

        /// <summary>
        /// 用于轮询E证通H5场景EidToken验证状态。
        /// </summary>
        /// <param name="req"><see cref="CheckEidTokenStatusRequest"/></param>
        /// <returns><see cref="CheckEidTokenStatusResponse"/></returns>
        public CheckEidTokenStatusResponse CheckEidTokenStatusSync(CheckEidTokenStatusRequest req)
        {
            return InternalRequestAsync<CheckEidTokenStatusResponse>(req, "CheckEidTokenStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入身份证人像面照片，识别身份证照片上的信息，并将姓名、身份证号、身份证人像照片与权威库的证件照进行比对，是否属于同一个人，从而验证身份证信息的真实性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardInformationRequest"/></param>
        /// <returns><see cref="CheckIdCardInformationResponse"/></returns>
        public Task<CheckIdCardInformationResponse> CheckIdCardInformation(CheckIdCardInformationRequest req)
        {
            return InternalRequestAsync<CheckIdCardInformationResponse>(req, "CheckIdCardInformation");
        }

        /// <summary>
        /// 传入身份证人像面照片，识别身份证照片上的信息，并将姓名、身份证号、身份证人像照片与权威库的证件照进行比对，是否属于同一个人，从而验证身份证信息的真实性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardInformationRequest"/></param>
        /// <returns><see cref="CheckIdCardInformationResponse"/></returns>
        public CheckIdCardInformationResponse CheckIdCardInformationSync(CheckIdCardInformationRequest req)
        {
            return InternalRequestAsync<CheckIdCardInformationResponse>(req, "CheckIdCardInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验姓名、身份证号、身份证有效期的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdNameDateRequest"/></param>
        /// <returns><see cref="CheckIdNameDateResponse"/></returns>
        public Task<CheckIdNameDateResponse> CheckIdNameDate(CheckIdNameDateRequest req)
        {
            return InternalRequestAsync<CheckIdNameDateResponse>(req, "CheckIdNameDate");
        }

        /// <summary>
        /// 本接口用于校验姓名、身份证号、身份证有效期的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="CheckIdNameDateRequest"/></param>
        /// <returns><see cref="CheckIdNameDateResponse"/></returns>
        public CheckIdNameDateResponse CheckIdNameDateSync(CheckIdNameDateRequest req)
        {
            return InternalRequestAsync<CheckIdNameDateResponse>(req, "CheckIdNameDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手机号二要素核验接口用于校验手机号和姓名的真实性和一致性，支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="CheckPhoneAndNameRequest"/></param>
        /// <returns><see cref="CheckPhoneAndNameResponse"/></returns>
        public Task<CheckPhoneAndNameResponse> CheckPhoneAndName(CheckPhoneAndNameRequest req)
        {
            return InternalRequestAsync<CheckPhoneAndNameResponse>(req, "CheckPhoneAndName");
        }

        /// <summary>
        /// 手机号二要素核验接口用于校验手机号和姓名的真实性和一致性，支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="CheckPhoneAndNameRequest"/></param>
        /// <returns><see cref="CheckPhoneAndNameResponse"/></returns>
        public CheckPhoneAndNameResponse CheckPhoneAndNameSync(CheckPhoneAndNameRequest req)
        {
            return InternalRequestAsync<CheckPhoneAndNameResponse>(req, "CheckPhoneAndName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于多模态的AI大模型算法，提供对人脸图片、视频的防攻击检测能力，可针对性有效识别高仿真的AIGC换脸、高清翻拍、批量黑产攻击、水印等攻击痕迹，增强对图片和视频的防伪安全能力。
        /// </summary>
        /// <param name="req"><see cref="DetectAIFakeFacesRequest"/></param>
        /// <returns><see cref="DetectAIFakeFacesResponse"/></returns>
        public Task<DetectAIFakeFacesResponse> DetectAIFakeFaces(DetectAIFakeFacesRequest req)
        {
            return InternalRequestAsync<DetectAIFakeFacesResponse>(req, "DetectAIFakeFaces");
        }

        /// <summary>
        /// 基于多模态的AI大模型算法，提供对人脸图片、视频的防攻击检测能力，可针对性有效识别高仿真的AIGC换脸、高清翻拍、批量黑产攻击、水印等攻击痕迹，增强对图片和视频的防伪安全能力。
        /// </summary>
        /// <param name="req"><see cref="DetectAIFakeFacesRequest"/></param>
        /// <returns><see cref="DetectAIFakeFacesResponse"/></returns>
        public DetectAIFakeFacesResponse DetectAIFakeFacesSync(DetectAIFakeFacesRequest req)
        {
            return InternalRequestAsync<DetectAIFakeFacesResponse>(req, "DetectAIFakeFaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 每次调用人脸核身SaaS化服务前，需先调用本接口获取BizToken，用来串联核身流程，在验证完成后，用于获取验证结果信息。
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
        public Task<DetectAuthResponse> DetectAuth(DetectAuthRequest req)
        {
            return InternalRequestAsync<DetectAuthResponse>(req, "DetectAuth");
        }

        /// <summary>
        /// 每次调用人脸核身SaaS化服务前，需先调用本接口获取BizToken，用来串联核身流程，在验证完成后，用于获取验证结果信息。
        /// </summary>
        /// <param name="req"><see cref="DetectAuthRequest"/></param>
        /// <returns><see cref="DetectAuthResponse"/></returns>
        public DetectAuthResponse DetectAuthSync(DetectAuthRequest req)
        {
            return InternalRequestAsync<DetectAuthResponse>(req, "DetectAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性，入参支持明文、MD5和SHA256加密传输。
        /// </summary>
        /// <param name="req"><see cref="EncryptedPhoneVerificationRequest"/></param>
        /// <returns><see cref="EncryptedPhoneVerificationResponse"/></returns>
        public Task<EncryptedPhoneVerificationResponse> EncryptedPhoneVerification(EncryptedPhoneVerificationRequest req)
        {
            return InternalRequestAsync<EncryptedPhoneVerificationResponse>(req, "EncryptedPhoneVerification");
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性，入参支持明文、MD5和SHA256加密传输。
        /// </summary>
        /// <param name="req"><see cref="EncryptedPhoneVerificationRequest"/></param>
        /// <returns><see cref="EncryptedPhoneVerificationResponse"/></returns>
        public EncryptedPhoneVerificationResponse EncryptedPhoneVerificationSync(EncryptedPhoneVerificationRequest req)
        {
            return InternalRequestAsync<EncryptedPhoneVerificationResponse>(req, "EncryptedPhoneVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用动作活体检测模式前，需调用本接口获取动作顺序。
        /// </summary>
        /// <param name="req"><see cref="GetActionSequenceRequest"/></param>
        /// <returns><see cref="GetActionSequenceResponse"/></returns>
        public Task<GetActionSequenceResponse> GetActionSequence(GetActionSequenceRequest req)
        {
            return InternalRequestAsync<GetActionSequenceResponse>(req, "GetActionSequence");
        }

        /// <summary>
        /// 使用动作活体检测模式前，需调用本接口获取动作顺序。
        /// </summary>
        /// <param name="req"><see cref="GetActionSequenceRequest"/></param>
        /// <returns><see cref="GetActionSequenceResponse"/></returns>
        public GetActionSequenceResponse GetActionSequenceSync(GetActionSequenceRequest req)
        {
            return InternalRequestAsync<GetActionSequenceResponse>(req, "GetActionSequence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoRequest"/></param>
        /// <returns><see cref="GetDetectInfoResponse"/></returns>
        public Task<GetDetectInfoResponse> GetDetectInfo(GetDetectInfoRequest req)
        {
            return InternalRequestAsync<GetDetectInfoResponse>(req, "GetDetectInfo");
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoRequest"/></param>
        /// <returns><see cref="GetDetectInfoResponse"/></returns>
        public GetDetectInfoResponse GetDetectInfoSync(GetDetectInfoRequest req)
        {
            return InternalRequestAsync<GetDetectInfoResponse>(req, "GetDetectInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoEnhancedRequest"/></param>
        /// <returns><see cref="GetDetectInfoEnhancedResponse"/></returns>
        public Task<GetDetectInfoEnhancedResponse> GetDetectInfoEnhanced(GetDetectInfoEnhancedRequest req)
        {
            return InternalRequestAsync<GetDetectInfoEnhancedResponse>(req, "GetDetectInfoEnhanced");
        }

        /// <summary>
        /// 完成验证后，用BizToken调用本接口获取结果信息，BizToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetDetectInfoEnhancedRequest"/></param>
        /// <returns><see cref="GetDetectInfoEnhancedResponse"/></returns>
        public GetDetectInfoEnhancedResponse GetDetectInfoEnhancedSync(GetDetectInfoEnhancedRequest req)
        {
            return InternalRequestAsync<GetDetectInfoEnhancedResponse>(req, "GetDetectInfoEnhanced")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完成验证后，用EidToken调用本接口获取结果信息，EidToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetEidResultRequest"/></param>
        /// <returns><see cref="GetEidResultResponse"/></returns>
        public Task<GetEidResultResponse> GetEidResult(GetEidResultRequest req)
        {
            return InternalRequestAsync<GetEidResultResponse>(req, "GetEidResult");
        }

        /// <summary>
        /// 完成验证后，用EidToken调用本接口获取结果信息，EidToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetEidResultRequest"/></param>
        /// <returns><see cref="GetEidResultResponse"/></returns>
        public GetEidResultResponse GetEidResultSync(GetEidResultRequest req)
        {
            return InternalRequestAsync<GetEidResultResponse>(req, "GetEidResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 每次调用E证通服务前，需先调用本接口获取EidToken，用来串联E证通流程，在验证完成后，用于获取E证通结果信息。
        /// </summary>
        /// <param name="req"><see cref="GetEidTokenRequest"/></param>
        /// <returns><see cref="GetEidTokenResponse"/></returns>
        public Task<GetEidTokenResponse> GetEidToken(GetEidTokenRequest req)
        {
            return InternalRequestAsync<GetEidTokenResponse>(req, "GetEidToken");
        }

        /// <summary>
        /// 每次调用E证通服务前，需先调用本接口获取EidToken，用来串联E证通流程，在验证完成后，用于获取E证通结果信息。
        /// </summary>
        /// <param name="req"><see cref="GetEidTokenRequest"/></param>
        /// <returns><see cref="GetEidTokenResponse"/></returns>
        public GetEidTokenResponse GetEidTokenSync(GetEidTokenRequest req)
        {
            return InternalRequestAsync<GetEidTokenResponse>(req, "GetEidToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取结果信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultRequest"/></param>
        /// <returns><see cref="GetFaceIdResultResponse"/></returns>
        public Task<GetFaceIdResultResponse> GetFaceIdResult(GetFaceIdResultRequest req)
        {
            return InternalRequestAsync<GetFaceIdResultResponse>(req, "GetFaceIdResult");
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取结果信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultRequest"/></param>
        /// <returns><see cref="GetFaceIdResultResponse"/></returns>
        public GetFaceIdResultResponse GetFaceIdResultSync(GetFaceIdResultRequest req)
        {
            return InternalRequestAsync<GetFaceIdResultResponse>(req, "GetFaceIdResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取设备风险相关信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdRiskInfoRequest"/></param>
        /// <returns><see cref="GetFaceIdRiskInfoResponse"/></returns>
        public Task<GetFaceIdRiskInfoResponse> GetFaceIdRiskInfo(GetFaceIdRiskInfoRequest req)
        {
            return InternalRequestAsync<GetFaceIdRiskInfoResponse>(req, "GetFaceIdRiskInfo");
        }

        /// <summary>
        /// 完成验证后，用FaceIdToken调用本接口获取设备风险相关信息，FaceIdToken生成后三天内（3\*24\*3,600秒）可多次拉取。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdRiskInfoRequest"/></param>
        /// <returns><see cref="GetFaceIdRiskInfoResponse"/></returns>
        public GetFaceIdRiskInfoResponse GetFaceIdRiskInfoSync(GetFaceIdRiskInfoRequest req)
        {
            return InternalRequestAsync<GetFaceIdRiskInfoResponse>(req, "GetFaceIdRiskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取验证结果信息，该token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenResponse"/></returns>
        public Task<GetFaceIdTokenResponse> GetFaceIdToken(GetFaceIdTokenRequest req)
        {
            return InternalRequestAsync<GetFaceIdTokenResponse>(req, "GetFaceIdToken");
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取验证结果信息，该token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenResponse"/></returns>
        public GetFaceIdTokenResponse GetFaceIdTokenSync(GetFaceIdTokenRequest req)
        {
            return InternalRequestAsync<GetFaceIdTokenResponse>(req, "GetFaceIdToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取风险结果信息，该Token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceidRiskInfoTokenRequest"/></param>
        /// <returns><see cref="GetFaceidRiskInfoTokenResponse"/></returns>
        public Task<GetFaceidRiskInfoTokenResponse> GetFaceidRiskInfoToken(GetFaceidRiskInfoTokenRequest req)
        {
            return InternalRequestAsync<GetFaceidRiskInfoTokenResponse>(req, "GetFaceidRiskInfoToken");
        }

        /// <summary>
        /// 每次调用人脸核身SDK服务前，需先调用本接口获取SDKToken，用来串联核身流程，在验证完成后，用于获取风险结果信息，该Token仅能核身一次。
        /// </summary>
        /// <param name="req"><see cref="GetFaceidRiskInfoTokenRequest"/></param>
        /// <returns><see cref="GetFaceidRiskInfoTokenResponse"/></returns>
        public GetFaceidRiskInfoTokenResponse GetFaceidRiskInfoTokenSync(GetFaceidRiskInfoTokenRequest req)
        {
            return InternalRequestAsync<GetFaceidRiskInfoTokenResponse>(req, "GetFaceidRiskInfoToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用数字活体检测模式前，需调用本接口获取数字验证码。
        /// </summary>
        /// <param name="req"><see cref="GetLiveCodeRequest"/></param>
        /// <returns><see cref="GetLiveCodeResponse"/></returns>
        public Task<GetLiveCodeResponse> GetLiveCode(GetLiveCodeRequest req)
        {
            return InternalRequestAsync<GetLiveCodeResponse>(req, "GetLiveCode");
        }

        /// <summary>
        /// 使用数字活体检测模式前，需调用本接口获取数字验证码。
        /// </summary>
        /// <param name="req"><see cref="GetLiveCodeRequest"/></param>
        /// <returns><see cref="GetLiveCodeResponse"/></returns>
        public GetLiveCodeResponse GetLiveCodeSync(GetLiveCodeRequest req)
        {
            return InternalRequestAsync<GetLiveCodeResponse>(req, "GetLiveCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询微信渠道服务（微信小程序、微信原生H5、微信普通H5）的账单明细及计费状态。
        /// </summary>
        /// <param name="req"><see cref="GetWeChatBillDetailsRequest"/></param>
        /// <returns><see cref="GetWeChatBillDetailsResponse"/></returns>
        public Task<GetWeChatBillDetailsResponse> GetWeChatBillDetails(GetWeChatBillDetailsRequest req)
        {
            return InternalRequestAsync<GetWeChatBillDetailsResponse>(req, "GetWeChatBillDetails");
        }

        /// <summary>
        /// 查询微信渠道服务（微信小程序、微信原生H5、微信普通H5）的账单明细及计费状态。
        /// </summary>
        /// <param name="req"><see cref="GetWeChatBillDetailsRequest"/></param>
        /// <returns><see cref="GetWeChatBillDetailsResponse"/></returns>
        public GetWeChatBillDetailsResponse GetWeChatBillDetailsSync(GetWeChatBillDetailsRequest req)
        {
            return InternalRequestAsync<GetWeChatBillDetailsResponse>(req, "GetWeChatBillDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验姓名和身份证号的真实性和一致性，您可以通过输入姓名和身份证号或传入身份证人像面照片提供所需验证信息。
        /// </summary>
        /// <param name="req"><see cref="IdCardOCRVerificationRequest"/></param>
        /// <returns><see cref="IdCardOCRVerificationResponse"/></returns>
        public Task<IdCardOCRVerificationResponse> IdCardOCRVerification(IdCardOCRVerificationRequest req)
        {
            return InternalRequestAsync<IdCardOCRVerificationResponse>(req, "IdCardOCRVerification");
        }

        /// <summary>
        /// 本接口用于校验姓名和身份证号的真实性和一致性，您可以通过输入姓名和身份证号或传入身份证人像面照片提供所需验证信息。
        /// </summary>
        /// <param name="req"><see cref="IdCardOCRVerificationRequest"/></param>
        /// <returns><see cref="IdCardOCRVerificationResponse"/></returns>
        public IdCardOCRVerificationResponse IdCardOCRVerificationSync(IdCardOCRVerificationRequest req)
        {
            return InternalRequestAsync<IdCardOCRVerificationResponse>(req, "IdCardOCRVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入姓名和身份证号，校验两者的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="IdCardVerificationRequest"/></param>
        /// <returns><see cref="IdCardVerificationResponse"/></returns>
        public Task<IdCardVerificationResponse> IdCardVerification(IdCardVerificationRequest req)
        {
            return InternalRequestAsync<IdCardVerificationResponse>(req, "IdCardVerification");
        }

        /// <summary>
        /// 传入姓名和身份证号，校验两者的真实性和一致性。
        /// </summary>
        /// <param name="req"><see cref="IdCardVerificationRequest"/></param>
        /// <returns><see cref="IdCardVerificationResponse"/></returns>
        public IdCardVerificationResponse IdCardVerificationSync(IdCardVerificationRequest req)
        {
            return InternalRequestAsync<IdCardVerificationResponse>(req, "IdCardVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入照片和身份信息，判断该照片与权威库的证件照是否属于同一个人（该接口已停止接入，新客户请使用<a href="https://cloud.tencent.com/document/product/1007/102203">照片人脸核身（V2.0）</a>接口）。
        /// </summary>
        /// <param name="req"><see cref="ImageRecognitionRequest"/></param>
        /// <returns><see cref="ImageRecognitionResponse"/></returns>
        public Task<ImageRecognitionResponse> ImageRecognition(ImageRecognitionRequest req)
        {
            return InternalRequestAsync<ImageRecognitionResponse>(req, "ImageRecognition");
        }

        /// <summary>
        /// 传入照片和身份信息，判断该照片与权威库的证件照是否属于同一个人（该接口已停止接入，新客户请使用<a href="https://cloud.tencent.com/document/product/1007/102203">照片人脸核身（V2.0）</a>接口）。
        /// </summary>
        /// <param name="req"><see cref="ImageRecognitionRequest"/></param>
        /// <returns><see cref="ImageRecognitionResponse"/></returns>
        public ImageRecognitionResponse ImageRecognitionSync(ImageRecognitionRequest req)
        {
            return InternalRequestAsync<ImageRecognitionResponse>(req, "ImageRecognition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入照片和身份信息，判断该照片与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="ImageRecognitionV2Request"/></param>
        /// <returns><see cref="ImageRecognitionV2Response"/></returns>
        public Task<ImageRecognitionV2Response> ImageRecognitionV2(ImageRecognitionV2Request req)
        {
            return InternalRequestAsync<ImageRecognitionV2Response>(req, "ImageRecognitionV2");
        }

        /// <summary>
        /// 传入照片和身份信息，判断该照片与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="ImageRecognitionV2Request"/></param>
        /// <returns><see cref="ImageRecognitionV2Response"/></returns>
        public ImageRecognitionV2Response ImageRecognitionV2Sync(ImageRecognitionV2Request req)
        {
            return InternalRequestAsync<ImageRecognitionV2Response>(req, "ImageRecognitionV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 活体检测
        /// </summary>
        /// <param name="req"><see cref="LivenessRequest"/></param>
        /// <returns><see cref="LivenessResponse"/></returns>
        public Task<LivenessResponse> Liveness(LivenessRequest req)
        {
            return InternalRequestAsync<LivenessResponse>(req, "Liveness");
        }

        /// <summary>
        /// 活体检测
        /// </summary>
        /// <param name="req"><see cref="LivenessRequest"/></param>
        /// <returns><see cref="LivenessResponse"/></returns>
        public LivenessResponse LivenessSync(LivenessRequest req)
        {
            return InternalRequestAsync<LivenessResponse>(req, "Liveness")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入视频和照片，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public Task<LivenessCompareResponse> LivenessCompare(LivenessCompareRequest req)
        {
            return InternalRequestAsync<LivenessCompareResponse>(req, "LivenessCompare");
        }

        /// <summary>
        /// 传入视频和照片，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与上传照片是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public LivenessCompareResponse LivenessCompareSync(LivenessCompareRequest req)
        {
            return InternalRequestAsync<LivenessCompareResponse>(req, "LivenessCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 传入视频和身份信息，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessRecognitionRequest"/></param>
        /// <returns><see cref="LivenessRecognitionResponse"/></returns>
        public Task<LivenessRecognitionResponse> LivenessRecognition(LivenessRecognitionRequest req)
        {
            return InternalRequestAsync<LivenessRecognitionResponse>(req, "LivenessRecognition");
        }

        /// <summary>
        /// 传入视频和身份信息，先判断视频中是否为真人，判断为真人后，再判断该视频中的人与权威库的证件照是否属于同一个人。
        /// </summary>
        /// <param name="req"><see cref="LivenessRecognitionRequest"/></param>
        /// <returns><see cref="LivenessRecognitionResponse"/></returns>
        public LivenessRecognitionResponse LivenessRecognitionSync(LivenessRecognitionRequest req)
        {
            return InternalRequestAsync<LivenessRecognitionResponse>(req, "LivenessRecognition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过传入手机号或姓名和身份证号，结合权威数据源和腾讯健康守护可信模型，判断该信息是否真实且年满18周岁。腾讯健康守护可信模型覆盖了上十亿手机库源，覆盖率高、准确率高，如果不在库中的手机号，还可以通过姓名+身份证进行兜底验证。
        /// </summary>
        /// <param name="req"><see cref="MinorsVerificationRequest"/></param>
        /// <returns><see cref="MinorsVerificationResponse"/></returns>
        public Task<MinorsVerificationResponse> MinorsVerification(MinorsVerificationRequest req)
        {
            return InternalRequestAsync<MinorsVerificationResponse>(req, "MinorsVerification");
        }

        /// <summary>
        /// 通过传入手机号或姓名和身份证号，结合权威数据源和腾讯健康守护可信模型，判断该信息是否真实且年满18周岁。腾讯健康守护可信模型覆盖了上十亿手机库源，覆盖率高、准确率高，如果不在库中的手机号，还可以通过姓名+身份证进行兜底验证。
        /// </summary>
        /// <param name="req"><see cref="MinorsVerificationRequest"/></param>
        /// <returns><see cref="MinorsVerificationResponse"/></returns>
        public MinorsVerificationResponse MinorsVerificationSync(MinorsVerificationRequest req)
        {
            return InternalRequestAsync<MinorsVerificationResponse>(req, "MinorsVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询手机号在网时长，输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileNetworkTimeVerificationRequest"/></param>
        /// <returns><see cref="MobileNetworkTimeVerificationResponse"/></returns>
        public Task<MobileNetworkTimeVerificationResponse> MobileNetworkTimeVerification(MobileNetworkTimeVerificationRequest req)
        {
            return InternalRequestAsync<MobileNetworkTimeVerificationResponse>(req, "MobileNetworkTimeVerification");
        }

        /// <summary>
        /// 本接口用于查询手机号在网时长，输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileNetworkTimeVerificationRequest"/></param>
        /// <returns><see cref="MobileNetworkTimeVerificationResponse"/></returns>
        public MobileNetworkTimeVerificationResponse MobileNetworkTimeVerificationSync(MobileNetworkTimeVerificationRequest req)
        {
            return InternalRequestAsync<MobileNetworkTimeVerificationResponse>(req, "MobileNetworkTimeVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于验证手机号的状态，您可以输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileStatusRequest"/></param>
        /// <returns><see cref="MobileStatusResponse"/></returns>
        public Task<MobileStatusResponse> MobileStatus(MobileStatusRequest req)
        {
            return InternalRequestAsync<MobileStatusResponse>(req, "MobileStatus");
        }

        /// <summary>
        /// 本接口用于验证手机号的状态，您可以输入手机号进行查询。
        /// </summary>
        /// <param name="req"><see cref="MobileStatusRequest"/></param>
        /// <returns><see cref="MobileStatusResponse"/></returns>
        public MobileStatusResponse MobileStatusSync(MobileStatusRequest req)
        {
            return InternalRequestAsync<MobileStatusResponse>(req, "MobileStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解析SDK获取到的证件NFC数据，接口传入SDK返回的ReqId，返回证件信息（个别字段为特定证件类型特有）。SDK生成的ReqId五分钟内有效，重复查询仅收一次费。支持身份证类证件（二代身份证、港澳居住证、台湾居住证、外国人永居证）以及旅行类证件（港澳通行证、台湾通行证、台胞证、回乡证）的NFC识别及核验。
        /// </summary>
        /// <param name="req"><see cref="ParseNfcDataRequest"/></param>
        /// <returns><see cref="ParseNfcDataResponse"/></returns>
        public Task<ParseNfcDataResponse> ParseNfcData(ParseNfcDataRequest req)
        {
            return InternalRequestAsync<ParseNfcDataResponse>(req, "ParseNfcData");
        }

        /// <summary>
        /// 解析SDK获取到的证件NFC数据，接口传入SDK返回的ReqId，返回证件信息（个别字段为特定证件类型特有）。SDK生成的ReqId五分钟内有效，重复查询仅收一次费。支持身份证类证件（二代身份证、港澳居住证、台湾居住证、外国人永居证）以及旅行类证件（港澳通行证、台湾通行证、台胞证、回乡证）的NFC识别及核验。
        /// </summary>
        /// <param name="req"><see cref="ParseNfcDataRequest"/></param>
        /// <returns><see cref="ParseNfcDataResponse"/></returns>
        public ParseNfcDataResponse ParseNfcDataSync(ParseNfcDataRequest req)
        {
            return InternalRequestAsync<ParseNfcDataResponse>(req, "ParseNfcData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性。支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationRequest"/></param>
        /// <returns><see cref="PhoneVerificationResponse"/></returns>
        public Task<PhoneVerificationResponse> PhoneVerification(PhoneVerificationRequest req)
        {
            return InternalRequestAsync<PhoneVerificationResponse>(req, "PhoneVerification");
        }

        /// <summary>
        /// 本接口用于校验手机号、姓名和身份证号的真实性和一致性。支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationRequest"/></param>
        /// <returns><see cref="PhoneVerificationResponse"/></returns>
        public PhoneVerificationResponse PhoneVerificationSync(PhoneVerificationRequest req)
        {
            return InternalRequestAsync<PhoneVerificationResponse>(req, "PhoneVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验中国移动手机号、姓名和身份证号的真实性和一致性。中国移动支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCMCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCMCCResponse"/></returns>
        public Task<PhoneVerificationCMCCResponse> PhoneVerificationCMCC(PhoneVerificationCMCCRequest req)
        {
            return InternalRequestAsync<PhoneVerificationCMCCResponse>(req, "PhoneVerificationCMCC");
        }

        /// <summary>
        /// 本接口用于校验中国移动手机号、姓名和身份证号的真实性和一致性。中国移动支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCMCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCMCCResponse"/></returns>
        public PhoneVerificationCMCCResponse PhoneVerificationCMCCSync(PhoneVerificationCMCCRequest req)
        {
            return InternalRequestAsync<PhoneVerificationCMCCResponse>(req, "PhoneVerificationCMCC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验中国电信手机号、姓名和身份证号的真实性和一致性。中国电信支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCTCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCTCCResponse"/></returns>
        public Task<PhoneVerificationCTCCResponse> PhoneVerificationCTCC(PhoneVerificationCTCCRequest req)
        {
            return InternalRequestAsync<PhoneVerificationCTCCResponse>(req, "PhoneVerificationCTCC");
        }

        /// <summary>
        /// 本接口用于校验中国电信手机号、姓名和身份证号的真实性和一致性。中国电信支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCTCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCTCCResponse"/></returns>
        public PhoneVerificationCTCCResponse PhoneVerificationCTCCSync(PhoneVerificationCTCCRequest req)
        {
            return InternalRequestAsync<PhoneVerificationCTCCResponse>(req, "PhoneVerificationCTCC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验中国联通手机号、姓名和身份证号的真实性和一致性。中国联通支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCUCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCUCCResponse"/></returns>
        public Task<PhoneVerificationCUCCResponse> PhoneVerificationCUCC(PhoneVerificationCUCCRequest req)
        {
            return InternalRequestAsync<PhoneVerificationCUCCResponse>(req, "PhoneVerificationCUCC");
        }

        /// <summary>
        /// 本接口用于校验中国联通手机号、姓名和身份证号的真实性和一致性。中国联通支持的手机号段详情请查阅<a href="https://cloud.tencent.com/document/product/1007/46063">运营商类</a>文档。
        /// </summary>
        /// <param name="req"><see cref="PhoneVerificationCUCCRequest"/></param>
        /// <returns><see cref="PhoneVerificationCUCCResponse"/></returns>
        public PhoneVerificationCUCCResponse PhoneVerificationCUCCSync(PhoneVerificationCUCCRequest req)
        {
            return InternalRequestAsync<PhoneVerificationCUCCResponse>(req, "PhoneVerificationCUCC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
