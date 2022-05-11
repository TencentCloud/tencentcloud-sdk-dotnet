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

namespace TencentCloud.Iotcloud.V20210408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotcloud.V20210408.Models;

   public class IotcloudClient : AbstractClient{

       private const string endpoint = "iotcloud.tencentcloudapi.com";
       private const string version = "2021-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotcloudClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotcloudClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（BatchUpdateFirmware）用于批量更新设备固件 
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateFirmwareRequest"/></param>
        /// <returns><see cref="BatchUpdateFirmwareResponse"/></returns>
        public async Task<BatchUpdateFirmwareResponse> BatchUpdateFirmware(BatchUpdateFirmwareRequest req)
        {
             JsonResponseModel<BatchUpdateFirmwareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchUpdateFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchUpdateFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BatchUpdateFirmware）用于批量更新设备固件 
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateFirmwareRequest"/></param>
        /// <returns><see cref="BatchUpdateFirmwareResponse"/></returns>
        public BatchUpdateFirmwareResponse BatchUpdateFirmwareSync(BatchUpdateFirmwareRequest req)
        {
             JsonResponseModel<BatchUpdateFirmwareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchUpdateFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchUpdateFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（BindDevices）用于网关设备批量绑定子设备 
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
        /// 本接口（BindDevices）用于网关设备批量绑定子设备 
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
        /// 取消设备升级任务
        /// </summary>
        /// <param name="req"><see cref="CancelDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="CancelDeviceFirmwareTaskResponse"/></returns>
        public async Task<CancelDeviceFirmwareTaskResponse> CancelDeviceFirmwareTask(CancelDeviceFirmwareTaskRequest req)
        {
             JsonResponseModel<CancelDeviceFirmwareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelDeviceFirmwareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelDeviceFirmwareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消设备升级任务
        /// </summary>
        /// <param name="req"><see cref="CancelDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="CancelDeviceFirmwareTaskResponse"/></returns>
        public CancelDeviceFirmwareTaskResponse CancelDeviceFirmwareTaskSync(CancelDeviceFirmwareTaskRequest req)
        {
             JsonResponseModel<CancelDeviceFirmwareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelDeviceFirmwareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelDeviceFirmwareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。 
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
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。 
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
        /// 本接口（CreateMultiDevicesTask）用于创建产品级别的批量创建设备任务
        /// </summary>
        /// <param name="req"><see cref="CreateMultiDevicesTaskRequest"/></param>
        /// <returns><see cref="CreateMultiDevicesTaskResponse"/></returns>
        public async Task<CreateMultiDevicesTaskResponse> CreateMultiDevicesTask(CreateMultiDevicesTaskRequest req)
        {
             JsonResponseModel<CreateMultiDevicesTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultiDevicesTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiDevicesTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateMultiDevicesTask）用于创建产品级别的批量创建设备任务
        /// </summary>
        /// <param name="req"><see cref="CreateMultiDevicesTaskRequest"/></param>
        /// <returns><see cref="CreateMultiDevicesTaskResponse"/></returns>
        public CreateMultiDevicesTaskResponse CreateMultiDevicesTaskSync(CreateMultiDevicesTaskRequest req)
        {
             JsonResponseModel<CreateMultiDevicesTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultiDevicesTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiDevicesTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建私有CA证书
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public async Task<CreatePrivateCAResponse> CreatePrivateCA(CreatePrivateCARequest req)
        {
             JsonResponseModel<CreatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建私有CA证书
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public CreatePrivateCAResponse CreatePrivateCASync(CreatePrivateCARequest req)
        {
             JsonResponseModel<CreatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网通信产品 
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
        /// 本接口（CreateProduct）用于创建一个新的物联网通信产品 
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
        /// 本接口（CreateTaskFileUrl）用于获取产品级任务文件上传链接
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFileUrlRequest"/></param>
        /// <returns><see cref="CreateTaskFileUrlResponse"/></returns>
        public async Task<CreateTaskFileUrlResponse> CreateTaskFileUrl(CreateTaskFileUrlRequest req)
        {
             JsonResponseModel<CreateTaskFileUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTaskFileUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskFileUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTaskFileUrl）用于获取产品级任务文件上传链接
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFileUrlRequest"/></param>
        /// <returns><see cref="CreateTaskFileUrlResponse"/></returns>
        public CreateTaskFileUrlResponse CreateTaskFileUrlSync(CreateTaskFileUrlRequest req)
        {
             JsonResponseModel<CreateTaskFileUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTaskFileUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskFileUrlResponse>>(strResp);
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
        /// 本接口（CreateTopicRule）用于创建一个规则 
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
        /// 本接口（CreateTopicRule）用于创建一个规则 
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
        /// 本接口（DeleteDevice）用于删除物联网通信设备。 
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
        /// 本接口（DeleteDevice）用于删除物联网通信设备。 
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
        /// 本接口（DeleteDeviceResource）用于删除设备资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceResourceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResourceResponse"/></returns>
        public async Task<DeleteDeviceResourceResponse> DeleteDeviceResource(DeleteDeviceResourceRequest req)
        {
             JsonResponseModel<DeleteDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteDeviceResource）用于删除设备资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceResourceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResourceResponse"/></returns>
        public DeleteDeviceResourceResponse DeleteDeviceResourceSync(DeleteDeviceResourceRequest req)
        {
             JsonResponseModel<DeleteDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public async Task<DeletePrivateCAResponse> DeletePrivateCA(DeletePrivateCARequest req)
        {
             JsonResponseModel<DeletePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public DeletePrivateCAResponse DeletePrivateCASync(DeletePrivateCARequest req)
        {
             JsonResponseModel<DeletePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品
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
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品
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
        /// 删除产品的私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeleteProductPrivateCARequest"/></param>
        /// <returns><see cref="DeleteProductPrivateCAResponse"/></returns>
        public async Task<DeleteProductPrivateCAResponse> DeleteProductPrivateCA(DeleteProductPrivateCARequest req)
        {
             JsonResponseModel<DeleteProductPrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProductPrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductPrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除产品的私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeleteProductPrivateCARequest"/></param>
        /// <returns><see cref="DeleteProductPrivateCAResponse"/></returns>
        public DeleteProductPrivateCAResponse DeleteProductPrivateCASync(DeleteProductPrivateCARequest req)
        {
             JsonResponseModel<DeleteProductPrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProductPrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductPrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteTopicRule）用于删除规则
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
        /// 本接口（DeleteTopicRule）用于删除规则
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
        /// 本接口（DescribeDevice）用于查看设备信息
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
        /// 本接口（DescribeDevice）用于查看设备信息
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
        /// 获取证书认证类型设备的私钥，刚生成或者重置设备后仅可调用一次 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClientKeyRequest"/></param>
        /// <returns><see cref="DescribeDeviceClientKeyResponse"/></returns>
        public async Task<DescribeDeviceClientKeyResponse> DescribeDeviceClientKey(DescribeDeviceClientKeyRequest req)
        {
             JsonResponseModel<DescribeDeviceClientKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceClientKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClientKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取证书认证类型设备的私钥，刚生成或者重置设备后仅可调用一次 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClientKeyRequest"/></param>
        /// <returns><see cref="DescribeDeviceClientKeyResponse"/></returns>
        public DescribeDeviceClientKeyResponse DescribeDeviceClientKeySync(DescribeDeviceClientKeyRequest req)
        {
             JsonResponseModel<DescribeDeviceClientKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceClientKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceClientKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceResource）用于查询设备资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourceResponse"/></returns>
        public async Task<DescribeDeviceResourceResponse> DescribeDeviceResource(DescribeDeviceResourceRequest req)
        {
             JsonResponseModel<DescribeDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceResource）用于查询设备资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourceResponse"/></returns>
        public DescribeDeviceResourceResponse DescribeDeviceResourceSync(DescribeDeviceResourceRequest req)
        {
             JsonResponseModel<DescribeDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceResources）用于查询设备资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourcesResponse"/></returns>
        public async Task<DescribeDeviceResourcesResponse> DescribeDeviceResources(DescribeDeviceResourcesRequest req)
        {
             JsonResponseModel<DescribeDeviceResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceResources）用于查询设备资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourcesResponse"/></returns>
        public DescribeDeviceResourcesResponse DescribeDeviceResourcesSync(DescribeDeviceResourcesRequest req)
        {
             JsonResponseModel<DescribeDeviceResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceShadow）用于查询虚拟设备信息。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowResponse"/></returns>
        public async Task<DescribeDeviceShadowResponse> DescribeDeviceShadow(DescribeDeviceShadowRequest req)
        {
             JsonResponseModel<DescribeDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDeviceShadow）用于查询虚拟设备信息。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowResponse"/></returns>
        public DescribeDeviceShadowResponse DescribeDeviceShadowSync(DescribeDeviceShadowRequest req)
        {
             JsonResponseModel<DescribeDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
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
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
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
        /// 查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public async Task<DescribeFirmwareResponse> DescribeFirmware(DescribeFirmwareRequest req)
        {
             JsonResponseModel<DescribeFirmwareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public DescribeFirmwareResponse DescribeFirmwareSync(DescribeFirmwareRequest req)
        {
             JsonResponseModel<DescribeFirmwareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务详情
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
        /// 查询固件升级任务详情
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
        /// 查询固件升级任务的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDevicesRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDevicesResponse"/></returns>
        public async Task<DescribeFirmwareTaskDevicesResponse> DescribeFirmwareTaskDevices(DescribeFirmwareTaskDevicesRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirmwareTaskDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDevicesRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDevicesResponse"/></returns>
        public DescribeFirmwareTaskDevicesResponse DescribeFirmwareTaskDevicesSync(DescribeFirmwareTaskDevicesRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirmwareTaskDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDistributionRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDistributionResponse"/></returns>
        public async Task<DescribeFirmwareTaskDistributionResponse> DescribeFirmwareTaskDistribution(DescribeFirmwareTaskDistributionRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirmwareTaskDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDistributionRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDistributionResponse"/></returns>
        public DescribeFirmwareTaskDistributionResponse DescribeFirmwareTaskDistributionSync(DescribeFirmwareTaskDistributionRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirmwareTaskDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskStatisticsResponse"/></returns>
        public async Task<DescribeFirmwareTaskStatisticsResponse> DescribeFirmwareTaskStatistics(DescribeFirmwareTaskStatisticsRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirmwareTaskStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询固件升级任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskStatisticsResponse"/></returns>
        public DescribeFirmwareTaskStatisticsResponse DescribeFirmwareTaskStatisticsSync(DescribeFirmwareTaskStatisticsRequest req)
        {
             JsonResponseModel<DescribeFirmwareTaskStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirmwareTaskStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTaskStatisticsResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeFirmwareTasksRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTasksResponse"/></returns>
        public async Task<DescribeFirmwareTasksResponse> DescribeFirmwareTasks(DescribeFirmwareTasksRequest req)
        {
             JsonResponseModel<DescribeFirmwareTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFirmwareTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTasksResponse>>(strResp);
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
        /// <param name="req"><see cref="DescribeFirmwareTasksRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTasksResponse"/></returns>
        public DescribeFirmwareTasksResponse DescribeFirmwareTasksSync(DescribeFirmwareTasksRequest req)
        {
             JsonResponseModel<DescribeFirmwareTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFirmwareTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFirmwareTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGatewayBindDevices）用于获取网关绑定的子设备列表 
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
        /// 本接口（DescribeGatewayBindDevices）用于获取网关绑定的子设备列表 
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
        /// 查询私有化CA信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public async Task<DescribePrivateCAResponse> DescribePrivateCA(DescribePrivateCARequest req)
        {
             JsonResponseModel<DescribePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有化CA信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public DescribePrivateCAResponse DescribePrivateCASync(DescribePrivateCARequest req)
        {
             JsonResponseModel<DescribePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA绑定的产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public async Task<DescribePrivateCABindedProductsResponse> DescribePrivateCABindedProducts(DescribePrivateCABindedProductsRequest req)
        {
             JsonResponseModel<DescribePrivateCABindedProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateCABindedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCABindedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA绑定的产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public DescribePrivateCABindedProductsResponse DescribePrivateCABindedProductsSync(DescribePrivateCABindedProductsRequest req)
        {
             JsonResponseModel<DescribePrivateCABindedProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateCABindedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCABindedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public async Task<DescribePrivateCAsResponse> DescribePrivateCAs(DescribePrivateCAsRequest req)
        {
             JsonResponseModel<DescribePrivateCAsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePrivateCAs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询私有CA证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public DescribePrivateCAsResponse DescribePrivateCAsSync(DescribePrivateCAsRequest req)
        {
             JsonResponseModel<DescribePrivateCAsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePrivateCAs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePrivateCAsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于查看产品详情
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
        /// 本接口（DescribeProduct）用于查看产品详情
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
        /// 查询产品绑定的CA证书
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public async Task<DescribeProductCAResponse> DescribeProductCA(DescribeProductCARequest req)
        {
             JsonResponseModel<DescribeProductCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询产品绑定的CA证书
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public DescribeProductCAResponse DescribeProductCASync(DescribeProductCARequest req)
        {
             JsonResponseModel<DescribeProductCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductResource）用于查询产品资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourceRequest"/></param>
        /// <returns><see cref="DescribeProductResourceResponse"/></returns>
        public async Task<DescribeProductResourceResponse> DescribeProductResource(DescribeProductResourceRequest req)
        {
             JsonResponseModel<DescribeProductResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductResource）用于查询产品资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourceRequest"/></param>
        /// <returns><see cref="DescribeProductResourceResponse"/></returns>
        public DescribeProductResourceResponse DescribeProductResourceSync(DescribeProductResourceRequest req)
        {
             JsonResponseModel<DescribeProductResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductResources）用于查询产品资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourcesRequest"/></param>
        /// <returns><see cref="DescribeProductResourcesResponse"/></returns>
        public async Task<DescribeProductResourcesResponse> DescribeProductResources(DescribeProductResourcesRequest req)
        {
             JsonResponseModel<DescribeProductResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductResources）用于查询产品资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourcesRequest"/></param>
        /// <returns><see cref="DescribeProductResourcesResponse"/></returns>
        public DescribeProductResourcesResponse DescribeProductResourcesSync(DescribeProductResourcesRequest req)
        {
             JsonResponseModel<DescribeProductResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductTask）用于查看产品级别的任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTaskRequest"/></param>
        /// <returns><see cref="DescribeProductTaskResponse"/></returns>
        public async Task<DescribeProductTaskResponse> DescribeProductTask(DescribeProductTaskRequest req)
        {
             JsonResponseModel<DescribeProductTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductTask）用于查看产品级别的任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTaskRequest"/></param>
        /// <returns><see cref="DescribeProductTaskResponse"/></returns>
        public DescribeProductTaskResponse DescribeProductTaskSync(DescribeProductTaskRequest req)
        {
             JsonResponseModel<DescribeProductTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductTasks）用于查看产品级别的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTasksRequest"/></param>
        /// <returns><see cref="DescribeProductTasksResponse"/></returns>
        public async Task<DescribeProductTasksResponse> DescribeProductTasks(DescribeProductTasksRequest req)
        {
             JsonResponseModel<DescribeProductTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProductTasks）用于查看产品级别的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTasksRequest"/></param>
        /// <returns><see cref="DescribeProductTasksResponse"/></returns>
        public DescribeProductTasksResponse DescribeProductTasksSync(DescribeProductTasksRequest req)
        {
             JsonResponseModel<DescribeProductTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出产品列表。 
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
        /// 本接口（DescribeProducts）用于列出产品列表。 
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
        /// 查询推送资源任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribePushResourceTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribePushResourceTaskStatisticsResponse"/></returns>
        public async Task<DescribePushResourceTaskStatisticsResponse> DescribePushResourceTaskStatistics(DescribePushResourceTaskStatisticsRequest req)
        {
             JsonResponseModel<DescribePushResourceTaskStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePushResourceTaskStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushResourceTaskStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询推送资源任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribePushResourceTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribePushResourceTaskStatisticsResponse"/></returns>
        public DescribePushResourceTaskStatisticsResponse DescribePushResourceTaskStatisticsSync(DescribePushResourceTaskStatisticsRequest req)
        {
             JsonResponseModel<DescribePushResourceTaskStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePushResourceTaskStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushResourceTaskStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源推送任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTasksRequest"/></param>
        /// <returns><see cref="DescribeResourceTasksResponse"/></returns>
        public async Task<DescribeResourceTasksResponse> DescribeResourceTasks(DescribeResourceTasksRequest req)
        {
             JsonResponseModel<DescribeResourceTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资源推送任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTasksRequest"/></param>
        /// <returns><see cref="DescribeResourceTasksResponse"/></returns>
        public DescribeResourceTasksResponse DescribeResourceTasksSync(DescribeResourceTasksRequest req)
        {
             JsonResponseModel<DescribeResourceTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DisableTopicRule）用于禁用规则
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
        /// 本接口（DisableTopicRule）用于禁用规则
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
        /// 本接口（DownloadDeviceResource）用于下载设备资源
        /// </summary>
        /// <param name="req"><see cref="DownloadDeviceResourceRequest"/></param>
        /// <returns><see cref="DownloadDeviceResourceResponse"/></returns>
        public async Task<DownloadDeviceResourceResponse> DownloadDeviceResource(DownloadDeviceResourceRequest req)
        {
             JsonResponseModel<DownloadDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DownloadDeviceResource）用于下载设备资源
        /// </summary>
        /// <param name="req"><see cref="DownloadDeviceResourceRequest"/></param>
        /// <returns><see cref="DownloadDeviceResourceResponse"/></returns>
        public DownloadDeviceResourceResponse DownloadDeviceResourceSync(DownloadDeviceResourceRequest req)
        {
             JsonResponseModel<DownloadDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑固件信息
        /// </summary>
        /// <param name="req"><see cref="EditFirmwareRequest"/></param>
        /// <returns><see cref="EditFirmwareResponse"/></returns>
        public async Task<EditFirmwareResponse> EditFirmware(EditFirmwareRequest req)
        {
             JsonResponseModel<EditFirmwareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑固件信息
        /// </summary>
        /// <param name="req"><see cref="EditFirmwareRequest"/></param>
        /// <returns><see cref="EditFirmwareResponse"/></returns>
        public EditFirmwareResponse EditFirmwareSync(EditFirmwareRequest req)
        {
             JsonResponseModel<EditFirmwareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EditFirmware");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditFirmwareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（EnableTopicRule）用于启用规则 
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
        /// 本接口（EnableTopicRule）用于启用规则 
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
        /// 本接口（GetCOSURL）用于获取固件存储在COS的URL 
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
        /// 本接口（GetCOSURL）用于获取固件存储在COS的URL 
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
        /// 本接口（GetUserResourceInfo）用于查询用户资源使用信息。
        /// </summary>
        /// <param name="req"><see cref="GetUserResourceInfoRequest"/></param>
        /// <returns><see cref="GetUserResourceInfoResponse"/></returns>
        public async Task<GetUserResourceInfoResponse> GetUserResourceInfo(GetUserResourceInfoRequest req)
        {
             JsonResponseModel<GetUserResourceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUserResourceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserResourceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetUserResourceInfo）用于查询用户资源使用信息。
        /// </summary>
        /// <param name="req"><see cref="GetUserResourceInfoRequest"/></param>
        /// <returns><see cref="GetUserResourceInfoResponse"/></returns>
        public GetUserResourceInfoResponse GetUserResourceInfoSync(GetUserResourceInfoRequest req)
        {
             JsonResponseModel<GetUserResourceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUserResourceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserResourceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListLog）用于查看日志信息 
        /// </summary>
        /// <param name="req"><see cref="ListLogRequest"/></param>
        /// <returns><see cref="ListLogResponse"/></returns>
        public async Task<ListLogResponse> ListLog(ListLogRequest req)
        {
             JsonResponseModel<ListLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListLog）用于查看日志信息 
        /// </summary>
        /// <param name="req"><see cref="ListLogRequest"/></param>
        /// <returns><see cref="ListLogResponse"/></returns>
        public ListLogResponse ListLogSync(ListLogRequest req)
        {
             JsonResponseModel<ListLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志内容列表
        /// </summary>
        /// <param name="req"><see cref="ListLogPayloadRequest"/></param>
        /// <returns><see cref="ListLogPayloadResponse"/></returns>
        public async Task<ListLogPayloadResponse> ListLogPayload(ListLogPayloadRequest req)
        {
             JsonResponseModel<ListLogPayloadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListLogPayload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLogPayloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志内容列表
        /// </summary>
        /// <param name="req"><see cref="ListLogPayloadRequest"/></param>
        /// <returns><see cref="ListLogPayloadResponse"/></returns>
        public ListLogPayloadResponse ListLogPayloadSync(ListLogPayloadRequest req)
        {
             JsonResponseModel<ListLogPayloadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListLogPayload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLogPayloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备上报的日志
        /// </summary>
        /// <param name="req"><see cref="ListSDKLogRequest"/></param>
        /// <returns><see cref="ListSDKLogResponse"/></returns>
        public async Task<ListSDKLogResponse> ListSDKLog(ListSDKLogRequest req)
        {
             JsonResponseModel<ListSDKLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSDKLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSDKLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设备上报的日志
        /// </summary>
        /// <param name="req"><see cref="ListSDKLogRequest"/></param>
        /// <returns><see cref="ListSDKLogResponse"/></returns>
        public ListSDKLogResponse ListSDKLogSync(ListSDKLogRequest req)
        {
             JsonResponseModel<ListSDKLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSDKLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSDKLogResponse>>(strResp);
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
        /// 本接口（PublishMessage）用于向某个主题发消息。 
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
        /// 本接口（PublishMessage）用于向某个主题发消息。 
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
        /// 发布RRPC消息
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
        /// 发布RRPC消息
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
        /// 本接口（ReplaceTopicRule）用于修改替换规则 
        /// </summary>
        /// <param name="req"><see cref="ReplaceTopicRuleRequest"/></param>
        /// <returns><see cref="ReplaceTopicRuleResponse"/></returns>
        public async Task<ReplaceTopicRuleResponse> ReplaceTopicRule(ReplaceTopicRuleRequest req)
        {
             JsonResponseModel<ReplaceTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ReplaceTopicRule）用于修改替换规则 
        /// </summary>
        /// <param name="req"><see cref="ReplaceTopicRuleRequest"/></param>
        /// <returns><see cref="ReplaceTopicRuleResponse"/></returns>
        public ReplaceTopicRuleResponse ReplaceTopicRuleSync(ReplaceTopicRuleRequest req)
        {
             JsonResponseModel<ReplaceTopicRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceTopicRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceTopicRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置设备的连接状态 
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceStateRequest"/></param>
        /// <returns><see cref="ResetDeviceStateResponse"/></returns>
        public async Task<ResetDeviceStateResponse> ResetDeviceState(ResetDeviceStateRequest req)
        {
             JsonResponseModel<ResetDeviceStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetDeviceState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置设备的连接状态 
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceStateRequest"/></param>
        /// <returns><see cref="ResetDeviceStateResponse"/></returns>
        public ResetDeviceStateResponse ResetDeviceStateSync(ResetDeviceStateRequest req)
        {
             JsonResponseModel<ResetDeviceStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetDeviceState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetDeviceStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试设备升级任务
        /// </summary>
        /// <param name="req"><see cref="RetryDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="RetryDeviceFirmwareTaskResponse"/></returns>
        public async Task<RetryDeviceFirmwareTaskResponse> RetryDeviceFirmwareTask(RetryDeviceFirmwareTaskRequest req)
        {
             JsonResponseModel<RetryDeviceFirmwareTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RetryDeviceFirmwareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryDeviceFirmwareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试设备升级任务
        /// </summary>
        /// <param name="req"><see cref="RetryDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="RetryDeviceFirmwareTaskResponse"/></returns>
        public RetryDeviceFirmwareTaskResponse RetryDeviceFirmwareTaskSync(RetryDeviceFirmwareTaskRequest req)
        {
             JsonResponseModel<RetryDeviceFirmwareTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RetryDeviceFirmwareTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryDeviceFirmwareTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量设置产品禁用状态
        /// </summary>
        /// <param name="req"><see cref="SetProductsForbiddenStatusRequest"/></param>
        /// <returns><see cref="SetProductsForbiddenStatusResponse"/></returns>
        public async Task<SetProductsForbiddenStatusResponse> SetProductsForbiddenStatus(SetProductsForbiddenStatusRequest req)
        {
             JsonResponseModel<SetProductsForbiddenStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetProductsForbiddenStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetProductsForbiddenStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量设置产品禁用状态
        /// </summary>
        /// <param name="req"><see cref="SetProductsForbiddenStatusRequest"/></param>
        /// <returns><see cref="SetProductsForbiddenStatusResponse"/></returns>
        public SetProductsForbiddenStatusResponse SetProductsForbiddenStatusSync(SetProductsForbiddenStatusRequest req)
        {
             JsonResponseModel<SetProductsForbiddenStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetProductsForbiddenStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetProductsForbiddenStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UnbindDevices）用于网关设备批量解绑子设备 
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
        /// 本接口（UnbindDevices）用于网关设备批量解绑子设备 
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
        /// 启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceAvailableStateRequest"/></param>
        /// <returns><see cref="UpdateDeviceAvailableStateResponse"/></returns>
        public async Task<UpdateDeviceAvailableStateResponse> UpdateDeviceAvailableState(UpdateDeviceAvailableStateRequest req)
        {
             JsonResponseModel<UpdateDeviceAvailableStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceAvailableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceAvailableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceAvailableStateRequest"/></param>
        /// <returns><see cref="UpdateDeviceAvailableStateResponse"/></returns>
        public UpdateDeviceAvailableStateResponse UpdateDeviceAvailableStateSync(UpdateDeviceAvailableStateRequest req)
        {
             JsonResponseModel<UpdateDeviceAvailableStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceAvailableState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceAvailableStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置设备上报的日志级别  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public async Task<UpdateDeviceLogLevelResponse> UpdateDeviceLogLevel(UpdateDeviceLogLevelRequest req)
        {
             JsonResponseModel<UpdateDeviceLogLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceLogLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceLogLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置设备上报的日志级别  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public UpdateDeviceLogLevelResponse UpdateDeviceLogLevelSync(UpdateDeviceLogLevelRequest req)
        {
             JsonResponseModel<UpdateDeviceLogLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceLogLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceLogLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateDevicePSK）用于更新设备的PSK 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePSKRequest"/></param>
        /// <returns><see cref="UpdateDevicePSKResponse"/></returns>
        public async Task<UpdateDevicePSKResponse> UpdateDevicePSK(UpdateDevicePSKRequest req)
        {
             JsonResponseModel<UpdateDevicePSKResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDevicePSK");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicePSKResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateDevicePSK）用于更新设备的PSK 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePSKRequest"/></param>
        /// <returns><see cref="UpdateDevicePSKResponse"/></returns>
        public UpdateDevicePSKResponse UpdateDevicePSKSync(UpdateDevicePSKRequest req)
        {
             JsonResponseModel<UpdateDevicePSKResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDevicePSK");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDevicePSKResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateDeviceShadow）用于更新虚拟设备信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceShadowRequest"/></param>
        /// <returns><see cref="UpdateDeviceShadowResponse"/></returns>
        public async Task<UpdateDeviceShadowResponse> UpdateDeviceShadow(UpdateDeviceShadowRequest req)
        {
             JsonResponseModel<UpdateDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateDeviceShadow）用于更新虚拟设备信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceShadowRequest"/></param>
        /// <returns><see cref="UpdateDeviceShadowResponse"/></returns>
        public UpdateDeviceShadowResponse UpdateDeviceShadowSync(UpdateDeviceShadowRequest req)
        {
             JsonResponseModel<UpdateDeviceShadowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDeviceShadow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDeviceShadowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量启用或者禁用设备 
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
        /// 批量启用或者禁用设备 
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
        /// 更新私有CA证书
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public async Task<UpdatePrivateCAResponse> UpdatePrivateCA(UpdatePrivateCARequest req)
        {
             JsonResponseModel<UpdatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新私有CA证书
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public UpdatePrivateCAResponse UpdatePrivateCASync(UpdatePrivateCARequest req)
        {
             JsonResponseModel<UpdatePrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新产品动态注册的配置 
        /// </summary>
        /// <param name="req"><see cref="UpdateProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="UpdateProductDynamicRegisterResponse"/></returns>
        public async Task<UpdateProductDynamicRegisterResponse> UpdateProductDynamicRegister(UpdateProductDynamicRegisterRequest req)
        {
             JsonResponseModel<UpdateProductDynamicRegisterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProductDynamicRegister");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProductDynamicRegisterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新产品动态注册的配置 
        /// </summary>
        /// <param name="req"><see cref="UpdateProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="UpdateProductDynamicRegisterResponse"/></returns>
        public UpdateProductDynamicRegisterResponse UpdateProductDynamicRegisterSync(UpdateProductDynamicRegisterRequest req)
        {
             JsonResponseModel<UpdateProductDynamicRegisterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProductDynamicRegister");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProductDynamicRegisterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新产品的私有CA
        /// </summary>
        /// <param name="req"><see cref="UpdateProductPrivateCARequest"/></param>
        /// <returns><see cref="UpdateProductPrivateCAResponse"/></returns>
        public async Task<UpdateProductPrivateCAResponse> UpdateProductPrivateCA(UpdateProductPrivateCARequest req)
        {
             JsonResponseModel<UpdateProductPrivateCAResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProductPrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProductPrivateCAResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新产品的私有CA
        /// </summary>
        /// <param name="req"><see cref="UpdateProductPrivateCARequest"/></param>
        /// <returns><see cref="UpdateProductPrivateCAResponse"/></returns>
        public UpdateProductPrivateCAResponse UpdateProductPrivateCASync(UpdateProductPrivateCARequest req)
        {
             JsonResponseModel<UpdateProductPrivateCAResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProductPrivateCA");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProductPrivateCAResponse>>(strResp);
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
        /// <param name="req"><see cref="UpdateTopicPolicyRequest"/></param>
        /// <returns><see cref="UpdateTopicPolicyResponse"/></returns>
        public async Task<UpdateTopicPolicyResponse> UpdateTopicPolicy(UpdateTopicPolicyRequest req)
        {
             JsonResponseModel<UpdateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTopicPolicyResponse>>(strResp);
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
        /// <param name="req"><see cref="UpdateTopicPolicyRequest"/></param>
        /// <returns><see cref="UpdateTopicPolicyResponse"/></returns>
        public UpdateTopicPolicyResponse UpdateTopicPolicySync(UpdateTopicPolicyRequest req)
        {
             JsonResponseModel<UpdateTopicPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateTopicPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateTopicPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadFirmware）用于上传设备固件信息 
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
        /// 本接口（UploadFirmware）用于上传设备固件信息 
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
