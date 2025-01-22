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
       private const string sdkVersion = "SDK_NET_3.0.1170";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotcloudClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（BatchUpdateFirmware）用于批量更新设备固件
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateFirmwareRequest"/></param>
        /// <returns><see cref="BatchUpdateFirmwareResponse"/></returns>
        public Task<BatchUpdateFirmwareResponse> BatchUpdateFirmware(BatchUpdateFirmwareRequest req)
        {
            return InternalRequestAsync<BatchUpdateFirmwareResponse>(req, "BatchUpdateFirmware");
        }

        /// <summary>
        /// 本接口（BatchUpdateFirmware）用于批量更新设备固件
        /// </summary>
        /// <param name="req"><see cref="BatchUpdateFirmwareRequest"/></param>
        /// <returns><see cref="BatchUpdateFirmwareResponse"/></returns>
        public BatchUpdateFirmwareResponse BatchUpdateFirmwareSync(BatchUpdateFirmwareRequest req)
        {
            return InternalRequestAsync<BatchUpdateFirmwareResponse>(req, "BatchUpdateFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（BindDevices）用于网关设备批量绑定子设备 
        /// </summary>
        /// <param name="req"><see cref="BindDevicesRequest"/></param>
        /// <returns><see cref="BindDevicesResponse"/></returns>
        public Task<BindDevicesResponse> BindDevices(BindDevicesRequest req)
        {
            return InternalRequestAsync<BindDevicesResponse>(req, "BindDevices");
        }

        /// <summary>
        /// 本接口（BindDevices）用于网关设备批量绑定子设备 
        /// </summary>
        /// <param name="req"><see cref="BindDevicesRequest"/></param>
        /// <returns><see cref="BindDevicesResponse"/></returns>
        public BindDevicesResponse BindDevicesSync(BindDevicesRequest req)
        {
            return InternalRequestAsync<BindDevicesResponse>(req, "BindDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消设备升级任务
        /// </summary>
        /// <param name="req"><see cref="CancelDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="CancelDeviceFirmwareTaskResponse"/></returns>
        public Task<CancelDeviceFirmwareTaskResponse> CancelDeviceFirmwareTask(CancelDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<CancelDeviceFirmwareTaskResponse>(req, "CancelDeviceFirmwareTask");
        }

        /// <summary>
        /// 取消设备升级任务
        /// </summary>
        /// <param name="req"><see cref="CancelDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="CancelDeviceFirmwareTaskResponse"/></returns>
        public CancelDeviceFirmwareTaskResponse CancelDeviceFirmwareTaskSync(CancelDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<CancelDeviceFirmwareTaskResponse>(req, "CancelDeviceFirmwareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice");
        }

        /// <summary>
        /// 本接口（CreateDevice）用于新建一个物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateMultiDevicesTask）用于创建产品级别的批量创建设备任务
        /// </summary>
        /// <param name="req"><see cref="CreateMultiDevicesTaskRequest"/></param>
        /// <returns><see cref="CreateMultiDevicesTaskResponse"/></returns>
        public Task<CreateMultiDevicesTaskResponse> CreateMultiDevicesTask(CreateMultiDevicesTaskRequest req)
        {
            return InternalRequestAsync<CreateMultiDevicesTaskResponse>(req, "CreateMultiDevicesTask");
        }

        /// <summary>
        /// 本接口（CreateMultiDevicesTask）用于创建产品级别的批量创建设备任务
        /// </summary>
        /// <param name="req"><see cref="CreateMultiDevicesTaskRequest"/></param>
        /// <returns><see cref="CreateMultiDevicesTaskResponse"/></returns>
        public CreateMultiDevicesTaskResponse CreateMultiDevicesTaskSync(CreateMultiDevicesTaskRequest req)
        {
            return InternalRequestAsync<CreateMultiDevicesTaskResponse>(req, "CreateMultiDevicesTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建私有CA证书
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public Task<CreatePrivateCAResponse> CreatePrivateCA(CreatePrivateCARequest req)
        {
            return InternalRequestAsync<CreatePrivateCAResponse>(req, "CreatePrivateCA");
        }

        /// <summary>
        /// 创建私有CA证书
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public CreatePrivateCAResponse CreatePrivateCASync(CreatePrivateCARequest req)
        {
            return InternalRequestAsync<CreatePrivateCAResponse>(req, "CreatePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网通信产品 
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct");
        }

        /// <summary>
        /// 本接口（CreateProduct）用于创建一个新的物联网通信产品 
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTaskFileUrl）用于获取产品级任务文件上传链接
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFileUrlRequest"/></param>
        /// <returns><see cref="CreateTaskFileUrlResponse"/></returns>
        public Task<CreateTaskFileUrlResponse> CreateTaskFileUrl(CreateTaskFileUrlRequest req)
        {
            return InternalRequestAsync<CreateTaskFileUrlResponse>(req, "CreateTaskFileUrl");
        }

        /// <summary>
        /// 本接口（CreateTaskFileUrl）用于获取产品级任务文件上传链接
        /// </summary>
        /// <param name="req"><see cref="CreateTaskFileUrlRequest"/></param>
        /// <returns><see cref="CreateTaskFileUrlResponse"/></returns>
        public CreateTaskFileUrlResponse CreateTaskFileUrlSync(CreateTaskFileUrlRequest req)
        {
            return InternalRequestAsync<CreateTaskFileUrlResponse>(req, "CreateTaskFileUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTopicPolicy）用于创建一个Topic 
        /// </summary>
        /// <param name="req"><see cref="CreateTopicPolicyRequest"/></param>
        /// <returns><see cref="CreateTopicPolicyResponse"/></returns>
        public Task<CreateTopicPolicyResponse> CreateTopicPolicy(CreateTopicPolicyRequest req)
        {
            return InternalRequestAsync<CreateTopicPolicyResponse>(req, "CreateTopicPolicy");
        }

        /// <summary>
        /// 本接口（CreateTopicPolicy）用于创建一个Topic 
        /// </summary>
        /// <param name="req"><see cref="CreateTopicPolicyRequest"/></param>
        /// <returns><see cref="CreateTopicPolicyResponse"/></returns>
        public CreateTopicPolicyResponse CreateTopicPolicySync(CreateTopicPolicyRequest req)
        {
            return InternalRequestAsync<CreateTopicPolicyResponse>(req, "CreateTopicPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTopicRule）用于创建一个规则 
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRuleRequest"/></param>
        /// <returns><see cref="CreateTopicRuleResponse"/></returns>
        public Task<CreateTopicRuleResponse> CreateTopicRule(CreateTopicRuleRequest req)
        {
            return InternalRequestAsync<CreateTopicRuleResponse>(req, "CreateTopicRule");
        }

        /// <summary>
        /// 本接口（CreateTopicRule）用于创建一个规则 
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRuleRequest"/></param>
        /// <returns><see cref="CreateTopicRuleResponse"/></returns>
        public CreateTopicRuleResponse CreateTopicRuleSync(CreateTopicRuleRequest req)
        {
            return InternalRequestAsync<CreateTopicRuleResponse>(req, "CreateTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// 本接口（DeleteDevice）用于删除物联网通信设备。 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDeviceResource）用于删除设备资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceResourceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResourceResponse"/></returns>
        public Task<DeleteDeviceResourceResponse> DeleteDeviceResource(DeleteDeviceResourceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResourceResponse>(req, "DeleteDeviceResource");
        }

        /// <summary>
        /// 本接口（DeleteDeviceResource）用于删除设备资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceResourceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResourceResponse"/></returns>
        public DeleteDeviceResourceResponse DeleteDeviceResourceSync(DeleteDeviceResourceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResourceResponse>(req, "DeleteDeviceResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteDeviceShadow）用于删除设备影子 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceShadowRequest"/></param>
        /// <returns><see cref="DeleteDeviceShadowResponse"/></returns>
        public Task<DeleteDeviceShadowResponse> DeleteDeviceShadow(DeleteDeviceShadowRequest req)
        {
            return InternalRequestAsync<DeleteDeviceShadowResponse>(req, "DeleteDeviceShadow");
        }

        /// <summary>
        /// 本接口（DeleteDeviceShadow）用于删除设备影子 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceShadowRequest"/></param>
        /// <returns><see cref="DeleteDeviceShadowResponse"/></returns>
        public DeleteDeviceShadowResponse DeleteDeviceShadowSync(DeleteDeviceShadowRequest req)
        {
            return InternalRequestAsync<DeleteDeviceShadowResponse>(req, "DeleteDeviceShadow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public Task<DeletePrivateCAResponse> DeletePrivateCA(DeletePrivateCARequest req)
        {
            return InternalRequestAsync<DeletePrivateCAResponse>(req, "DeletePrivateCA");
        }

        /// <summary>
        /// 删除私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public DeletePrivateCAResponse DeletePrivateCASync(DeletePrivateCARequest req)
        {
            return InternalRequestAsync<DeletePrivateCAResponse>(req, "DeletePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct");
        }

        /// <summary>
        /// 本接口（DeleteProduct）用于删除一个物联网通信产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除产品的私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeleteProductPrivateCARequest"/></param>
        /// <returns><see cref="DeleteProductPrivateCAResponse"/></returns>
        public Task<DeleteProductPrivateCAResponse> DeleteProductPrivateCA(DeleteProductPrivateCARequest req)
        {
            return InternalRequestAsync<DeleteProductPrivateCAResponse>(req, "DeleteProductPrivateCA");
        }

        /// <summary>
        /// 删除产品的私有CA证书
        /// </summary>
        /// <param name="req"><see cref="DeleteProductPrivateCARequest"/></param>
        /// <returns><see cref="DeleteProductPrivateCAResponse"/></returns>
        public DeleteProductPrivateCAResponse DeleteProductPrivateCASync(DeleteProductPrivateCARequest req)
        {
            return InternalRequestAsync<DeleteProductPrivateCAResponse>(req, "DeleteProductPrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteTopicRule）用于删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRuleRequest"/></param>
        /// <returns><see cref="DeleteTopicRuleResponse"/></returns>
        public Task<DeleteTopicRuleResponse> DeleteTopicRule(DeleteTopicRuleRequest req)
        {
            return InternalRequestAsync<DeleteTopicRuleResponse>(req, "DeleteTopicRule");
        }

        /// <summary>
        /// 本接口（DeleteTopicRule）用于删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRuleRequest"/></param>
        /// <returns><see cref="DeleteTopicRuleResponse"/></returns>
        public DeleteTopicRuleResponse DeleteTopicRuleSync(DeleteTopicRuleRequest req)
        {
            return InternalRequestAsync<DeleteTopicRuleResponse>(req, "DeleteTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDevice）用于查看设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice");
        }

        /// <summary>
        /// 本接口（DescribeDevice）用于查看设备信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取证书认证类型设备的私钥，刚生成或者重置设备后仅可调用一次 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClientKeyRequest"/></param>
        /// <returns><see cref="DescribeDeviceClientKeyResponse"/></returns>
        public Task<DescribeDeviceClientKeyResponse> DescribeDeviceClientKey(DescribeDeviceClientKeyRequest req)
        {
            return InternalRequestAsync<DescribeDeviceClientKeyResponse>(req, "DescribeDeviceClientKey");
        }

        /// <summary>
        /// 获取证书认证类型设备的私钥，刚生成或者重置设备后仅可调用一次 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceClientKeyRequest"/></param>
        /// <returns><see cref="DescribeDeviceClientKeyResponse"/></returns>
        public DescribeDeviceClientKeyResponse DescribeDeviceClientKeySync(DescribeDeviceClientKeyRequest req)
        {
            return InternalRequestAsync<DescribeDeviceClientKeyResponse>(req, "DescribeDeviceClientKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDeviceResource）用于查询设备资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourceResponse"/></returns>
        public Task<DescribeDeviceResourceResponse> DescribeDeviceResource(DescribeDeviceResourceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResourceResponse>(req, "DescribeDeviceResource");
        }

        /// <summary>
        /// 本接口（DescribeDeviceResource）用于查询设备资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourceResponse"/></returns>
        public DescribeDeviceResourceResponse DescribeDeviceResourceSync(DescribeDeviceResourceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResourceResponse>(req, "DescribeDeviceResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDeviceResources）用于查询设备资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourcesResponse"/></returns>
        public Task<DescribeDeviceResourcesResponse> DescribeDeviceResources(DescribeDeviceResourcesRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResourcesResponse>(req, "DescribeDeviceResources");
        }

        /// <summary>
        /// 本接口（DescribeDeviceResources）用于查询设备资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceResourcesRequest"/></param>
        /// <returns><see cref="DescribeDeviceResourcesResponse"/></returns>
        public DescribeDeviceResourcesResponse DescribeDeviceResourcesSync(DescribeDeviceResourcesRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResourcesResponse>(req, "DescribeDeviceResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDeviceShadow）用于查询虚拟设备信息。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowResponse"/></returns>
        public Task<DescribeDeviceShadowResponse> DescribeDeviceShadow(DescribeDeviceShadowRequest req)
        {
            return InternalRequestAsync<DescribeDeviceShadowResponse>(req, "DescribeDeviceShadow");
        }

        /// <summary>
        /// 本接口（DescribeDeviceShadow）用于查询虚拟设备信息。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceShadowRequest"/></param>
        /// <returns><see cref="DescribeDeviceShadowResponse"/></returns>
        public DescribeDeviceShadowResponse DescribeDeviceShadowSync(DescribeDeviceShadowRequest req)
        {
            return InternalRequestAsync<DescribeDeviceShadowResponse>(req, "DescribeDeviceShadow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// 本接口（DescribeDevices）用于查询物联网通信设备的设备列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public Task<DescribeFirmwareResponse> DescribeFirmware(DescribeFirmwareRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareResponse>(req, "DescribeFirmware");
        }

        /// <summary>
        /// 查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public DescribeFirmwareResponse DescribeFirmwareSync(DescribeFirmwareRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareResponse>(req, "DescribeFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件升级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public Task<DescribeFirmwareTaskResponse> DescribeFirmwareTask(DescribeFirmwareTaskRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskResponse>(req, "DescribeFirmwareTask");
        }

        /// <summary>
        /// 查询固件升级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public DescribeFirmwareTaskResponse DescribeFirmwareTaskSync(DescribeFirmwareTaskRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskResponse>(req, "DescribeFirmwareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件升级任务的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDevicesRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDevicesResponse"/></returns>
        public Task<DescribeFirmwareTaskDevicesResponse> DescribeFirmwareTaskDevices(DescribeFirmwareTaskDevicesRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDevicesResponse>(req, "DescribeFirmwareTaskDevices");
        }

        /// <summary>
        /// 查询固件升级任务的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDevicesRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDevicesResponse"/></returns>
        public DescribeFirmwareTaskDevicesResponse DescribeFirmwareTaskDevicesSync(DescribeFirmwareTaskDevicesRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDevicesResponse>(req, "DescribeFirmwareTaskDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件升级任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDistributionRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDistributionResponse"/></returns>
        public Task<DescribeFirmwareTaskDistributionResponse> DescribeFirmwareTaskDistribution(DescribeFirmwareTaskDistributionRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDistributionResponse>(req, "DescribeFirmwareTaskDistribution");
        }

        /// <summary>
        /// 查询固件升级任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDistributionRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDistributionResponse"/></returns>
        public DescribeFirmwareTaskDistributionResponse DescribeFirmwareTaskDistributionSync(DescribeFirmwareTaskDistributionRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDistributionResponse>(req, "DescribeFirmwareTaskDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件升级任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskStatisticsResponse"/></returns>
        public Task<DescribeFirmwareTaskStatisticsResponse> DescribeFirmwareTaskStatistics(DescribeFirmwareTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskStatisticsResponse>(req, "DescribeFirmwareTaskStatistics");
        }

        /// <summary>
        /// 查询固件升级任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskStatisticsResponse"/></returns>
        public DescribeFirmwareTaskStatisticsResponse DescribeFirmwareTaskStatisticsSync(DescribeFirmwareTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskStatisticsResponse>(req, "DescribeFirmwareTaskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTasksRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTasksResponse"/></returns>
        public Task<DescribeFirmwareTasksResponse> DescribeFirmwareTasks(DescribeFirmwareTasksRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTasksResponse>(req, "DescribeFirmwareTasks");
        }

        /// <summary>
        /// 查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTasksRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTasksResponse"/></returns>
        public DescribeFirmwareTasksResponse DescribeFirmwareTasksSync(DescribeFirmwareTasksRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTasksResponse>(req, "DescribeFirmwareTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeGatewayBindDevices）用于获取网关绑定的子设备列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayBindDevicesRequest"/></param>
        /// <returns><see cref="DescribeGatewayBindDevicesResponse"/></returns>
        public Task<DescribeGatewayBindDevicesResponse> DescribeGatewayBindDevices(DescribeGatewayBindDevicesRequest req)
        {
            return InternalRequestAsync<DescribeGatewayBindDevicesResponse>(req, "DescribeGatewayBindDevices");
        }

        /// <summary>
        /// 本接口（DescribeGatewayBindDevices）用于获取网关绑定的子设备列表 
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayBindDevicesRequest"/></param>
        /// <returns><see cref="DescribeGatewayBindDevicesResponse"/></returns>
        public DescribeGatewayBindDevicesResponse DescribeGatewayBindDevicesSync(DescribeGatewayBindDevicesRequest req)
        {
            return InternalRequestAsync<DescribeGatewayBindDevicesResponse>(req, "DescribeGatewayBindDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私有化CA信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public Task<DescribePrivateCAResponse> DescribePrivateCA(DescribePrivateCARequest req)
        {
            return InternalRequestAsync<DescribePrivateCAResponse>(req, "DescribePrivateCA");
        }

        /// <summary>
        /// 查询私有化CA信息
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public DescribePrivateCAResponse DescribePrivateCASync(DescribePrivateCARequest req)
        {
            return InternalRequestAsync<DescribePrivateCAResponse>(req, "DescribePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私有CA绑定的产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public Task<DescribePrivateCABindedProductsResponse> DescribePrivateCABindedProducts(DescribePrivateCABindedProductsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCABindedProductsResponse>(req, "DescribePrivateCABindedProducts");
        }

        /// <summary>
        /// 查询私有CA绑定的产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public DescribePrivateCABindedProductsResponse DescribePrivateCABindedProductsSync(DescribePrivateCABindedProductsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCABindedProductsResponse>(req, "DescribePrivateCABindedProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私有CA证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public Task<DescribePrivateCAsResponse> DescribePrivateCAs(DescribePrivateCAsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCAsResponse>(req, "DescribePrivateCAs");
        }

        /// <summary>
        /// 查询私有CA证书列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public DescribePrivateCAsResponse DescribePrivateCAsSync(DescribePrivateCAsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCAsResponse>(req, "DescribePrivateCAs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于查看产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public Task<DescribeProductResponse> DescribeProduct(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct");
        }

        /// <summary>
        /// 本接口（DescribeProduct）用于查看产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public DescribeProductResponse DescribeProductSync(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询产品绑定的CA证书
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public Task<DescribeProductCAResponse> DescribeProductCA(DescribeProductCARequest req)
        {
            return InternalRequestAsync<DescribeProductCAResponse>(req, "DescribeProductCA");
        }

        /// <summary>
        /// 查询产品绑定的CA证书
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public DescribeProductCAResponse DescribeProductCASync(DescribeProductCARequest req)
        {
            return InternalRequestAsync<DescribeProductCAResponse>(req, "DescribeProductCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProductResource）用于查询产品资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourceRequest"/></param>
        /// <returns><see cref="DescribeProductResourceResponse"/></returns>
        public Task<DescribeProductResourceResponse> DescribeProductResource(DescribeProductResourceRequest req)
        {
            return InternalRequestAsync<DescribeProductResourceResponse>(req, "DescribeProductResource");
        }

        /// <summary>
        /// 本接口（DescribeProductResource）用于查询产品资源详情。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourceRequest"/></param>
        /// <returns><see cref="DescribeProductResourceResponse"/></returns>
        public DescribeProductResourceResponse DescribeProductResourceSync(DescribeProductResourceRequest req)
        {
            return InternalRequestAsync<DescribeProductResourceResponse>(req, "DescribeProductResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProductResources）用于查询产品资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourcesRequest"/></param>
        /// <returns><see cref="DescribeProductResourcesResponse"/></returns>
        public Task<DescribeProductResourcesResponse> DescribeProductResources(DescribeProductResourcesRequest req)
        {
            return InternalRequestAsync<DescribeProductResourcesResponse>(req, "DescribeProductResources");
        }

        /// <summary>
        /// 本接口（DescribeProductResources）用于查询产品资源列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductResourcesRequest"/></param>
        /// <returns><see cref="DescribeProductResourcesResponse"/></returns>
        public DescribeProductResourcesResponse DescribeProductResourcesSync(DescribeProductResourcesRequest req)
        {
            return InternalRequestAsync<DescribeProductResourcesResponse>(req, "DescribeProductResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProductTask）用于查看产品级别的任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTaskRequest"/></param>
        /// <returns><see cref="DescribeProductTaskResponse"/></returns>
        public Task<DescribeProductTaskResponse> DescribeProductTask(DescribeProductTaskRequest req)
        {
            return InternalRequestAsync<DescribeProductTaskResponse>(req, "DescribeProductTask");
        }

        /// <summary>
        /// 本接口（DescribeProductTask）用于查看产品级别的任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTaskRequest"/></param>
        /// <returns><see cref="DescribeProductTaskResponse"/></returns>
        public DescribeProductTaskResponse DescribeProductTaskSync(DescribeProductTaskRequest req)
        {
            return InternalRequestAsync<DescribeProductTaskResponse>(req, "DescribeProductTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProductTasks）用于查看产品级别的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTasksRequest"/></param>
        /// <returns><see cref="DescribeProductTasksResponse"/></returns>
        public Task<DescribeProductTasksResponse> DescribeProductTasks(DescribeProductTasksRequest req)
        {
            return InternalRequestAsync<DescribeProductTasksResponse>(req, "DescribeProductTasks");
        }

        /// <summary>
        /// 本接口（DescribeProductTasks）用于查看产品级别的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductTasksRequest"/></param>
        /// <returns><see cref="DescribeProductTasksResponse"/></returns>
        public DescribeProductTasksResponse DescribeProductTasksSync(DescribeProductTasksRequest req)
        {
            return InternalRequestAsync<DescribeProductTasksResponse>(req, "DescribeProductTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出产品列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts");
        }

        /// <summary>
        /// 本接口（DescribeProducts）用于列出产品列表。 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询推送资源任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribePushResourceTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribePushResourceTaskStatisticsResponse"/></returns>
        public Task<DescribePushResourceTaskStatisticsResponse> DescribePushResourceTaskStatistics(DescribePushResourceTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribePushResourceTaskStatisticsResponse>(req, "DescribePushResourceTaskStatistics");
        }

        /// <summary>
        /// 查询推送资源任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribePushResourceTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribePushResourceTaskStatisticsResponse"/></returns>
        public DescribePushResourceTaskStatisticsResponse DescribePushResourceTaskStatisticsSync(DescribePushResourceTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribePushResourceTaskStatisticsResponse>(req, "DescribePushResourceTaskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源推送任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTasksRequest"/></param>
        /// <returns><see cref="DescribeResourceTasksResponse"/></returns>
        public Task<DescribeResourceTasksResponse> DescribeResourceTasks(DescribeResourceTasksRequest req)
        {
            return InternalRequestAsync<DescribeResourceTasksResponse>(req, "DescribeResourceTasks");
        }

        /// <summary>
        /// 查询资源推送任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTasksRequest"/></param>
        /// <returns><see cref="DescribeResourceTasksResponse"/></returns>
        public DescribeResourceTasksResponse DescribeResourceTasksSync(DescribeResourceTasksRequest req)
        {
            return InternalRequestAsync<DescribeResourceTasksResponse>(req, "DescribeResourceTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DisableTopicRule）用于禁用规则
        /// </summary>
        /// <param name="req"><see cref="DisableTopicRuleRequest"/></param>
        /// <returns><see cref="DisableTopicRuleResponse"/></returns>
        public Task<DisableTopicRuleResponse> DisableTopicRule(DisableTopicRuleRequest req)
        {
            return InternalRequestAsync<DisableTopicRuleResponse>(req, "DisableTopicRule");
        }

        /// <summary>
        /// 本接口（DisableTopicRule）用于禁用规则
        /// </summary>
        /// <param name="req"><see cref="DisableTopicRuleRequest"/></param>
        /// <returns><see cref="DisableTopicRuleResponse"/></returns>
        public DisableTopicRuleResponse DisableTopicRuleSync(DisableTopicRuleRequest req)
        {
            return InternalRequestAsync<DisableTopicRuleResponse>(req, "DisableTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DownloadDeviceResource）用于下载设备资源
        /// </summary>
        /// <param name="req"><see cref="DownloadDeviceResourceRequest"/></param>
        /// <returns><see cref="DownloadDeviceResourceResponse"/></returns>
        public Task<DownloadDeviceResourceResponse> DownloadDeviceResource(DownloadDeviceResourceRequest req)
        {
            return InternalRequestAsync<DownloadDeviceResourceResponse>(req, "DownloadDeviceResource");
        }

        /// <summary>
        /// 本接口（DownloadDeviceResource）用于下载设备资源
        /// </summary>
        /// <param name="req"><see cref="DownloadDeviceResourceRequest"/></param>
        /// <returns><see cref="DownloadDeviceResourceResponse"/></returns>
        public DownloadDeviceResourceResponse DownloadDeviceResourceSync(DownloadDeviceResourceRequest req)
        {
            return InternalRequestAsync<DownloadDeviceResourceResponse>(req, "DownloadDeviceResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑固件信息
        /// </summary>
        /// <param name="req"><see cref="EditFirmwareRequest"/></param>
        /// <returns><see cref="EditFirmwareResponse"/></returns>
        public Task<EditFirmwareResponse> EditFirmware(EditFirmwareRequest req)
        {
            return InternalRequestAsync<EditFirmwareResponse>(req, "EditFirmware");
        }

        /// <summary>
        /// 编辑固件信息
        /// </summary>
        /// <param name="req"><see cref="EditFirmwareRequest"/></param>
        /// <returns><see cref="EditFirmwareResponse"/></returns>
        public EditFirmwareResponse EditFirmwareSync(EditFirmwareRequest req)
        {
            return InternalRequestAsync<EditFirmwareResponse>(req, "EditFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（EnableTopicRule）用于启用规则 
        /// </summary>
        /// <param name="req"><see cref="EnableTopicRuleRequest"/></param>
        /// <returns><see cref="EnableTopicRuleResponse"/></returns>
        public Task<EnableTopicRuleResponse> EnableTopicRule(EnableTopicRuleRequest req)
        {
            return InternalRequestAsync<EnableTopicRuleResponse>(req, "EnableTopicRule");
        }

        /// <summary>
        /// 本接口（EnableTopicRule）用于启用规则 
        /// </summary>
        /// <param name="req"><see cref="EnableTopicRuleRequest"/></param>
        /// <returns><see cref="EnableTopicRuleResponse"/></returns>
        public EnableTopicRuleResponse EnableTopicRuleSync(EnableTopicRuleRequest req)
        {
            return InternalRequestAsync<EnableTopicRuleResponse>(req, "EnableTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetAllVersion）用于获取所有的版本列表 
        /// </summary>
        /// <param name="req"><see cref="GetAllVersionRequest"/></param>
        /// <returns><see cref="GetAllVersionResponse"/></returns>
        public Task<GetAllVersionResponse> GetAllVersion(GetAllVersionRequest req)
        {
            return InternalRequestAsync<GetAllVersionResponse>(req, "GetAllVersion");
        }

        /// <summary>
        /// 本接口（GetAllVersion）用于获取所有的版本列表 
        /// </summary>
        /// <param name="req"><see cref="GetAllVersionRequest"/></param>
        /// <returns><see cref="GetAllVersionResponse"/></returns>
        public GetAllVersionResponse GetAllVersionSync(GetAllVersionRequest req)
        {
            return InternalRequestAsync<GetAllVersionResponse>(req, "GetAllVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetCOSURL）用于获取固件存储在COS的URL 
        /// </summary>
        /// <param name="req"><see cref="GetCOSURLRequest"/></param>
        /// <returns><see cref="GetCOSURLResponse"/></returns>
        public Task<GetCOSURLResponse> GetCOSURL(GetCOSURLRequest req)
        {
            return InternalRequestAsync<GetCOSURLResponse>(req, "GetCOSURL");
        }

        /// <summary>
        /// 本接口（GetCOSURL）用于获取固件存储在COS的URL 
        /// </summary>
        /// <param name="req"><see cref="GetCOSURLRequest"/></param>
        /// <returns><see cref="GetCOSURLResponse"/></returns>
        public GetCOSURLResponse GetCOSURLSync(GetCOSURLRequest req)
        {
            return InternalRequestAsync<GetCOSURLResponse>(req, "GetCOSURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetUserResourceInfo）用于查询用户资源使用信息。
        /// </summary>
        /// <param name="req"><see cref="GetUserResourceInfoRequest"/></param>
        /// <returns><see cref="GetUserResourceInfoResponse"/></returns>
        public Task<GetUserResourceInfoResponse> GetUserResourceInfo(GetUserResourceInfoRequest req)
        {
            return InternalRequestAsync<GetUserResourceInfoResponse>(req, "GetUserResourceInfo");
        }

        /// <summary>
        /// 本接口（GetUserResourceInfo）用于查询用户资源使用信息。
        /// </summary>
        /// <param name="req"><see cref="GetUserResourceInfoRequest"/></param>
        /// <returns><see cref="GetUserResourceInfoResponse"/></returns>
        public GetUserResourceInfoResponse GetUserResourceInfoSync(GetUserResourceInfoRequest req)
        {
            return InternalRequestAsync<GetUserResourceInfoResponse>(req, "GetUserResourceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListFirmwares）用于获取固件列表
        /// </summary>
        /// <param name="req"><see cref="ListFirmwaresRequest"/></param>
        /// <returns><see cref="ListFirmwaresResponse"/></returns>
        public Task<ListFirmwaresResponse> ListFirmwares(ListFirmwaresRequest req)
        {
            return InternalRequestAsync<ListFirmwaresResponse>(req, "ListFirmwares");
        }

        /// <summary>
        /// 本接口（ListFirmwares）用于获取固件列表
        /// </summary>
        /// <param name="req"><see cref="ListFirmwaresRequest"/></param>
        /// <returns><see cref="ListFirmwaresResponse"/></returns>
        public ListFirmwaresResponse ListFirmwaresSync(ListFirmwaresRequest req)
        {
            return InternalRequestAsync<ListFirmwaresResponse>(req, "ListFirmwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListLog）用于查看日志信息 
        /// </summary>
        /// <param name="req"><see cref="ListLogRequest"/></param>
        /// <returns><see cref="ListLogResponse"/></returns>
        public Task<ListLogResponse> ListLog(ListLogRequest req)
        {
            return InternalRequestAsync<ListLogResponse>(req, "ListLog");
        }

        /// <summary>
        /// 本接口（ListLog）用于查看日志信息 
        /// </summary>
        /// <param name="req"><see cref="ListLogRequest"/></param>
        /// <returns><see cref="ListLogResponse"/></returns>
        public ListLogResponse ListLogSync(ListLogRequest req)
        {
            return InternalRequestAsync<ListLogResponse>(req, "ListLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取日志内容列表
        /// </summary>
        /// <param name="req"><see cref="ListLogPayloadRequest"/></param>
        /// <returns><see cref="ListLogPayloadResponse"/></returns>
        public Task<ListLogPayloadResponse> ListLogPayload(ListLogPayloadRequest req)
        {
            return InternalRequestAsync<ListLogPayloadResponse>(req, "ListLogPayload");
        }

        /// <summary>
        /// 获取日志内容列表
        /// </summary>
        /// <param name="req"><see cref="ListLogPayloadRequest"/></param>
        /// <returns><see cref="ListLogPayloadResponse"/></returns>
        public ListLogPayloadResponse ListLogPayloadSync(ListLogPayloadRequest req)
        {
            return InternalRequestAsync<ListLogPayloadResponse>(req, "ListLogPayload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备上报的日志
        /// </summary>
        /// <param name="req"><see cref="ListSDKLogRequest"/></param>
        /// <returns><see cref="ListSDKLogResponse"/></returns>
        public Task<ListSDKLogResponse> ListSDKLog(ListSDKLogRequest req)
        {
            return InternalRequestAsync<ListSDKLogResponse>(req, "ListSDKLog");
        }

        /// <summary>
        /// 获取设备上报的日志
        /// </summary>
        /// <param name="req"><see cref="ListSDKLogRequest"/></param>
        /// <returns><see cref="ListSDKLogResponse"/></returns>
        public ListSDKLogResponse ListSDKLogSync(ListSDKLogRequest req)
        {
            return InternalRequestAsync<ListSDKLogResponse>(req, "ListSDKLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListTopicRules）用于分页获取规则列表
        /// </summary>
        /// <param name="req"><see cref="ListTopicRulesRequest"/></param>
        /// <returns><see cref="ListTopicRulesResponse"/></returns>
        public Task<ListTopicRulesResponse> ListTopicRules(ListTopicRulesRequest req)
        {
            return InternalRequestAsync<ListTopicRulesResponse>(req, "ListTopicRules");
        }

        /// <summary>
        /// 本接口（ListTopicRules）用于分页获取规则列表
        /// </summary>
        /// <param name="req"><see cref="ListTopicRulesRequest"/></param>
        /// <returns><see cref="ListTopicRulesResponse"/></returns>
        public ListTopicRulesResponse ListTopicRulesSync(ListTopicRulesRequest req)
        {
            return InternalRequestAsync<ListTopicRulesResponse>(req, "ListTopicRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布广播消息
        /// </summary>
        /// <param name="req"><see cref="PublishBroadcastMessageRequest"/></param>
        /// <returns><see cref="PublishBroadcastMessageResponse"/></returns>
        public Task<PublishBroadcastMessageResponse> PublishBroadcastMessage(PublishBroadcastMessageRequest req)
        {
            return InternalRequestAsync<PublishBroadcastMessageResponse>(req, "PublishBroadcastMessage");
        }

        /// <summary>
        /// 发布广播消息
        /// </summary>
        /// <param name="req"><see cref="PublishBroadcastMessageRequest"/></param>
        /// <returns><see cref="PublishBroadcastMessageResponse"/></returns>
        public PublishBroadcastMessageResponse PublishBroadcastMessageSync(PublishBroadcastMessageRequest req)
        {
            return InternalRequestAsync<PublishBroadcastMessageResponse>(req, "PublishBroadcastMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（PublishMessage）用于向某个主题发消息。 
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public Task<PublishMessageResponse> PublishMessage(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage");
        }

        /// <summary>
        /// 本接口（PublishMessage）用于向某个主题发消息。 
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public PublishMessageResponse PublishMessageSync(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发布RRPC消息
        /// </summary>
        /// <param name="req"><see cref="PublishRRPCMessageRequest"/></param>
        /// <returns><see cref="PublishRRPCMessageResponse"/></returns>
        public Task<PublishRRPCMessageResponse> PublishRRPCMessage(PublishRRPCMessageRequest req)
        {
            return InternalRequestAsync<PublishRRPCMessageResponse>(req, "PublishRRPCMessage");
        }

        /// <summary>
        /// 发布RRPC消息
        /// </summary>
        /// <param name="req"><see cref="PublishRRPCMessageRequest"/></param>
        /// <returns><see cref="PublishRRPCMessageResponse"/></returns>
        public PublishRRPCMessageResponse PublishRRPCMessageSync(PublishRRPCMessageRequest req)
        {
            return InternalRequestAsync<PublishRRPCMessageResponse>(req, "PublishRRPCMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ReplaceTopicRule）用于修改替换规则 
        /// </summary>
        /// <param name="req"><see cref="ReplaceTopicRuleRequest"/></param>
        /// <returns><see cref="ReplaceTopicRuleResponse"/></returns>
        public Task<ReplaceTopicRuleResponse> ReplaceTopicRule(ReplaceTopicRuleRequest req)
        {
            return InternalRequestAsync<ReplaceTopicRuleResponse>(req, "ReplaceTopicRule");
        }

        /// <summary>
        /// 本接口（ReplaceTopicRule）用于修改替换规则 
        /// </summary>
        /// <param name="req"><see cref="ReplaceTopicRuleRequest"/></param>
        /// <returns><see cref="ReplaceTopicRuleResponse"/></returns>
        public ReplaceTopicRuleResponse ReplaceTopicRuleSync(ReplaceTopicRuleRequest req)
        {
            return InternalRequestAsync<ReplaceTopicRuleResponse>(req, "ReplaceTopicRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置设备的连接状态 
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceStateRequest"/></param>
        /// <returns><see cref="ResetDeviceStateResponse"/></returns>
        public Task<ResetDeviceStateResponse> ResetDeviceState(ResetDeviceStateRequest req)
        {
            return InternalRequestAsync<ResetDeviceStateResponse>(req, "ResetDeviceState");
        }

        /// <summary>
        /// 重置设备的连接状态 
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceStateRequest"/></param>
        /// <returns><see cref="ResetDeviceStateResponse"/></returns>
        public ResetDeviceStateResponse ResetDeviceStateSync(ResetDeviceStateRequest req)
        {
            return InternalRequestAsync<ResetDeviceStateResponse>(req, "ResetDeviceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重试设备升级任务
        /// </summary>
        /// <param name="req"><see cref="RetryDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="RetryDeviceFirmwareTaskResponse"/></returns>
        public Task<RetryDeviceFirmwareTaskResponse> RetryDeviceFirmwareTask(RetryDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<RetryDeviceFirmwareTaskResponse>(req, "RetryDeviceFirmwareTask");
        }

        /// <summary>
        /// 重试设备升级任务
        /// </summary>
        /// <param name="req"><see cref="RetryDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="RetryDeviceFirmwareTaskResponse"/></returns>
        public RetryDeviceFirmwareTaskResponse RetryDeviceFirmwareTaskSync(RetryDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<RetryDeviceFirmwareTaskResponse>(req, "RetryDeviceFirmwareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量设置产品禁用状态
        /// </summary>
        /// <param name="req"><see cref="SetProductsForbiddenStatusRequest"/></param>
        /// <returns><see cref="SetProductsForbiddenStatusResponse"/></returns>
        public Task<SetProductsForbiddenStatusResponse> SetProductsForbiddenStatus(SetProductsForbiddenStatusRequest req)
        {
            return InternalRequestAsync<SetProductsForbiddenStatusResponse>(req, "SetProductsForbiddenStatus");
        }

        /// <summary>
        /// 批量设置产品禁用状态
        /// </summary>
        /// <param name="req"><see cref="SetProductsForbiddenStatusRequest"/></param>
        /// <returns><see cref="SetProductsForbiddenStatusResponse"/></returns>
        public SetProductsForbiddenStatusResponse SetProductsForbiddenStatusSync(SetProductsForbiddenStatusRequest req)
        {
            return InternalRequestAsync<SetProductsForbiddenStatusResponse>(req, "SetProductsForbiddenStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UnbindDevices）用于网关设备批量解绑子设备 
        /// </summary>
        /// <param name="req"><see cref="UnbindDevicesRequest"/></param>
        /// <returns><see cref="UnbindDevicesResponse"/></returns>
        public Task<UnbindDevicesResponse> UnbindDevices(UnbindDevicesRequest req)
        {
            return InternalRequestAsync<UnbindDevicesResponse>(req, "UnbindDevices");
        }

        /// <summary>
        /// 本接口（UnbindDevices）用于网关设备批量解绑子设备 
        /// </summary>
        /// <param name="req"><see cref="UnbindDevicesRequest"/></param>
        /// <returns><see cref="UnbindDevicesResponse"/></returns>
        public UnbindDevicesResponse UnbindDevicesSync(UnbindDevicesRequest req)
        {
            return InternalRequestAsync<UnbindDevicesResponse>(req, "UnbindDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceAvailableStateRequest"/></param>
        /// <returns><see cref="UpdateDeviceAvailableStateResponse"/></returns>
        public Task<UpdateDeviceAvailableStateResponse> UpdateDeviceAvailableState(UpdateDeviceAvailableStateRequest req)
        {
            return InternalRequestAsync<UpdateDeviceAvailableStateResponse>(req, "UpdateDeviceAvailableState");
        }

        /// <summary>
        /// 启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceAvailableStateRequest"/></param>
        /// <returns><see cref="UpdateDeviceAvailableStateResponse"/></returns>
        public UpdateDeviceAvailableStateResponse UpdateDeviceAvailableStateSync(UpdateDeviceAvailableStateRequest req)
        {
            return InternalRequestAsync<UpdateDeviceAvailableStateResponse>(req, "UpdateDeviceAvailableState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置设备上报的日志级别  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public Task<UpdateDeviceLogLevelResponse> UpdateDeviceLogLevel(UpdateDeviceLogLevelRequest req)
        {
            return InternalRequestAsync<UpdateDeviceLogLevelResponse>(req, "UpdateDeviceLogLevel");
        }

        /// <summary>
        /// 设置设备上报的日志级别  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public UpdateDeviceLogLevelResponse UpdateDeviceLogLevelSync(UpdateDeviceLogLevelRequest req)
        {
            return InternalRequestAsync<UpdateDeviceLogLevelResponse>(req, "UpdateDeviceLogLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateDevicePSK）用于更新设备的PSK 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePSKRequest"/></param>
        /// <returns><see cref="UpdateDevicePSKResponse"/></returns>
        public Task<UpdateDevicePSKResponse> UpdateDevicePSK(UpdateDevicePSKRequest req)
        {
            return InternalRequestAsync<UpdateDevicePSKResponse>(req, "UpdateDevicePSK");
        }

        /// <summary>
        /// 本接口（UpdateDevicePSK）用于更新设备的PSK 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicePSKRequest"/></param>
        /// <returns><see cref="UpdateDevicePSKResponse"/></returns>
        public UpdateDevicePSKResponse UpdateDevicePSKSync(UpdateDevicePSKRequest req)
        {
            return InternalRequestAsync<UpdateDevicePSKResponse>(req, "UpdateDevicePSK")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateDeviceShadow）用于更新虚拟设备信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceShadowRequest"/></param>
        /// <returns><see cref="UpdateDeviceShadowResponse"/></returns>
        public Task<UpdateDeviceShadowResponse> UpdateDeviceShadow(UpdateDeviceShadowRequest req)
        {
            return InternalRequestAsync<UpdateDeviceShadowResponse>(req, "UpdateDeviceShadow");
        }

        /// <summary>
        /// 本接口（UpdateDeviceShadow）用于更新虚拟设备信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceShadowRequest"/></param>
        /// <returns><see cref="UpdateDeviceShadowResponse"/></returns>
        public UpdateDeviceShadowResponse UpdateDeviceShadowSync(UpdateDeviceShadowRequest req)
        {
            return InternalRequestAsync<UpdateDeviceShadowResponse>(req, "UpdateDeviceShadow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public Task<UpdateDevicesEnableStateResponse> UpdateDevicesEnableState(UpdateDevicesEnableStateRequest req)
        {
            return InternalRequestAsync<UpdateDevicesEnableStateResponse>(req, "UpdateDevicesEnableState");
        }

        /// <summary>
        /// 批量启用或者禁用设备 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public UpdateDevicesEnableStateResponse UpdateDevicesEnableStateSync(UpdateDevicesEnableStateRequest req)
        {
            return InternalRequestAsync<UpdateDevicesEnableStateResponse>(req, "UpdateDevicesEnableState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateOtaTask）当固件升级大任务处于没有在全部成功的状态时，可修改为取消状态，取消部分或全部设备的升级;或其它允许的可修改的状态
        /// </summary>
        /// <param name="req"><see cref="UpdateOtaTaskStatusRequest"/></param>
        /// <returns><see cref="UpdateOtaTaskStatusResponse"/></returns>
        public Task<UpdateOtaTaskStatusResponse> UpdateOtaTaskStatus(UpdateOtaTaskStatusRequest req)
        {
            return InternalRequestAsync<UpdateOtaTaskStatusResponse>(req, "UpdateOtaTaskStatus");
        }

        /// <summary>
        /// 本接口（UpdateOtaTask）当固件升级大任务处于没有在全部成功的状态时，可修改为取消状态，取消部分或全部设备的升级;或其它允许的可修改的状态
        /// </summary>
        /// <param name="req"><see cref="UpdateOtaTaskStatusRequest"/></param>
        /// <returns><see cref="UpdateOtaTaskStatusResponse"/></returns>
        public UpdateOtaTaskStatusResponse UpdateOtaTaskStatusSync(UpdateOtaTaskStatusRequest req)
        {
            return InternalRequestAsync<UpdateOtaTaskStatusResponse>(req, "UpdateOtaTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新私有CA证书
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public Task<UpdatePrivateCAResponse> UpdatePrivateCA(UpdatePrivateCARequest req)
        {
            return InternalRequestAsync<UpdatePrivateCAResponse>(req, "UpdatePrivateCA");
        }

        /// <summary>
        /// 更新私有CA证书
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public UpdatePrivateCAResponse UpdatePrivateCASync(UpdatePrivateCARequest req)
        {
            return InternalRequestAsync<UpdatePrivateCAResponse>(req, "UpdatePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新产品动态注册的配置 
        /// </summary>
        /// <param name="req"><see cref="UpdateProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="UpdateProductDynamicRegisterResponse"/></returns>
        public Task<UpdateProductDynamicRegisterResponse> UpdateProductDynamicRegister(UpdateProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<UpdateProductDynamicRegisterResponse>(req, "UpdateProductDynamicRegister");
        }

        /// <summary>
        /// 更新产品动态注册的配置 
        /// </summary>
        /// <param name="req"><see cref="UpdateProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="UpdateProductDynamicRegisterResponse"/></returns>
        public UpdateProductDynamicRegisterResponse UpdateProductDynamicRegisterSync(UpdateProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<UpdateProductDynamicRegisterResponse>(req, "UpdateProductDynamicRegister")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新产品的私有CA
        /// </summary>
        /// <param name="req"><see cref="UpdateProductPrivateCARequest"/></param>
        /// <returns><see cref="UpdateProductPrivateCAResponse"/></returns>
        public Task<UpdateProductPrivateCAResponse> UpdateProductPrivateCA(UpdateProductPrivateCARequest req)
        {
            return InternalRequestAsync<UpdateProductPrivateCAResponse>(req, "UpdateProductPrivateCA");
        }

        /// <summary>
        /// 更新产品的私有CA
        /// </summary>
        /// <param name="req"><see cref="UpdateProductPrivateCARequest"/></param>
        /// <returns><see cref="UpdateProductPrivateCAResponse"/></returns>
        public UpdateProductPrivateCAResponse UpdateProductPrivateCASync(UpdateProductPrivateCARequest req)
        {
            return InternalRequestAsync<UpdateProductPrivateCAResponse>(req, "UpdateProductPrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息
        /// </summary>
        /// <param name="req"><see cref="UpdateTopicPolicyRequest"/></param>
        /// <returns><see cref="UpdateTopicPolicyResponse"/></returns>
        public Task<UpdateTopicPolicyResponse> UpdateTopicPolicy(UpdateTopicPolicyRequest req)
        {
            return InternalRequestAsync<UpdateTopicPolicyResponse>(req, "UpdateTopicPolicy");
        }

        /// <summary>
        /// 本接口（UpdateTopicPolicy）用于更新Topic信息
        /// </summary>
        /// <param name="req"><see cref="UpdateTopicPolicyRequest"/></param>
        /// <returns><see cref="UpdateTopicPolicyResponse"/></returns>
        public UpdateTopicPolicyResponse UpdateTopicPolicySync(UpdateTopicPolicyRequest req)
        {
            return InternalRequestAsync<UpdateTopicPolicyResponse>(req, "UpdateTopicPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UploadFirmware）用于上传设备固件信息
        /// </summary>
        /// <param name="req"><see cref="UploadFirmwareRequest"/></param>
        /// <returns><see cref="UploadFirmwareResponse"/></returns>
        public Task<UploadFirmwareResponse> UploadFirmware(UploadFirmwareRequest req)
        {
            return InternalRequestAsync<UploadFirmwareResponse>(req, "UploadFirmware");
        }

        /// <summary>
        /// 本接口（UploadFirmware）用于上传设备固件信息
        /// </summary>
        /// <param name="req"><see cref="UploadFirmwareRequest"/></param>
        /// <returns><see cref="UploadFirmwareResponse"/></returns>
        public UploadFirmwareResponse UploadFirmwareSync(UploadFirmwareRequest req)
        {
            return InternalRequestAsync<UploadFirmwareResponse>(req, "UploadFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
