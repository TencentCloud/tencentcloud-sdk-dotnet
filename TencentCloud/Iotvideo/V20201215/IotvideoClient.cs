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

namespace TencentCloud.Iotvideo.V20201215
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotvideo.V20201215.Models;

   public class IotvideoClient : AbstractClient{

       private const string endpoint = "iotvideo.tencentcloudapi.com";
       private const string version = "2020-12-15";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotvideoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotvideoClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 判断是否开启的转发的权限
        /// </summary>
        /// <param name="req"><see cref="CheckForwardAuthRequest"/></param>
        /// <returns><see cref="CheckForwardAuthResponse"/></returns>
        public async Task<CheckForwardAuthResponse> CheckForwardAuth(CheckForwardAuthRequest req)
        {
             JsonResponseModel<CheckForwardAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckForwardAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckForwardAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 判断是否开启的转发的权限
        /// </summary>
        /// <param name="req"><see cref="CheckForwardAuthRequest"/></param>
        /// <returns><see cref="CheckForwardAuthResponse"/></returns>
        public CheckForwardAuthResponse CheckForwardAuthSync(CheckForwardAuthRequest req)
        {
             JsonResponseModel<CheckForwardAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckForwardAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckForwardAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建批次
        /// </summary>
        /// <param name="req"><see cref="CreateBatchRequest"/></param>
        /// <returns><see cref="CreateBatchResponse"/></returns>
        public async Task<CreateBatchResponse> CreateBatch(CreateBatchRequest req)
        {
             JsonResponseModel<CreateBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建批次
        /// </summary>
        /// <param name="req"><see cref="CreateBatchRequest"/></param>
        /// <returns><see cref="CreateBatchResponse"/></returns>
        public CreateBatchResponse CreateBatchSync(CreateBatchRequest req)
        {
             JsonResponseModel<CreateBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateForwardRuleRequest"/></param>
        /// <returns><see cref="CreateForwardRuleResponse"/></returns>
        public async Task<CreateForwardRuleResponse> CreateForwardRule(CreateForwardRuleRequest req)
        {
             JsonResponseModel<CreateForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateForwardRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateForwardRuleRequest"/></param>
        /// <returns><see cref="CreateForwardRuleResponse"/></returns>
        public CreateForwardRuleResponse CreateForwardRuleSync(CreateForwardRuleRequest req)
        {
             JsonResponseModel<CreateForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateForwardRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建产品
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public async Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建产品
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
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
        /// 删除转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardRuleResponse"/></returns>
        public async Task<DeleteForwardRuleResponse> DeleteForwardRule(DeleteForwardRuleRequest req)
        {
             JsonResponseModel<DeleteForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteForwardRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardRuleResponse"/></returns>
        public DeleteForwardRuleResponse DeleteForwardRuleSync(DeleteForwardRuleRequest req)
        {
             JsonResponseModel<DeleteForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteForwardRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取批次详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchRequest"/></param>
        /// <returns><see cref="DescribeBatchResponse"/></returns>
        public async Task<DescribeBatchResponse> DescribeBatch(DescribeBatchRequest req)
        {
             JsonResponseModel<DescribeBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取批次详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchRequest"/></param>
        /// <returns><see cref="DescribeBatchResponse"/></returns>
        public DescribeBatchResponse DescribeBatchSync(DescribeBatchRequest req)
        {
             JsonResponseModel<DescribeBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchsRequest"/></param>
        /// <returns><see cref="DescribeBatchsResponse"/></returns>
        public async Task<DescribeBatchsResponse> DescribeBatchs(DescribeBatchsRequest req)
        {
             JsonResponseModel<DescribeBatchsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchsRequest"/></param>
        /// <returns><see cref="DescribeBatchsResponse"/></returns>
        public DescribeBatchsResponse DescribeBatchsSync(DescribeBatchsRequest req)
        {
             JsonResponseModel<DescribeBatchsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Category详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCategoryRequest"/></param>
        /// <returns><see cref="DescribeCategoryResponse"/></returns>
        public async Task<DescribeCategoryResponse> DescribeCategory(DescribeCategoryRequest req)
        {
             JsonResponseModel<DescribeCategoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Category详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCategoryRequest"/></param>
        /// <returns><see cref="DescribeCategoryResponse"/></returns>
        public DescribeCategoryResponse DescribeCategorySync(DescribeCategoryRequest req)
        {
             JsonResponseModel<DescribeCategoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看设备详情
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
        /// 查看设备详情
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
        /// 为用户提供获取动作历史的能力。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceActionHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceActionHistoryResponse"/></returns>
        public async Task<DescribeDeviceActionHistoryResponse> DescribeDeviceActionHistory(DescribeDeviceActionHistoryRequest req)
        {
             JsonResponseModel<DescribeDeviceActionHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceActionHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceActionHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户提供获取动作历史的能力。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceActionHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceActionHistoryResponse"/></returns>
        public DescribeDeviceActionHistoryResponse DescribeDeviceActionHistorySync(DescribeDeviceActionHistoryRequest req)
        {
             JsonResponseModel<DescribeDeviceActionHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceActionHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceActionHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备在指定时间范围内的通讯日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCommLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceCommLogResponse"/></returns>
        public async Task<DescribeDeviceCommLogResponse> DescribeDeviceCommLog(DescribeDeviceCommLogRequest req)
        {
             JsonResponseModel<DescribeDeviceCommLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceCommLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceCommLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备在指定时间范围内的通讯日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCommLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceCommLogResponse"/></returns>
        public DescribeDeviceCommLogResponse DescribeDeviceCommLogSync(DescribeDeviceCommLogRequest req)
        {
             JsonResponseModel<DescribeDeviceCommLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceCommLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceCommLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备属性数据
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
        /// 获取设备属性数据
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
        /// 获取设备的历史事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceEventHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventHistoryResponse"/></returns>
        public async Task<DescribeDeviceEventHistoryResponse> DescribeDeviceEventHistory(DescribeDeviceEventHistoryRequest req)
        {
             JsonResponseModel<DescribeDeviceEventHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceEventHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceEventHistoryResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeDeviceEventHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventHistoryResponse"/></returns>
        public DescribeDeviceEventHistoryResponse DescribeDeviceEventHistorySync(DescribeDeviceEventHistoryRequest req)
        {
             JsonResponseModel<DescribeDeviceEventHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceEventHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceEventHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleResponse"/></returns>
        public async Task<DescribeForwardRuleResponse> DescribeForwardRule(DescribeForwardRuleRequest req)
        {
             JsonResponseModel<DescribeForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeForwardRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleResponse"/></returns>
        public DescribeForwardRuleResponse DescribeForwardRuleSync(DescribeForwardRuleRequest req)
        {
             JsonResponseModel<DescribeForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeForwardRuleResponse>>(strResp);
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
        /// 获取产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public async Task<DescribeProductResponse> DescribeProduct(DescribeProductRequest req)
        {
             JsonResponseModel<DescribeProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public DescribeProductResponse DescribeProductSync(DescribeProductRequest req)
        {
             JsonResponseModel<DescribeProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public async Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入其它产品的数据模板，覆盖现有数据模板的物模型和产品分类信息
        /// </summary>
        /// <param name="req"><see cref="ImportModelDefinitionRequest"/></param>
        /// <returns><see cref="ImportModelDefinitionResponse"/></returns>
        public async Task<ImportModelDefinitionResponse> ImportModelDefinition(ImportModelDefinitionRequest req)
        {
             JsonResponseModel<ImportModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImportModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导入其它产品的数据模板，覆盖现有数据模板的物模型和产品分类信息
        /// </summary>
        /// <param name="req"><see cref="ImportModelDefinitionRequest"/></param>
        /// <returns><see cref="ImportModelDefinitionResponse"/></returns>
        public ImportModelDefinitionResponse ImportModelDefinitionSync(ImportModelDefinitionRequest req)
        {
             JsonResponseModel<ImportModelDefinitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImportModelDefinition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImportModelDefinitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public async Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
             JsonResponseModel<ModifyDeviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
             JsonResponseModel<ModifyDeviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDevice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDeviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardRuleResponse"/></returns>
        public async Task<ModifyForwardRuleResponse> ModifyForwardRule(ModifyForwardRuleRequest req)
        {
             JsonResponseModel<ModifyForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyForwardRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardRuleResponse"/></returns>
        public ModifyForwardRuleResponse ModifyForwardRuleSync(ModifyForwardRuleRequest req)
        {
             JsonResponseModel<ModifyForwardRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyForwardRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyForwardRuleResponse>>(strResp);
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
        /// 修改产品信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public async Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest req)
        {
             JsonResponseModel<ModifyProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改产品信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public ModifyProductResponse ModifyProductSync(ModifyProductRequest req)
        {
             JsonResponseModel<ModifyProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置转发权限
        /// </summary>
        /// <param name="req"><see cref="SetForwardAuthRequest"/></param>
        /// <returns><see cref="SetForwardAuthResponse"/></returns>
        public async Task<SetForwardAuthResponse> SetForwardAuth(SetForwardAuthRequest req)
        {
             JsonResponseModel<SetForwardAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetForwardAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetForwardAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置转发权限
        /// </summary>
        /// <param name="req"><see cref="SetForwardAuthRequest"/></param>
        /// <returns><see cref="SetForwardAuthResponse"/></returns>
        public SetForwardAuthResponse SetForwardAuthSync(SetForwardAuthRequest req)
        {
             JsonResponseModel<SetForwardAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetForwardAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetForwardAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
