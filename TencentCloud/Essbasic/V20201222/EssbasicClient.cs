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

namespace TencentCloud.Essbasic.V20201222
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Essbasic.V20201222.Models;

   public class EssbasicClient : AbstractClient{

       private const string endpoint = "essbasic.tencentcloudapi.com";
       private const string version = "2020-12-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EssbasicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EssbasicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 此接口（ArchiveFlow）用于流程的归档。
        /// 
        /// 注意：归档后的流程不可再进行发送、签署、拒签、撤回等一系列操作。
        /// </summary>
        /// <param name="req"><see cref="ArchiveFlowRequest"/></param>
        /// <returns><see cref="ArchiveFlowResponse"/></returns>
        public async Task<ArchiveFlowResponse> ArchiveFlow(ArchiveFlowRequest req)
        {
             JsonResponseModel<ArchiveFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ArchiveFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ArchiveFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ArchiveFlow）用于流程的归档。
        /// 
        /// 注意：归档后的流程不可再进行发送、签署、拒签、撤回等一系列操作。
        /// </summary>
        /// <param name="req"><see cref="ArchiveFlowRequest"/></param>
        /// <returns><see cref="ArchiveFlowResponse"/></returns>
        public ArchiveFlowResponse ArchiveFlowSync(ArchiveFlowRequest req)
        {
             JsonResponseModel<ArchiveFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ArchiveFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ArchiveFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CancelFlow）用于撤销正在进行中的流程。
        /// 
        /// 注：已归档流程不可完成撤销动作。
        /// </summary>
        /// <param name="req"><see cref="CancelFlowRequest"/></param>
        /// <returns><see cref="CancelFlowResponse"/></returns>
        public async Task<CancelFlowResponse> CancelFlow(CancelFlowRequest req)
        {
             JsonResponseModel<CancelFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CancelFlow）用于撤销正在进行中的流程。
        /// 
        /// 注：已归档流程不可完成撤销动作。
        /// </summary>
        /// <param name="req"><see cref="CancelFlowRequest"/></param>
        /// <returns><see cref="CancelFlowResponse"/></returns>
        public CancelFlowResponse CancelFlowSync(CancelFlowRequest req)
        {
             JsonResponseModel<CancelFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard2EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard2EVerificationResponse"/></returns>
        public async Task<CheckBankCard2EVerificationResponse> CheckBankCard2EVerification(CheckBankCard2EVerificationRequest req)
        {
             JsonResponseModel<CheckBankCard2EVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBankCard2EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCard2EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard2EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard2EVerificationResponse"/></returns>
        public CheckBankCard2EVerificationResponse CheckBankCard2EVerificationSync(CheckBankCard2EVerificationRequest req)
        {
             JsonResponseModel<CheckBankCard2EVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBankCard2EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCard2EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡三要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard3EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard3EVerificationResponse"/></returns>
        public async Task<CheckBankCard3EVerificationResponse> CheckBankCard3EVerification(CheckBankCard3EVerificationRequest req)
        {
             JsonResponseModel<CheckBankCard3EVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBankCard3EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCard3EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡三要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard3EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard3EVerificationResponse"/></returns>
        public CheckBankCard3EVerificationResponse CheckBankCard3EVerificationSync(CheckBankCard3EVerificationRequest req)
        {
             JsonResponseModel<CheckBankCard3EVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBankCard3EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCard3EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡四要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard4EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard4EVerificationResponse"/></returns>
        public async Task<CheckBankCard4EVerificationResponse> CheckBankCard4EVerification(CheckBankCard4EVerificationRequest req)
        {
             JsonResponseModel<CheckBankCard4EVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBankCard4EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCard4EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡四要素
        /// </summary>
        /// <param name="req"><see cref="CheckBankCard4EVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCard4EVerificationResponse"/></returns>
        public CheckBankCard4EVerificationResponse CheckBankCard4EVerificationSync(CheckBankCard4EVerificationRequest req)
        {
             JsonResponseModel<CheckBankCard4EVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBankCard4EVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCard4EVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二/三/四要素
        /// 银行卡二要素(同CheckBankCard2EVerification): bank_card + name
        /// 银行卡三要素(同CheckBankCard3EVerification): bank_card + name + id_card_number
        /// 银行卡四要素(同CheckBankCard4EVerification): bank_card + name + id_card_number + mobile
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCardVerificationResponse"/></returns>
        public async Task<CheckBankCardVerificationResponse> CheckBankCardVerification(CheckBankCardVerificationRequest req)
        {
             JsonResponseModel<CheckBankCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBankCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证银行卡二/三/四要素
        /// 银行卡二要素(同CheckBankCard2EVerification): bank_card + name
        /// 银行卡三要素(同CheckBankCard3EVerification): bank_card + name + id_card_number
        /// 银行卡四要素(同CheckBankCard4EVerification): bank_card + name + id_card_number + mobile
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardVerificationRequest"/></param>
        /// <returns><see cref="CheckBankCardVerificationResponse"/></returns>
        public CheckBankCardVerificationResponse CheckBankCardVerificationSync(CheckBankCardVerificationRequest req)
        {
             JsonResponseModel<CheckBankCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBankCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBankCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台检测慧眼或腾讯电子签小程序人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="CheckFaceIdentifyRequest"/></param>
        /// <returns><see cref="CheckFaceIdentifyResponse"/></returns>
        public async Task<CheckFaceIdentifyResponse> CheckFaceIdentify(CheckFaceIdentifyRequest req)
        {
             JsonResponseModel<CheckFaceIdentifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckFaceIdentify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFaceIdentifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台检测慧眼或腾讯电子签小程序人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="CheckFaceIdentifyRequest"/></param>
        /// <returns><see cref="CheckFaceIdentifyResponse"/></returns>
        public CheckFaceIdentifyResponse CheckFaceIdentifySync(CheckFaceIdentifyRequest req)
        {
             JsonResponseModel<CheckFaceIdentifyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckFaceIdentify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFaceIdentifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证姓名和身份证信息
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardVerificationRequest"/></param>
        /// <returns><see cref="CheckIdCardVerificationResponse"/></returns>
        public async Task<CheckIdCardVerificationResponse> CheckIdCardVerification(CheckIdCardVerificationRequest req)
        {
             JsonResponseModel<CheckIdCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckIdCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证姓名和身份证信息
        /// </summary>
        /// <param name="req"><see cref="CheckIdCardVerificationRequest"/></param>
        /// <returns><see cref="CheckIdCardVerificationResponse"/></returns>
        public CheckIdCardVerificationResponse CheckIdCardVerificationSync(CheckIdCardVerificationRequest req)
        {
             JsonResponseModel<CheckIdCardVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckIdCardVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckIdCardVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号二要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileAndNameRequest"/></param>
        /// <returns><see cref="CheckMobileAndNameResponse"/></returns>
        public async Task<CheckMobileAndNameResponse> CheckMobileAndName(CheckMobileAndNameRequest req)
        {
             JsonResponseModel<CheckMobileAndNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckMobileAndName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckMobileAndNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号二要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileAndNameRequest"/></param>
        /// <returns><see cref="CheckMobileAndNameResponse"/></returns>
        public CheckMobileAndNameResponse CheckMobileAndNameSync(CheckMobileAndNameRequest req)
        {
             JsonResponseModel<CheckMobileAndNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckMobileAndName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckMobileAndNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号三要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileVerificationRequest"/></param>
        /// <returns><see cref="CheckMobileVerificationResponse"/></returns>
        public async Task<CheckMobileVerificationResponse> CheckMobileVerification(CheckMobileVerificationRequest req)
        {
             JsonResponseModel<CheckMobileVerificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckMobileVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckMobileVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台验证手机号三要素
        /// </summary>
        /// <param name="req"><see cref="CheckMobileVerificationRequest"/></param>
        /// <returns><see cref="CheckMobileVerificationResponse"/></returns>
        public CheckMobileVerificationResponse CheckMobileVerificationSync(CheckMobileVerificationRequest req)
        {
             JsonResponseModel<CheckMobileVerificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckMobileVerification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckMobileVerificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于确认验证码是否正确
        /// </summary>
        /// <param name="req"><see cref="CheckVerifyCodeMatchFlowIdRequest"/></param>
        /// <returns><see cref="CheckVerifyCodeMatchFlowIdResponse"/></returns>
        public async Task<CheckVerifyCodeMatchFlowIdResponse> CheckVerifyCodeMatchFlowId(CheckVerifyCodeMatchFlowIdRequest req)
        {
             JsonResponseModel<CheckVerifyCodeMatchFlowIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckVerifyCodeMatchFlowId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckVerifyCodeMatchFlowIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于确认验证码是否正确
        /// </summary>
        /// <param name="req"><see cref="CheckVerifyCodeMatchFlowIdRequest"/></param>
        /// <returns><see cref="CheckVerifyCodeMatchFlowIdResponse"/></returns>
        public CheckVerifyCodeMatchFlowIdResponse CheckVerifyCodeMatchFlowIdSync(CheckVerifyCodeMatchFlowIdRequest req)
        {
             JsonResponseModel<CheckVerifyCodeMatchFlowIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckVerifyCodeMatchFlowId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckVerifyCodeMatchFlowIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼慧眼API签名
        /// </summary>
        /// <param name="req"><see cref="CreateFaceIdSignRequest"/></param>
        /// <returns><see cref="CreateFaceIdSignResponse"/></returns>
        public async Task<CreateFaceIdSignResponse> CreateFaceIdSign(CreateFaceIdSignRequest req)
        {
             JsonResponseModel<CreateFaceIdSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFaceIdSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceIdSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼慧眼API签名
        /// </summary>
        /// <param name="req"><see cref="CreateFaceIdSignRequest"/></param>
        /// <returns><see cref="CreateFaceIdSignResponse"/></returns>
        public CreateFaceIdSignResponse CreateFaceIdSignSync(CreateFaceIdSignRequest req)
        {
             JsonResponseModel<CreateFaceIdSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFaceIdSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceIdSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowByFiles）用于通过PDF文件创建签署流程。
        /// 
        /// 注意：调用此接口前，请先调用多文件上传接口 (UploadFiles)，提前上传合同文件。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowByFilesResponse"/></returns>
        public async Task<CreateFlowByFilesResponse> CreateFlowByFiles(CreateFlowByFilesRequest req)
        {
             JsonResponseModel<CreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowByFiles）用于通过PDF文件创建签署流程。
        /// 
        /// 注意：调用此接口前，请先调用多文件上传接口 (UploadFiles)，提前上传合同文件。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowByFilesResponse"/></returns>
        public CreateFlowByFilesResponse CreateFlowByFilesSync(CreateFlowByFilesRequest req)
        {
             JsonResponseModel<CreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼H5人脸核身Url
        /// </summary>
        /// <param name="req"><see cref="CreateH5FaceIdUrlRequest"/></param>
        /// <returns><see cref="CreateH5FaceIdUrlResponse"/></returns>
        public async Task<CreateH5FaceIdUrlResponse> CreateH5FaceIdUrl(CreateH5FaceIdUrlRequest req)
        {
             JsonResponseModel<CreateH5FaceIdUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateH5FaceIdUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateH5FaceIdUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼H5人脸核身Url
        /// </summary>
        /// <param name="req"><see cref="CreateH5FaceIdUrlRequest"/></param>
        /// <returns><see cref="CreateH5FaceIdUrlResponse"/></returns>
        public CreateH5FaceIdUrlResponse CreateH5FaceIdUrlSync(CreateH5FaceIdUrlRequest req)
        {
             JsonResponseModel<CreateH5FaceIdUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateH5FaceIdUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateH5FaceIdUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreatePreviewSignUrl）用于生成生成预览签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreatePreviewSignUrlRequest"/></param>
        /// <returns><see cref="CreatePreviewSignUrlResponse"/></returns>
        public async Task<CreatePreviewSignUrlResponse> CreatePreviewSignUrl(CreatePreviewSignUrlRequest req)
        {
             JsonResponseModel<CreatePreviewSignUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePreviewSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePreviewSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreatePreviewSignUrl）用于生成生成预览签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreatePreviewSignUrlRequest"/></param>
        /// <returns><see cref="CreatePreviewSignUrlResponse"/></returns>
        public CreatePreviewSignUrlResponse CreatePreviewSignUrlSync(CreatePreviewSignUrlRequest req)
        {
             JsonResponseModel<CreatePreviewSignUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePreviewSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePreviewSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateSeal）用于创建个人/企业印章。
        /// 
        /// 注意：使用FileId参数指定印章，需先调用多文件上传 (UploadFiles) 上传印章图片。
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
        /// 此接口（CreateSeal）用于创建个人/企业印章。
        /// 
        /// 注意：使用FileId参数指定印章，需先调用多文件上传 (UploadFiles) 上传印章图片。
        /// </summary>
        /// <param name="req"><see cref="CreateSealRequest"/></param>
        /// <returns><see cref="CreateSealResponse"/></returns>
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
        /// 此接口（CreateServerFlowSign）用于静默签署文件。
        /// 
        /// 注：
        /// 1、此接口为白名单接口，调用前请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// 2、仅合同发起者可使用流程静默签署能力。
        /// </summary>
        /// <param name="req"><see cref="CreateServerFlowSignRequest"/></param>
        /// <returns><see cref="CreateServerFlowSignResponse"/></returns>
        public async Task<CreateServerFlowSignResponse> CreateServerFlowSign(CreateServerFlowSignRequest req)
        {
             JsonResponseModel<CreateServerFlowSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServerFlowSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerFlowSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateServerFlowSign）用于静默签署文件。
        /// 
        /// 注：
        /// 1、此接口为白名单接口，调用前请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// 2、仅合同发起者可使用流程静默签署能力。
        /// </summary>
        /// <param name="req"><see cref="CreateServerFlowSignRequest"/></param>
        /// <returns><see cref="CreateServerFlowSignResponse"/></returns>
        public CreateServerFlowSignResponse CreateServerFlowSignSync(CreateServerFlowSignRequest req)
        {
             JsonResponseModel<CreateServerFlowSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServerFlowSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerFlowSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateSignUrl）用于生成指定用户的签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlRequest"/></param>
        /// <returns><see cref="CreateSignUrlResponse"/></returns>
        public async Task<CreateSignUrlResponse> CreateSignUrl(CreateSignUrlRequest req)
        {
             JsonResponseModel<CreateSignUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateSignUrl）用于生成指定用户的签署URL。
        /// 
        /// 注：调用此接口前，请确保您已提前调用了发送流程接口（SendFlow）指定相关签署方。
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlRequest"/></param>
        /// <returns><see cref="CreateSignUrlResponse"/></returns>
        public CreateSignUrlResponse CreateSignUrlSync(CreateSignUrlRequest req)
        {
             JsonResponseModel<CreateSignUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateSubOrganization）用于在腾讯电子签内注册子机构。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationResponse"/></returns>
        public async Task<CreateSubOrganizationResponse> CreateSubOrganization(CreateSubOrganizationRequest req)
        {
             JsonResponseModel<CreateSubOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateSubOrganization）用于在腾讯电子签内注册子机构。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationResponse"/></returns>
        public CreateSubOrganizationResponse CreateSubOrganizationSync(CreateSubOrganizationRequest req)
        {
             JsonResponseModel<CreateSubOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateSubOrganizationAndSeal）用于注册子机构，同时系统将为该子企业自动生成一个默认电子印章图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的印章图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationAndSealRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationAndSealResponse"/></returns>
        public async Task<CreateSubOrganizationAndSealResponse> CreateSubOrganizationAndSeal(CreateSubOrganizationAndSealRequest req)
        {
             JsonResponseModel<CreateSubOrganizationAndSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSubOrganizationAndSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubOrganizationAndSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateSubOrganizationAndSeal）用于注册子机构，同时系统将为该子企业自动生成一个默认电子印章图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的印章图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateSubOrganizationAndSealRequest"/></param>
        /// <returns><see cref="CreateSubOrganizationAndSealResponse"/></returns>
        public CreateSubOrganizationAndSealResponse CreateSubOrganizationAndSealSync(CreateSubOrganizationAndSealRequest req)
        {
             JsonResponseModel<CreateSubOrganizationAndSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSubOrganizationAndSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSubOrganizationAndSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateUser）用于注册腾讯电子签个人用户。
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateUser）用于注册腾讯电子签个人用户。
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（CreateUserAndSeal）注册腾讯电子签实名个人用户，同时系统将为该用户自动生成一个默认电子签名图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的签名图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateUserAndSealRequest"/></param>
        /// <returns><see cref="CreateUserAndSealResponse"/></returns>
        public async Task<CreateUserAndSealResponse> CreateUserAndSeal(CreateUserAndSealRequest req)
        {
             JsonResponseModel<CreateUserAndSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserAndSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserAndSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（CreateUserAndSeal）注册腾讯电子签实名个人用户，同时系统将为该用户自动生成一个默认电子签名图片。
        /// 
        /// 注意：
        /// 1. 在后续的签署流程中，若未指定签署使用的印章ID，则默认调用自动生成的签名图片进行签署。
        /// 2. 此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="CreateUserAndSealRequest"/></param>
        /// <returns><see cref="CreateUserAndSealResponse"/></returns>
        public CreateUserAndSealResponse CreateUserAndSealSync(CreateUserAndSealRequest req)
        {
             JsonResponseModel<CreateUserAndSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserAndSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserAndSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口 (DeleteSeal) 用于删除指定ID的印章。
        /// 
        /// 注意：默认印章不支持删除
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
        /// 此接口 (DeleteSeal) 用于删除指定ID的印章。
        /// 
        /// 注意：默认印章不支持删除
        /// </summary>
        /// <param name="req"><see cref="DeleteSealRequest"/></param>
        /// <returns><see cref="DeleteSealResponse"/></returns>
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
        /// 第三方应用可通过此接口（DescribeCatalogApprovers）查询指定目录的参与者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogApproversRequest"/></param>
        /// <returns><see cref="DescribeCatalogApproversResponse"/></returns>
        public async Task<DescribeCatalogApproversResponse> DescribeCatalogApprovers(DescribeCatalogApproversRequest req)
        {
             JsonResponseModel<DescribeCatalogApproversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCatalogApprovers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCatalogApproversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeCatalogApprovers）查询指定目录的参与者列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogApproversRequest"/></param>
        /// <returns><see cref="DescribeCatalogApproversResponse"/></returns>
        public DescribeCatalogApproversResponse DescribeCatalogApproversSync(DescribeCatalogApproversRequest req)
        {
             JsonResponseModel<DescribeCatalogApproversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCatalogApprovers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCatalogApproversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeCatalogSignComponents）拉取目录签署区
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogSignComponentsRequest"/></param>
        /// <returns><see cref="DescribeCatalogSignComponentsResponse"/></returns>
        public async Task<DescribeCatalogSignComponentsResponse> DescribeCatalogSignComponents(DescribeCatalogSignComponentsRequest req)
        {
             JsonResponseModel<DescribeCatalogSignComponentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCatalogSignComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCatalogSignComponentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeCatalogSignComponents）拉取目录签署区
        /// </summary>
        /// <param name="req"><see cref="DescribeCatalogSignComponentsRequest"/></param>
        /// <returns><see cref="DescribeCatalogSignComponentsResponse"/></returns>
        public DescribeCatalogSignComponentsResponse DescribeCatalogSignComponentsSync(DescribeCatalogSignComponentsRequest req)
        {
             JsonResponseModel<DescribeCatalogSignComponentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCatalogSignComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCatalogSignComponentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIds）用于通过自定义流程id来查询对应的电子签流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsResponse"/></returns>
        public async Task<DescribeCustomFlowIdsResponse> DescribeCustomFlowIds(DescribeCustomFlowIdsRequest req)
        {
             JsonResponseModel<DescribeCustomFlowIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomFlowIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomFlowIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIds）用于通过自定义流程id来查询对应的电子签流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsResponse"/></returns>
        public DescribeCustomFlowIdsResponse DescribeCustomFlowIdsSync(DescribeCustomFlowIdsRequest req)
        {
             JsonResponseModel<DescribeCustomFlowIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomFlowIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomFlowIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIdsByFlowId）用于根据流程id反查自定义流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsByFlowIdResponse"/></returns>
        public async Task<DescribeCustomFlowIdsByFlowIdResponse> DescribeCustomFlowIdsByFlowId(DescribeCustomFlowIdsByFlowIdRequest req)
        {
             JsonResponseModel<DescribeCustomFlowIdsByFlowIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomFlowIdsByFlowId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomFlowIdsByFlowIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeCustomFlowIdsByFlowId）用于根据流程id反查自定义流程id
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomFlowIdsByFlowIdRequest"/></param>
        /// <returns><see cref="DescribeCustomFlowIdsByFlowIdResponse"/></returns>
        public DescribeCustomFlowIdsByFlowIdResponse DescribeCustomFlowIdsByFlowIdSync(DescribeCustomFlowIdsByFlowIdRequest req)
        {
             JsonResponseModel<DescribeCustomFlowIdsByFlowIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomFlowIdsByFlowId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomFlowIdsByFlowIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身照片
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdPhotosRequest"/></param>
        /// <returns><see cref="DescribeFaceIdPhotosResponse"/></returns>
        public async Task<DescribeFaceIdPhotosResponse> DescribeFaceIdPhotos(DescribeFaceIdPhotosRequest req)
        {
             JsonResponseModel<DescribeFaceIdPhotosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFaceIdPhotos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFaceIdPhotosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身照片
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdPhotosRequest"/></param>
        /// <returns><see cref="DescribeFaceIdPhotosResponse"/></returns>
        public DescribeFaceIdPhotosResponse DescribeFaceIdPhotosSync(DescribeFaceIdPhotosRequest req)
        {
             JsonResponseModel<DescribeFaceIdPhotosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFaceIdPhotos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFaceIdPhotosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdResultsRequest"/></param>
        /// <returns><see cref="DescribeFaceIdResultsResponse"/></returns>
        public async Task<DescribeFaceIdResultsResponse> DescribeFaceIdResults(DescribeFaceIdResultsRequest req)
        {
             JsonResponseModel<DescribeFaceIdResultsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFaceIdResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFaceIdResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口为第三方平台向电子签平台获取慧眼人脸核身结果
        /// </summary>
        /// <param name="req"><see cref="DescribeFaceIdResultsRequest"/></param>
        /// <returns><see cref="DescribeFaceIdResultsResponse"/></returns>
        public DescribeFaceIdResultsResponse DescribeFaceIdResultsSync(DescribeFaceIdResultsRequest req)
        {
             JsonResponseModel<DescribeFaceIdResultsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFaceIdResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFaceIdResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据用户自定义id查询文件id
        /// </summary>
        /// <param name="req"><see cref="DescribeFileIdsByCustomIdsRequest"/></param>
        /// <returns><see cref="DescribeFileIdsByCustomIdsResponse"/></returns>
        public async Task<DescribeFileIdsByCustomIdsResponse> DescribeFileIdsByCustomIds(DescribeFileIdsByCustomIdsRequest req)
        {
             JsonResponseModel<DescribeFileIdsByCustomIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileIdsByCustomIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileIdsByCustomIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据用户自定义id查询文件id
        /// </summary>
        /// <param name="req"><see cref="DescribeFileIdsByCustomIdsRequest"/></param>
        /// <returns><see cref="DescribeFileIdsByCustomIdsResponse"/></returns>
        public DescribeFileIdsByCustomIdsResponse DescribeFileIdsByCustomIdsSync(DescribeFileIdsByCustomIdsRequest req)
        {
             JsonResponseModel<DescribeFileIdsByCustomIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileIdsByCustomIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileIdsByCustomIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFileUrls）用于获取签署文件下载的URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUrlsRequest"/></param>
        /// <returns><see cref="DescribeFileUrlsResponse"/></returns>
        public async Task<DescribeFileUrlsResponse> DescribeFileUrls(DescribeFileUrlsRequest req)
        {
             JsonResponseModel<DescribeFileUrlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFileUrls）用于获取签署文件下载的URL。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUrlsRequest"/></param>
        /// <returns><see cref="DescribeFileUrlsResponse"/></returns>
        public DescribeFileUrlsResponse DescribeFileUrlsSync(DescribeFileUrlsRequest req)
        {
             JsonResponseModel<DescribeFileUrlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeFlow）可查询签署流程的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public async Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
             JsonResponseModel<DescribeFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeFlow）可查询签署流程的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
             JsonResponseModel<DescribeFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeFlowApprovers）查询流程参与者信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowApproversRequest"/></param>
        /// <returns><see cref="DescribeFlowApproversResponse"/></returns>
        public async Task<DescribeFlowApproversResponse> DescribeFlowApprovers(DescribeFlowApproversRequest req)
        {
             JsonResponseModel<DescribeFlowApproversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowApprovers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowApproversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（DescribeFlowApprovers）查询流程参与者信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowApproversRequest"/></param>
        /// <returns><see cref="DescribeFlowApproversResponse"/></returns>
        public DescribeFlowApproversResponse DescribeFlowApproversSync(DescribeFlowApproversRequest req)
        {
             JsonResponseModel<DescribeFlowApproversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowApprovers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowApproversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowFilesRequest"/></param>
        /// <returns><see cref="DescribeFlowFilesResponse"/></returns>
        public async Task<DescribeFlowFilesResponse> DescribeFlowFiles(DescribeFlowFilesRequest req)
        {
             JsonResponseModel<DescribeFlowFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程文件
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowFilesRequest"/></param>
        /// <returns><see cref="DescribeFlowFilesResponse"/></returns>
        public DescribeFlowFilesResponse DescribeFlowFilesSync(DescribeFlowFilesRequest req)
        {
             JsonResponseModel<DescribeFlowFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSeals）用于查询指定ID的印章信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSealsRequest"/></param>
        /// <returns><see cref="DescribeSealsResponse"/></returns>
        public async Task<DescribeSealsResponse> DescribeSeals(DescribeSealsRequest req)
        {
             JsonResponseModel<DescribeSealsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSeals）用于查询指定ID的印章信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSealsRequest"/></param>
        /// <returns><see cref="DescribeSealsResponse"/></returns>
        public DescribeSealsResponse DescribeSealsSync(DescribeSealsRequest req)
        {
             JsonResponseModel<DescribeSealsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSubOrganizations）用于查询子机构信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的子机构信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubOrganizationsRequest"/></param>
        /// <returns><see cref="DescribeSubOrganizationsResponse"/></returns>
        public async Task<DescribeSubOrganizationsResponse> DescribeSubOrganizations(DescribeSubOrganizationsRequest req)
        {
             JsonResponseModel<DescribeSubOrganizationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSubOrganizations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubOrganizationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeSubOrganizations）用于查询子机构信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的子机构信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSubOrganizationsRequest"/></param>
        /// <returns><see cref="DescribeSubOrganizationsResponse"/></returns>
        public DescribeSubOrganizationsResponse DescribeSubOrganizationsSync(DescribeSubOrganizationsRequest req)
        {
             JsonResponseModel<DescribeSubOrganizationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSubOrganizations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSubOrganizationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsers）用于查询应用号下的个人用户信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的个人用户信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public async Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsers）用于查询应用号下的个人用户信息。
        /// 
        /// 注：此接口仅可查询您所属机构应用号创建的个人用户信息，不可跨应用/跨机构查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DestroyFlowFile）可删除指定流程中的合同文件。
        /// 
        /// 注：调用此接口前，请确保此流程已属于归档状态。您可通过查询流程信息接口（DescribeFlow）进行查询。
        /// </summary>
        /// <param name="req"><see cref="DestroyFlowFileRequest"/></param>
        /// <returns><see cref="DestroyFlowFileResponse"/></returns>
        public async Task<DestroyFlowFileResponse> DestroyFlowFile(DestroyFlowFileRequest req)
        {
             JsonResponseModel<DestroyFlowFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyFlowFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyFlowFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DestroyFlowFile）可删除指定流程中的合同文件。
        /// 
        /// 注：调用此接口前，请确保此流程已属于归档状态。您可通过查询流程信息接口（DescribeFlow）进行查询。
        /// </summary>
        /// <param name="req"><see cref="DestroyFlowFileRequest"/></param>
        /// <returns><see cref="DestroyFlowFileResponse"/></returns>
        public DestroyFlowFileResponse DestroyFlowFileSync(DestroyFlowFileRequest req)
        {
             JsonResponseModel<DestroyFlowFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyFlowFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyFlowFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成企业电子印章
        /// </summary>
        /// <param name="req"><see cref="GenerateOrganizationSealRequest"/></param>
        /// <returns><see cref="GenerateOrganizationSealResponse"/></returns>
        public async Task<GenerateOrganizationSealResponse> GenerateOrganizationSeal(GenerateOrganizationSealRequest req)
        {
             JsonResponseModel<GenerateOrganizationSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateOrganizationSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateOrganizationSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成企业电子印章
        /// </summary>
        /// <param name="req"><see cref="GenerateOrganizationSealRequest"/></param>
        /// <returns><see cref="GenerateOrganizationSealResponse"/></returns>
        public GenerateOrganizationSealResponse GenerateOrganizationSealSync(GenerateOrganizationSealRequest req)
        {
             JsonResponseModel<GenerateOrganizationSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateOrganizationSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateOrganizationSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GenerateUserSeal）用于生成个人签名图片。
        /// 
        /// 注意：
        /// 1. 个人签名由用户注册时预留的姓名信息生成，不支持自定义签名内容。
        /// 2. 个人用户仅支持拥有一个系统生成的电子签名。
        /// </summary>
        /// <param name="req"><see cref="GenerateUserSealRequest"/></param>
        /// <returns><see cref="GenerateUserSealResponse"/></returns>
        public async Task<GenerateUserSealResponse> GenerateUserSeal(GenerateUserSealRequest req)
        {
             JsonResponseModel<GenerateUserSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateUserSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateUserSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GenerateUserSeal）用于生成个人签名图片。
        /// 
        /// 注意：
        /// 1. 个人签名由用户注册时预留的姓名信息生成，不支持自定义签名内容。
        /// 2. 个人用户仅支持拥有一个系统生成的电子签名。
        /// </summary>
        /// <param name="req"><see cref="GenerateUserSealRequest"/></param>
        /// <returns><see cref="GenerateUserSealResponse"/></returns>
        public GenerateUserSealResponse GenerateUserSealSync(GenerateUserSealRequest req)
        {
             JsonResponseModel<GenerateUserSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateUserSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateUserSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口 (ModifyOrganizationDefaultSeal) 用于重新指定企业默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyOrganizationDefaultSealResponse"/></returns>
        public async Task<ModifyOrganizationDefaultSealResponse> ModifyOrganizationDefaultSeal(ModifyOrganizationDefaultSealRequest req)
        {
             JsonResponseModel<ModifyOrganizationDefaultSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyOrganizationDefaultSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOrganizationDefaultSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口 (ModifyOrganizationDefaultSeal) 用于重新指定企业默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyOrganizationDefaultSealResponse"/></returns>
        public ModifyOrganizationDefaultSealResponse ModifyOrganizationDefaultSealSync(ModifyOrganizationDefaultSealRequest req)
        {
             JsonResponseModel<ModifyOrganizationDefaultSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyOrganizationDefaultSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyOrganizationDefaultSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifySeal）用于修改指定印章ID的印章图片和名称。
        /// 
        /// 注：印章类型暂不支持修改，如需调整，请联系客服经理或通过创建印章接口（CreateSeal）进行创建新印章。
        /// </summary>
        /// <param name="req"><see cref="ModifySealRequest"/></param>
        /// <returns><see cref="ModifySealResponse"/></returns>
        public async Task<ModifySealResponse> ModifySeal(ModifySealRequest req)
        {
             JsonResponseModel<ModifySealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifySeal）用于修改指定印章ID的印章图片和名称。
        /// 
        /// 注：印章类型暂不支持修改，如需调整，请联系客服经理或通过创建印章接口（CreateSeal）进行创建新印章。
        /// </summary>
        /// <param name="req"><see cref="ModifySealRequest"/></param>
        /// <returns><see cref="ModifySealResponse"/></returns>
        public ModifySealResponse ModifySealSync(ModifySealRequest req)
        {
             JsonResponseModel<ModifySealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifySubOrganizationInfo）用于更新子机构信息。
        /// 
        /// 注：若修改子机构名称或更新机构证件照片，需要重新通过子机构实名接口（VerifySubOrganization）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifySubOrganizationInfoRequest"/></param>
        /// <returns><see cref="ModifySubOrganizationInfoResponse"/></returns>
        public async Task<ModifySubOrganizationInfoResponse> ModifySubOrganizationInfo(ModifySubOrganizationInfoRequest req)
        {
             JsonResponseModel<ModifySubOrganizationInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySubOrganizationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubOrganizationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifySubOrganizationInfo）用于更新子机构信息。
        /// 
        /// 注：若修改子机构名称或更新机构证件照片，需要重新通过子机构实名接口（VerifySubOrganization）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifySubOrganizationInfoRequest"/></param>
        /// <returns><see cref="ModifySubOrganizationInfoResponse"/></returns>
        public ModifySubOrganizationInfoResponse ModifySubOrganizationInfoSync(ModifySubOrganizationInfoRequest req)
        {
             JsonResponseModel<ModifySubOrganizationInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySubOrganizationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySubOrganizationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifyUser）用于更新个人用户信息。
        /// 
        /// 注：若修改用户姓名，需要重新通过个人用户实名接口（VerifyUser）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public async Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifyUser）用于更新个人用户信息。
        /// 
        /// 注：若修改用户姓名，需要重新通过个人用户实名接口（VerifyUser）进行重新实名。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口 (ModifyUserDefaultSeal) 用于重新指定个人默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyUserDefaultSealResponse"/></returns>
        public async Task<ModifyUserDefaultSealResponse> ModifyUserDefaultSeal(ModifyUserDefaultSealRequest req)
        {
             JsonResponseModel<ModifyUserDefaultSealResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserDefaultSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserDefaultSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口 (ModifyUserDefaultSeal) 用于重新指定个人默认印章。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserDefaultSealRequest"/></param>
        /// <returns><see cref="ModifyUserDefaultSealResponse"/></returns>
        public ModifyUserDefaultSealResponse ModifyUserDefaultSealSync(ModifyUserDefaultSealRequest req)
        {
             JsonResponseModel<ModifyUserDefaultSealResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserDefaultSeal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserDefaultSealResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（RejectFlow）用于用户拒绝签署合同流程。
        /// </summary>
        /// <param name="req"><see cref="RejectFlowRequest"/></param>
        /// <returns><see cref="RejectFlowResponse"/></returns>
        public async Task<RejectFlowResponse> RejectFlow(RejectFlowRequest req)
        {
             JsonResponseModel<RejectFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RejectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（RejectFlow）用于用户拒绝签署合同流程。
        /// </summary>
        /// <param name="req"><see cref="RejectFlowRequest"/></param>
        /// <returns><see cref="RejectFlowResponse"/></returns>
        public RejectFlowResponse RejectFlowSync(RejectFlowRequest req)
        {
             JsonResponseModel<RejectFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RejectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SendFlow）用于指定签署者及签署内容，后续可通过生成签署接口（CreateSignUrl）获取签署url。
        /// </summary>
        /// <param name="req"><see cref="SendFlowRequest"/></param>
        /// <returns><see cref="SendFlowResponse"/></returns>
        public async Task<SendFlowResponse> SendFlow(SendFlowRequest req)
        {
             JsonResponseModel<SendFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SendFlow）用于指定签署者及签署内容，后续可通过生成签署接口（CreateSignUrl）获取签署url。
        /// </summary>
        /// <param name="req"><see cref="SendFlowRequest"/></param>
        /// <returns><see cref="SendFlowResponse"/></returns>
        public SendFlowResponse SendFlowSync(SendFlowRequest req)
        {
             JsonResponseModel<SendFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送流程并获取签署URL
        /// </summary>
        /// <param name="req"><see cref="SendFlowUrlRequest"/></param>
        /// <returns><see cref="SendFlowUrlResponse"/></returns>
        public async Task<SendFlowUrlResponse> SendFlowUrl(SendFlowUrlRequest req)
        {
             JsonResponseModel<SendFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送流程并获取签署URL
        /// </summary>
        /// <param name="req"><see cref="SendFlowUrlRequest"/></param>
        /// <returns><see cref="SendFlowUrlResponse"/></returns>
        public SendFlowUrlResponse SendFlowUrlSync(SendFlowUrlRequest req)
        {
             JsonResponseModel<SendFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于发送签署验证码
        /// </summary>
        /// <param name="req"><see cref="SendSignInnerVerifyCodeRequest"/></param>
        /// <returns><see cref="SendSignInnerVerifyCodeResponse"/></returns>
        public async Task<SendSignInnerVerifyCodeResponse> SendSignInnerVerifyCode(SendSignInnerVerifyCodeRequest req)
        {
             JsonResponseModel<SendSignInnerVerifyCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSignInnerVerifyCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSignInnerVerifyCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于发送签署验证码
        /// </summary>
        /// <param name="req"><see cref="SendSignInnerVerifyCodeRequest"/></param>
        /// <returns><see cref="SendSignInnerVerifyCodeResponse"/></returns>
        public SendSignInnerVerifyCodeResponse SendSignInnerVerifyCodeSync(SendSignInnerVerifyCodeRequest req)
        {
             JsonResponseModel<SendSignInnerVerifyCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendSignInnerVerifyCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSignInnerVerifyCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SignFlow）可用于对流程文件进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignFlowRequest"/></param>
        /// <returns><see cref="SignFlowResponse"/></returns>
        public async Task<SignFlowResponse> SignFlow(SignFlowRequest req)
        {
             JsonResponseModel<SignFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SignFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SignFlow）可用于对流程文件进行签署。
        /// </summary>
        /// <param name="req"><see cref="SignFlowRequest"/></param>
        /// <returns><see cref="SignFlowResponse"/></returns>
        public SignFlowResponse SignFlowSync(SignFlowRequest req)
        {
             JsonResponseModel<SignFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SignFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public async Task<UploadFilesResponse> UploadFiles(UploadFilesRequest req)
        {
             JsonResponseModel<UploadFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public UploadFilesResponse UploadFilesSync(UploadFilesRequest req)
        {
             JsonResponseModel<UploadFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（VerifySubOrganization）用于通过子机构的实名认证。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifySubOrganizationRequest"/></param>
        /// <returns><see cref="VerifySubOrganizationResponse"/></returns>
        public async Task<VerifySubOrganizationResponse> VerifySubOrganization(VerifySubOrganizationRequest req)
        {
             JsonResponseModel<VerifySubOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifySubOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifySubOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（VerifySubOrganization）用于通过子机构的实名认证。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifySubOrganizationRequest"/></param>
        /// <returns><see cref="VerifySubOrganizationResponse"/></returns>
        public VerifySubOrganizationResponse VerifySubOrganizationSync(VerifySubOrganizationRequest req)
        {
             JsonResponseModel<VerifySubOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifySubOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifySubOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（VerifyUser）将腾讯电子签个人用户的实名认证状态设为通过。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifyUserRequest"/></param>
        /// <returns><see cref="VerifyUserResponse"/></returns>
        public async Task<VerifyUserResponse> VerifyUser(VerifyUserRequest req)
        {
             JsonResponseModel<VerifyUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方应用可通过此接口（VerifyUser）将腾讯电子签个人用户的实名认证状态设为通过。
        /// 
        /// 注：此接口为白名单接口，如您需要使用此能力，请提前与客户经理沟通或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        /// <param name="req"><see cref="VerifyUserRequest"/></param>
        /// <returns><see cref="VerifyUserResponse"/></returns>
        public VerifyUserResponse VerifyUserSync(VerifyUserRequest req)
        {
             JsonResponseModel<VerifyUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
