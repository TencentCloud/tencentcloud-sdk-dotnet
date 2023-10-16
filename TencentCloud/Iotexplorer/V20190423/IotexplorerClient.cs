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

namespace TencentCloud.Iotexplorer.V20190423
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotexplorer.V20190423.Models;

   public class IotexplorerClient : AbstractClient{

       private const string endpoint = "iotexplorer.tencentcloudapi.com";
       private const string version = "2019-04-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotexplorerClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotexplorerClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 批量绑定子设备
        /// </summary>
        /// <param name="req"><see cref="BindDevicesRequest"/></param>
        /// <returns><see cref="BindDevicesResponse"/></returns>
        public async Task<BindDevicesResponse> BindDevices(BindDevicesRequest req)
        {
             JsonResponseModel<BindDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量绑定子设备
        /// </summary>
        /// <param name="req"><see cref="BindDevicesRequest"/></param>
        /// <returns><see cref="BindDevicesResponse"/></returns>
        public BindDevicesResponse BindDevicesSync(BindDevicesRequest req)
        {
             JsonResponseModel<BindDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量绑定子产品
        /// </summary>
        /// <param name="req"><see cref="BindProductsRequest"/></param>
        /// <returns><see cref="BindProductsResponse"/></returns>
        public async Task<BindProductsResponse> BindProducts(BindProductsRequest req)
        {
             JsonResponseModel<BindProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量绑定子产品
        /// </summary>
        /// <param name="req"><see cref="BindProductsRequest"/></param>
        /// <returns><see cref="BindProductsResponse"/></returns>
        public BindProductsResponse BindProductsSync(BindProductsRequest req)
        {
             JsonResponseModel<BindProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供给用户异步调用设备行为的能力
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionAsyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionAsyncResponse"/></returns>
        public async Task<CallDeviceActionAsyncResponse> CallDeviceActionAsync(CallDeviceActionAsyncRequest req)
        {
             JsonResponseModel<CallDeviceActionAsyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CallDeviceActionAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供给用户异步调用设备行为的能力
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionAsyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionAsyncResponse"/></returns>
        public CallDeviceActionAsyncResponse CallDeviceActionAsyncSync(CallDeviceActionAsyncRequest req)
        {
             JsonResponseModel<CallDeviceActionAsyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CallDeviceActionAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供同步调用设备行为的能力。
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionSyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionSyncResponse"/></returns>
        public async Task<CallDeviceActionSyncResponse> CallDeviceActionSync(CallDeviceActionSyncRequest req)
        {
             JsonResponseModel<CallDeviceActionSyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CallDeviceActionSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供同步调用设备行为的能力。
        /// </summary>
        /// <param name="req"><see cref="CallDeviceActionSyncRequest"/></param>
        /// <returns><see cref="CallDeviceActionSyncResponse"/></returns>
        public CallDeviceActionSyncResponse CallDeviceActionSyncSync(CallDeviceActionSyncRequest req)
        {
             JsonResponseModel<CallDeviceActionSyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CallDeviceActionSync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallDeviceActionSyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，设置控制设备的属性数据。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceDataRequest"/></param>
        /// <returns><see cref="ControlDeviceDataResponse"/></returns>
        public async Task<ControlDeviceDataResponse> ControlDeviceData(ControlDeviceDataRequest req)
        {
             JsonResponseModel<ControlDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ControlDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，设置控制设备的属性数据。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceDataRequest"/></param>
        /// <returns><see cref="ControlDeviceDataResponse"/></returns>
        public ControlDeviceDataResponse ControlDeviceDataSync(ControlDeviceDataRequest req)
        {
             JsonResponseModel<ControlDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ControlDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ControlDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新建批量生产设备
        /// </summary>
        /// <param name="req"><see cref="CreateBatchProductionRequest"/></param>
        /// <returns><see cref="CreateBatchProductionResponse"/></returns>
        public async Task<CreateBatchProductionResponse> CreateBatchProduction(CreateBatchProductionRequest req)
        {
             JsonResponseModel<CreateBatchProductionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBatchProduction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchProductionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于新建批量生产设备
        /// </summary>
        /// <param name="req"><see cref="CreateBatchProductionRequest"/></param>
        /// <returns><see cref="CreateBatchProductionResponse"/></returns>
        public CreateBatchProductionResponse CreateBatchProductionSync(CreateBatchProductionRequest req)
        {
             JsonResponseModel<CreateBatchProductionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBatchProduction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchProductionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public async Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建设备
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
             JsonResponseModel<CreateDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建围栏绑定信息
        /// </summary>
        /// <param name="req"><see cref="CreateFenceBindRequest"/></param>
        /// <returns><see cref="CreateFenceBindResponse"/></returns>
        public async Task<CreateFenceBindResponse> CreateFenceBind(CreateFenceBindRequest req)
        {
             JsonResponseModel<CreateFenceBindResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFenceBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFenceBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建围栏绑定信息
        /// </summary>
        /// <param name="req"><see cref="CreateFenceBindRequest"/></param>
        /// <returns><see cref="CreateFenceBindResponse"/></returns>
        public CreateFenceBindResponse CreateFenceBindSync(CreateFenceBindRequest req)
        {
             JsonResponseModel<CreateFenceBindResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFenceBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFenceBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 LoRa 自定义频点
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaFrequencyRequest"/></param>
        /// <returns><see cref="CreateLoRaFrequencyResponse"/></returns>
        public async Task<CreateLoRaFrequencyResponse> CreateLoRaFrequency(CreateLoRaFrequencyRequest req)
        {
             JsonResponseModel<CreateLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 LoRa 自定义频点
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaFrequencyRequest"/></param>
        /// <returns><see cref="CreateLoRaFrequencyResponse"/></returns>
        public CreateLoRaFrequencyResponse CreateLoRaFrequencySync(CreateLoRaFrequencyRequest req)
        {
             JsonResponseModel<CreateLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新 LoRa 网关设备接口
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaGatewayRequest"/></param>
        /// <returns><see cref="CreateLoRaGatewayResponse"/></returns>
        public async Task<CreateLoRaGatewayResponse> CreateLoRaGateway(CreateLoRaGatewayRequest req)
        {
             JsonResponseModel<CreateLoRaGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLoRaGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoRaGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新 LoRa 网关设备接口
        /// </summary>
        /// <param name="req"><see cref="CreateLoRaGatewayRequest"/></param>
        /// <returns><see cref="CreateLoRaGatewayResponse"/></returns>
        public CreateLoRaGatewayResponse CreateLoRaGatewaySync(CreateLoRaGatewayRequest req)
        {
             JsonResponseModel<CreateLoRaGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLoRaGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLoRaGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建围栏
        /// </summary>
        /// <param name="req"><see cref="CreatePositionFenceRequest"/></param>
        /// <returns><see cref="CreatePositionFenceResponse"/></returns>
        public async Task<CreatePositionFenceResponse> CreatePositionFence(CreatePositionFenceRequest req)
        {
             JsonResponseModel<CreatePositionFenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePositionFence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePositionFenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建围栏
        /// </summary>
        /// <param name="req"><see cref="CreatePositionFenceRequest"/></param>
        /// <returns><see cref="CreatePositionFenceResponse"/></returns>
        public CreatePositionFenceResponse CreatePositionFenceSync(CreatePositionFenceRequest req)
        {
             JsonResponseModel<CreatePositionFenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePositionFence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePositionFenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建位置空间
        /// </summary>
        /// <param name="req"><see cref="CreatePositionSpaceRequest"/></param>
        /// <returns><see cref="CreatePositionSpaceResponse"/></returns>
        public async Task<CreatePositionSpaceResponse> CreatePositionSpace(CreatePositionSpaceRequest req)
        {
             JsonResponseModel<CreatePositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建位置空间
        /// </summary>
        /// <param name="req"><see cref="CreatePositionSpaceRequest"/></param>
        /// <returns><see cref="CreatePositionSpaceResponse"/></returns>
        public CreatePositionSpaceResponse CreatePositionSpaceSync(CreatePositionSpaceRequest req)
        {
             JsonResponseModel<CreatePositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供新建项目的能力，用于集中管理产品和应用。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public async Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供新建项目的能力，用于集中管理产品和应用。
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供新建产品的能力，用于管理用户的设备
        /// </summary>
        /// <param name="req"><see cref="CreateStudioProductRequest"/></param>
        /// <returns><see cref="CreateStudioProductResponse"/></returns>
        public async Task<CreateStudioProductResponse> CreateStudioProduct(CreateStudioProductRequest req)
        {
             JsonResponseModel<CreateStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供新建产品的能力，用于管理用户的设备
        /// </summary>
        /// <param name="req"><see cref="CreateStudioProductRequest"/></param>
        /// <returns><see cref="CreateStudioProductResponse"/></returns>
        public CreateStudioProductResponse CreateStudioProductSync(CreateStudioProductRequest req)
        {
             JsonResponseModel<CreateStudioProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTopicPolicy）用于创建一个Topic 
        /// </summary>
        /// <param name="req"><see cref="CreateTopicPolicyRequest"/></param>
        /// <returns><see cref="CreateTopicPolicyResponse"/></returns>
        public async Task<CreateTopicPolicyResponse> CreateTopicPolicy(CreateTopicPolicyRequest req)
        {
             JsonResponseModel<CreateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTopicPolicy）用于创建一个Topic 
        /// </summary>
        /// <param name="req"><see cref="CreateTopicPolicyRequest"/></param>
        /// <returns><see cref="CreateTopicPolicyResponse"/></returns>
        public CreateTopicPolicyResponse CreateTopicPolicySync(CreateTopicPolicyRequest req)
        {
             JsonResponseModel<CreateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRuleRequest"/></param>
        /// <returns><see cref="CreateTopicRuleResponse"/></returns>
        public async Task<CreateTopicRuleResponse> CreateTopicRule(CreateTopicRuleRequest req)
        {
             JsonResponseModel<CreateTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRuleRequest"/></param>
        /// <returns><see cref="CreateTopicRuleResponse"/></returns>
        public CreateTopicRuleResponse CreateTopicRuleSync(CreateTopicRuleRequest req)
        {
             JsonResponseModel<CreateTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public async Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
             JsonResponseModel<DeleteDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public async Task<DeleteDevicesResponse> DeleteDevices(DeleteDevicesRequest req)
        {
             JsonResponseModel<DeleteDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public DeleteDevicesResponse DeleteDevicesSync(DeleteDevicesRequest req)
        {
             JsonResponseModel<DeleteDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除围栏绑定信息
        /// </summary>
        /// <param name="req"><see cref="DeleteFenceBindRequest"/></param>
        /// <returns><see cref="DeleteFenceBindResponse"/></returns>
        public async Task<DeleteFenceBindResponse> DeleteFenceBind(DeleteFenceBindRequest req)
        {
             JsonResponseModel<DeleteFenceBindResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFenceBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFenceBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除围栏绑定信息
        /// </summary>
        /// <param name="req"><see cref="DeleteFenceBindRequest"/></param>
        /// <returns><see cref="DeleteFenceBindResponse"/></returns>
        public DeleteFenceBindResponse DeleteFenceBindSync(DeleteFenceBindRequest req)
        {
             JsonResponseModel<DeleteFenceBindResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFenceBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFenceBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除LoRa自定义频点的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DeleteLoRaFrequencyResponse"/></returns>
        public async Task<DeleteLoRaFrequencyResponse> DeleteLoRaFrequency(DeleteLoRaFrequencyRequest req)
        {
             JsonResponseModel<DeleteLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除LoRa自定义频点的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DeleteLoRaFrequencyResponse"/></returns>
        public DeleteLoRaFrequencyResponse DeleteLoRaFrequencySync(DeleteLoRaFrequencyRequest req)
        {
             JsonResponseModel<DeleteLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除  LoRa 网关的接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaGatewayRequest"/></param>
        /// <returns><see cref="DeleteLoRaGatewayResponse"/></returns>
        public async Task<DeleteLoRaGatewayResponse> DeleteLoRaGateway(DeleteLoRaGatewayRequest req)
        {
             JsonResponseModel<DeleteLoRaGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLoRaGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoRaGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除  LoRa 网关的接口
        /// </summary>
        /// <param name="req"><see cref="DeleteLoRaGatewayRequest"/></param>
        /// <returns><see cref="DeleteLoRaGatewayResponse"/></returns>
        public DeleteLoRaGatewayResponse DeleteLoRaGatewaySync(DeleteLoRaGatewayRequest req)
        {
             JsonResponseModel<DeleteLoRaGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLoRaGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLoRaGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除围栏
        /// </summary>
        /// <param name="req"><see cref="DeletePositionFenceRequest"/></param>
        /// <returns><see cref="DeletePositionFenceResponse"/></returns>
        public async Task<DeletePositionFenceResponse> DeletePositionFence(DeletePositionFenceRequest req)
        {
             JsonResponseModel<DeletePositionFenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePositionFence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePositionFenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除围栏
        /// </summary>
        /// <param name="req"><see cref="DeletePositionFenceRequest"/></param>
        /// <returns><see cref="DeletePositionFenceResponse"/></returns>
        public DeletePositionFenceResponse DeletePositionFenceSync(DeletePositionFenceRequest req)
        {
             JsonResponseModel<DeletePositionFenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePositionFence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePositionFenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除位置空间
        /// </summary>
        /// <param name="req"><see cref="DeletePositionSpaceRequest"/></param>
        /// <returns><see cref="DeletePositionSpaceResponse"/></returns>
        public async Task<DeletePositionSpaceResponse> DeletePositionSpace(DeletePositionSpaceRequest req)
        {
             JsonResponseModel<DeletePositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除位置空间
        /// </summary>
        /// <param name="req"><see cref="DeletePositionSpaceRequest"/></param>
        /// <returns><see cref="DeletePositionSpaceResponse"/></returns>
        public DeletePositionSpaceResponse DeletePositionSpaceSync(DeletePositionSpaceRequest req)
        {
             JsonResponseModel<DeletePositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除某个项目的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public async Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除某个项目的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除某个项目下产品的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteStudioProductRequest"/></param>
        /// <returns><see cref="DeleteStudioProductResponse"/></returns>
        public async Task<DeleteStudioProductResponse> DeleteStudioProduct(DeleteStudioProductRequest req)
        {
             JsonResponseModel<DeleteStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供删除某个项目下产品的能力
        /// </summary>
        /// <param name="req"><see cref="DeleteStudioProductRequest"/></param>
        /// <returns><see cref="DeleteStudioProductResponse"/></returns>
        public DeleteStudioProductResponse DeleteStudioProductSync(DeleteStudioProductRequest req)
        {
             JsonResponseModel<DeleteStudioProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteTopicPolicy）用于删除Topic 
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicPolicyRequest"/></param>
        /// <returns><see cref="DeleteTopicPolicyResponse"/></returns>
        public async Task<DeleteTopicPolicyResponse> DeleteTopicPolicy(DeleteTopicPolicyRequest req)
        {
             JsonResponseModel<DeleteTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteTopicPolicy）用于删除Topic 
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicPolicyRequest"/></param>
        /// <returns><see cref="DeleteTopicPolicyResponse"/></returns>
        public DeleteTopicPolicyResponse DeleteTopicPolicySync(DeleteTopicPolicyRequest req)
        {
             JsonResponseModel<DeleteTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRuleRequest"/></param>
        /// <returns><see cref="DeleteTopicRuleResponse"/></returns>
        public async Task<DeleteTopicRuleResponse> DeleteTopicRule(DeleteTopicRuleRequest req)
        {
             JsonResponseModel<DeleteTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRuleRequest"/></param>
        /// <returns><see cref="DeleteTopicRuleResponse"/></returns>
        public DeleteTopicRuleResponse DeleteTopicRuleSync(DeleteTopicRuleRequest req)
        {
             JsonResponseModel<DeleteTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取量产详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchProductionRequest"/></param>
        /// <returns><see cref="DescribeBatchProductionResponse"/></returns>
        public async Task<DescribeBatchProductionResponse> DescribeBatchProduction(DescribeBatchProductionRequest req)
        {
             JsonResponseModel<DescribeBatchProductionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchProduction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchProductionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取量产详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchProductionRequest"/></param>
        /// <returns><see cref="DescribeBatchProductionResponse"/></returns>
        public DescribeBatchProductionResponse DescribeBatchProductionSync(DescribeBatchProductionRequest req)
        {
             JsonResponseModel<DescribeBatchProductionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchProduction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchProductionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网关产品已经绑定的子产品
        /// </summary>
        /// <param name="req"><see cref="DescribeBindedProductsRequest"/></param>
        /// <returns><see cref="DescribeBindedProductsResponse"/></returns>
        public async Task<DescribeBindedProductsResponse> DescribeBindedProducts(DescribeBindedProductsRequest req)
        {
             JsonResponseModel<DescribeBindedProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网关产品已经绑定的子产品
        /// </summary>
        /// <param name="req"><see cref="DescribeBindedProductsRequest"/></param>
        /// <returns><see cref="DescribeBindedProductsResponse"/></returns>
        public DescribeBindedProductsResponse DescribeBindedProductsSync(DescribeBindedProductsRequest req)
        {
             JsonResponseModel<DescribeBindedProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看某个设备的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public async Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查看某个设备的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
             JsonResponseModel<DescribeDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备绑定的网关设备
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceBindGatewayRequest"/></param>
        /// <returns><see cref="DescribeDeviceBindGatewayResponse"/></returns>
        public async Task<DescribeDeviceBindGatewayResponse> DescribeDeviceBindGateway(DescribeDeviceBindGatewayRequest req)
        {
             JsonResponseModel<DescribeDeviceBindGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceBindGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceBindGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询设备绑定的网关设备
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceBindGatewayRequest"/></param>
        /// <returns><see cref="DescribeDeviceBindGatewayResponse"/></returns>
        public DescribeDeviceBindGatewayResponse DescribeDeviceBindGatewaySync(DescribeDeviceBindGatewayRequest req)
        {
             JsonResponseModel<DescribeDeviceBindGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceBindGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceBindGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，获取设备上报的属性数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataResponse"/></returns>
        public async Task<DescribeDeviceDataResponse> DescribeDeviceData(DescribeDeviceDataRequest req)
        {
             JsonResponseModel<DescribeDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，获取设备上报的属性数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataResponse"/></returns>
        public DescribeDeviceDataResponse DescribeDeviceDataSync(DescribeDeviceDataRequest req)
        {
             JsonResponseModel<DescribeDeviceDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备在指定时间范围内上报的历史数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataHistoryResponse"/></returns>
        public async Task<DescribeDeviceDataHistoryResponse> DescribeDeviceDataHistory(DescribeDeviceDataHistoryRequest req)
        {
             JsonResponseModel<DescribeDeviceDataHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceDataHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备在指定时间范围内上报的历史数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataHistoryResponse"/></returns>
        public DescribeDeviceDataHistoryResponse DescribeDeviceDataHistorySync(DescribeDeviceDataHistoryRequest req)
        {
             JsonResponseModel<DescribeDeviceDataHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceDataHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceDataHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实时位置解析
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceLocationSolveRequest"/></param>
        /// <returns><see cref="DescribeDeviceLocationSolveResponse"/></returns>
        public async Task<DescribeDeviceLocationSolveResponse> DescribeDeviceLocationSolve(DescribeDeviceLocationSolveRequest req)
        {
             JsonResponseModel<DescribeDeviceLocationSolveResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceLocationSolve");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceLocationSolveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实时位置解析
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceLocationSolveRequest"/></param>
        /// <returns><see cref="DescribeDeviceLocationSolveResponse"/></returns>
        public DescribeDeviceLocationSolveResponse DescribeDeviceLocationSolveSync(DescribeDeviceLocationSolveRequest req)
        {
             JsonResponseModel<DescribeDeviceLocationSolveResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceLocationSolve");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceLocationSolveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备位置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePositionListRequest"/></param>
        /// <returns><see cref="DescribeDevicePositionListResponse"/></returns>
        public async Task<DescribeDevicePositionListResponse> DescribeDevicePositionList(DescribeDevicePositionListRequest req)
        {
             JsonResponseModel<DescribeDevicePositionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevicePositionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePositionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备位置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicePositionListRequest"/></param>
        /// <returns><see cref="DescribeDevicePositionListResponse"/></returns>
        public DescribeDevicePositionListResponse DescribeDevicePositionListSync(DescribeDevicePositionListRequest req)
        {
             JsonResponseModel<DescribeDevicePositionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevicePositionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicePositionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取围栏绑定信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceBindListRequest"/></param>
        /// <returns><see cref="DescribeFenceBindListResponse"/></returns>
        public async Task<DescribeFenceBindListResponse> DescribeFenceBindList(DescribeFenceBindListRequest req)
        {
             JsonResponseModel<DescribeFenceBindListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFenceBindList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFenceBindListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取围栏绑定信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceBindListRequest"/></param>
        /// <returns><see cref="DescribeFenceBindListResponse"/></returns>
        public DescribeFenceBindListResponse DescribeFenceBindListSync(DescribeFenceBindListRequest req)
        {
             JsonResponseModel<DescribeFenceBindListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFenceBindList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFenceBindListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取围栏告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeFenceEventListResponse"/></returns>
        public async Task<DescribeFenceEventListResponse> DescribeFenceEventList(DescribeFenceEventListRequest req)
        {
             JsonResponseModel<DescribeFenceEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFenceEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFenceEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取围栏告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeFenceEventListResponse"/></returns>
        public DescribeFenceEventListResponse DescribeFenceEventListSync(DescribeFenceEventListRequest req)
        {
             JsonResponseModel<DescribeFenceEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFenceEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFenceEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public async Task<DescribeFirmwareTaskResponse> DescribeFirmwareTask(DescribeFirmwareTaskRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirmwareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public DescribeFirmwareTaskResponse DescribeFirmwareTaskSync(DescribeFirmwareTaskRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirmwareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网关绑定的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayBindDevicesRequest"/></param>
        /// <returns><see cref="DescribeGatewayBindDevicesResponse"/></returns>
        public async Task<DescribeGatewayBindDevicesResponse> DescribeGatewayBindDevices(DescribeGatewayBindDevicesRequest req)
        {
             JsonResponseModel<DescribeGatewayBindDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewayBindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayBindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取网关绑定的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayBindDevicesRequest"/></param>
        /// <returns><see cref="DescribeGatewayBindDevicesResponse"/></returns>
        public DescribeGatewayBindDevicesResponse DescribeGatewayBindDevicesSync(DescribeGatewayBindDevicesRequest req)
        {
             JsonResponseModel<DescribeGatewayBindDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewayBindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewayBindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询绑定到家庭的网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubDeviceListResponse"/></returns>
        public async Task<DescribeGatewaySubDeviceListResponse> DescribeGatewaySubDeviceList(DescribeGatewaySubDeviceListRequest req)
        {
             JsonResponseModel<DescribeGatewaySubDeviceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewaySubDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewaySubDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询绑定到家庭的网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubDeviceListResponse"/></returns>
        public DescribeGatewaySubDeviceListResponse DescribeGatewaySubDeviceListSync(DescribeGatewaySubDeviceListRequest req)
        {
             JsonResponseModel<DescribeGatewaySubDeviceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewaySubDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewaySubDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关可绑定或解绑的子产品
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubProductsRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubProductsResponse"/></returns>
        public async Task<DescribeGatewaySubProductsResponse> DescribeGatewaySubProducts(DescribeGatewaySubProductsRequest req)
        {
             JsonResponseModel<DescribeGatewaySubProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGatewaySubProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewaySubProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取网关可绑定或解绑的子产品
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewaySubProductsRequest"/></param>
        /// <returns><see cref="DescribeGatewaySubProductsResponse"/></returns>
        public DescribeGatewaySubProductsResponse DescribeGatewaySubProductsSync(DescribeGatewaySubProductsRequest req)
        {
             JsonResponseModel<DescribeGatewaySubProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGatewaySubProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGatewaySubProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 公共实例过期时间 0001-01-01T00:00:00Z，公共实例是永久有效
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public async Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 公共实例过期时间 0001-01-01T00:00:00Z，公共实例是永久有效
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
             JsonResponseModel<DescribeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询LoRa自定义频点详情的能力
        /// </summary>
        /// <param name="req"><see cref="DescribeLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DescribeLoRaFrequencyResponse"/></returns>
        public async Task<DescribeLoRaFrequencyResponse> DescribeLoRaFrequency(DescribeLoRaFrequencyRequest req)
        {
             JsonResponseModel<DescribeLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询LoRa自定义频点详情的能力
        /// </summary>
        /// <param name="req"><see cref="DescribeLoRaFrequencyRequest"/></param>
        /// <returns><see cref="DescribeLoRaFrequencyResponse"/></returns>
        public DescribeLoRaFrequencyResponse DescribeLoRaFrequencySync(DescribeLoRaFrequencyRequest req)
        {
             JsonResponseModel<DescribeLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品配置的数据模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDefinitionRequest"/></param>
        /// <returns><see cref="DescribeModelDefinitionResponse"/></returns>
        public async Task<DescribeModelDefinitionResponse> DescribeModelDefinition(DescribeModelDefinitionRequest req)
        {
             JsonResponseModel<DescribeModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品配置的数据模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDefinitionRequest"/></param>
        /// <returns><see cref="DescribeModelDefinitionResponse"/></returns>
        public DescribeModelDefinitionResponse DescribeModelDefinitionSync(DescribeModelDefinitionRequest req)
        {
             JsonResponseModel<DescribeModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取围栏列表
        /// </summary>
        /// <param name="req"><see cref="DescribePositionFenceListRequest"/></param>
        /// <returns><see cref="DescribePositionFenceListResponse"/></returns>
        public async Task<DescribePositionFenceListResponse> DescribePositionFenceList(DescribePositionFenceListRequest req)
        {
             JsonResponseModel<DescribePositionFenceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePositionFenceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePositionFenceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取围栏列表
        /// </summary>
        /// <param name="req"><see cref="DescribePositionFenceListRequest"/></param>
        /// <returns><see cref="DescribePositionFenceListResponse"/></returns>
        public DescribePositionFenceListResponse DescribePositionFenceListSync(DescribePositionFenceListRequest req)
        {
             JsonResponseModel<DescribePositionFenceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePositionFenceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePositionFenceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public async Task<DescribeProjectResponse> DescribeProject(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectRequest"/></param>
        /// <returns><see cref="DescribeProjectResponse"/></returns>
        public DescribeProjectResponse DescribeProjectSync(DescribeProjectRequest req)
        {
             JsonResponseModel<DescribeProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取位置空间中围栏告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeSpaceFenceEventListResponse"/></returns>
        public async Task<DescribeSpaceFenceEventListResponse> DescribeSpaceFenceEventList(DescribeSpaceFenceEventListRequest req)
        {
             JsonResponseModel<DescribeSpaceFenceEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSpaceFenceEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceFenceEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取位置空间中围栏告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpaceFenceEventListRequest"/></param>
        /// <returns><see cref="DescribeSpaceFenceEventListResponse"/></returns>
        public DescribeSpaceFenceEventListResponse DescribeSpaceFenceEventListSync(DescribeSpaceFenceEventListRequest req)
        {
             JsonResponseModel<DescribeSpaceFenceEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSpaceFenceEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSpaceFenceEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查看产品详细信息的能力，包括产品的ID、数据协议、认证类型等重要参数
        /// </summary>
        /// <param name="req"><see cref="DescribeStudioProductRequest"/></param>
        /// <returns><see cref="DescribeStudioProductResponse"/></returns>
        public async Task<DescribeStudioProductResponse> DescribeStudioProduct(DescribeStudioProductRequest req)
        {
             JsonResponseModel<DescribeStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查看产品详细信息的能力，包括产品的ID、数据协议、认证类型等重要参数
        /// </summary>
        /// <param name="req"><see cref="DescribeStudioProductRequest"/></param>
        /// <returns><see cref="DescribeStudioProductResponse"/></returns>
        public DescribeStudioProductResponse DescribeStudioProductSync(DescribeStudioProductRequest req)
        {
             JsonResponseModel<DescribeStudioProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTopicPolicy）用于查看Topic详细信息 
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicPolicyRequest"/></param>
        /// <returns><see cref="DescribeTopicPolicyResponse"/></returns>
        public async Task<DescribeTopicPolicyResponse> DescribeTopicPolicy(DescribeTopicPolicyRequest req)
        {
             JsonResponseModel<DescribeTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTopicPolicy）用于查看Topic详细信息 
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicPolicyRequest"/></param>
        /// <returns><see cref="DescribeTopicPolicyResponse"/></returns>
        public DescribeTopicPolicyResponse DescribeTopicPolicySync(DescribeTopicPolicyRequest req)
        {
             JsonResponseModel<DescribeTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRuleRequest"/></param>
        /// <returns><see cref="DescribeTopicRuleResponse"/></returns>
        public async Task<DescribeTopicRuleResponse> DescribeTopicRule(DescribeTopicRuleRequest req)
        {
             JsonResponseModel<DescribeTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicRuleRequest"/></param>
        /// <returns><see cref="DescribeTopicRuleResponse"/></returns>
        public DescribeTopicRuleResponse DescribeTopicRuleSync(DescribeTopicRuleRequest req)
        {
             JsonResponseModel<DescribeTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直接绑定设备和家庭
        /// </summary>
        /// <param name="req"><see cref="DirectBindDeviceInFamilyRequest"/></param>
        /// <returns><see cref="DirectBindDeviceInFamilyResponse"/></returns>
        public async Task<DirectBindDeviceInFamilyResponse> DirectBindDeviceInFamily(DirectBindDeviceInFamilyRequest req)
        {
             JsonResponseModel<DirectBindDeviceInFamilyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DirectBindDeviceInFamily");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DirectBindDeviceInFamilyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直接绑定设备和家庭
        /// </summary>
        /// <param name="req"><see cref="DirectBindDeviceInFamilyRequest"/></param>
        /// <returns><see cref="DirectBindDeviceInFamilyResponse"/></returns>
        public DirectBindDeviceInFamilyResponse DirectBindDeviceInFamilySync(DirectBindDeviceInFamilyRequest req)
        {
             JsonResponseModel<DirectBindDeviceInFamilyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DirectBindDeviceInFamily");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DirectBindDeviceInFamilyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用规则
        /// </summary>
        /// <param name="req"><see cref="DisableTopicRuleRequest"/></param>
        /// <returns><see cref="DisableTopicRuleResponse"/></returns>
        public async Task<DisableTopicRuleResponse> DisableTopicRule(DisableTopicRuleRequest req)
        {
             JsonResponseModel<DisableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用规则
        /// </summary>
        /// <param name="req"><see cref="DisableTopicRuleRequest"/></param>
        /// <returns><see cref="DisableTopicRuleResponse"/></returns>
        public DisableTopicRuleResponse DisableTopicRuleSync(DisableTopicRuleRequest req)
        {
             JsonResponseModel<DisableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用规则
        /// </summary>
        /// <param name="req"><see cref="EnableTopicRuleRequest"/></param>
        /// <returns><see cref="EnableTopicRuleResponse"/></returns>
        public async Task<EnableTopicRuleResponse> EnableTopicRule(EnableTopicRuleRequest req)
        {
             JsonResponseModel<EnableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用规则
        /// </summary>
        /// <param name="req"><see cref="EnableTopicRuleRequest"/></param>
        /// <returns><see cref="EnableTopicRuleResponse"/></returns>
        public EnableTopicRuleResponse EnableTopicRuleSync(EnableTopicRuleRequest req)
        {
             JsonResponseModel<EnableTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="GenSingleDeviceSignatureOfPublicRequest"/></param>
        /// <returns><see cref="GenSingleDeviceSignatureOfPublicResponse"/></returns>
        public async Task<GenSingleDeviceSignatureOfPublicResponse> GenSingleDeviceSignatureOfPublic(GenSingleDeviceSignatureOfPublicRequest req)
        {
             JsonResponseModel<GenSingleDeviceSignatureOfPublicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenSingleDeviceSignatureOfPublic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenSingleDeviceSignatureOfPublicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 无
        /// </summary>
        /// <param name="req"><see cref="GenSingleDeviceSignatureOfPublicRequest"/></param>
        /// <returns><see cref="GenSingleDeviceSignatureOfPublicResponse"/></returns>
        public GenSingleDeviceSignatureOfPublicResponse GenSingleDeviceSignatureOfPublicSync(GenSingleDeviceSignatureOfPublicRequest req)
        {
             JsonResponseModel<GenSingleDeviceSignatureOfPublicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenSingleDeviceSignatureOfPublic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenSingleDeviceSignatureOfPublicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出量产数据列表信息。
        /// </summary>
        /// <param name="req"><see cref="GetBatchProductionsListRequest"/></param>
        /// <returns><see cref="GetBatchProductionsListResponse"/></returns>
        public async Task<GetBatchProductionsListResponse> GetBatchProductionsList(GetBatchProductionsListRequest req)
        {
             JsonResponseModel<GetBatchProductionsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBatchProductionsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBatchProductionsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出量产数据列表信息。
        /// </summary>
        /// <param name="req"><see cref="GetBatchProductionsListRequest"/></param>
        /// <returns><see cref="GetBatchProductionsListResponse"/></returns>
        public GetBatchProductionsListResponse GetBatchProductionsListSync(GetBatchProductionsListRequest req)
        {
             JsonResponseModel<GetBatchProductionsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBatchProductionsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBatchProductionsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetCOSURL）用于获取固件COS存储的上传请求URL地址
        /// </summary>
        /// <param name="req"><see cref="GetCOSURLRequest"/></param>
        /// <returns><see cref="GetCOSURLResponse"/></returns>
        public async Task<GetCOSURLResponse> GetCOSURL(GetCOSURLRequest req)
        {
             JsonResponseModel<GetCOSURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCOSURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCOSURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetCOSURL）用于获取固件COS存储的上传请求URL地址
        /// </summary>
        /// <param name="req"><see cref="GetCOSURLRequest"/></param>
        /// <returns><see cref="GetCOSURLResponse"/></returns>
        public GetCOSURLResponse GetCOSURLSync(GetCOSURLRequest req)
        {
             JsonResponseModel<GetCOSURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCOSURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCOSURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询某个产品下的设备列表
        /// </summary>
        /// <param name="req"><see cref="GetDeviceListRequest"/></param>
        /// <returns><see cref="GetDeviceListResponse"/></returns>
        public async Task<GetDeviceListResponse> GetDeviceList(GetDeviceListRequest req)
        {
             JsonResponseModel<GetDeviceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询某个产品下的设备列表
        /// </summary>
        /// <param name="req"><see cref="GetDeviceListRequest"/></param>
        /// <returns><see cref="GetDeviceListResponse"/></returns>
        public GetDeviceListResponse GetDeviceListSync(GetDeviceListRequest req)
        {
             JsonResponseModel<GetDeviceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备历史位置
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLocationHistoryRequest"/></param>
        /// <returns><see cref="GetDeviceLocationHistoryResponse"/></returns>
        public async Task<GetDeviceLocationHistoryResponse> GetDeviceLocationHistory(GetDeviceLocationHistoryRequest req)
        {
             JsonResponseModel<GetDeviceLocationHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceLocationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceLocationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备历史位置
        /// </summary>
        /// <param name="req"><see cref="GetDeviceLocationHistoryRequest"/></param>
        /// <returns><see cref="GetDeviceLocationHistoryResponse"/></returns>
        public GetDeviceLocationHistoryResponse GetDeviceLocationHistorySync(GetDeviceLocationHistoryRequest req)
        {
             JsonResponseModel<GetDeviceLocationHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDeviceLocationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceLocationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取设备统计汇总数据 
        /// </summary>
        /// <param name="req"><see cref="GetDeviceSumStatisticsRequest"/></param>
        /// <returns><see cref="GetDeviceSumStatisticsResponse"/></returns>
        public async Task<GetDeviceSumStatisticsResponse> GetDeviceSumStatistics(GetDeviceSumStatisticsRequest req)
        {
             JsonResponseModel<GetDeviceSumStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDeviceSumStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceSumStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取设备统计汇总数据 
        /// </summary>
        /// <param name="req"><see cref="GetDeviceSumStatisticsRequest"/></param>
        /// <returns><see cref="GetDeviceSumStatisticsResponse"/></returns>
        public GetDeviceSumStatisticsResponse GetDeviceSumStatisticsSync(GetDeviceSumStatisticsRequest req)
        {
             JsonResponseModel<GetDeviceSumStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDeviceSumStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDeviceSumStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备绑定的用户列表
        /// </summary>
        /// <param name="req"><see cref="GetFamilyDeviceUserListRequest"/></param>
        /// <returns><see cref="GetFamilyDeviceUserListResponse"/></returns>
        public async Task<GetFamilyDeviceUserListResponse> GetFamilyDeviceUserList(GetFamilyDeviceUserListRequest req)
        {
             JsonResponseModel<GetFamilyDeviceUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFamilyDeviceUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFamilyDeviceUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于获取设备绑定的用户列表
        /// </summary>
        /// <param name="req"><see cref="GetFamilyDeviceUserListRequest"/></param>
        /// <returns><see cref="GetFamilyDeviceUserListResponse"/></returns>
        public GetFamilyDeviceUserListResponse GetFamilyDeviceUserListSync(GetFamilyDeviceUserListRequest req)
        {
             JsonResponseModel<GetFamilyDeviceUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFamilyDeviceUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFamilyDeviceUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="GetGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="GetGatewaySubDeviceListResponse"/></returns>
        public async Task<GetGatewaySubDeviceListResponse> GetGatewaySubDeviceList(GetGatewaySubDeviceListRequest req)
        {
             JsonResponseModel<GetGatewaySubDeviceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGatewaySubDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGatewaySubDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定网关设备的子设备列表
        /// </summary>
        /// <param name="req"><see cref="GetGatewaySubDeviceListRequest"/></param>
        /// <returns><see cref="GetGatewaySubDeviceListResponse"/></returns>
        public GetGatewaySubDeviceListResponse GetGatewaySubDeviceListSync(GetGatewaySubDeviceListRequest req)
        {
             JsonResponseModel<GetGatewaySubDeviceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGatewaySubDeviceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGatewaySubDeviceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取 LoRa 网关列表接口
        /// </summary>
        /// <param name="req"><see cref="GetLoRaGatewayListRequest"/></param>
        /// <returns><see cref="GetLoRaGatewayListResponse"/></returns>
        public async Task<GetLoRaGatewayListResponse> GetLoRaGatewayList(GetLoRaGatewayListRequest req)
        {
             JsonResponseModel<GetLoRaGatewayListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLoRaGatewayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLoRaGatewayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取 LoRa 网关列表接口
        /// </summary>
        /// <param name="req"><see cref="GetLoRaGatewayListRequest"/></param>
        /// <returns><see cref="GetLoRaGatewayListResponse"/></returns>
        public GetLoRaGatewayListResponse GetLoRaGatewayListSync(GetLoRaGatewayListRequest req)
        {
             JsonResponseModel<GetLoRaGatewayListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLoRaGatewayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLoRaGatewayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取位置空间列表
        /// </summary>
        /// <param name="req"><see cref="GetPositionSpaceListRequest"/></param>
        /// <returns><see cref="GetPositionSpaceListResponse"/></returns>
        public async Task<GetPositionSpaceListResponse> GetPositionSpaceList(GetPositionSpaceListRequest req)
        {
             JsonResponseModel<GetPositionSpaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPositionSpaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPositionSpaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取位置空间列表
        /// </summary>
        /// <param name="req"><see cref="GetPositionSpaceListRequest"/></param>
        /// <returns><see cref="GetPositionSpaceListResponse"/></returns>
        public GetPositionSpaceListResponse GetPositionSpaceListSync(GetPositionSpaceListRequest req)
        {
             JsonResponseModel<GetPositionSpaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPositionSpaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPositionSpaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询用户所创建的项目列表查询功能。
        /// </summary>
        /// <param name="req"><see cref="GetProjectListRequest"/></param>
        /// <returns><see cref="GetProjectListResponse"/></returns>
        public async Task<GetProjectListResponse> GetProjectList(GetProjectListRequest req)
        {
             JsonResponseModel<GetProjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询用户所创建的项目列表查询功能。
        /// </summary>
        /// <param name="req"><see cref="GetProjectListRequest"/></param>
        /// <returns><see cref="GetProjectListResponse"/></returns>
        public GetProjectListResponse GetProjectListSync(GetProjectListRequest req)
        {
             JsonResponseModel<GetProjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetProjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询某个项目下所有产品信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetStudioProductListRequest"/></param>
        /// <returns><see cref="GetStudioProductListResponse"/></returns>
        public async Task<GetStudioProductListResponse> GetStudioProductList(GetStudioProductListRequest req)
        {
             JsonResponseModel<GetStudioProductListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetStudioProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStudioProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供查询某个项目下所有产品信息的能力。
        /// </summary>
        /// <param name="req"><see cref="GetStudioProductListRequest"/></param>
        /// <returns><see cref="GetStudioProductListResponse"/></returns>
        public GetStudioProductListResponse GetStudioProductListSync(GetStudioProductListRequest req)
        {
             JsonResponseModel<GetStudioProductListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetStudioProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStudioProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取规则列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicRuleListRequest"/></param>
        /// <returns><see cref="GetTopicRuleListResponse"/></returns>
        public async Task<GetTopicRuleListResponse> GetTopicRuleList(GetTopicRuleListRequest req)
        {
             JsonResponseModel<GetTopicRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTopicRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTopicRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取规则列表
        /// </summary>
        /// <param name="req"><see cref="GetTopicRuleListRequest"/></param>
        /// <returns><see cref="GetTopicRuleListResponse"/></returns>
        public GetTopicRuleListResponse GetTopicRuleListSync(GetTopicRuleListRequest req)
        {
             JsonResponseModel<GetTopicRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTopicRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTopicRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备的历史事件
        /// </summary>
        /// <param name="req"><see cref="ListEventHistoryRequest"/></param>
        /// <returns><see cref="ListEventHistoryResponse"/></returns>
        public async Task<ListEventHistoryResponse> ListEventHistory(ListEventHistoryRequest req)
        {
             JsonResponseModel<ListEventHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEventHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEventHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备的历史事件
        /// </summary>
        /// <param name="req"><see cref="ListEventHistoryRequest"/></param>
        /// <returns><see cref="ListEventHistoryResponse"/></returns>
        public ListEventHistoryResponse ListEventHistorySync(ListEventHistoryRequest req)
        {
             JsonResponseModel<ListEventHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEventHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEventHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListFirmwares）用于获取固件列表
        /// </summary>
        /// <param name="req"><see cref="ListFirmwaresRequest"/></param>
        /// <returns><see cref="ListFirmwaresResponse"/></returns>
        public async Task<ListFirmwaresResponse> ListFirmwares(ListFirmwaresRequest req)
        {
             JsonResponseModel<ListFirmwaresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListFirmwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFirmwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListFirmwares）用于获取固件列表
        /// </summary>
        /// <param name="req"><see cref="ListFirmwaresRequest"/></param>
        /// <returns><see cref="ListFirmwaresResponse"/></returns>
        public ListFirmwaresResponse ListFirmwaresSync(ListFirmwaresRequest req)
        {
             JsonResponseModel<ListFirmwaresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListFirmwares");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFirmwaresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListTopicPolicy）用于获取Topic列表
        /// </summary>
        /// <param name="req"><see cref="ListTopicPolicyRequest"/></param>
        /// <returns><see cref="ListTopicPolicyResponse"/></returns>
        public async Task<ListTopicPolicyResponse> ListTopicPolicy(ListTopicPolicyRequest req)
        {
             JsonResponseModel<ListTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListTopicPolicy）用于获取Topic列表
        /// </summary>
        /// <param name="req"><see cref="ListTopicPolicyRequest"/></param>
        /// <returns><see cref="ListTopicPolicyResponse"/></returns>
        public ListTopicPolicyResponse ListTopicPolicySync(ListTopicPolicyRequest req)
        {
             JsonResponseModel<ListTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新围栏绑定信息
        /// </summary>
        /// <param name="req"><see cref="ModifyFenceBindRequest"/></param>
        /// <returns><see cref="ModifyFenceBindResponse"/></returns>
        public async Task<ModifyFenceBindResponse> ModifyFenceBind(ModifyFenceBindRequest req)
        {
             JsonResponseModel<ModifyFenceBindResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFenceBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFenceBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新围栏绑定信息
        /// </summary>
        /// <param name="req"><see cref="ModifyFenceBindRequest"/></param>
        /// <returns><see cref="ModifyFenceBindResponse"/></returns>
        public ModifyFenceBindResponse ModifyFenceBindSync(ModifyFenceBindRequest req)
        {
             JsonResponseModel<ModifyFenceBindResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFenceBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFenceBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改LoRa自定义频点
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaFrequencyRequest"/></param>
        /// <returns><see cref="ModifyLoRaFrequencyResponse"/></returns>
        public async Task<ModifyLoRaFrequencyResponse> ModifyLoRaFrequency(ModifyLoRaFrequencyRequest req)
        {
             JsonResponseModel<ModifyLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改LoRa自定义频点
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaFrequencyRequest"/></param>
        /// <returns><see cref="ModifyLoRaFrequencyResponse"/></returns>
        public ModifyLoRaFrequencyResponse ModifyLoRaFrequencySync(ModifyLoRaFrequencyRequest req)
        {
             JsonResponseModel<ModifyLoRaFrequencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoRaFrequency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoRaFrequencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 LoRa 网关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaGatewayRequest"/></param>
        /// <returns><see cref="ModifyLoRaGatewayResponse"/></returns>
        public async Task<ModifyLoRaGatewayResponse> ModifyLoRaGateway(ModifyLoRaGatewayRequest req)
        {
             JsonResponseModel<ModifyLoRaGatewayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoRaGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoRaGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 LoRa 网关信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLoRaGatewayRequest"/></param>
        /// <returns><see cref="ModifyLoRaGatewayResponse"/></returns>
        public ModifyLoRaGatewayResponse ModifyLoRaGatewaySync(ModifyLoRaGatewayRequest req)
        {
             JsonResponseModel<ModifyLoRaGatewayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoRaGateway");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoRaGatewayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供修改产品的数据模板的能力
        /// </summary>
        /// <param name="req"><see cref="ModifyModelDefinitionRequest"/></param>
        /// <returns><see cref="ModifyModelDefinitionResponse"/></returns>
        public async Task<ModifyModelDefinitionResponse> ModifyModelDefinition(ModifyModelDefinitionRequest req)
        {
             JsonResponseModel<ModifyModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供修改产品的数据模板的能力
        /// </summary>
        /// <param name="req"><see cref="ModifyModelDefinitionRequest"/></param>
        /// <returns><see cref="ModifyModelDefinitionResponse"/></returns>
        public ModifyModelDefinitionResponse ModifyModelDefinitionSync(ModifyModelDefinitionRequest req)
        {
             JsonResponseModel<ModifyModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新围栏
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionFenceRequest"/></param>
        /// <returns><see cref="ModifyPositionFenceResponse"/></returns>
        public async Task<ModifyPositionFenceResponse> ModifyPositionFence(ModifyPositionFenceRequest req)
        {
             JsonResponseModel<ModifyPositionFenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPositionFence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPositionFenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新围栏
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionFenceRequest"/></param>
        /// <returns><see cref="ModifyPositionFenceResponse"/></returns>
        public ModifyPositionFenceResponse ModifyPositionFenceSync(ModifyPositionFenceRequest req)
        {
             JsonResponseModel<ModifyPositionFenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPositionFence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPositionFenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新位置空间
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionSpaceRequest"/></param>
        /// <returns><see cref="ModifyPositionSpaceResponse"/></returns>
        public async Task<ModifyPositionSpaceResponse> ModifyPositionSpace(ModifyPositionSpaceRequest req)
        {
             JsonResponseModel<ModifyPositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新位置空间
        /// </summary>
        /// <param name="req"><see cref="ModifyPositionSpaceRequest"/></param>
        /// <returns><see cref="ModifyPositionSpaceResponse"/></returns>
        public ModifyPositionSpaceResponse ModifyPositionSpaceSync(ModifyPositionSpaceRequest req)
        {
             JsonResponseModel<ModifyPositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public async Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新位置空间产品属性
        /// </summary>
        /// <param name="req"><see cref="ModifySpacePropertyRequest"/></param>
        /// <returns><see cref="ModifySpacePropertyResponse"/></returns>
        public async Task<ModifySpacePropertyResponse> ModifySpaceProperty(ModifySpacePropertyRequest req)
        {
             JsonResponseModel<ModifySpacePropertyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySpaceProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySpacePropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新位置空间产品属性
        /// </summary>
        /// <param name="req"><see cref="ModifySpacePropertyRequest"/></param>
        /// <returns><see cref="ModifySpacePropertyResponse"/></returns>
        public ModifySpacePropertyResponse ModifySpacePropertySync(ModifySpacePropertyRequest req)
        {
             JsonResponseModel<ModifySpacePropertyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySpaceProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySpacePropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供修改产品的名称和描述等信息的能力，对于已发布产品不允许进行修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyStudioProductRequest"/></param>
        /// <returns><see cref="ModifyStudioProductResponse"/></returns>
        public async Task<ModifyStudioProductResponse> ModifyStudioProduct(ModifyStudioProductRequest req)
        {
             JsonResponseModel<ModifyStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供修改产品的名称和描述等信息的能力，对于已发布产品不允许进行修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyStudioProductRequest"/></param>
        /// <returns><see cref="ModifyStudioProductResponse"/></returns>
        public ModifyStudioProductResponse ModifyStudioProductSync(ModifyStudioProductRequest req)
        {
             JsonResponseModel<ModifyStudioProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息 
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicPolicyRequest"/></param>
        /// <returns><see cref="ModifyTopicPolicyResponse"/></returns>
        public async Task<ModifyTopicPolicyResponse> ModifyTopicPolicy(ModifyTopicPolicyRequest req)
        {
             JsonResponseModel<ModifyTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息 
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicPolicyRequest"/></param>
        /// <returns><see cref="ModifyTopicPolicyResponse"/></returns>
        public ModifyTopicPolicyResponse ModifyTopicPolicySync(ModifyTopicPolicyRequest req)
        {
             JsonResponseModel<ModifyTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRuleRequest"/></param>
        /// <returns><see cref="ModifyTopicRuleResponse"/></returns>
        public async Task<ModifyTopicRuleResponse> ModifyTopicRule(ModifyTopicRuleRequest req)
        {
             JsonResponseModel<ModifyTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRuleRequest"/></param>
        /// <returns><see cref="ModifyTopicRuleResponse"/></returns>
        public ModifyTopicRuleResponse ModifyTopicRuleSync(ModifyTopicRuleRequest req)
        {
             JsonResponseModel<ModifyTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布广播消息
        /// </summary>
        /// <param name="req"><see cref="PublishBroadcastMessageRequest"/></param>
        /// <returns><see cref="PublishBroadcastMessageResponse"/></returns>
        public async Task<PublishBroadcastMessageResponse> PublishBroadcastMessage(PublishBroadcastMessageRequest req)
        {
             JsonResponseModel<PublishBroadcastMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishBroadcastMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishBroadcastMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发布广播消息
        /// </summary>
        /// <param name="req"><see cref="PublishBroadcastMessageRequest"/></param>
        /// <returns><see cref="PublishBroadcastMessageResponse"/></returns>
        public PublishBroadcastMessageResponse PublishBroadcastMessageSync(PublishBroadcastMessageRequest req)
        {
             JsonResponseModel<PublishBroadcastMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishBroadcastMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishBroadcastMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（PublishMessage）用于使用自定义透传协议进行设备远控
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public async Task<PublishMessageResponse> PublishMessage(PublishMessageRequest req)
        {
             JsonResponseModel<PublishMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（PublishMessage）用于使用自定义透传协议进行设备远控
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public PublishMessageResponse PublishMessageSync(PublishMessageRequest req)
        {
             JsonResponseModel<PublishMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下发RRPC消息
        /// </summary>
        /// <param name="req"><see cref="PublishRRPCMessageRequest"/></param>
        /// <returns><see cref="PublishRRPCMessageResponse"/></returns>
        public async Task<PublishRRPCMessageResponse> PublishRRPCMessage(PublishRRPCMessageRequest req)
        {
             JsonResponseModel<PublishRRPCMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishRRPCMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishRRPCMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下发RRPC消息
        /// </summary>
        /// <param name="req"><see cref="PublishRRPCMessageRequest"/></param>
        /// <returns><see cref="PublishRRPCMessageResponse"/></returns>
        public PublishRRPCMessageResponse PublishRRPCMessageSync(PublishRRPCMessageRequest req)
        {
             JsonResponseModel<PublishRRPCMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishRRPCMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishRRPCMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品开发完成并测试通过后，通过发布产品将产品设置为发布状态
        /// </summary>
        /// <param name="req"><see cref="ReleaseStudioProductRequest"/></param>
        /// <returns><see cref="ReleaseStudioProductResponse"/></returns>
        public async Task<ReleaseStudioProductResponse> ReleaseStudioProduct(ReleaseStudioProductRequest req)
        {
             JsonResponseModel<ReleaseStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 产品开发完成并测试通过后，通过发布产品将产品设置为发布状态
        /// </summary>
        /// <param name="req"><see cref="ReleaseStudioProductRequest"/></param>
        /// <returns><see cref="ReleaseStudioProductResponse"/></returns>
        public ReleaseStudioProductResponse ReleaseStudioProductSync(ReleaseStudioProductRequest req)
        {
             JsonResponseModel<ReleaseStudioProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索位置空间
        /// </summary>
        /// <param name="req"><see cref="SearchPositionSpaceRequest"/></param>
        /// <returns><see cref="SearchPositionSpaceResponse"/></returns>
        public async Task<SearchPositionSpaceResponse> SearchPositionSpace(SearchPositionSpaceRequest req)
        {
             JsonResponseModel<SearchPositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchPositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索位置空间
        /// </summary>
        /// <param name="req"><see cref="SearchPositionSpaceRequest"/></param>
        /// <returns><see cref="SearchPositionSpaceResponse"/></returns>
        public SearchPositionSpaceResponse SearchPositionSpaceSync(SearchPositionSpaceRequest req)
        {
             JsonResponseModel<SearchPositionSpaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchPositionSpace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPositionSpaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供根据产品名称查找产品的能力
        /// </summary>
        /// <param name="req"><see cref="SearchStudioProductRequest"/></param>
        /// <returns><see cref="SearchStudioProductResponse"/></returns>
        public async Task<SearchStudioProductResponse> SearchStudioProduct(SearchStudioProductRequest req)
        {
             JsonResponseModel<SearchStudioProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提供根据产品名称查找产品的能力
        /// </summary>
        /// <param name="req"><see cref="SearchStudioProductRequest"/></param>
        /// <returns><see cref="SearchStudioProductResponse"/></returns>
        public SearchStudioProductResponse SearchStudioProductSync(SearchStudioProductRequest req)
        {
             JsonResponseModel<SearchStudioProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchStudioProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchStudioProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索规则
        /// </summary>
        /// <param name="req"><see cref="SearchTopicRuleRequest"/></param>
        /// <returns><see cref="SearchTopicRuleResponse"/></returns>
        public async Task<SearchTopicRuleResponse> SearchTopicRule(SearchTopicRuleRequest req)
        {
             JsonResponseModel<SearchTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索规则
        /// </summary>
        /// <param name="req"><see cref="SearchTopicRuleRequest"/></param>
        /// <returns><see cref="SearchTopicRuleResponse"/></returns>
        public SearchTopicRuleResponse SearchTopicRuleSync(SearchTopicRuleRequest req)
        {
             JsonResponseModel<SearchTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑子设备
        /// </summary>
        /// <param name="req"><see cref="UnbindDevicesRequest"/></param>
        /// <returns><see cref="UnbindDevicesResponse"/></returns>
        public async Task<UnbindDevicesResponse> UnbindDevices(UnbindDevicesRequest req)
        {
             JsonResponseModel<UnbindDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑子设备
        /// </summary>
        /// <param name="req"><see cref="UnbindDevicesRequest"/></param>
        /// <returns><see cref="UnbindDevicesResponse"/></returns>
        public UnbindDevicesResponse UnbindDevicesSync(UnbindDevicesRequest req)
        {
             JsonResponseModel<UnbindDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑子产品
        /// </summary>
        /// <param name="req"><see cref="UnbindProductsRequest"/></param>
        /// <returns><see cref="UnbindProductsResponse"/></returns>
        public async Task<UnbindProductsResponse> UnbindProducts(UnbindProductsRequest req)
        {
             JsonResponseModel<UnbindProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量解绑子产品
        /// </summary>
        /// <param name="req"><see cref="UnbindProductsRequest"/></param>
        /// <returns><see cref="UnbindProductsResponse"/></returns>
        public UnbindProductsResponse UnbindProductsSync(UnbindProductsRequest req)
        {
             JsonResponseModel<UnbindProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量禁用启用设备
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public async Task<UpdateDevicesEnableStateResponse> UpdateDevicesEnableState(UpdateDevicesEnableStateRequest req)
        {
             JsonResponseModel<UpdateDevicesEnableStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDevicesEnableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicesEnableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量禁用启用设备
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public UpdateDevicesEnableStateResponse UpdateDevicesEnableStateSync(UpdateDevicesEnableStateRequest req)
        {
             JsonResponseModel<UpdateDevicesEnableStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDevicesEnableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicesEnableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFirmware）用于对指定设备发起固件升级请求 
        /// </summary>
        /// <param name="req"><see cref="UpdateFirmwareRequest"/></param>
        /// <returns><see cref="UpdateFirmwareResponse"/></returns>
        public async Task<UpdateFirmwareResponse> UpdateFirmware(UpdateFirmwareRequest req)
        {
             JsonResponseModel<UpdateFirmwareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFirmware）用于对指定设备发起固件升级请求 
        /// </summary>
        /// <param name="req"><see cref="UpdateFirmwareRequest"/></param>
        /// <returns><see cref="UpdateFirmwareResponse"/></returns>
        public UpdateFirmwareResponse UpdateFirmwareSync(UpdateFirmwareRequest req)
        {
             JsonResponseModel<UpdateFirmwareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadFirmware）用于创建设备固件版本信息，在平台用于固件版本升级、固件资源下发等。
        /// </summary>
        /// <param name="req"><see cref="UploadFirmwareRequest"/></param>
        /// <returns><see cref="UploadFirmwareResponse"/></returns>
        public async Task<UploadFirmwareResponse> UploadFirmware(UploadFirmwareRequest req)
        {
             JsonResponseModel<UploadFirmwareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadFirmware）用于创建设备固件版本信息，在平台用于固件版本升级、固件资源下发等。
        /// </summary>
        /// <param name="req"><see cref="UploadFirmwareRequest"/></param>
        /// <returns><see cref="UploadFirmwareResponse"/></returns>
        public UploadFirmwareResponse UploadFirmwareSync(UploadFirmwareRequest req)
        {
             JsonResponseModel<UploadFirmwareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
