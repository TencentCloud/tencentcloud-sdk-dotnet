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
       private const string sdkVersion = "SDK_NET_3.0.958";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotvideoClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 申请AI模型
        /// </summary>
        /// <param name="req"><see cref="ApplyAIModelRequest"/></param>
        /// <returns><see cref="ApplyAIModelResponse"/></returns>
        public Task<ApplyAIModelResponse> ApplyAIModel(ApplyAIModelRequest req)
        {
            return InternalRequestAsync<ApplyAIModelResponse>(req, "ApplyAIModel");
        }

        /// <summary>
        /// 申请AI模型
        /// </summary>
        /// <param name="req"><see cref="ApplyAIModelRequest"/></param>
        /// <returns><see cref="ApplyAIModelResponse"/></returns>
        public ApplyAIModelResponse ApplyAIModelSync(ApplyAIModelRequest req)
        {
            return InternalRequestAsync<ApplyAIModelResponse>(req, "ApplyAIModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// 绑定云存用户
        /// </summary>
        /// <param name="req"><see cref="BindCloudStorageUserRequest"/></param>
        /// <returns><see cref="BindCloudStorageUserResponse"/></returns>
        public Task<BindCloudStorageUserResponse> BindCloudStorageUser(BindCloudStorageUserRequest req)
        {
            return InternalRequestAsync<BindCloudStorageUserResponse>(req, "BindCloudStorageUser");
        }

        /// <summary>
        /// 绑定云存用户
        /// </summary>
        /// <param name="req"><see cref="BindCloudStorageUserRequest"/></param>
        /// <returns><see cref="BindCloudStorageUserResponse"/></returns>
        public BindCloudStorageUserResponse BindCloudStorageUserSync(BindCloudStorageUserRequest req)
        {
            return InternalRequestAsync<BindCloudStorageUserResponse>(req, "BindCloudStorageUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消AI模型申请
        /// </summary>
        /// <param name="req"><see cref="CancelAIModelApplicationRequest"/></param>
        /// <returns><see cref="CancelAIModelApplicationResponse"/></returns>
        public Task<CancelAIModelApplicationResponse> CancelAIModelApplication(CancelAIModelApplicationRequest req)
        {
            return InternalRequestAsync<CancelAIModelApplicationResponse>(req, "CancelAIModelApplication");
        }

        /// <summary>
        /// 取消AI模型申请
        /// </summary>
        /// <param name="req"><see cref="CancelAIModelApplicationRequest"/></param>
        /// <returns><see cref="CancelAIModelApplicationResponse"/></returns>
        public CancelAIModelApplicationResponse CancelAIModelApplicationSync(CancelAIModelApplicationRequest req)
        {
            return InternalRequestAsync<CancelAIModelApplicationResponse>(req, "CancelAIModelApplication")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于取消设备升级任务
        /// </summary>
        /// <param name="req"><see cref="CancelDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="CancelDeviceFirmwareTaskResponse"/></returns>
        public Task<CancelDeviceFirmwareTaskResponse> CancelDeviceFirmwareTask(CancelDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<CancelDeviceFirmwareTaskResponse>(req, "CancelDeviceFirmwareTask");
        }

        /// <summary>
        /// 本接口用于取消设备升级任务
        /// </summary>
        /// <param name="req"><see cref="CancelDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="CancelDeviceFirmwareTaskResponse"/></returns>
        public CancelDeviceFirmwareTaskResponse CancelDeviceFirmwareTaskSync(CancelDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<CancelDeviceFirmwareTaskResponse>(req, "CancelDeviceFirmwareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断是否开启转发的权限
        /// </summary>
        /// <param name="req"><see cref="CheckForwardAuthRequest"/></param>
        /// <returns><see cref="CheckForwardAuthResponse"/></returns>
        public Task<CheckForwardAuthResponse> CheckForwardAuth(CheckForwardAuthRequest req)
        {
            return InternalRequestAsync<CheckForwardAuthResponse>(req, "CheckForwardAuth");
        }

        /// <summary>
        /// 判断是否开启转发的权限
        /// </summary>
        /// <param name="req"><see cref="CheckForwardAuthRequest"/></param>
        /// <returns><see cref="CheckForwardAuthResponse"/></returns>
        public CheckForwardAuthResponse CheckForwardAuthSync(CheckForwardAuthRequest req)
        {
            return InternalRequestAsync<CheckForwardAuthResponse>(req, "CheckForwardAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，设置控制设备的属性数据。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceDataRequest"/></param>
        /// <returns><see cref="ControlDeviceDataResponse"/></returns>
        public Task<ControlDeviceDataResponse> ControlDeviceData(ControlDeviceDataRequest req)
        {
            return InternalRequestAsync<ControlDeviceDataResponse>(req, "ControlDeviceData");
        }

        /// <summary>
        /// 根据设备产品ID、设备名称，设置控制设备的属性数据。
        /// </summary>
        /// <param name="req"><see cref="ControlDeviceDataRequest"/></param>
        /// <returns><see cref="ControlDeviceDataResponse"/></returns>
        public ControlDeviceDataResponse ControlDeviceDataSync(ControlDeviceDataRequest req)
        {
            return InternalRequestAsync<ControlDeviceDataResponse>(req, "ControlDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起AI推理请求
        /// </summary>
        /// <param name="req"><see cref="CreateAIDetectionRequest"/></param>
        /// <returns><see cref="CreateAIDetectionResponse"/></returns>
        public Task<CreateAIDetectionResponse> CreateAIDetection(CreateAIDetectionRequest req)
        {
            return InternalRequestAsync<CreateAIDetectionResponse>(req, "CreateAIDetection");
        }

        /// <summary>
        /// 发起AI推理请求
        /// </summary>
        /// <param name="req"><see cref="CreateAIDetectionRequest"/></param>
        /// <returns><see cref="CreateAIDetectionResponse"/></returns>
        public CreateAIDetectionResponse CreateAIDetectionSync(CreateAIDetectionRequest req)
        {
            return InternalRequestAsync<CreateAIDetectionResponse>(req, "CreateAIDetection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建批次
        /// </summary>
        /// <param name="req"><see cref="CreateBatchRequest"/></param>
        /// <returns><see cref="CreateBatchResponse"/></returns>
        public Task<CreateBatchResponse> CreateBatch(CreateBatchRequest req)
        {
            return InternalRequestAsync<CreateBatchResponse>(req, "CreateBatch");
        }

        /// <summary>
        /// 创建批次
        /// </summary>
        /// <param name="req"><see cref="CreateBatchRequest"/></param>
        /// <returns><see cref="CreateBatchResponse"/></returns>
        public CreateBatchResponse CreateBatchSync(CreateBatchRequest req)
        {
            return InternalRequestAsync<CreateBatchResponse>(req, "CreateBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建COS上传密钥
        /// </summary>
        /// <param name="req"><see cref="CreateCOSCredentialsRequest"/></param>
        /// <returns><see cref="CreateCOSCredentialsResponse"/></returns>
        public Task<CreateCOSCredentialsResponse> CreateCOSCredentials(CreateCOSCredentialsRequest req)
        {
            return InternalRequestAsync<CreateCOSCredentialsResponse>(req, "CreateCOSCredentials");
        }

        /// <summary>
        /// 创建COS上传密钥
        /// </summary>
        /// <param name="req"><see cref="CreateCOSCredentialsRequest"/></param>
        /// <returns><see cref="CreateCOSCredentialsResponse"/></returns>
        public CreateCOSCredentialsResponse CreateCOSCredentialsSync(CreateCOSCredentialsRequest req)
        {
            return InternalRequestAsync<CreateCOSCredentialsResponse>(req, "CreateCOSCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudStorageRequest"/></param>
        /// <returns><see cref="CreateCloudStorageResponse"/></returns>
        public Task<CreateCloudStorageResponse> CreateCloudStorage(CreateCloudStorageRequest req)
        {
            return InternalRequestAsync<CreateCloudStorageResponse>(req, "CreateCloudStorage");
        }

        /// <summary>
        /// 开通云存服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudStorageRequest"/></param>
        /// <returns><see cref="CreateCloudStorageResponse"/></returns>
        public CreateCloudStorageResponse CreateCloudStorageSync(CreateCloudStorageRequest req)
        {
            return InternalRequestAsync<CreateCloudStorageResponse>(req, "CreateCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据转发
        /// </summary>
        /// <param name="req"><see cref="CreateDataForwardRequest"/></param>
        /// <returns><see cref="CreateDataForwardResponse"/></returns>
        public Task<CreateDataForwardResponse> CreateDataForward(CreateDataForwardRequest req)
        {
            return InternalRequestAsync<CreateDataForwardResponse>(req, "CreateDataForward");
        }

        /// <summary>
        /// 创建数据转发
        /// </summary>
        /// <param name="req"><see cref="CreateDataForwardRequest"/></param>
        /// <returns><see cref="CreateDataForwardResponse"/></returns>
        public CreateDataForwardResponse CreateDataForwardSync(CreateDataForwardRequest req)
        {
            return InternalRequestAsync<CreateDataForwardResponse>(req, "CreateDataForward")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateForwardRuleRequest"/></param>
        /// <returns><see cref="CreateForwardRuleResponse"/></returns>
        public Task<CreateForwardRuleResponse> CreateForwardRule(CreateForwardRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardRuleResponse>(req, "CreateForwardRule");
        }

        /// <summary>
        /// 创建转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateForwardRuleRequest"/></param>
        /// <returns><see cref="CreateForwardRuleResponse"/></returns>
        public CreateForwardRuleResponse CreateForwardRuleSync(CreateForwardRuleRequest req)
        {
            return InternalRequestAsync<CreateForwardRuleResponse>(req, "CreateForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建产品
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct");
        }

        /// <summary>
        /// 创建产品
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
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteFirmware）用于删除固件 
        /// </summary>
        /// <param name="req"><see cref="DeleteFirmwareRequest"/></param>
        /// <returns><see cref="DeleteFirmwareResponse"/></returns>
        public Task<DeleteFirmwareResponse> DeleteFirmware(DeleteFirmwareRequest req)
        {
            return InternalRequestAsync<DeleteFirmwareResponse>(req, "DeleteFirmware");
        }

        /// <summary>
        /// 本接口（DeleteFirmware）用于删除固件 
        /// </summary>
        /// <param name="req"><see cref="DeleteFirmwareRequest"/></param>
        /// <returns><see cref="DeleteFirmwareResponse"/></returns>
        public DeleteFirmwareResponse DeleteFirmwareSync(DeleteFirmwareRequest req)
        {
            return InternalRequestAsync<DeleteFirmwareResponse>(req, "DeleteFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardRuleResponse"/></returns>
        public Task<DeleteForwardRuleResponse> DeleteForwardRule(DeleteForwardRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardRuleResponse>(req, "DeleteForwardRule");
        }

        /// <summary>
        /// 删除转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteForwardRuleRequest"/></param>
        /// <returns><see cref="DeleteForwardRuleResponse"/></returns>
        public DeleteForwardRuleResponse DeleteForwardRuleSync(DeleteForwardRuleRequest req)
        {
            return InternalRequestAsync<DeleteForwardRuleResponse>(req, "DeleteForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct");
        }

        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户AI模型申请记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelApplicationsRequest"/></param>
        /// <returns><see cref="DescribeAIModelApplicationsResponse"/></returns>
        public Task<DescribeAIModelApplicationsResponse> DescribeAIModelApplications(DescribeAIModelApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeAIModelApplicationsResponse>(req, "DescribeAIModelApplications");
        }

        /// <summary>
        /// 用户AI模型申请记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelApplicationsRequest"/></param>
        /// <returns><see cref="DescribeAIModelApplicationsResponse"/></returns>
        public DescribeAIModelApplicationsResponse DescribeAIModelApplicationsSync(DescribeAIModelApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeAIModelApplicationsResponse>(req, "DescribeAIModelApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看AI推理结果推送配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelChannelRequest"/></param>
        /// <returns><see cref="DescribeAIModelChannelResponse"/></returns>
        public Task<DescribeAIModelChannelResponse> DescribeAIModelChannel(DescribeAIModelChannelRequest req)
        {
            return InternalRequestAsync<DescribeAIModelChannelResponse>(req, "DescribeAIModelChannel");
        }

        /// <summary>
        /// 查看AI推理结果推送配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelChannelRequest"/></param>
        /// <returns><see cref="DescribeAIModelChannelResponse"/></returns>
        public DescribeAIModelChannelResponse DescribeAIModelChannelSync(DescribeAIModelChannelRequest req)
        {
            return InternalRequestAsync<DescribeAIModelChannelResponse>(req, "DescribeAIModelChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看AI模型资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelUsageRequest"/></param>
        /// <returns><see cref="DescribeAIModelUsageResponse"/></returns>
        public Task<DescribeAIModelUsageResponse> DescribeAIModelUsage(DescribeAIModelUsageRequest req)
        {
            return InternalRequestAsync<DescribeAIModelUsageResponse>(req, "DescribeAIModelUsage");
        }

        /// <summary>
        /// 查看AI模型资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelUsageRequest"/></param>
        /// <returns><see cref="DescribeAIModelUsageResponse"/></returns>
        public DescribeAIModelUsageResponse DescribeAIModelUsageSync(DescribeAIModelUsageRequest req)
        {
            return InternalRequestAsync<DescribeAIModelUsageResponse>(req, "DescribeAIModelUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取AI模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelsRequest"/></param>
        /// <returns><see cref="DescribeAIModelsResponse"/></returns>
        public Task<DescribeAIModelsResponse> DescribeAIModels(DescribeAIModelsRequest req)
        {
            return InternalRequestAsync<DescribeAIModelsResponse>(req, "DescribeAIModels");
        }

        /// <summary>
        /// 拉取AI模型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIModelsRequest"/></param>
        /// <returns><see cref="DescribeAIModelsResponse"/></returns>
        public DescribeAIModelsResponse DescribeAIModelsSync(DescribeAIModelsRequest req)
        {
            return InternalRequestAsync<DescribeAIModelsResponse>(req, "DescribeAIModels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账户余额
        /// </summary>
        /// <param name="req"><see cref="DescribeBalanceRequest"/></param>
        /// <returns><see cref="DescribeBalanceResponse"/></returns>
        public Task<DescribeBalanceResponse> DescribeBalance(DescribeBalanceRequest req)
        {
            return InternalRequestAsync<DescribeBalanceResponse>(req, "DescribeBalance");
        }

        /// <summary>
        /// 查询账户余额
        /// </summary>
        /// <param name="req"><see cref="DescribeBalanceRequest"/></param>
        /// <returns><see cref="DescribeBalanceResponse"/></returns>
        public DescribeBalanceResponse DescribeBalanceSync(DescribeBalanceRequest req)
        {
            return InternalRequestAsync<DescribeBalanceResponse>(req, "DescribeBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取账户流水
        /// </summary>
        /// <param name="req"><see cref="DescribeBalanceTransactionsRequest"/></param>
        /// <returns><see cref="DescribeBalanceTransactionsResponse"/></returns>
        public Task<DescribeBalanceTransactionsResponse> DescribeBalanceTransactions(DescribeBalanceTransactionsRequest req)
        {
            return InternalRequestAsync<DescribeBalanceTransactionsResponse>(req, "DescribeBalanceTransactions");
        }

        /// <summary>
        /// 拉取账户流水
        /// </summary>
        /// <param name="req"><see cref="DescribeBalanceTransactionsRequest"/></param>
        /// <returns><see cref="DescribeBalanceTransactionsResponse"/></returns>
        public DescribeBalanceTransactionsResponse DescribeBalanceTransactionsSync(DescribeBalanceTransactionsRequest req)
        {
            return InternalRequestAsync<DescribeBalanceTransactionsResponse>(req, "DescribeBalanceTransactions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取批次详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchRequest"/></param>
        /// <returns><see cref="DescribeBatchResponse"/></returns>
        public Task<DescribeBatchResponse> DescribeBatch(DescribeBatchRequest req)
        {
            return InternalRequestAsync<DescribeBatchResponse>(req, "DescribeBatch");
        }

        /// <summary>
        /// 获取批次详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchRequest"/></param>
        /// <returns><see cref="DescribeBatchResponse"/></returns>
        public DescribeBatchResponse DescribeBatchSync(DescribeBatchRequest req)
        {
            return InternalRequestAsync<DescribeBatchResponse>(req, "DescribeBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchsRequest"/></param>
        /// <returns><see cref="DescribeBatchsResponse"/></returns>
        public Task<DescribeBatchsResponse> DescribeBatchs(DescribeBatchsRequest req)
        {
            return InternalRequestAsync<DescribeBatchsResponse>(req, "DescribeBatchs");
        }

        /// <summary>
        /// 获取批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchsRequest"/></param>
        /// <returns><see cref="DescribeBatchsResponse"/></returns>
        public DescribeBatchsResponse DescribeBatchsSync(DescribeBatchsRequest req)
        {
            return InternalRequestAsync<DescribeBatchsResponse>(req, "DescribeBatchs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Category详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCategoryRequest"/></param>
        /// <returns><see cref="DescribeCategoryResponse"/></returns>
        public Task<DescribeCategoryResponse> DescribeCategory(DescribeCategoryRequest req)
        {
            return InternalRequestAsync<DescribeCategoryResponse>(req, "DescribeCategory");
        }

        /// <summary>
        /// 获取Category详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCategoryRequest"/></param>
        /// <returns><see cref="DescribeCategoryResponse"/></returns>
        public DescribeCategoryResponse DescribeCategorySync(DescribeCategoryRequest req)
        {
            return InternalRequestAsync<DescribeCategoryResponse>(req, "DescribeCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备云存服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageResponse"/></returns>
        public Task<DescribeCloudStorageResponse> DescribeCloudStorage(DescribeCloudStorageRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageResponse>(req, "DescribeCloudStorage");
        }

        /// <summary>
        /// 获取设备云存服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageResponse"/></returns>
        public DescribeCloudStorageResponse DescribeCloudStorageSync(DescribeCloudStorageRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageResponse>(req, "DescribeCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取具有云存的日期
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageDateRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageDateResponse"/></returns>
        public Task<DescribeCloudStorageDateResponse> DescribeCloudStorageDate(DescribeCloudStorageDateRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageDateResponse>(req, "DescribeCloudStorageDate");
        }

        /// <summary>
        /// 获取具有云存的日期
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageDateRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageDateResponse"/></returns>
        public DescribeCloudStorageDateResponse DescribeCloudStorageDateSync(DescribeCloudStorageDateRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageDateResponse>(req, "DescribeCloudStorageDate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云存事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageEventsRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageEventsResponse"/></returns>
        public Task<DescribeCloudStorageEventsResponse> DescribeCloudStorageEvents(DescribeCloudStorageEventsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageEventsResponse>(req, "DescribeCloudStorageEvents");
        }

        /// <summary>
        /// 拉取云存事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageEventsRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageEventsResponse"/></returns>
        public DescribeCloudStorageEventsResponse DescribeCloudStorageEventsSync(DescribeCloudStorageEventsRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageEventsResponse>(req, "DescribeCloudStorageEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageThumbnailRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageThumbnailResponse"/></returns>
        public Task<DescribeCloudStorageThumbnailResponse> DescribeCloudStorageThumbnail(DescribeCloudStorageThumbnailRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageThumbnailResponse>(req, "DescribeCloudStorageThumbnail");
        }

        /// <summary>
        /// 拉取云存事件缩略图
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageThumbnailRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageThumbnailResponse"/></returns>
        public DescribeCloudStorageThumbnailResponse DescribeCloudStorageThumbnailSync(DescribeCloudStorageThumbnailRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageThumbnailResponse>(req, "DescribeCloudStorageThumbnail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取某一天云存时间轴
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageTimeRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageTimeResponse"/></returns>
        public Task<DescribeCloudStorageTimeResponse> DescribeCloudStorageTime(DescribeCloudStorageTimeRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageTimeResponse>(req, "DescribeCloudStorageTime");
        }

        /// <summary>
        /// 获取某一天云存时间轴
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageTimeRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageTimeResponse"/></returns>
        public DescribeCloudStorageTimeResponse DescribeCloudStorageTimeSync(DescribeCloudStorageTimeRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageTimeResponse>(req, "DescribeCloudStorageTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云存用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageUsersRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageUsersResponse"/></returns>
        public Task<DescribeCloudStorageUsersResponse> DescribeCloudStorageUsers(DescribeCloudStorageUsersRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageUsersResponse>(req, "DescribeCloudStorageUsers");
        }

        /// <summary>
        /// 拉取云存用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudStorageUsersRequest"/></param>
        /// <returns><see cref="DescribeCloudStorageUsersResponse"/></returns>
        public DescribeCloudStorageUsersResponse DescribeCloudStorageUsersSync(DescribeCloudStorageUsersRequest req)
        {
            return InternalRequestAsync<DescribeCloudStorageUsersResponse>(req, "DescribeCloudStorageUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据转发列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataForwardListRequest"/></param>
        /// <returns><see cref="DescribeDataForwardListResponse"/></returns>
        public Task<DescribeDataForwardListResponse> DescribeDataForwardList(DescribeDataForwardListRequest req)
        {
            return InternalRequestAsync<DescribeDataForwardListResponse>(req, "DescribeDataForwardList");
        }

        /// <summary>
        /// 获取数据转发列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataForwardListRequest"/></param>
        /// <returns><see cref="DescribeDataForwardListResponse"/></returns>
        public DescribeDataForwardListResponse DescribeDataForwardListSync(DescribeDataForwardListRequest req)
        {
            return InternalRequestAsync<DescribeDataForwardListResponse>(req, "DescribeDataForwardList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看设备详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice");
        }

        /// <summary>
        /// 查看设备详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为用户提供获取动作历史的能力。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceActionHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceActionHistoryResponse"/></returns>
        public Task<DescribeDeviceActionHistoryResponse> DescribeDeviceActionHistory(DescribeDeviceActionHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceActionHistoryResponse>(req, "DescribeDeviceActionHistory");
        }

        /// <summary>
        /// 为用户提供获取动作历史的能力。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceActionHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceActionHistoryResponse"/></returns>
        public DescribeDeviceActionHistoryResponse DescribeDeviceActionHistorySync(DescribeDeviceActionHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceActionHistoryResponse>(req, "DescribeDeviceActionHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备在指定时间范围内的通讯日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCommLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceCommLogResponse"/></returns>
        public Task<DescribeDeviceCommLogResponse> DescribeDeviceCommLog(DescribeDeviceCommLogRequest req)
        {
            return InternalRequestAsync<DescribeDeviceCommLogResponse>(req, "DescribeDeviceCommLog");
        }

        /// <summary>
        /// 获取设备在指定时间范围内的通讯日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceCommLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceCommLogResponse"/></returns>
        public DescribeDeviceCommLogResponse DescribeDeviceCommLogSync(DescribeDeviceCommLogRequest req)
        {
            return InternalRequestAsync<DescribeDeviceCommLogResponse>(req, "DescribeDeviceCommLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备属性数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataResponse"/></returns>
        public Task<DescribeDeviceDataResponse> DescribeDeviceData(DescribeDeviceDataRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataResponse>(req, "DescribeDeviceData");
        }

        /// <summary>
        /// 获取设备属性数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataResponse"/></returns>
        public DescribeDeviceDataResponse DescribeDeviceDataSync(DescribeDeviceDataRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataResponse>(req, "DescribeDeviceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备在指定时间范围内上报的历史数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataHistoryResponse"/></returns>
        public Task<DescribeDeviceDataHistoryResponse> DescribeDeviceDataHistory(DescribeDeviceDataHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataHistoryResponse>(req, "DescribeDeviceDataHistory");
        }

        /// <summary>
        /// 获取设备在指定时间范围内上报的历史数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceDataHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceDataHistoryResponse"/></returns>
        public DescribeDeviceDataHistoryResponse DescribeDeviceDataHistorySync(DescribeDeviceDataHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceDataHistoryResponse>(req, "DescribeDeviceDataHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备的历史事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceEventHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventHistoryResponse"/></returns>
        public Task<DescribeDeviceEventHistoryResponse> DescribeDeviceEventHistory(DescribeDeviceEventHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceEventHistoryResponse>(req, "DescribeDeviceEventHistory");
        }

        /// <summary>
        /// 获取设备的历史事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceEventHistoryRequest"/></param>
        /// <returns><see cref="DescribeDeviceEventHistoryResponse"/></returns>
        public DescribeDeviceEventHistoryResponse DescribeDeviceEventHistorySync(DescribeDeviceEventHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDeviceEventHistoryResponse>(req, "DescribeDeviceEventHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备上下线日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusLogResponse"/></returns>
        public Task<DescribeDeviceStatusLogResponse> DescribeDeviceStatusLog(DescribeDeviceStatusLogRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStatusLogResponse>(req, "DescribeDeviceStatusLog");
        }

        /// <summary>
        /// 获取设备上下线日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceStatusLogRequest"/></param>
        /// <returns><see cref="DescribeDeviceStatusLogResponse"/></returns>
        public DescribeDeviceStatusLogResponse DescribeDeviceStatusLogSync(DescribeDeviceStatusLogRequest req)
        {
            return InternalRequestAsync<DescribeDeviceStatusLogResponse>(req, "DescribeDeviceStatusLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeFirmware）用于查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public Task<DescribeFirmwareResponse> DescribeFirmware(DescribeFirmwareRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareResponse>(req, "DescribeFirmware");
        }

        /// <summary>
        /// 本接口（DescribeFirmware）用于查询固件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareRequest"/></param>
        /// <returns><see cref="DescribeFirmwareResponse"/></returns>
        public DescribeFirmwareResponse DescribeFirmwareSync(DescribeFirmwareRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareResponse>(req, "DescribeFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口查询固件升级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public Task<DescribeFirmwareTaskResponse> DescribeFirmwareTask(DescribeFirmwareTaskRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskResponse>(req, "DescribeFirmwareTask");
        }

        /// <summary>
        /// 此接口查询固件升级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskResponse"/></returns>
        public DescribeFirmwareTaskResponse DescribeFirmwareTaskSync(DescribeFirmwareTaskRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskResponse>(req, "DescribeFirmwareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询固件升级任务的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDevicesRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDevicesResponse"/></returns>
        public Task<DescribeFirmwareTaskDevicesResponse> DescribeFirmwareTaskDevices(DescribeFirmwareTaskDevicesRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDevicesResponse>(req, "DescribeFirmwareTaskDevices");
        }

        /// <summary>
        /// 本接口用于查询固件升级任务的设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDevicesRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDevicesResponse"/></returns>
        public DescribeFirmwareTaskDevicesResponse DescribeFirmwareTaskDevicesSync(DescribeFirmwareTaskDevicesRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDevicesResponse>(req, "DescribeFirmwareTaskDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询固件升级任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDistributionRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDistributionResponse"/></returns>
        public Task<DescribeFirmwareTaskDistributionResponse> DescribeFirmwareTaskDistribution(DescribeFirmwareTaskDistributionRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDistributionResponse>(req, "DescribeFirmwareTaskDistribution");
        }

        /// <summary>
        /// 本接口用于查询固件升级任务状态分布
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskDistributionRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskDistributionResponse"/></returns>
        public DescribeFirmwareTaskDistributionResponse DescribeFirmwareTaskDistributionSync(DescribeFirmwareTaskDistributionRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskDistributionResponse>(req, "DescribeFirmwareTaskDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询固件升级任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskStatisticsResponse"/></returns>
        public Task<DescribeFirmwareTaskStatisticsResponse> DescribeFirmwareTaskStatistics(DescribeFirmwareTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskStatisticsResponse>(req, "DescribeFirmwareTaskStatistics");
        }

        /// <summary>
        /// 本接口用于查询固件升级任务统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTaskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTaskStatisticsResponse"/></returns>
        public DescribeFirmwareTaskStatisticsResponse DescribeFirmwareTaskStatisticsSync(DescribeFirmwareTaskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTaskStatisticsResponse>(req, "DescribeFirmwareTaskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTasksRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTasksResponse"/></returns>
        public Task<DescribeFirmwareTasksResponse> DescribeFirmwareTasks(DescribeFirmwareTasksRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTasksResponse>(req, "DescribeFirmwareTasks");
        }

        /// <summary>
        /// 本接口用于查询固件升级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFirmwareTasksRequest"/></param>
        /// <returns><see cref="DescribeFirmwareTasksResponse"/></returns>
        public DescribeFirmwareTasksResponse DescribeFirmwareTasksSync(DescribeFirmwareTasksRequest req)
        {
            return InternalRequestAsync<DescribeFirmwareTasksResponse>(req, "DescribeFirmwareTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleResponse"/></returns>
        public Task<DescribeForwardRuleResponse> DescribeForwardRule(DescribeForwardRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardRuleResponse>(req, "DescribeForwardRule");
        }

        /// <summary>
        /// 获取产品转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeForwardRuleRequest"/></param>
        /// <returns><see cref="DescribeForwardRuleResponse"/></returns>
        public DescribeForwardRuleResponse DescribeForwardRuleSync(DescribeForwardRuleRequest req)
        {
            return InternalRequestAsync<DescribeForwardRuleResponse>(req, "DescribeForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询产品配置的数据模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDefinitionRequest"/></param>
        /// <returns><see cref="DescribeModelDefinitionResponse"/></returns>
        public Task<DescribeModelDefinitionResponse> DescribeModelDefinition(DescribeModelDefinitionRequest req)
        {
            return InternalRequestAsync<DescribeModelDefinitionResponse>(req, "DescribeModelDefinition");
        }

        /// <summary>
        /// 查询产品配置的数据模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeModelDefinitionRequest"/></param>
        /// <returns><see cref="DescribeModelDefinitionResponse"/></returns>
        public DescribeModelDefinitionResponse DescribeModelDefinitionSync(DescribeModelDefinitionRequest req)
        {
            return InternalRequestAsync<DescribeModelDefinitionResponse>(req, "DescribeModelDefinition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public Task<DescribeProductResponse> DescribeProduct(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct");
        }

        /// <summary>
        /// 获取产品详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public DescribeProductResponse DescribeProductSync(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品动态注册详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="DescribeProductDynamicRegisterResponse"/></returns>
        public Task<DescribeProductDynamicRegisterResponse> DescribeProductDynamicRegister(DescribeProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<DescribeProductDynamicRegisterResponse>(req, "DescribeProductDynamicRegister");
        }

        /// <summary>
        /// 获取产品动态注册详情
        /// </summary>
        /// <param name="req"><see cref="DescribeProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="DescribeProductDynamicRegisterResponse"/></returns>
        public DescribeProductDynamicRegisterResponse DescribeProductDynamicRegisterSync(DescribeProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<DescribeProductDynamicRegisterResponse>(req, "DescribeProductDynamicRegister")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts");
        }

        /// <summary>
        /// 获取产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备sdk日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSDKLogRequest"/></param>
        /// <returns><see cref="DescribeSDKLogResponse"/></returns>
        public Task<DescribeSDKLogResponse> DescribeSDKLog(DescribeSDKLogRequest req)
        {
            return InternalRequestAsync<DescribeSDKLogResponse>(req, "DescribeSDKLog");
        }

        /// <summary>
        /// 获取设备sdk日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSDKLogRequest"/></param>
        /// <returns><see cref="DescribeSDKLogResponse"/></returns>
        public DescribeSDKLogResponse DescribeSDKLogSync(DescribeSDKLogRequest req)
        {
            return InternalRequestAsync<DescribeSDKLogResponse>(req, "DescribeSDKLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于编辑固件信息
        /// </summary>
        /// <param name="req"><see cref="EditFirmwareRequest"/></param>
        /// <returns><see cref="EditFirmwareResponse"/></returns>
        public Task<EditFirmwareResponse> EditFirmware(EditFirmwareRequest req)
        {
            return InternalRequestAsync<EditFirmwareResponse>(req, "EditFirmware");
        }

        /// <summary>
        /// 本接口用于编辑固件信息
        /// </summary>
        /// <param name="req"><see cref="EditFirmwareRequest"/></param>
        /// <returns><see cref="EditFirmwareResponse"/></returns>
        public EditFirmwareResponse EditFirmwareSync(EditFirmwareRequest req)
        {
            return InternalRequestAsync<EditFirmwareResponse>(req, "EditFirmware")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取视频防盗链播放URL
        /// </summary>
        /// <param name="req"><see cref="GenerateSignedVideoURLRequest"/></param>
        /// <returns><see cref="GenerateSignedVideoURLResponse"/></returns>
        public Task<GenerateSignedVideoURLResponse> GenerateSignedVideoURL(GenerateSignedVideoURLRequest req)
        {
            return InternalRequestAsync<GenerateSignedVideoURLResponse>(req, "GenerateSignedVideoURL");
        }

        /// <summary>
        /// 获取视频防盗链播放URL
        /// </summary>
        /// <param name="req"><see cref="GenerateSignedVideoURLRequest"/></param>
        /// <returns><see cref="GenerateSignedVideoURLResponse"/></returns>
        public GenerateSignedVideoURLResponse GenerateSignedVideoURLSync(GenerateSignedVideoURLRequest req)
        {
            return InternalRequestAsync<GenerateSignedVideoURLResponse>(req, "GenerateSignedVideoURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetAllFirmwareVersion）用于获取所有的版本列表 
        /// </summary>
        /// <param name="req"><see cref="GetAllFirmwareVersionRequest"/></param>
        /// <returns><see cref="GetAllFirmwareVersionResponse"/></returns>
        public Task<GetAllFirmwareVersionResponse> GetAllFirmwareVersion(GetAllFirmwareVersionRequest req)
        {
            return InternalRequestAsync<GetAllFirmwareVersionResponse>(req, "GetAllFirmwareVersion");
        }

        /// <summary>
        /// 本接口（GetAllFirmwareVersion）用于获取所有的版本列表 
        /// </summary>
        /// <param name="req"><see cref="GetAllFirmwareVersionRequest"/></param>
        /// <returns><see cref="GetAllFirmwareVersionResponse"/></returns>
        public GetAllFirmwareVersionResponse GetAllFirmwareVersionSync(GetAllFirmwareVersionRequest req)
        {
            return InternalRequestAsync<GetAllFirmwareVersionResponse>(req, "GetAllFirmwareVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（GetFirmwareURL）用于获取固件存储的URL 
        /// </summary>
        /// <param name="req"><see cref="GetFirmwareURLRequest"/></param>
        /// <returns><see cref="GetFirmwareURLResponse"/></returns>
        public Task<GetFirmwareURLResponse> GetFirmwareURL(GetFirmwareURLRequest req)
        {
            return InternalRequestAsync<GetFirmwareURLResponse>(req, "GetFirmwareURL");
        }

        /// <summary>
        /// 本接口（GetFirmwareURL）用于获取固件存储的URL 
        /// </summary>
        /// <param name="req"><see cref="GetFirmwareURLRequest"/></param>
        /// <returns><see cref="GetFirmwareURLResponse"/></returns>
        public GetFirmwareURLResponse GetFirmwareURLSync(GetFirmwareURLRequest req)
        {
            return InternalRequestAsync<GetFirmwareURLResponse>(req, "GetFirmwareURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入其它产品的数据模板，覆盖现有数据模板的物模型和产品分类信息
        /// </summary>
        /// <param name="req"><see cref="ImportModelDefinitionRequest"/></param>
        /// <returns><see cref="ImportModelDefinitionResponse"/></returns>
        public Task<ImportModelDefinitionResponse> ImportModelDefinition(ImportModelDefinitionRequest req)
        {
            return InternalRequestAsync<ImportModelDefinitionResponse>(req, "ImportModelDefinition");
        }

        /// <summary>
        /// 导入其它产品的数据模板，覆盖现有数据模板的物模型和产品分类信息
        /// </summary>
        /// <param name="req"><see cref="ImportModelDefinitionRequest"/></param>
        /// <returns><see cref="ImportModelDefinitionResponse"/></returns>
        public ImportModelDefinitionResponse ImportModelDefinitionSync(ImportModelDefinitionRequest req)
        {
            return InternalRequestAsync<ImportModelDefinitionResponse>(req, "ImportModelDefinition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 继承云存用户
        /// </summary>
        /// <param name="req"><see cref="InheritCloudStorageUserRequest"/></param>
        /// <returns><see cref="InheritCloudStorageUserResponse"/></returns>
        public Task<InheritCloudStorageUserResponse> InheritCloudStorageUser(InheritCloudStorageUserRequest req)
        {
            return InternalRequestAsync<InheritCloudStorageUserResponse>(req, "InheritCloudStorageUser");
        }

        /// <summary>
        /// 继承云存用户
        /// </summary>
        /// <param name="req"><see cref="InheritCloudStorageUserRequest"/></param>
        /// <returns><see cref="InheritCloudStorageUserResponse"/></returns>
        public InheritCloudStorageUserResponse InheritCloudStorageUserSync(InheritCloudStorageUserRequest req)
        {
            return InternalRequestAsync<InheritCloudStorageUserResponse>(req, "InheritCloudStorageUser")
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
        /// 修改数据转发
        /// </summary>
        /// <param name="req"><see cref="ModifyDataForwardRequest"/></param>
        /// <returns><see cref="ModifyDataForwardResponse"/></returns>
        public Task<ModifyDataForwardResponse> ModifyDataForward(ModifyDataForwardRequest req)
        {
            return InternalRequestAsync<ModifyDataForwardResponse>(req, "ModifyDataForward");
        }

        /// <summary>
        /// 修改数据转发
        /// </summary>
        /// <param name="req"><see cref="ModifyDataForwardRequest"/></param>
        /// <returns><see cref="ModifyDataForwardResponse"/></returns>
        public ModifyDataForwardResponse ModifyDataForwardSync(ModifyDataForwardRequest req)
        {
            return InternalRequestAsync<ModifyDataForwardResponse>(req, "ModifyDataForward")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置数据转发状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDataForwardStatusRequest"/></param>
        /// <returns><see cref="ModifyDataForwardStatusResponse"/></returns>
        public Task<ModifyDataForwardStatusResponse> ModifyDataForwardStatus(ModifyDataForwardStatusRequest req)
        {
            return InternalRequestAsync<ModifyDataForwardStatusResponse>(req, "ModifyDataForwardStatus");
        }

        /// <summary>
        /// 设置数据转发状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDataForwardStatusRequest"/></param>
        /// <returns><see cref="ModifyDataForwardStatusResponse"/></returns>
        public ModifyDataForwardStatusResponse ModifyDataForwardStatusSync(ModifyDataForwardStatusRequest req)
        {
            return InternalRequestAsync<ModifyDataForwardStatusResponse>(req, "ModifyDataForwardStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice");
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新设备日志级别
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceLogLevelRequest"/></param>
        /// <returns><see cref="ModifyDeviceLogLevelResponse"/></returns>
        public Task<ModifyDeviceLogLevelResponse> ModifyDeviceLogLevel(ModifyDeviceLogLevelRequest req)
        {
            return InternalRequestAsync<ModifyDeviceLogLevelResponse>(req, "ModifyDeviceLogLevel");
        }

        /// <summary>
        /// 更新设备日志级别
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceLogLevelRequest"/></param>
        /// <returns><see cref="ModifyDeviceLogLevelResponse"/></returns>
        public ModifyDeviceLogLevelResponse ModifyDeviceLogLevelSync(ModifyDeviceLogLevelRequest req)
        {
            return InternalRequestAsync<ModifyDeviceLogLevelResponse>(req, "ModifyDeviceLogLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardRuleResponse"/></returns>
        public Task<ModifyForwardRuleResponse> ModifyForwardRule(ModifyForwardRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardRuleResponse>(req, "ModifyForwardRule");
        }

        /// <summary>
        /// 修改转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyForwardRuleRequest"/></param>
        /// <returns><see cref="ModifyForwardRuleResponse"/></returns>
        public ModifyForwardRuleResponse ModifyForwardRuleSync(ModifyForwardRuleRequest req)
        {
            return InternalRequestAsync<ModifyForwardRuleResponse>(req, "ModifyForwardRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供修改产品的数据模板的能力
        /// </summary>
        /// <param name="req"><see cref="ModifyModelDefinitionRequest"/></param>
        /// <returns><see cref="ModifyModelDefinitionResponse"/></returns>
        public Task<ModifyModelDefinitionResponse> ModifyModelDefinition(ModifyModelDefinitionRequest req)
        {
            return InternalRequestAsync<ModifyModelDefinitionResponse>(req, "ModifyModelDefinition");
        }

        /// <summary>
        /// 提供修改产品的数据模板的能力
        /// </summary>
        /// <param name="req"><see cref="ModifyModelDefinitionRequest"/></param>
        /// <returns><see cref="ModifyModelDefinitionResponse"/></returns>
        public ModifyModelDefinitionResponse ModifyModelDefinitionSync(ModifyModelDefinitionRequest req)
        {
            return InternalRequestAsync<ModifyModelDefinitionResponse>(req, "ModifyModelDefinition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改产品信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest req)
        {
            return InternalRequestAsync<ModifyProductResponse>(req, "ModifyProduct");
        }

        /// <summary>
        /// 修改产品信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public ModifyProductResponse ModifyProductSync(ModifyProductRequest req)
        {
            return InternalRequestAsync<ModifyProductResponse>(req, "ModifyProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改产品动态注册
        /// </summary>
        /// <param name="req"><see cref="ModifyProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="ModifyProductDynamicRegisterResponse"/></returns>
        public Task<ModifyProductDynamicRegisterResponse> ModifyProductDynamicRegister(ModifyProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<ModifyProductDynamicRegisterResponse>(req, "ModifyProductDynamicRegister");
        }

        /// <summary>
        /// 修改产品动态注册
        /// </summary>
        /// <param name="req"><see cref="ModifyProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="ModifyProductDynamicRegisterResponse"/></returns>
        public ModifyProductDynamicRegisterResponse ModifyProductDynamicRegisterSync(ModifyProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<ModifyProductDynamicRegisterResponse>(req, "ModifyProductDynamicRegister")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（PublishMessage）用于使用自定义透传协议进行设备远控
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public Task<PublishMessageResponse> PublishMessage(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage");
        }

        /// <summary>
        /// 本接口（PublishMessage）用于使用自定义透传协议进行设备远控
        /// </summary>
        /// <param name="req"><see cref="PublishMessageRequest"/></param>
        /// <returns><see cref="PublishMessageResponse"/></returns>
        public PublishMessageResponse PublishMessageSync(PublishMessageRequest req)
        {
            return InternalRequestAsync<PublishMessageResponse>(req, "PublishMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报活跃设备
        /// </summary>
        /// <param name="req"><see cref="ReportAliveDeviceRequest"/></param>
        /// <returns><see cref="ReportAliveDeviceResponse"/></returns>
        public Task<ReportAliveDeviceResponse> ReportAliveDevice(ReportAliveDeviceRequest req)
        {
            return InternalRequestAsync<ReportAliveDeviceResponse>(req, "ReportAliveDevice");
        }

        /// <summary>
        /// 上报活跃设备
        /// </summary>
        /// <param name="req"><see cref="ReportAliveDeviceRequest"/></param>
        /// <returns><see cref="ReportAliveDeviceResponse"/></returns>
        public ReportAliveDeviceResponse ReportAliveDeviceSync(ReportAliveDeviceRequest req)
        {
            return InternalRequestAsync<ReportAliveDeviceResponse>(req, "ReportAliveDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置云存服务
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageRequest"/></param>
        /// <returns><see cref="ResetCloudStorageResponse"/></returns>
        public Task<ResetCloudStorageResponse> ResetCloudStorage(ResetCloudStorageRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageResponse>(req, "ResetCloudStorage");
        }

        /// <summary>
        /// 重置云存服务
        /// </summary>
        /// <param name="req"><see cref="ResetCloudStorageRequest"/></param>
        /// <returns><see cref="ResetCloudStorageResponse"/></returns>
        public ResetCloudStorageResponse ResetCloudStorageSync(ResetCloudStorageRequest req)
        {
            return InternalRequestAsync<ResetCloudStorageResponse>(req, "ResetCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于重试设备升级任务
        /// </summary>
        /// <param name="req"><see cref="RetryDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="RetryDeviceFirmwareTaskResponse"/></returns>
        public Task<RetryDeviceFirmwareTaskResponse> RetryDeviceFirmwareTask(RetryDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<RetryDeviceFirmwareTaskResponse>(req, "RetryDeviceFirmwareTask");
        }

        /// <summary>
        /// 本接口用于重试设备升级任务
        /// </summary>
        /// <param name="req"><see cref="RetryDeviceFirmwareTaskRequest"/></param>
        /// <returns><see cref="RetryDeviceFirmwareTaskResponse"/></returns>
        public RetryDeviceFirmwareTaskResponse RetryDeviceFirmwareTaskSync(RetryDeviceFirmwareTaskRequest req)
        {
            return InternalRequestAsync<RetryDeviceFirmwareTaskResponse>(req, "RetryDeviceFirmwareTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置转发权限
        /// </summary>
        /// <param name="req"><see cref="SetForwardAuthRequest"/></param>
        /// <returns><see cref="SetForwardAuthResponse"/></returns>
        public Task<SetForwardAuthResponse> SetForwardAuth(SetForwardAuthRequest req)
        {
            return InternalRequestAsync<SetForwardAuthResponse>(req, "SetForwardAuth");
        }

        /// <summary>
        /// 设置转发权限
        /// </summary>
        /// <param name="req"><see cref="SetForwardAuthRequest"/></param>
        /// <returns><see cref="SetForwardAuthResponse"/></returns>
        public SetForwardAuthResponse SetForwardAuthSync(SetForwardAuthRequest req)
        {
            return InternalRequestAsync<SetForwardAuthResponse>(req, "SetForwardAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 转移云存服务
        /// </summary>
        /// <param name="req"><see cref="TransferCloudStorageRequest"/></param>
        /// <returns><see cref="TransferCloudStorageResponse"/></returns>
        public Task<TransferCloudStorageResponse> TransferCloudStorage(TransferCloudStorageRequest req)
        {
            return InternalRequestAsync<TransferCloudStorageResponse>(req, "TransferCloudStorage");
        }

        /// <summary>
        /// 转移云存服务
        /// </summary>
        /// <param name="req"><see cref="TransferCloudStorageRequest"/></param>
        /// <returns><see cref="TransferCloudStorageResponse"/></returns>
        public TransferCloudStorageResponse TransferCloudStorageSync(TransferCloudStorageRequest req)
        {
            return InternalRequestAsync<TransferCloudStorageResponse>(req, "TransferCloudStorage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新AI推理结果推送配置
        /// </summary>
        /// <param name="req"><see cref="UpdateAIModelChannelRequest"/></param>
        /// <returns><see cref="UpdateAIModelChannelResponse"/></returns>
        public Task<UpdateAIModelChannelResponse> UpdateAIModelChannel(UpdateAIModelChannelRequest req)
        {
            return InternalRequestAsync<UpdateAIModelChannelResponse>(req, "UpdateAIModelChannel");
        }

        /// <summary>
        /// 更新AI推理结果推送配置
        /// </summary>
        /// <param name="req"><see cref="UpdateAIModelChannelRequest"/></param>
        /// <returns><see cref="UpdateAIModelChannelResponse"/></returns>
        public UpdateAIModelChannelResponse UpdateAIModelChannelSync(UpdateAIModelChannelRequest req)
        {
            return InternalRequestAsync<UpdateAIModelChannelResponse>(req, "UpdateAIModelChannel")
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

        /// <summary>
        /// 设备唤醒
        /// </summary>
        /// <param name="req"><see cref="WakeUpDeviceRequest"/></param>
        /// <returns><see cref="WakeUpDeviceResponse"/></returns>
        public Task<WakeUpDeviceResponse> WakeUpDevice(WakeUpDeviceRequest req)
        {
            return InternalRequestAsync<WakeUpDeviceResponse>(req, "WakeUpDevice");
        }

        /// <summary>
        /// 设备唤醒
        /// </summary>
        /// <param name="req"><see cref="WakeUpDeviceRequest"/></param>
        /// <returns><see cref="WakeUpDeviceResponse"/></returns>
        public WakeUpDeviceResponse WakeUpDeviceSync(WakeUpDeviceRequest req)
        {
            return InternalRequestAsync<WakeUpDeviceResponse>(req, "WakeUpDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
