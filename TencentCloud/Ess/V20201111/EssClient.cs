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

namespace TencentCloud.Ess.V20201111
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ess.V20201111.Models;

   public class EssClient : AbstractClient{

       private const string endpoint = "ess.tencentcloudapi.com";
       private const string version = "2020-11-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 将电子签系统员工userId与客户系统员工openId进行绑定
        /// </summary>
        /// <param name="req"><see cref="BindEmployeeUserIdWithClientOpenIdRequest"/></param>
        /// <returns><see cref="BindEmployeeUserIdWithClientOpenIdResponse"/></returns>
        public async Task<BindEmployeeUserIdWithClientOpenIdResponse> BindEmployeeUserIdWithClientOpenId(BindEmployeeUserIdWithClientOpenIdRequest req)
        {
             JsonResponseModel<BindEmployeeUserIdWithClientOpenIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindEmployeeUserIdWithClientOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEmployeeUserIdWithClientOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将电子签系统员工userId与客户系统员工openId进行绑定
        /// </summary>
        /// <param name="req"><see cref="BindEmployeeUserIdWithClientOpenIdRequest"/></param>
        /// <returns><see cref="BindEmployeeUserIdWithClientOpenIdResponse"/></returns>
        public BindEmployeeUserIdWithClientOpenIdResponse BindEmployeeUserIdWithClientOpenIdSync(BindEmployeeUserIdWithClientOpenIdRequest req)
        {
             JsonResponseModel<BindEmployeeUserIdWithClientOpenIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindEmployeeUserIdWithClientOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindEmployeeUserIdWithClientOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于撤销签署流程<br/>
        /// 适用场景：如果某个合同流程当前至少还有一方没有签署，则可通过该接口取消该合同流程。常用于合同发错、内容填错，需要及时撤销的场景。<br/>
        /// `注意：如果合同流程中的参与方均已签署完毕，则无法通过该接口撤销合同。`
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
        /// 用于撤销签署流程<br/>
        /// 适用场景：如果某个合同流程当前至少还有一方没有签署，则可通过该接口取消该合同流程。常用于合同发错、内容填错，需要及时撤销的场景。<br/>
        /// `注意：如果合同流程中的参与方均已签署完毕，则无法通过该接口撤销合同。`
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
        /// 此接口（CancelMultiFlowSignQRCode）用于废除一码多扫流程签署二维码。
        /// 该接口所需的二维码ID，源自[创建一码多扫流程签署二维码](https://qian.tencent.com/developers/companyApis/startFlows/CreateMultiFlowSignQRCode)生成的。
        /// 如果该二维码尚处于有效期内，可通过本接口将其设置为失效状态。
        /// </summary>
        /// <param name="req"><see cref="CancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CancelMultiFlowSignQRCodeResponse"/></returns>
        public async Task<CancelMultiFlowSignQRCodeResponse> CancelMultiFlowSignQRCode(CancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CancelMultiFlowSignQRCode）用于废除一码多扫流程签署二维码。
        /// 该接口所需的二维码ID，源自[创建一码多扫流程签署二维码](https://qian.tencent.com/developers/companyApis/startFlows/CreateMultiFlowSignQRCode)生成的。
        /// 如果该二维码尚处于有效期内，可通过本接口将其设置为失效状态。
        /// </summary>
        /// <param name="req"><see cref="CancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CancelMultiFlowSignQRCodeResponse"/></returns>
        public CancelMultiFlowSignQRCodeResponse CancelMultiFlowSignQRCodeSync(CancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CancelUserAutoSignEnableUrl）用来撤销发送给个人用户的自动签开通链接，撤销后对应的个人用户开通链接失效。若个人用户已经完成开通，将无法撤销。（处方单场景专用，使用此接口请与客户经理确认）
        /// 
        /// 注: `在调用此接口时，请确保指定的用户已生成自动签开通链接并且未完成开通，否则无法撤销`
        /// </summary>
        /// <param name="req"><see cref="CancelUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="CancelUserAutoSignEnableUrlResponse"/></returns>
        public async Task<CancelUserAutoSignEnableUrlResponse> CancelUserAutoSignEnableUrl(CancelUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<CancelUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CancelUserAutoSignEnableUrl）用来撤销发送给个人用户的自动签开通链接，撤销后对应的个人用户开通链接失效。若个人用户已经完成开通，将无法撤销。（处方单场景专用，使用此接口请与客户经理确认）
        /// 
        /// 注: `在调用此接口时，请确保指定的用户已生成自动签开通链接并且未完成开通，否则无法撤销`
        /// </summary>
        /// <param name="req"><see cref="CancelUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="CancelUserAutoSignEnableUrlResponse"/></returns>
        public CancelUserAutoSignEnableUrlResponse CancelUserAutoSignEnableUrlSync(CancelUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<CancelUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注：此接口将会废弃，请使用撤销单个签署流程（CancelFlow）接口。
        /// 指定需要批量撤回的签署流程Id，获取批量撤销链接。
        /// 客户指定需要撤回的签署流程Id，最多100个，超过100不处理；接口调用成功返回批量撤回合同的链接，通过链接跳转到电子签小程序完成批量撤回。
        /// </summary>
        /// <param name="req"><see cref="CreateBatchCancelFlowUrlRequest"/></param>
        /// <returns><see cref="CreateBatchCancelFlowUrlResponse"/></returns>
        public async Task<CreateBatchCancelFlowUrlResponse> CreateBatchCancelFlowUrl(CreateBatchCancelFlowUrlRequest req)
        {
             JsonResponseModel<CreateBatchCancelFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBatchCancelFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchCancelFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注：此接口将会废弃，请使用撤销单个签署流程（CancelFlow）接口。
        /// 指定需要批量撤回的签署流程Id，获取批量撤销链接。
        /// 客户指定需要撤回的签署流程Id，最多100个，超过100不处理；接口调用成功返回批量撤回合同的链接，通过链接跳转到电子签小程序完成批量撤回。
        /// </summary>
        /// <param name="req"><see cref="CreateBatchCancelFlowUrlRequest"/></param>
        /// <returns><see cref="CreateBatchCancelFlowUrlResponse"/></returns>
        public CreateBatchCancelFlowUrlResponse CreateBatchCancelFlowUrlSync(CreateBatchCancelFlowUrlRequest req)
        {
             JsonResponseModel<CreateBatchCancelFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBatchCancelFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchCancelFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据产品要求，调整接口目录
        /// 
        /// 新接口：ChannelCreateOrganizationModifyQrCode 
        /// 
        /// 老接口目前无线上流量，测试用例已下线处理
        /// 
        /// 生成子客编辑企业信息二维码
        /// </summary>
        /// <param name="req"><see cref="CreateChannelSubOrganizationModifyQrCodeRequest"/></param>
        /// <returns><see cref="CreateChannelSubOrganizationModifyQrCodeResponse"/></returns>
        public async Task<CreateChannelSubOrganizationModifyQrCodeResponse> CreateChannelSubOrganizationModifyQrCode(CreateChannelSubOrganizationModifyQrCodeRequest req)
        {
             JsonResponseModel<CreateChannelSubOrganizationModifyQrCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateChannelSubOrganizationModifyQrCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChannelSubOrganizationModifyQrCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据产品要求，调整接口目录
        /// 
        /// 新接口：ChannelCreateOrganizationModifyQrCode 
        /// 
        /// 老接口目前无线上流量，测试用例已下线处理
        /// 
        /// 生成子客编辑企业信息二维码
        /// </summary>
        /// <param name="req"><see cref="CreateChannelSubOrganizationModifyQrCodeRequest"/></param>
        /// <returns><see cref="CreateChannelSubOrganizationModifyQrCodeResponse"/></returns>
        public CreateChannelSubOrganizationModifyQrCodeResponse CreateChannelSubOrganizationModifyQrCodeSync(CreateChannelSubOrganizationModifyQrCodeRequest req)
        {
             JsonResponseModel<CreateChannelSubOrganizationModifyQrCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateChannelSubOrganizationModifyQrCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateChannelSubOrganizationModifyQrCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传了word、excel、图片文件后，通过该接口发起文件转换任务，将word、excel、图片文件转换为pdf文件。
        /// </summary>
        /// <param name="req"><see cref="CreateConvertTaskApiRequest"/></param>
        /// <returns><see cref="CreateConvertTaskApiResponse"/></returns>
        public async Task<CreateConvertTaskApiResponse> CreateConvertTaskApi(CreateConvertTaskApiRequest req)
        {
             JsonResponseModel<CreateConvertTaskApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConvertTaskApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConvertTaskApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传了word、excel、图片文件后，通过该接口发起文件转换任务，将word、excel、图片文件转换为pdf文件。
        /// </summary>
        /// <param name="req"><see cref="CreateConvertTaskApiRequest"/></param>
        /// <returns><see cref="CreateConvertTaskApiResponse"/></returns>
        public CreateConvertTaskApiResponse CreateConvertTaskApiSync(CreateConvertTaskApiRequest req)
        {
             JsonResponseModel<CreateConvertTaskApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConvertTaskApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConvertTaskApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建签署流程电子文档
        /// 适用场景：见创建签署流程接口。
        /// 注：该接口需要给对应的流程指定一个模板id，并且填充该模板中需要补充的信息。是“发起流程”接口的前置接口。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public async Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建签署流程电子文档
        /// 适用场景：见创建签署流程接口。
        /// 注：该接口需要给对应的流程指定一个模板id，并且填充该模板中需要补充的信息。是“发起流程”接口的前置接口。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public CreateDocumentResponse CreateDocumentSync(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateEmbedWebUrl）用于创建嵌入web的链接 本接口支持创建：创建印章，创建模板，修改模板，预览模板，预览合同流程的web链接 进入web连接后与当前控制台操作保持一致
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedWebUrlRequest"/></param>
        /// <returns><see cref="CreateEmbedWebUrlResponse"/></returns>
        public async Task<CreateEmbedWebUrlResponse> CreateEmbedWebUrl(CreateEmbedWebUrlRequest req)
        {
             JsonResponseModel<CreateEmbedWebUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmbedWebUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmbedWebUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateEmbedWebUrl）用于创建嵌入web的链接 本接口支持创建：创建印章，创建模板，修改模板，预览模板，预览合同流程的web链接 进入web连接后与当前控制台操作保持一致
        /// </summary>
        /// <param name="req"><see cref="CreateEmbedWebUrlRequest"/></param>
        /// <returns><see cref="CreateEmbedWebUrlResponse"/></returns>
        public CreateEmbedWebUrlResponse CreateEmbedWebUrlSync(CreateEmbedWebUrlRequest req)
        {
             JsonResponseModel<CreateEmbedWebUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmbedWebUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmbedWebUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过模板创建签署流程<br/>
        /// 适用场景：在标准制式的合同场景中，可通过提前预制好模板文件，每次调用模板文件的id，补充合同内容信息及签署信息生成电子合同。<br/>
        /// 注：该接口是通过模板生成合同流程的前置接口，先创建一个不包含签署文件的流程。<br/>
        /// 配合“创建电子文档”接口和“发起流程”接口使用。<br/>
        /// </summary>
        /// <param name="req"><see cref="CreateFlowRequest"/></param>
        /// <returns><see cref="CreateFlowResponse"/></returns>
        public async Task<CreateFlowResponse> CreateFlow(CreateFlowRequest req)
        {
             JsonResponseModel<CreateFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过模板创建签署流程<br/>
        /// 适用场景：在标准制式的合同场景中，可通过提前预制好模板文件，每次调用模板文件的id，补充合同内容信息及签署信息生成电子合同。<br/>
        /// 注：该接口是通过模板生成合同流程的前置接口，先创建一个不包含签署文件的流程。<br/>
        /// 配合“创建电子文档”接口和“发起流程”接口使用。<br/>
        /// </summary>
        /// <param name="req"><see cref="CreateFlowRequest"/></param>
        /// <returns><see cref="CreateFlowResponse"/></returns>
        public CreateFlowResponse CreateFlowSync(CreateFlowRequest req)
        {
             JsonResponseModel<CreateFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ### 适用场景
        /// 在通过模板或者文件发起合同时，若未指定企业签署人信息，则流程发起后，可以调用此接口补充或签签署人。
        /// 同一签署人可以补充多个员工作为或签签署人,最终实际签署人取决于谁先领取合同完成签署。
        /// ### 限制条件
        /// -  本企业(发起方企业)支持通过企业微信UserId 或者 姓名+手机号补充
        /// - 他方企业仅支持通过姓名+手机号补充
        /// </summary>
        /// <param name="req"><see cref="CreateFlowApproversRequest"/></param>
        /// <returns><see cref="CreateFlowApproversResponse"/></returns>
        public async Task<CreateFlowApproversResponse> CreateFlowApprovers(CreateFlowApproversRequest req)
        {
             JsonResponseModel<CreateFlowApproversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowApprovers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowApproversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ### 适用场景
        /// 在通过模板或者文件发起合同时，若未指定企业签署人信息，则流程发起后，可以调用此接口补充或签签署人。
        /// 同一签署人可以补充多个员工作为或签签署人,最终实际签署人取决于谁先领取合同完成签署。
        /// ### 限制条件
        /// -  本企业(发起方企业)支持通过企业微信UserId 或者 姓名+手机号补充
        /// - 他方企业仅支持通过姓名+手机号补充
        /// </summary>
        /// <param name="req"><see cref="CreateFlowApproversRequest"/></param>
        /// <returns><see cref="CreateFlowApproversResponse"/></returns>
        public CreateFlowApproversResponse CreateFlowApproversSync(CreateFlowApproversRequest req)
        {
             JsonResponseModel<CreateFlowApproversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowApprovers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowApproversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowByFiles）用来通过上传后的pdf资源编号来创建待签署的合同流程。<br/>
        /// 适用场景1：适用非制式的合同文件签署。一般开发者自己有完整的签署文件，可以通过该接口传入完整的PDF文件及流程信息生成待签署的合同流程。<br/>
        /// 适用场景2：可通过该接口传入制式合同文件，同时在指定位置添加签署控件。可以起到接口创建临时模板的效果。如果是标准的制式文件，建议使用模板功能生成模板ID进行合同流程的生成。<br/>
        /// 注意事项：该接口需要依赖“多文件上传”接口生成pdf资源编号（FileIds）进行使用。<br/>
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
        /// 此接口（CreateFlowByFiles）用来通过上传后的pdf资源编号来创建待签署的合同流程。<br/>
        /// 适用场景1：适用非制式的合同文件签署。一般开发者自己有完整的签署文件，可以通过该接口传入完整的PDF文件及流程信息生成待签署的合同流程。<br/>
        /// 适用场景2：可通过该接口传入制式合同文件，同时在指定位置添加签署控件。可以起到接口创建临时模板的效果。如果是标准的制式文件，建议使用模板功能生成模板ID进行合同流程的生成。<br/>
        /// 注意事项：该接口需要依赖“多文件上传”接口生成pdf资源编号（FileIds）进行使用。<br/>
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
        /// 创建出证报告并返回报告ID。
        /// 使用此功能需搭配出证套餐。
        /// 注意：出证过程需一定时间，建议在调用创建出证后的24小时之后，通过DescribeFlowEvidenceReport接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="CreateFlowEvidenceReportResponse"/></returns>
        public async Task<CreateFlowEvidenceReportResponse> CreateFlowEvidenceReport(CreateFlowEvidenceReportRequest req)
        {
             JsonResponseModel<CreateFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建出证报告并返回报告ID。
        /// 使用此功能需搭配出证套餐。
        /// 注意：出证过程需一定时间，建议在调用创建出证后的24小时之后，通过DescribeFlowEvidenceReport接口进行查询。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="CreateFlowEvidenceReportResponse"/></returns>
        public CreateFlowEvidenceReportResponse CreateFlowEvidenceReportSync(CreateFlowEvidenceReportRequest req)
        {
             JsonResponseModel<CreateFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowGroupByFiles）通过多文件创建合同组签署流程。<br/>
        /// PDF资源Id 通过上传文件接口获取
        /// 此接口合同组中的子合同必须都是文件发起的合同
        /// </summary>
        /// <param name="req"><see cref="CreateFlowGroupByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowGroupByFilesResponse"/></returns>
        public async Task<CreateFlowGroupByFilesResponse> CreateFlowGroupByFiles(CreateFlowGroupByFilesRequest req)
        {
             JsonResponseModel<CreateFlowGroupByFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowGroupByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowGroupByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowGroupByFiles）通过多文件创建合同组签署流程。<br/>
        /// PDF资源Id 通过上传文件接口获取
        /// 此接口合同组中的子合同必须都是文件发起的合同
        /// </summary>
        /// <param name="req"><see cref="CreateFlowGroupByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowGroupByFilesResponse"/></returns>
        public CreateFlowGroupByFilesResponse CreateFlowGroupByFilesSync(CreateFlowGroupByFilesRequest req)
        {
             JsonResponseModel<CreateFlowGroupByFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowGroupByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowGroupByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowGroupByTemplates）通过多模板创建合同组签署流程。<br/>
        /// 此接口合同组中的子合同必须都是模板发起的合同。 <br/>目前最大仅支持50个子合同
        /// </summary>
        /// <param name="req"><see cref="CreateFlowGroupByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowGroupByTemplatesResponse"/></returns>
        public async Task<CreateFlowGroupByTemplatesResponse> CreateFlowGroupByTemplates(CreateFlowGroupByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowGroupByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowGroupByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowGroupByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowGroupByTemplates）通过多模板创建合同组签署流程。<br/>
        /// 此接口合同组中的子合同必须都是模板发起的合同。 <br/>目前最大仅支持50个子合同
        /// </summary>
        /// <param name="req"><see cref="CreateFlowGroupByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowGroupByTemplatesResponse"/></returns>
        public CreateFlowGroupByTemplatesResponse CreateFlowGroupByTemplatesSync(CreateFlowGroupByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowGroupByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowGroupByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowGroupByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量催办的签署流程ID，批量催办合同，最多100个。需要符合以下条件的合同才可被催办：
        /// 
        /// 1. 发起合同时，签署人的NotifyType需设置为sms
        /// 2. 合同中当前状态为“待签署”的签署人是催办的对象
        /// 3. 每个合同只能催办一次
        /// 
        /// 注意：该接口无法直接调用，请联系客户经理申请使用。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowRemindsRequest"/></param>
        /// <returns><see cref="CreateFlowRemindsResponse"/></returns>
        public async Task<CreateFlowRemindsResponse> CreateFlowReminds(CreateFlowRemindsRequest req)
        {
             JsonResponseModel<CreateFlowRemindsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowReminds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowRemindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量催办的签署流程ID，批量催办合同，最多100个。需要符合以下条件的合同才可被催办：
        /// 
        /// 1. 发起合同时，签署人的NotifyType需设置为sms
        /// 2. 合同中当前状态为“待签署”的签署人是催办的对象
        /// 3. 每个合同只能催办一次
        /// 
        /// 注意：该接口无法直接调用，请联系客户经理申请使用。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowRemindsRequest"/></param>
        /// <returns><see cref="CreateFlowRemindsResponse"/></returns>
        public CreateFlowRemindsResponse CreateFlowRemindsSync(CreateFlowRemindsRequest req)
        {
             JsonResponseModel<CreateFlowRemindsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowReminds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowRemindsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交企业签署流程审批结果
        /// 适用场景: 
        /// 在通过接口(CreateFlow 或者CreateFlowByFiles)创建签署流程时，若指定了参数 NeedSignReview 为true，且发起方企业作为签署方参与了流程签署，则可以调用此接口提交企业内部签署审批结果。
        /// 若签署流程状态正常，且本企业存在签署方未签署，同一签署流程可以多次提交签署审批结果，签署时的最后一个“审批结果”有效。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowSignReviewRequest"/></param>
        /// <returns><see cref="CreateFlowSignReviewResponse"/></returns>
        public async Task<CreateFlowSignReviewResponse> CreateFlowSignReview(CreateFlowSignReviewRequest req)
        {
             JsonResponseModel<CreateFlowSignReviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowSignReview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowSignReviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交企业签署流程审批结果
        /// 适用场景: 
        /// 在通过接口(CreateFlow 或者CreateFlowByFiles)创建签署流程时，若指定了参数 NeedSignReview 为true，且发起方企业作为签署方参与了流程签署，则可以调用此接口提交企业内部签署审批结果。
        /// 若签署流程状态正常，且本企业存在签署方未签署，同一签署流程可以多次提交签署审批结果，签署时的最后一个“审批结果”有效。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowSignReviewRequest"/></param>
        /// <returns><see cref="CreateFlowSignReviewResponse"/></returns>
        public CreateFlowSignReviewResponse CreateFlowSignReviewSync(CreateFlowSignReviewRequest req)
        {
             JsonResponseModel<CreateFlowSignReviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowSignReview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowSignReviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于发起合同后，生成个人用户的签署链接, 暂时不支持企业端签署 <br/>
        /// 
        /// 注：
        /// `1. 该接口目前仅支持签署人类型是个人签署方的场景（PERSON）` 
        /// `2. 该接口可生成签署链接的C端签署人必须仅有手写签名和时间类型的签署控件，不支持填写控件 `
        /// `3. 该接口返回的签署链接是用于APP集成的场景，支持APP打开或浏览器直接打开，不支持微信小程序嵌入`。跳转到小程序的实现，参考微信官方文档（分为<a href="https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html">全屏</a>、<a href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html">半屏</a>两种方式），如何配置也可以请参考: <a href="https://qian.tencent.com/developers/company/openwxminiprogram">跳转电子签小程序配置</a>
        /// </summary>
        /// <param name="req"><see cref="CreateFlowSignUrlRequest"/></param>
        /// <returns><see cref="CreateFlowSignUrlResponse"/></returns>
        public async Task<CreateFlowSignUrlResponse> CreateFlowSignUrl(CreateFlowSignUrlRequest req)
        {
             JsonResponseModel<CreateFlowSignUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于发起合同后，生成个人用户的签署链接, 暂时不支持企业端签署 <br/>
        /// 
        /// 注：
        /// `1. 该接口目前仅支持签署人类型是个人签署方的场景（PERSON）` 
        /// `2. 该接口可生成签署链接的C端签署人必须仅有手写签名和时间类型的签署控件，不支持填写控件 `
        /// `3. 该接口返回的签署链接是用于APP集成的场景，支持APP打开或浏览器直接打开，不支持微信小程序嵌入`。跳转到小程序的实现，参考微信官方文档（分为<a href="https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html">全屏</a>、<a href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html">半屏</a>两种方式），如何配置也可以请参考: <a href="https://qian.tencent.com/developers/company/openwxminiprogram">跳转电子签小程序配置</a>
        /// </summary>
        /// <param name="req"><see cref="CreateFlowSignUrlRequest"/></param>
        /// <returns><see cref="CreateFlowSignUrlResponse"/></returns>
        public CreateFlowSignUrlResponse CreateFlowSignUrlSync(CreateFlowSignUrlRequest req)
        {
             JsonResponseModel<CreateFlowSignUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，创建企业的部门，支持绑定客户系统部门ID。
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationDepartmentRequest"/></param>
        /// <returns><see cref="CreateIntegrationDepartmentResponse"/></returns>
        public async Task<CreateIntegrationDepartmentResponse> CreateIntegrationDepartment(CreateIntegrationDepartmentRequest req)
        {
             JsonResponseModel<CreateIntegrationDepartmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntegrationDepartment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationDepartmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，创建企业的部门，支持绑定客户系统部门ID。
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationDepartmentRequest"/></param>
        /// <returns><see cref="CreateIntegrationDepartmentResponse"/></returns>
        public CreateIntegrationDepartmentResponse CreateIntegrationDepartmentSync(CreateIntegrationDepartmentRequest req)
        {
             JsonResponseModel<CreateIntegrationDepartmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntegrationDepartment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationDepartmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建员工,此接口会发送提醒员工实名的短信，如果通过手机号发现员工已经创建，则不会重新创建，会发送短信提醒员工实名
        /// 注意：此接口支持企微组织架构的 openid 创建员工，这种场景下传递明文的企微 openid 到WeworkOpenId字段即可（企微明文的 openid 一定要在应用的可见范围内才行），通过企微创建的员工，会发送企微消息去提醒实名
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="CreateIntegrationEmployeesResponse"/></returns>
        public async Task<CreateIntegrationEmployeesResponse> CreateIntegrationEmployees(CreateIntegrationEmployeesRequest req)
        {
             JsonResponseModel<CreateIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建员工,此接口会发送提醒员工实名的短信，如果通过手机号发现员工已经创建，则不会重新创建，会发送短信提醒员工实名
        /// 注意：此接口支持企微组织架构的 openid 创建员工，这种场景下传递明文的企微 openid 到WeworkOpenId字段即可（企微明文的 openid 一定要在应用的可见范围内才行），通过企微创建的员工，会发送企微消息去提醒实名
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="CreateIntegrationEmployeesResponse"/></returns>
        public CreateIntegrationEmployeesResponse CreateIntegrationEmployeesSync(CreateIntegrationEmployeesRequest req)
        {
             JsonResponseModel<CreateIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateIntegrationRole）用来创建企业自定义的SaaS角色或集团角色。
        /// 
        /// 适用场景1：创建当前企业的自定义SaaS角色或集团角色，并且创建时不进行权限的设置（PermissionGroups 参数不传），角色中的权限内容可通过控制台编辑角色或通过接口 ModifyIntegrationRole 完成更新。
        /// 
        /// 适用场景2：创建当前企业的自定义SaaS角色或集团角色，并且创建时进行权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 DescribeIntegrationRoles 的输出。
        /// 适用场景3：创建集团角色时可同时设置角色管理的子企业列表，可通过设置 SubOrganizationIds 参数达到此效果。
        /// 
        /// 适用场景4：主企业代理子企业操作的场景，需要设置Agent参数，并且ProxyOrganizationId设置为子企业的id即可。
        /// 
        /// 注意事项：SaaS角色和集团角色对应的权限树是不一样的。
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationRoleRequest"/></param>
        /// <returns><see cref="CreateIntegrationRoleResponse"/></returns>
        public async Task<CreateIntegrationRoleResponse> CreateIntegrationRole(CreateIntegrationRoleRequest req)
        {
             JsonResponseModel<CreateIntegrationRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntegrationRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateIntegrationRole）用来创建企业自定义的SaaS角色或集团角色。
        /// 
        /// 适用场景1：创建当前企业的自定义SaaS角色或集团角色，并且创建时不进行权限的设置（PermissionGroups 参数不传），角色中的权限内容可通过控制台编辑角色或通过接口 ModifyIntegrationRole 完成更新。
        /// 
        /// 适用场景2：创建当前企业的自定义SaaS角色或集团角色，并且创建时进行权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 DescribeIntegrationRoles 的输出。
        /// 适用场景3：创建集团角色时可同时设置角色管理的子企业列表，可通过设置 SubOrganizationIds 参数达到此效果。
        /// 
        /// 适用场景4：主企业代理子企业操作的场景，需要设置Agent参数，并且ProxyOrganizationId设置为子企业的id即可。
        /// 
        /// 注意事项：SaaS角色和集团角色对应的权限树是不一样的。
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationRoleRequest"/></param>
        /// <returns><see cref="CreateIntegrationRoleResponse"/></returns>
        public CreateIntegrationRoleResponse CreateIntegrationRoleSync(CreateIntegrationRoleRequest req)
        {
             JsonResponseModel<CreateIntegrationRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntegrationRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定员工与对应角色
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationUserRolesRequest"/></param>
        /// <returns><see cref="CreateIntegrationUserRolesResponse"/></returns>
        public async Task<CreateIntegrationUserRolesResponse> CreateIntegrationUserRoles(CreateIntegrationUserRolesRequest req)
        {
             JsonResponseModel<CreateIntegrationUserRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIntegrationUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定员工与对应角色
        /// </summary>
        /// <param name="req"><see cref="CreateIntegrationUserRolesRequest"/></param>
        /// <returns><see cref="CreateIntegrationUserRolesResponse"/></returns>
        public CreateIntegrationUserRolesResponse CreateIntegrationUserRolesSync(CreateIntegrationUserRolesRequest req)
        {
             JsonResponseModel<CreateIntegrationUserRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIntegrationUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIntegrationUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateMultiFlowSignQRCode）用于创建一码多扫流程签署二维码。
        /// 适用场景：无需填写签署人信息，可通过模板id生成签署二维码，签署人可通过扫描二维码补充签署信息进行实名签署。
        /// 常用于提前不知道签署人的身份信息场景，例如：劳务工招工、大批量员工入职等场景。
        /// 
        /// **本接口适用于发起方没有填写控件的 B2C或者单C模板**
        /// 
        /// **若是B2C模板,还要满足以下任意一个条件**
        /// - 模板中配置的签署顺序是无序
        /// - B端企业的签署方式是静默签署
        /// - B端企业是非首位签署
        /// 
        ///  通过一码多扫二维码发起的合同，涉及到的合同回调消息可参考文档[合同发起以及签署相关回调](https://qian.tencent.com/developers/company/callback_types_contracts_sign)
        /// 
        /// 用户通过签署二维码发起合同时，因企业额度不足导致失败 会触发签署二维码相关回调,具体参考文档[签署二维码相关回调](https://qian.tencent.com/developers/company/callback_types_commons#%E7%AD%BE%E7%BD%B2%E4%BA%8C%E7%BB%B4%E7%A0%81%E7%9B%B8%E5%85%B3%E5%9B%9E%E8%B0%83)
        /// </summary>
        /// <param name="req"><see cref="CreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CreateMultiFlowSignQRCodeResponse"/></returns>
        public async Task<CreateMultiFlowSignQRCodeResponse> CreateMultiFlowSignQRCode(CreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateMultiFlowSignQRCode）用于创建一码多扫流程签署二维码。
        /// 适用场景：无需填写签署人信息，可通过模板id生成签署二维码，签署人可通过扫描二维码补充签署信息进行实名签署。
        /// 常用于提前不知道签署人的身份信息场景，例如：劳务工招工、大批量员工入职等场景。
        /// 
        /// **本接口适用于发起方没有填写控件的 B2C或者单C模板**
        /// 
        /// **若是B2C模板,还要满足以下任意一个条件**
        /// - 模板中配置的签署顺序是无序
        /// - B端企业的签署方式是静默签署
        /// - B端企业是非首位签署
        /// 
        ///  通过一码多扫二维码发起的合同，涉及到的合同回调消息可参考文档[合同发起以及签署相关回调](https://qian.tencent.com/developers/company/callback_types_contracts_sign)
        /// 
        /// 用户通过签署二维码发起合同时，因企业额度不足导致失败 会触发签署二维码相关回调,具体参考文档[签署二维码相关回调](https://qian.tencent.com/developers/company/callback_types_commons#%E7%AD%BE%E7%BD%B2%E4%BA%8C%E7%BB%B4%E7%A0%81%E7%9B%B8%E5%85%B3%E5%9B%9E%E8%B0%83)
        /// </summary>
        /// <param name="req"><see cref="CreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CreateMultiFlowSignQRCodeResponse"/></returns>
        public CreateMultiFlowSignQRCodeResponse CreateMultiFlowSignQRCodeSync(CreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，创建企业批量签署链接，企业员工点击链接即可跳转控制台进行批量签署。
        /// 如果没有UserId，Name和Mobile必填，对应的员工必须在企业下已经实名，且该员工为批量签署合同中的签署方。
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationBatchSignUrlRequest"/></param>
        /// <returns><see cref="CreateOrganizationBatchSignUrlResponse"/></returns>
        public async Task<CreateOrganizationBatchSignUrlResponse> CreateOrganizationBatchSignUrl(CreateOrganizationBatchSignUrlRequest req)
        {
             JsonResponseModel<CreateOrganizationBatchSignUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrganizationBatchSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationBatchSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，创建企业批量签署链接，企业员工点击链接即可跳转控制台进行批量签署。
        /// 如果没有UserId，Name和Mobile必填，对应的员工必须在企业下已经实名，且该员工为批量签署合同中的签署方。
        /// </summary>
        /// <param name="req"><see cref="CreateOrganizationBatchSignUrlRequest"/></param>
        /// <returns><see cref="CreateOrganizationBatchSignUrlResponse"/></returns>
        public CreateOrganizationBatchSignUrlResponse CreateOrganizationBatchSignUrlSync(CreateOrganizationBatchSignUrlRequest req)
        {
             JsonResponseModel<CreateOrganizationBatchSignUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrganizationBatchSignUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrganizationBatchSignUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePersonAuthCertificateImage）用于创建个人用户证书证明图片
        /// </summary>
        /// <param name="req"><see cref="CreatePersonAuthCertificateImageRequest"/></param>
        /// <returns><see cref="CreatePersonAuthCertificateImageResponse"/></returns>
        public async Task<CreatePersonAuthCertificateImageResponse> CreatePersonAuthCertificateImage(CreatePersonAuthCertificateImageRequest req)
        {
             JsonResponseModel<CreatePersonAuthCertificateImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePersonAuthCertificateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonAuthCertificateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePersonAuthCertificateImage）用于创建个人用户证书证明图片
        /// </summary>
        /// <param name="req"><see cref="CreatePersonAuthCertificateImageRequest"/></param>
        /// <returns><see cref="CreatePersonAuthCertificateImageResponse"/></returns>
        public CreatePersonAuthCertificateImageResponse CreatePersonAuthCertificateImageSync(CreatePersonAuthCertificateImageRequest req)
        {
             JsonResponseModel<CreatePersonAuthCertificateImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePersonAuthCertificateImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonAuthCertificateImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建快速发起流程
        /// <br/>适用场景：用户通过API 合同文件及签署信息，并可通过我们返回的URL在页面完成签署控件等信息的编辑与确认，快速发起合同.
        /// <br/>注：该接口文件的resourceId 是通过上传文件之后获取的。
        /// </summary>
        /// <param name="req"><see cref="CreatePrepareFlowRequest"/></param>
        /// <returns><see cref="CreatePrepareFlowResponse"/></returns>
        public async Task<CreatePrepareFlowResponse> CreatePrepareFlow(CreatePrepareFlowRequest req)
        {
             JsonResponseModel<CreatePrepareFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrepareFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrepareFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建快速发起流程
        /// <br/>适用场景：用户通过API 合同文件及签署信息，并可通过我们返回的URL在页面完成签署控件等信息的编辑与确认，快速发起合同.
        /// <br/>注：该接口文件的resourceId 是通过上传文件之后获取的。
        /// </summary>
        /// <param name="req"><see cref="CreatePrepareFlowRequest"/></param>
        /// <returns><see cref="CreatePrepareFlowResponse"/></returns>
        public CreatePrepareFlowResponse CreatePrepareFlowSync(CreatePrepareFlowRequest req)
        {
             JsonResponseModel<CreatePrepareFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrepareFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrepareFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePreparedPersonalEsign）用于创建导入个人印章（处方单场景专用，使用此接口请与客户经理确认）。
        /// </summary>
        /// <param name="req"><see cref="CreatePreparedPersonalEsignRequest"/></param>
        /// <returns><see cref="CreatePreparedPersonalEsignResponse"/></returns>
        public async Task<CreatePreparedPersonalEsignResponse> CreatePreparedPersonalEsign(CreatePreparedPersonalEsignRequest req)
        {
             JsonResponseModel<CreatePreparedPersonalEsignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePreparedPersonalEsign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePreparedPersonalEsignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreatePreparedPersonalEsign）用于创建导入个人印章（处方单场景专用，使用此接口请与客户经理确认）。
        /// </summary>
        /// <param name="req"><see cref="CreatePreparedPersonalEsignRequest"/></param>
        /// <returns><see cref="CreatePreparedPersonalEsignResponse"/></returns>
        public CreatePreparedPersonalEsignResponse CreatePreparedPersonalEsignSync(CreatePreparedPersonalEsignRequest req)
        {
             JsonResponseModel<CreatePreparedPersonalEsignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePreparedPersonalEsign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePreparedPersonalEsignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起解除协议，主要应用场景为：基于一份已经签署的合同(签署流程)，进行解除操作。
        /// 
        /// `注意：原合同必须签署完成后，才能发起解除协议。` <br/>
        /// `注意：只有原合同企业类型的参与人才能发起解除协议，个人不能发起解除协议。`<br/>
        /// `注意：原合同个人类型参与人必须是解除协议的参与人，不能更换其他第三方个人参与解除协议。`<br/>
        /// `注意：如果原合同企业参与人无法参与解除协议，可以指定同企业具有同等权限的企业员工代为处理。`<br/>
        /// `注意：发起解除协议同发起其他企业合同一样，也会参与合同扣费，扣费标准同其他类型合同。`<br/>
        /// `注意：在解除协议发起之后，原合同的状态将转变为解除中。一旦解除协议签署完毕，原合同及解除协议均会转变为已解除状态。`<br/>
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFlowRequest"/></param>
        /// <returns><see cref="CreateReleaseFlowResponse"/></returns>
        public async Task<CreateReleaseFlowResponse> CreateReleaseFlow(CreateReleaseFlowRequest req)
        {
             JsonResponseModel<CreateReleaseFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReleaseFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReleaseFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起解除协议，主要应用场景为：基于一份已经签署的合同(签署流程)，进行解除操作。
        /// 
        /// `注意：原合同必须签署完成后，才能发起解除协议。` <br/>
        /// `注意：只有原合同企业类型的参与人才能发起解除协议，个人不能发起解除协议。`<br/>
        /// `注意：原合同个人类型参与人必须是解除协议的参与人，不能更换其他第三方个人参与解除协议。`<br/>
        /// `注意：如果原合同企业参与人无法参与解除协议，可以指定同企业具有同等权限的企业员工代为处理。`<br/>
        /// `注意：发起解除协议同发起其他企业合同一样，也会参与合同扣费，扣费标准同其他类型合同。`<br/>
        /// `注意：在解除协议发起之后，原合同的状态将转变为解除中。一旦解除协议签署完毕，原合同及解除协议均会转变为已解除状态。`<br/>
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFlowRequest"/></param>
        /// <returns><see cref="CreateReleaseFlowResponse"/></returns>
        public CreateReleaseFlowResponse CreateReleaseFlowSync(CreateReleaseFlowRequest req)
        {
             JsonResponseModel<CreateReleaseFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReleaseFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReleaseFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取跳转至腾讯电子签小程序的签署链接
        /// 
        /// 适用场景：如果需要签署人在自己的APP、小程序、H5应用中签署，可以通过此接口获取跳转腾讯电子签小程序的签署跳转链接。
        /// 
        /// 跳转到小程序的实现，参考微信官方文档（分为<a href="https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html">全屏</a>、<a href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html">半屏</a>两种方式），如何配置也可以请参考: <a href="https://qian.tencent.com/developers/company/openwxminiprogram">跳转电子签小程序配置</a>
        /// 
        /// 注：
        /// `1. 如果签署人是在PC端扫码签署，可以通过生成跳转链接自主转换成二维码，让签署人在PC端扫码签署`
        /// `2. 签署链接的有效期为90天，超过有效期链接不可用`
        /// 
        /// 其中小程序的原始Id如下，或者查看小程序信息自助获取。
        /// 
        /// | 小程序 | AppID | 原始ID |
        /// | ------------ | ------------ | ------------ |
        /// | 腾讯电子签（正式版） | wxa023b292fd19d41d | gh_da88f6188665 |
        /// | 腾讯电子签Demo | wx371151823f6f3edf | gh_39a5d3de69fa |
        /// </summary>
        /// <param name="req"><see cref="CreateSchemeUrlRequest"/></param>
        /// <returns><see cref="CreateSchemeUrlResponse"/></returns>
        public async Task<CreateSchemeUrlResponse> CreateSchemeUrl(CreateSchemeUrlRequest req)
        {
             JsonResponseModel<CreateSchemeUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSchemeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchemeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取跳转至腾讯电子签小程序的签署链接
        /// 
        /// 适用场景：如果需要签署人在自己的APP、小程序、H5应用中签署，可以通过此接口获取跳转腾讯电子签小程序的签署跳转链接。
        /// 
        /// 跳转到小程序的实现，参考微信官方文档（分为<a href="https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html">全屏</a>、<a href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html">半屏</a>两种方式），如何配置也可以请参考: <a href="https://qian.tencent.com/developers/company/openwxminiprogram">跳转电子签小程序配置</a>
        /// 
        /// 注：
        /// `1. 如果签署人是在PC端扫码签署，可以通过生成跳转链接自主转换成二维码，让签署人在PC端扫码签署`
        /// `2. 签署链接的有效期为90天，超过有效期链接不可用`
        /// 
        /// 其中小程序的原始Id如下，或者查看小程序信息自助获取。
        /// 
        /// | 小程序 | AppID | 原始ID |
        /// | ------------ | ------------ | ------------ |
        /// | 腾讯电子签（正式版） | wxa023b292fd19d41d | gh_da88f6188665 |
        /// | 腾讯电子签Demo | wx371151823f6f3edf | gh_39a5d3de69fa |
        /// </summary>
        /// <param name="req"><see cref="CreateSchemeUrlRequest"/></param>
        /// <returns><see cref="CreateSchemeUrlResponse"/></returns>
        public CreateSchemeUrlResponse CreateSchemeUrlSync(CreateSchemeUrlRequest req)
        {
             JsonResponseModel<CreateSchemeUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSchemeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchemeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSeal）用于创建企业电子印章，支持创建企业公章，合同章，财务专用章和人事专用章创建。
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
        /// 本接口（CreateSeal）用于创建企业电子印章，支持创建企业公章，合同章，财务专用章和人事专用章创建。
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
        /// 对企业员工进行印章授权
        /// </summary>
        /// <param name="req"><see cref="CreateSealPolicyRequest"/></param>
        /// <returns><see cref="CreateSealPolicyResponse"/></returns>
        public async Task<CreateSealPolicyResponse> CreateSealPolicy(CreateSealPolicyRequest req)
        {
             JsonResponseModel<CreateSealPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSealPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对企业员工进行印章授权
        /// </summary>
        /// <param name="req"><see cref="CreateSealPolicyRequest"/></param>
        /// <returns><see cref="CreateSealPolicyResponse"/></returns>
        public CreateSealPolicyResponse CreateSealPolicySync(CreateSealPolicyRequest req)
        {
             JsonResponseModel<CreateSealPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSealPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口获取个人用户开启自动签的跳转链接（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="CreateUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="CreateUserAutoSignEnableUrlResponse"/></returns>
        public async Task<CreateUserAutoSignEnableUrlResponse> CreateUserAutoSignEnableUrl(CreateUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<CreateUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口获取个人用户开启自动签的跳转链接（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="CreateUserAutoSignEnableUrlRequest"/></param>
        /// <returns><see cref="CreateUserAutoSignEnableUrlResponse"/></returns>
        public CreateUserAutoSignEnableUrlResponse CreateUserAutoSignEnableUrlSync(CreateUserAutoSignEnableUrlRequest req)
        {
             JsonResponseModel<CreateUserAutoSignEnableUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserAutoSignEnableUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserAutoSignEnableUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用来创建页面主题配置
        /// </summary>
        /// <param name="req"><see cref="CreateWebThemeConfigRequest"/></param>
        /// <returns><see cref="CreateWebThemeConfigResponse"/></returns>
        public async Task<CreateWebThemeConfigResponse> CreateWebThemeConfig(CreateWebThemeConfigRequest req)
        {
             JsonResponseModel<CreateWebThemeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWebThemeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebThemeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用来创建页面主题配置
        /// </summary>
        /// <param name="req"><see cref="CreateWebThemeConfigRequest"/></param>
        /// <returns><see cref="CreateWebThemeConfigResponse"/></returns>
        public CreateWebThemeConfigResponse CreateWebThemeConfigSync(CreateWebThemeConfigRequest req)
        {
             JsonResponseModel<CreateWebThemeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWebThemeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebThemeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，删除企业的部门。
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationDepartmentRequest"/></param>
        /// <returns><see cref="DeleteIntegrationDepartmentResponse"/></returns>
        public async Task<DeleteIntegrationDepartmentResponse> DeleteIntegrationDepartment(DeleteIntegrationDepartmentRequest req)
        {
             JsonResponseModel<DeleteIntegrationDepartmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIntegrationDepartment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationDepartmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，删除企业的部门。
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationDepartmentRequest"/></param>
        /// <returns><see cref="DeleteIntegrationDepartmentResponse"/></returns>
        public DeleteIntegrationDepartmentResponse DeleteIntegrationDepartmentSync(DeleteIntegrationDepartmentRequest req)
        {
             JsonResponseModel<DeleteIntegrationDepartmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIntegrationDepartment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationDepartmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除员工
        /// 这里分两个场景
        /// 如果不传交接人的ReceiveUserId或者ReceiveOpenId，则会直接把这个人进行离职
        /// 如果传了交接人，会把离职人未处理完的合同交接给交接人后再离职
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="DeleteIntegrationEmployeesResponse"/></returns>
        public async Task<DeleteIntegrationEmployeesResponse> DeleteIntegrationEmployees(DeleteIntegrationEmployeesRequest req)
        {
             JsonResponseModel<DeleteIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除员工
        /// 这里分两个场景
        /// 如果不传交接人的ReceiveUserId或者ReceiveOpenId，则会直接把这个人进行离职
        /// 如果传了交接人，会把离职人未处理完的合同交接给交接人后再离职
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="DeleteIntegrationEmployeesResponse"/></returns>
        public DeleteIntegrationEmployeesResponse DeleteIntegrationEmployeesSync(DeleteIntegrationEmployeesRequest req)
        {
             JsonResponseModel<DeleteIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑员工与对应角色关系
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationRoleUsersRequest"/></param>
        /// <returns><see cref="DeleteIntegrationRoleUsersResponse"/></returns>
        public async Task<DeleteIntegrationRoleUsersResponse> DeleteIntegrationRoleUsers(DeleteIntegrationRoleUsersRequest req)
        {
             JsonResponseModel<DeleteIntegrationRoleUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIntegrationRoleUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationRoleUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑员工与对应角色关系
        /// </summary>
        /// <param name="req"><see cref="DeleteIntegrationRoleUsersRequest"/></param>
        /// <returns><see cref="DeleteIntegrationRoleUsersResponse"/></returns>
        public DeleteIntegrationRoleUsersResponse DeleteIntegrationRoleUsersSync(DeleteIntegrationRoleUsersRequest req)
        {
             JsonResponseModel<DeleteIntegrationRoleUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIntegrationRoleUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIntegrationRoleUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销员工持有的印章权限
        /// </summary>
        /// <param name="req"><see cref="DeleteSealPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSealPoliciesResponse"/></returns>
        public async Task<DeleteSealPoliciesResponse> DeleteSealPolicies(DeleteSealPoliciesRequest req)
        {
             JsonResponseModel<DeleteSealPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSealPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSealPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销员工持有的印章权限
        /// </summary>
        /// <param name="req"><see cref="DeleteSealPoliciesRequest"/></param>
        /// <returns><see cref="DeleteSealPoliciesResponse"/></returns>
        public DeleteSealPoliciesResponse DeleteSealPoliciesSync(DeleteSealPoliciesRequest req)
        {
             JsonResponseModel<DeleteSealPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSealPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSealPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业扩展服务的开通和授权情况，当前支持查询以下内容：
        /// 1. 企业静默签
        /// 2. 企业与港澳台居民签署合同
        /// 3. 使用手机号验证签署方身份
        /// 4. 骑缝章
        /// 5. 批量签署能力
        /// </summary>
        /// <param name="req"><see cref="DescribeExtendedServiceAuthInfosRequest"/></param>
        /// <returns><see cref="DescribeExtendedServiceAuthInfosResponse"/></returns>
        public async Task<DescribeExtendedServiceAuthInfosResponse> DescribeExtendedServiceAuthInfos(DescribeExtendedServiceAuthInfosRequest req)
        {
             JsonResponseModel<DescribeExtendedServiceAuthInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExtendedServiceAuthInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtendedServiceAuthInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业扩展服务的开通和授权情况，当前支持查询以下内容：
        /// 1. 企业静默签
        /// 2. 企业与港澳台居民签署合同
        /// 3. 使用手机号验证签署方身份
        /// 4. 骑缝章
        /// 5. 批量签署能力
        /// </summary>
        /// <param name="req"><see cref="DescribeExtendedServiceAuthInfosRequest"/></param>
        /// <returns><see cref="DescribeExtendedServiceAuthInfosResponse"/></returns>
        public DescribeExtendedServiceAuthInfosResponse DescribeExtendedServiceAuthInfosSync(DescribeExtendedServiceAuthInfosRequest req)
        {
             JsonResponseModel<DescribeExtendedServiceAuthInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExtendedServiceAuthInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExtendedServiceAuthInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件下载URL。
        /// 适用场景：通过传参合同流程编号，下载对应的合同PDF文件流到本地。
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
        /// 查询文件下载URL。
        /// 适用场景：通过传参合同流程编号，下载对应的合同PDF文件流到本地。
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
        /// 查询流程基础信息
        /// 适用场景：可用于主动查询某个合同流程的签署状态信息。可以配合回调通知使用。
        /// 每个企业限制日调用量限制：100W，当日超过此限制后再调用接口返回错误
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowBriefsRequest"/></param>
        /// <returns><see cref="DescribeFlowBriefsResponse"/></returns>
        public async Task<DescribeFlowBriefsResponse> DescribeFlowBriefs(DescribeFlowBriefsRequest req)
        {
             JsonResponseModel<DescribeFlowBriefsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowBriefs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowBriefsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程基础信息
        /// 适用场景：可用于主动查询某个合同流程的签署状态信息。可以配合回调通知使用。
        /// 每个企业限制日调用量限制：100W，当日超过此限制后再调用接口返回错误
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowBriefsRequest"/></param>
        /// <returns><see cref="DescribeFlowBriefsResponse"/></returns>
        public DescribeFlowBriefsResponse DescribeFlowBriefsSync(DescribeFlowBriefsRequest req)
        {
             JsonResponseModel<DescribeFlowBriefsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowBriefs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowBriefsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程填写控件内容，可以根据流程Id查询该流程相关联的填写控件信息和填写内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowComponentsRequest"/></param>
        /// <returns><see cref="DescribeFlowComponentsResponse"/></returns>
        public async Task<DescribeFlowComponentsResponse> DescribeFlowComponents(DescribeFlowComponentsRequest req)
        {
             JsonResponseModel<DescribeFlowComponentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowComponentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程填写控件内容，可以根据流程Id查询该流程相关联的填写控件信息和填写内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowComponentsRequest"/></param>
        /// <returns><see cref="DescribeFlowComponentsResponse"/></returns>
        public DescribeFlowComponentsResponse DescribeFlowComponentsSync(DescribeFlowComponentsRequest req)
        {
             JsonResponseModel<DescribeFlowComponentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowComponents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowComponentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询签署报告，返回报告 URL。需调用创建并返回出证报告接口（CreateFlowEvidenceReport）获取报告编号后调用当前接口获取报告链接。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="DescribeFlowEvidenceReportResponse"/></returns>
        public async Task<DescribeFlowEvidenceReportResponse> DescribeFlowEvidenceReport(DescribeFlowEvidenceReportRequest req)
        {
             JsonResponseModel<DescribeFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询签署报告，返回报告 URL。需调用创建并返回出证报告接口（CreateFlowEvidenceReport）获取报告编号后调用当前接口获取报告链接。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowEvidenceReportRequest"/></param>
        /// <returns><see cref="DescribeFlowEvidenceReportResponse"/></returns>
        public DescribeFlowEvidenceReportResponse DescribeFlowEvidenceReportSync(DescribeFlowEvidenceReportRequest req)
        {
             JsonResponseModel<DescribeFlowEvidenceReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowEvidenceReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowEvidenceReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询合同详情
        /// 适用场景：可用于主动查询某个合同详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowInfoResponse"/></returns>
        public async Task<DescribeFlowInfoResponse> DescribeFlowInfo(DescribeFlowInfoRequest req)
        {
             JsonResponseModel<DescribeFlowInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询合同详情
        /// 适用场景：可用于主动查询某个合同详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowInfoResponse"/></returns>
        public DescribeFlowInfoResponse DescribeFlowInfoSync(DescribeFlowInfoRequest req)
        {
             JsonResponseModel<DescribeFlowInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询本企业模板列表。
        /// 
        /// 当模板较多或模板中的控件较多时，可以通过查询模板接口更方便的获取模板列表，以及每个模板内的控件信息。
        /// 
        /// > **适用场景** 
        /// >
        /// >  该接口常用来配合“模板发起合同-创建电子文档”接口作为前置的接口使用。 
        /// >  一个模板通常会包含以下结构信息
        /// >- 模板基本信息
        /// >- 发起方参与信息Promoter、签署参与方 Recipients，后者会在模板发起合同时用于指定参与方
        /// >- 填写控件 Components
        /// >- 签署控件 SignComponents
        /// >- 生成模板的文件基础信息 FileInfos
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTemplatesRequest"/></param>
        /// <returns><see cref="DescribeFlowTemplatesResponse"/></returns>
        public async Task<DescribeFlowTemplatesResponse> DescribeFlowTemplates(DescribeFlowTemplatesRequest req)
        {
             JsonResponseModel<DescribeFlowTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询本企业模板列表。
        /// 
        /// 当模板较多或模板中的控件较多时，可以通过查询模板接口更方便的获取模板列表，以及每个模板内的控件信息。
        /// 
        /// > **适用场景** 
        /// >
        /// >  该接口常用来配合“模板发起合同-创建电子文档”接口作为前置的接口使用。 
        /// >  一个模板通常会包含以下结构信息
        /// >- 模板基本信息
        /// >- 发起方参与信息Promoter、签署参与方 Recipients，后者会在模板发起合同时用于指定参与方
        /// >- 填写控件 Components
        /// >- 签署控件 SignComponents
        /// >- 生成模板的文件基础信息 FileInfos
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTemplatesRequest"/></param>
        /// <returns><see cref="DescribeFlowTemplatesResponse"/></returns>
        public DescribeFlowTemplatesResponse DescribeFlowTemplatesSync(DescribeFlowTemplatesRequest req)
        {
             JsonResponseModel<DescribeFlowTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，查询企业的部门，支持查询单个部门节点或单个部门节点及一级子节点部门列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationDepartmentsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationDepartmentsResponse"/></returns>
        public async Task<DescribeIntegrationDepartmentsResponse> DescribeIntegrationDepartments(DescribeIntegrationDepartmentsRequest req)
        {
             JsonResponseModel<DescribeIntegrationDepartmentsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationDepartments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationDepartmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，查询企业的部门，支持查询单个部门节点或单个部门节点及一级子节点部门列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationDepartmentsRequest"/></param>
        /// <returns><see cref="DescribeIntegrationDepartmentsResponse"/></returns>
        public DescribeIntegrationDepartmentsResponse DescribeIntegrationDepartmentsSync(DescribeIntegrationDepartmentsRequest req)
        {
             JsonResponseModel<DescribeIntegrationDepartmentsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationDepartments");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationDepartmentsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业员工列表，每次返回的数据量最大为20
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="DescribeIntegrationEmployeesResponse"/></returns>
        public async Task<DescribeIntegrationEmployeesResponse> DescribeIntegrationEmployees(DescribeIntegrationEmployeesRequest req)
        {
             JsonResponseModel<DescribeIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业员工列表，每次返回的数据量最大为20
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="DescribeIntegrationEmployeesResponse"/></returns>
        public DescribeIntegrationEmployeesResponse DescribeIntegrationEmployeesSync(DescribeIntegrationEmployeesRequest req)
        {
             JsonResponseModel<DescribeIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集团企业统一使用主代子进行操作，无需根据子企业账号进行转化查询，该接口需要屏蔽下线
        /// 
        /// 通过子企业影子账号查询主企业员工账号
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationMainOrganizationUserRequest"/></param>
        /// <returns><see cref="DescribeIntegrationMainOrganizationUserResponse"/></returns>
        public async Task<DescribeIntegrationMainOrganizationUserResponse> DescribeIntegrationMainOrganizationUser(DescribeIntegrationMainOrganizationUserRequest req)
        {
             JsonResponseModel<DescribeIntegrationMainOrganizationUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationMainOrganizationUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationMainOrganizationUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集团企业统一使用主代子进行操作，无需根据子企业账号进行转化查询，该接口需要屏蔽下线
        /// 
        /// 通过子企业影子账号查询主企业员工账号
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationMainOrganizationUserRequest"/></param>
        /// <returns><see cref="DescribeIntegrationMainOrganizationUserResponse"/></returns>
        public DescribeIntegrationMainOrganizationUserResponse DescribeIntegrationMainOrganizationUserSync(DescribeIntegrationMainOrganizationUserRequest req)
        {
             JsonResponseModel<DescribeIntegrationMainOrganizationUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationMainOrganizationUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationMainOrganizationUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询企业角色列表，法人的角色是系统保留角色，不会返回，按照角色创建时间升序排列
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationRolesRequest"/></param>
        /// <returns><see cref="DescribeIntegrationRolesResponse"/></returns>
        public async Task<DescribeIntegrationRolesResponse> DescribeIntegrationRoles(DescribeIntegrationRolesRequest req)
        {
             JsonResponseModel<DescribeIntegrationRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIntegrationRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询企业角色列表，法人的角色是系统保留角色，不会返回，按照角色创建时间升序排列
        /// </summary>
        /// <param name="req"><see cref="DescribeIntegrationRolesRequest"/></param>
        /// <returns><see cref="DescribeIntegrationRolesResponse"/></returns>
        public DescribeIntegrationRolesResponse DescribeIntegrationRolesSync(DescribeIntegrationRolesRequest req)
        {
             JsonResponseModel<DescribeIntegrationRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIntegrationRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIntegrationRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此API接口用户查询加入集团的成员企业
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationGroupOrganizationsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationGroupOrganizationsResponse"/></returns>
        public async Task<DescribeOrganizationGroupOrganizationsResponse> DescribeOrganizationGroupOrganizations(DescribeOrganizationGroupOrganizationsRequest req)
        {
             JsonResponseModel<DescribeOrganizationGroupOrganizationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationGroupOrganizations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationGroupOrganizationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此API接口用户查询加入集团的成员企业
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationGroupOrganizationsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationGroupOrganizationsResponse"/></returns>
        public DescribeOrganizationGroupOrganizationsResponse DescribeOrganizationGroupOrganizationsSync(DescribeOrganizationGroupOrganizationsRequest req)
        {
             JsonResponseModel<DescribeOrganizationGroupOrganizationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationGroupOrganizations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationGroupOrganizationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业印章的列表，需要操作者具有查询印章权限
        /// 客户指定需要获取的印章数量和偏移量，数量最多100，超过100按100处理；入参InfoType控制印章是否携带授权人信息，为1则携带，为0则返回的授权人信息为空数组。接口调用成功返回印章的信息列表还有企业印章的总数。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationSealsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationSealsResponse"/></returns>
        public async Task<DescribeOrganizationSealsResponse> DescribeOrganizationSeals(DescribeOrganizationSealsRequest req)
        {
             JsonResponseModel<DescribeOrganizationSealsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrganizationSeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationSealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业印章的列表，需要操作者具有查询印章权限
        /// 客户指定需要获取的印章数量和偏移量，数量最多100，超过100按100处理；入参InfoType控制印章是否携带授权人信息，为1则携带，为0则返回的授权人信息为空数组。接口调用成功返回印章的信息列表还有企业印章的总数。
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationSealsRequest"/></param>
        /// <returns><see cref="DescribeOrganizationSealsResponse"/></returns>
        public DescribeOrganizationSealsResponse DescribeOrganizationSealsSync(DescribeOrganizationSealsRequest req)
        {
             JsonResponseModel<DescribeOrganizationSealsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrganizationSeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrganizationSealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过AuthCode查询用户是否实名
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAuthCodeRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAuthCodeResponse"/></returns>
        public async Task<DescribeThirdPartyAuthCodeResponse> DescribeThirdPartyAuthCode(DescribeThirdPartyAuthCodeRequest req)
        {
             JsonResponseModel<DescribeThirdPartyAuthCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeThirdPartyAuthCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeThirdPartyAuthCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过AuthCode查询用户是否实名
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAuthCodeRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAuthCodeResponse"/></returns>
        public DescribeThirdPartyAuthCodeResponse DescribeThirdPartyAuthCodeSync(DescribeThirdPartyAuthCodeRequest req)
        {
             JsonResponseModel<DescribeThirdPartyAuthCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeThirdPartyAuthCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeThirdPartyAuthCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口查询个人用户自动签开启状态。（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAutoSignStatusRequest"/></param>
        /// <returns><see cref="DescribeUserAutoSignStatusResponse"/></returns>
        public async Task<DescribeUserAutoSignStatusResponse> DescribeUserAutoSignStatus(DescribeUserAutoSignStatusRequest req)
        {
             JsonResponseModel<DescribeUserAutoSignStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserAutoSignStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserAutoSignStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口查询个人用户自动签开启状态。（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAutoSignStatusRequest"/></param>
        /// <returns><see cref="DescribeUserAutoSignStatusResponse"/></returns>
        public DescribeUserAutoSignStatusResponse DescribeUserAutoSignStatusSync(DescribeUserAutoSignStatusRequest req)
        {
             JsonResponseModel<DescribeUserAutoSignStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserAutoSignStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserAutoSignStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口关闭个人的自动签功能（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="DisableUserAutoSignRequest"/></param>
        /// <returns><see cref="DisableUserAutoSignResponse"/></returns>
        public async Task<DisableUserAutoSignResponse> DisableUserAutoSign(DisableUserAutoSignRequest req)
        {
             JsonResponseModel<DisableUserAutoSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableUserAutoSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableUserAutoSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 企业方可以通过此接口关闭个人的自动签功能（处方单场景专用，使用此接口请与客户经理确认）
        /// </summary>
        /// <param name="req"><see cref="DisableUserAutoSignRequest"/></param>
        /// <returns><see cref="DisableUserAutoSignResponse"/></returns>
        public DisableUserAutoSignResponse DisableUserAutoSignSync(DisableUserAutoSignRequest req)
        {
             JsonResponseModel<DisableUserAutoSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableUserAutoSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableUserAutoSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转换任务的状态。转换任务Id通过发起转换任务接口（CreateConvertTaskApi）获取。
        /// 注意：大文件转换所需的时间可能会比较长。
        /// </summary>
        /// <param name="req"><see cref="GetTaskResultApiRequest"/></param>
        /// <returns><see cref="GetTaskResultApiResponse"/></returns>
        public async Task<GetTaskResultApiResponse> GetTaskResultApi(GetTaskResultApiRequest req)
        {
             JsonResponseModel<GetTaskResultApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTaskResultApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskResultApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转换任务的状态。转换任务Id通过发起转换任务接口（CreateConvertTaskApi）获取。
        /// 注意：大文件转换所需的时间可能会比较长。
        /// </summary>
        /// <param name="req"><see cref="GetTaskResultApiRequest"/></param>
        /// <returns><see cref="GetTaskResultApiResponse"/></returns>
        public GetTaskResultApiResponse GetTaskResultApiSync(GetTaskResultApiRequest req)
        {
             JsonResponseModel<GetTaskResultApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTaskResultApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTaskResultApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增/删除企业应用集成中的回调配置。
        /// 新增回调配置只会增加不存在的CallbackUrl；删除操作将针对找到的相同CallbackUrl的配置进行删除。
        /// 请确保回调地址能够接收并处理 HTTP POST 请求，并返回状态码 200 以表示处理正常。
        /// 更多回调相关的说明参考文档[回调通知能力](https://qian.tencent.com/developers/company/callback_types_v2)
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationCallbackInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationCallbackInfoResponse"/></returns>
        public async Task<ModifyApplicationCallbackInfoResponse> ModifyApplicationCallbackInfo(ModifyApplicationCallbackInfoRequest req)
        {
             JsonResponseModel<ModifyApplicationCallbackInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationCallbackInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationCallbackInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增/删除企业应用集成中的回调配置。
        /// 新增回调配置只会增加不存在的CallbackUrl；删除操作将针对找到的相同CallbackUrl的配置进行删除。
        /// 请确保回调地址能够接收并处理 HTTP POST 请求，并返回状态码 200 以表示处理正常。
        /// 更多回调相关的说明参考文档[回调通知能力](https://qian.tencent.com/developers/company/callback_types_v2)
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationCallbackInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationCallbackInfoResponse"/></returns>
        public ModifyApplicationCallbackInfoResponse ModifyApplicationCallbackInfoSync(ModifyApplicationCallbackInfoRequest req)
        {
             JsonResponseModel<ModifyApplicationCallbackInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationCallbackInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationCallbackInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，更新企业的部门信息，支持更新部门名、客户系统部门ID、部门序列号。
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationDepartmentRequest"/></param>
        /// <returns><see cref="ModifyIntegrationDepartmentResponse"/></returns>
        public async Task<ModifyIntegrationDepartmentResponse> ModifyIntegrationDepartment(ModifyIntegrationDepartmentRequest req)
        {
             JsonResponseModel<ModifyIntegrationDepartmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIntegrationDepartment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationDepartmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口，更新企业的部门信息，支持更新部门名、客户系统部门ID、部门序列号。
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationDepartmentRequest"/></param>
        /// <returns><see cref="ModifyIntegrationDepartmentResponse"/></returns>
        public ModifyIntegrationDepartmentResponse ModifyIntegrationDepartmentSync(ModifyIntegrationDepartmentRequest req)
        {
             JsonResponseModel<ModifyIntegrationDepartmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIntegrationDepartment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationDepartmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifyIntegrationRole）用来更新企业自定义的SaaS角色或集团角色。
        /// 
        /// 适用场景1：更新当前企业的自定义SaaS角色或集团角色，并且更新时不进行角色中权限的更新（PermissionGroups 参数不传）。
        /// 
        /// 适用场景2：更新当前企业的自定义SaaS角色或集团角色，并且更新时进行角色中权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 DescribeIntegrationRoles 的输出。
        /// 适用场景3：更新集团角色管理的子企业列表，可通过设置 SubOrganizationIds 参数达到此效果。
        /// 
        /// 适用场景4：主企业代理子企业操作的场景，需要设置Agent参数，并且ProxyOrganizationId设置为子企业的id即可。
        /// 
        /// 注意事项：SaaS角色和集团角色对应的权限树是不一样的。
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationRoleRequest"/></param>
        /// <returns><see cref="ModifyIntegrationRoleResponse"/></returns>
        public async Task<ModifyIntegrationRoleResponse> ModifyIntegrationRole(ModifyIntegrationRoleRequest req)
        {
             JsonResponseModel<ModifyIntegrationRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIntegrationRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ModifyIntegrationRole）用来更新企业自定义的SaaS角色或集团角色。
        /// 
        /// 适用场景1：更新当前企业的自定义SaaS角色或集团角色，并且更新时不进行角色中权限的更新（PermissionGroups 参数不传）。
        /// 
        /// 适用场景2：更新当前企业的自定义SaaS角色或集团角色，并且更新时进行角色中权限的设置（PermissionGroups 参数要传），权限树内容 PermissionGroups 可参考接口 DescribeIntegrationRoles 的输出。
        /// 适用场景3：更新集团角色管理的子企业列表，可通过设置 SubOrganizationIds 参数达到此效果。
        /// 
        /// 适用场景4：主企业代理子企业操作的场景，需要设置Agent参数，并且ProxyOrganizationId设置为子企业的id即可。
        /// 
        /// 注意事项：SaaS角色和集团角色对应的权限树是不一样的。
        /// </summary>
        /// <param name="req"><see cref="ModifyIntegrationRoleRequest"/></param>
        /// <returns><see cref="ModifyIntegrationRoleResponse"/></returns>
        public ModifyIntegrationRoleResponse ModifyIntegrationRoleSync(ModifyIntegrationRoleRequest req)
        {
             JsonResponseModel<ModifyIntegrationRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIntegrationRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIntegrationRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于启动流程。它是模板发起合同的最后一步。
        /// 在[创建签署流程](https://qian.tencent.com/developers/companyApis/startFlows/CreateFlow)和[创建电子文档](https://qian.tencent.com/developers/companyApis/startFlows/CreateDocument)之后，用于激活包含完整合同信息（模板及内容信息）的流程。
        /// 流程激活后，将生成一份待签署的电子合同。
        /// </summary>
        /// <param name="req"><see cref="StartFlowRequest"/></param>
        /// <returns><see cref="StartFlowResponse"/></returns>
        public async Task<StartFlowResponse> StartFlow(StartFlowRequest req)
        {
             JsonResponseModel<StartFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于启动流程。它是模板发起合同的最后一步。
        /// 在[创建签署流程](https://qian.tencent.com/developers/companyApis/startFlows/CreateFlow)和[创建电子文档](https://qian.tencent.com/developers/companyApis/startFlows/CreateDocument)之后，用于激活包含完整合同信息（模板及内容信息）的流程。
        /// 流程激活后，将生成一份待签署的电子合同。
        /// </summary>
        /// <param name="req"><see cref="StartFlowRequest"/></param>
        /// <returns><see cref="StartFlowResponse"/></returns>
        public StartFlowResponse StartFlowSync(StartFlowRequest req)
        {
             JsonResponseModel<StartFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将存在绑定关系的电子签系统员工userId与客户系统员工openId进行解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindEmployeeUserIdWithClientOpenIdRequest"/></param>
        /// <returns><see cref="UnbindEmployeeUserIdWithClientOpenIdResponse"/></returns>
        public async Task<UnbindEmployeeUserIdWithClientOpenIdResponse> UnbindEmployeeUserIdWithClientOpenId(UnbindEmployeeUserIdWithClientOpenIdRequest req)
        {
             JsonResponseModel<UnbindEmployeeUserIdWithClientOpenIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindEmployeeUserIdWithClientOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindEmployeeUserIdWithClientOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将存在绑定关系的电子签系统员工userId与客户系统员工openId进行解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindEmployeeUserIdWithClientOpenIdRequest"/></param>
        /// <returns><see cref="UnbindEmployeeUserIdWithClientOpenIdResponse"/></returns>
        public UnbindEmployeeUserIdWithClientOpenIdResponse UnbindEmployeeUserIdWithClientOpenIdSync(UnbindEmployeeUserIdWithClientOpenIdRequest req)
        {
             JsonResponseModel<UnbindEmployeeUserIdWithClientOpenIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindEmployeeUserIdWithClientOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindEmployeeUserIdWithClientOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新员工信息(姓名，手机号，邮件、部门)，用户实名后无法更改姓名与手机号。
        /// 可进行批量操作，Employees中的userID与openID二选一必填
        /// </summary>
        /// <param name="req"><see cref="UpdateIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="UpdateIntegrationEmployeesResponse"/></returns>
        public async Task<UpdateIntegrationEmployeesResponse> UpdateIntegrationEmployees(UpdateIntegrationEmployeesRequest req)
        {
             JsonResponseModel<UpdateIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新员工信息(姓名，手机号，邮件、部门)，用户实名后无法更改姓名与手机号。
        /// 可进行批量操作，Employees中的userID与openID二选一必填
        /// </summary>
        /// <param name="req"><see cref="UpdateIntegrationEmployeesRequest"/></param>
        /// <returns><see cref="UpdateIntegrationEmployeesResponse"/></returns>
        public UpdateIntegrationEmployeesResponse UpdateIntegrationEmployeesSync(UpdateIntegrationEmployeesRequest req)
        {
             JsonResponseModel<UpdateIntegrationEmployeesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateIntegrationEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateIntegrationEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。<br/>
        /// 适用场景：用于生成pdf资源编号（FileIds）来配合“用PDF创建流程”接口使用，使用场景可详见“用PDF创建流程”接口说明。<br/>
        /// 
        /// 其中上传的文件，图片类型(png/jpg/jpeg)大小限制为5M，其他大小限制为60M。<br/>
        /// 调用时需要设置Domain/接口请求域名为 file.ess.tencent.cn,代码示例：<br/>
        /// HttpProfile httpProfile = new HttpProfile();<br/>
        /// httpProfile.setEndpoint("file.test.ess.tencent.cn");<br/>
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
        /// 此接口（UploadFiles）用于文件上传。<br/>
        /// 适用场景：用于生成pdf资源编号（FileIds）来配合“用PDF创建流程”接口使用，使用场景可详见“用PDF创建流程”接口说明。<br/>
        /// 
        /// 其中上传的文件，图片类型(png/jpg/jpeg)大小限制为5M，其他大小限制为60M。<br/>
        /// 调用时需要设置Domain/接口请求域名为 file.ess.tencent.cn,代码示例：<br/>
        /// HttpProfile httpProfile = new HttpProfile();<br/>
        /// httpProfile.setEndpoint("file.test.ess.tencent.cn");<br/>
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
        /// 对流程的合同文件进行数字签名验证，判断文件是否被篡改。
        /// </summary>
        /// <param name="req"><see cref="VerifyPdfRequest"/></param>
        /// <returns><see cref="VerifyPdfResponse"/></returns>
        public async Task<VerifyPdfResponse> VerifyPdf(VerifyPdfRequest req)
        {
             JsonResponseModel<VerifyPdfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyPdf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPdfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对流程的合同文件进行数字签名验证，判断文件是否被篡改。
        /// </summary>
        /// <param name="req"><see cref="VerifyPdfRequest"/></param>
        /// <returns><see cref="VerifyPdfResponse"/></returns>
        public VerifyPdfResponse VerifyPdfSync(VerifyPdfRequest req)
        {
             JsonResponseModel<VerifyPdfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyPdf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPdfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
