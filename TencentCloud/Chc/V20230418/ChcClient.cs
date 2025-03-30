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

namespace TencentCloud.Chc.V20230418
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Chc.V20230418.Models;

   public class ChcClient : AbstractClient{

       private const string endpoint = "chc.tencentcloudapi.com";
       private const string version = "2023-04-18";
       private const string sdkVersion = "SDK_NET_3.0.1212";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ChcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ChcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 确认通用服务工单
        /// </summary>
        /// <param name="req"><see cref="ConfirmCommonServiceWorkOrderRequest"/></param>
        /// <returns><see cref="ConfirmCommonServiceWorkOrderResponse"/></returns>
        public Task<ConfirmCommonServiceWorkOrderResponse> ConfirmCommonServiceWorkOrder(ConfirmCommonServiceWorkOrderRequest req)
        {
            return InternalRequestAsync<ConfirmCommonServiceWorkOrderResponse>(req, "ConfirmCommonServiceWorkOrder");
        }

        /// <summary>
        /// 确认通用服务工单
        /// </summary>
        /// <param name="req"><see cref="ConfirmCommonServiceWorkOrderRequest"/></param>
        /// <returns><see cref="ConfirmCommonServiceWorkOrderResponse"/></returns>
        public ConfirmCommonServiceWorkOrderResponse ConfirmCommonServiceWorkOrderSync(ConfirmCommonServiceWorkOrderRequest req)
        {
            return InternalRequestAsync<ConfirmCommonServiceWorkOrderResponse>(req, "ConfirmCommonServiceWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建通用工单
        /// </summary>
        /// <param name="req"><see cref="CreateCommonServiceWorkOrderRequest"/></param>
        /// <returns><see cref="CreateCommonServiceWorkOrderResponse"/></returns>
        public Task<CreateCommonServiceWorkOrderResponse> CreateCommonServiceWorkOrder(CreateCommonServiceWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateCommonServiceWorkOrderResponse>(req, "CreateCommonServiceWorkOrder");
        }

        /// <summary>
        /// 创建通用工单
        /// </summary>
        /// <param name="req"><see cref="CreateCommonServiceWorkOrderRequest"/></param>
        /// <returns><see cref="CreateCommonServiceWorkOrderResponse"/></returns>
        public CreateCommonServiceWorkOrderResponse CreateCommonServiceWorkOrderSync(CreateCommonServiceWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateCommonServiceWorkOrderResponse>(req, "CreateCommonServiceWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备型号评估工单
        /// </summary>
        /// <param name="req"><see cref="CreateModelEvaluationWorkOrderRequest"/></param>
        /// <returns><see cref="CreateModelEvaluationWorkOrderResponse"/></returns>
        public Task<CreateModelEvaluationWorkOrderResponse> CreateModelEvaluationWorkOrder(CreateModelEvaluationWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateModelEvaluationWorkOrderResponse>(req, "CreateModelEvaluationWorkOrder");
        }

        /// <summary>
        /// 创建设备型号评估工单
        /// </summary>
        /// <param name="req"><see cref="CreateModelEvaluationWorkOrderRequest"/></param>
        /// <returns><see cref="CreateModelEvaluationWorkOrderResponse"/></returns>
        public CreateModelEvaluationWorkOrderResponse CreateModelEvaluationWorkOrderSync(CreateModelEvaluationWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateModelEvaluationWorkOrderResponse>(req, "CreateModelEvaluationWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备搬迁工单
        /// </summary>
        /// <param name="req"><see cref="CreateMovingWorkOrderRequest"/></param>
        /// <returns><see cref="CreateMovingWorkOrderResponse"/></returns>
        public Task<CreateMovingWorkOrderResponse> CreateMovingWorkOrder(CreateMovingWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateMovingWorkOrderResponse>(req, "CreateMovingWorkOrder");
        }

        /// <summary>
        /// 创建设备搬迁工单
        /// </summary>
        /// <param name="req"><see cref="CreateMovingWorkOrderRequest"/></param>
        /// <returns><see cref="CreateMovingWorkOrderResponse"/></returns>
        public CreateMovingWorkOrderResponse CreateMovingWorkOrderSync(CreateMovingWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateMovingWorkOrderResponse>(req, "CreateMovingWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建新的网络设备型号
        /// </summary>
        /// <param name="req"><see cref="CreateNetDeviceModelRequest"/></param>
        /// <returns><see cref="CreateNetDeviceModelResponse"/></returns>
        public Task<CreateNetDeviceModelResponse> CreateNetDeviceModel(CreateNetDeviceModelRequest req)
        {
            return InternalRequestAsync<CreateNetDeviceModelResponse>(req, "CreateNetDeviceModel");
        }

        /// <summary>
        /// 创建新的网络设备型号
        /// </summary>
        /// <param name="req"><see cref="CreateNetDeviceModelRequest"/></param>
        /// <returns><see cref="CreateNetDeviceModelResponse"/></returns>
        public CreateNetDeviceModelResponse CreateNetDeviceModelSync(CreateNetDeviceModelRequest req)
        {
            return InternalRequestAsync<CreateNetDeviceModelResponse>(req, "CreateNetDeviceModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建人员到访工单
        /// </summary>
        /// <param name="req"><see cref="CreatePersonnelVisitWorkOrderRequest"/></param>
        /// <returns><see cref="CreatePersonnelVisitWorkOrderResponse"/></returns>
        public Task<CreatePersonnelVisitWorkOrderResponse> CreatePersonnelVisitWorkOrder(CreatePersonnelVisitWorkOrderRequest req)
        {
            return InternalRequestAsync<CreatePersonnelVisitWorkOrderResponse>(req, "CreatePersonnelVisitWorkOrder");
        }

        /// <summary>
        /// 创建人员到访工单
        /// </summary>
        /// <param name="req"><see cref="CreatePersonnelVisitWorkOrderRequest"/></param>
        /// <returns><see cref="CreatePersonnelVisitWorkOrderResponse"/></returns>
        public CreatePersonnelVisitWorkOrderResponse CreatePersonnelVisitWorkOrderSync(CreatePersonnelVisitWorkOrderRequest req)
        {
            return InternalRequestAsync<CreatePersonnelVisitWorkOrderResponse>(req, "CreatePersonnelVisitWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备关电工单
        /// </summary>
        /// <param name="req"><see cref="CreatePowerOffWorkOrderRequest"/></param>
        /// <returns><see cref="CreatePowerOffWorkOrderResponse"/></returns>
        public Task<CreatePowerOffWorkOrderResponse> CreatePowerOffWorkOrder(CreatePowerOffWorkOrderRequest req)
        {
            return InternalRequestAsync<CreatePowerOffWorkOrderResponse>(req, "CreatePowerOffWorkOrder");
        }

        /// <summary>
        /// 创建设备关电工单
        /// </summary>
        /// <param name="req"><see cref="CreatePowerOffWorkOrderRequest"/></param>
        /// <returns><see cref="CreatePowerOffWorkOrderResponse"/></returns>
        public CreatePowerOffWorkOrderResponse CreatePowerOffWorkOrderSync(CreatePowerOffWorkOrderRequest req)
        {
            return InternalRequestAsync<CreatePowerOffWorkOrderResponse>(req, "CreatePowerOffWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备开电工单
        /// </summary>
        /// <param name="req"><see cref="CreatePowerOnWorkOrderRequest"/></param>
        /// <returns><see cref="CreatePowerOnWorkOrderResponse"/></returns>
        public Task<CreatePowerOnWorkOrderResponse> CreatePowerOnWorkOrder(CreatePowerOnWorkOrderRequest req)
        {
            return InternalRequestAsync<CreatePowerOnWorkOrderResponse>(req, "CreatePowerOnWorkOrder");
        }

        /// <summary>
        /// 创建设备开电工单
        /// </summary>
        /// <param name="req"><see cref="CreatePowerOnWorkOrderRequest"/></param>
        /// <returns><see cref="CreatePowerOnWorkOrderResponse"/></returns>
        public CreatePowerOnWorkOrderResponse CreatePowerOnWorkOrderSync(CreatePowerOnWorkOrderRequest req)
        {
            return InternalRequestAsync<CreatePowerOnWorkOrderResponse>(req, "CreatePowerOnWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备退出工单
        /// </summary>
        /// <param name="req"><see cref="CreateQuitWorkOrderRequest"/></param>
        /// <returns><see cref="CreateQuitWorkOrderResponse"/></returns>
        public Task<CreateQuitWorkOrderResponse> CreateQuitWorkOrder(CreateQuitWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateQuitWorkOrderResponse>(req, "CreateQuitWorkOrder");
        }

        /// <summary>
        /// 创建设备退出工单
        /// </summary>
        /// <param name="req"><see cref="CreateQuitWorkOrderRequest"/></param>
        /// <returns><see cref="CreateQuitWorkOrderResponse"/></returns>
        public CreateQuitWorkOrderResponse CreateQuitWorkOrderSync(CreateQuitWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateQuitWorkOrderResponse>(req, "CreateQuitWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备下架工单
        /// </summary>
        /// <param name="req"><see cref="CreateRackOffWorkOrderRequest"/></param>
        /// <returns><see cref="CreateRackOffWorkOrderResponse"/></returns>
        public Task<CreateRackOffWorkOrderResponse> CreateRackOffWorkOrder(CreateRackOffWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateRackOffWorkOrderResponse>(req, "CreateRackOffWorkOrder");
        }

        /// <summary>
        /// 创建设备下架工单
        /// </summary>
        /// <param name="req"><see cref="CreateRackOffWorkOrderRequest"/></param>
        /// <returns><see cref="CreateRackOffWorkOrderResponse"/></returns>
        public CreateRackOffWorkOrderResponse CreateRackOffWorkOrderSync(CreateRackOffWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateRackOffWorkOrderResponse>(req, "CreateRackOffWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备上架工单
        /// </summary>
        /// <param name="req"><see cref="CreateRackOnWorkOrderRequest"/></param>
        /// <returns><see cref="CreateRackOnWorkOrderResponse"/></returns>
        public Task<CreateRackOnWorkOrderResponse> CreateRackOnWorkOrder(CreateRackOnWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateRackOnWorkOrderResponse>(req, "CreateRackOnWorkOrder");
        }

        /// <summary>
        /// 创建设备上架工单
        /// </summary>
        /// <param name="req"><see cref="CreateRackOnWorkOrderRequest"/></param>
        /// <returns><see cref="CreateRackOnWorkOrderResponse"/></returns>
        public CreateRackOnWorkOrderResponse CreateRackOnWorkOrderSync(CreateRackOnWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateRackOnWorkOrderResponse>(req, "CreateRackOnWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建设备收货工单
        /// </summary>
        /// <param name="req"><see cref="CreateReceivingWorkOrderRequest"/></param>
        /// <returns><see cref="CreateReceivingWorkOrderResponse"/></returns>
        public Task<CreateReceivingWorkOrderResponse> CreateReceivingWorkOrder(CreateReceivingWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateReceivingWorkOrderResponse>(req, "CreateReceivingWorkOrder");
        }

        /// <summary>
        /// 创建设备收货工单
        /// </summary>
        /// <param name="req"><see cref="CreateReceivingWorkOrderRequest"/></param>
        /// <returns><see cref="CreateReceivingWorkOrderResponse"/></returns>
        public CreateReceivingWorkOrderResponse CreateReceivingWorkOrderSync(CreateReceivingWorkOrderRequest req)
        {
            return InternalRequestAsync<CreateReceivingWorkOrderResponse>(req, "CreateReceivingWorkOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增服务器设备型号
        /// </summary>
        /// <param name="req"><see cref="CreateServerModelRequest"/></param>
        /// <returns><see cref="CreateServerModelResponse"/></returns>
        public Task<CreateServerModelResponse> CreateServerModel(CreateServerModelRequest req)
        {
            return InternalRequestAsync<CreateServerModelResponse>(req, "CreateServerModel");
        }

        /// <summary>
        /// 新增服务器设备型号
        /// </summary>
        /// <param name="req"><see cref="CreateServerModelRequest"/></param>
        /// <returns><see cref="CreateServerModelResponse"/></returns>
        public CreateServerModelResponse CreateServerModelSync(CreateServerModelRequest req)
        {
            return InternalRequestAsync<CreateServerModelResponse>(req, "CreateServerModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机房内可用的型号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableModelListRequest"/></param>
        /// <returns><see cref="DescribeAvailableModelListResponse"/></returns>
        public Task<DescribeAvailableModelListResponse> DescribeAvailableModelList(DescribeAvailableModelListRequest req)
        {
            return InternalRequestAsync<DescribeAvailableModelListResponse>(req, "DescribeAvailableModelList");
        }

        /// <summary>
        /// 获取机房内可用的型号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableModelListRequest"/></param>
        /// <returns><see cref="DescribeAvailableModelListResponse"/></returns>
        public DescribeAvailableModelListResponse DescribeAvailableModelListSync(DescribeAvailableModelListRequest req)
        {
            return InternalRequestAsync<DescribeAvailableModelListResponse>(req, "DescribeAvailableModelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户可操作的园区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCampusListRequest"/></param>
        /// <returns><see cref="DescribeCampusListResponse"/></returns>
        public Task<DescribeCampusListResponse> DescribeCampusList(DescribeCampusListRequest req)
        {
            return InternalRequestAsync<DescribeCampusListResponse>(req, "DescribeCampusList");
        }

        /// <summary>
        /// 获取用户可操作的园区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCampusListRequest"/></param>
        /// <returns><see cref="DescribeCampusListResponse"/></returns>
        public DescribeCampusListResponse DescribeCampusListSync(DescribeCampusListRequest req)
        {
            return InternalRequestAsync<DescribeCampusListResponse>(req, "DescribeCampusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询通用服务工单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonServiceWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribeCommonServiceWorkOrderDetailResponse"/></returns>
        public Task<DescribeCommonServiceWorkOrderDetailResponse> DescribeCommonServiceWorkOrderDetail(DescribeCommonServiceWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribeCommonServiceWorkOrderDetailResponse>(req, "DescribeCommonServiceWorkOrderDetail");
        }

        /// <summary>
        /// 查询通用服务工单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCommonServiceWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribeCommonServiceWorkOrderDetailResponse"/></returns>
        public DescribeCommonServiceWorkOrderDetailResponse DescribeCommonServiceWorkOrderDetailSync(DescribeCommonServiceWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribeCommonServiceWorkOrderDetailResponse>(req, "DescribeCommonServiceWorkOrderDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询客户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerInfoRequest"/></param>
        /// <returns><see cref="DescribeCustomerInfoResponse"/></returns>
        public Task<DescribeCustomerInfoResponse> DescribeCustomerInfo(DescribeCustomerInfoRequest req)
        {
            return InternalRequestAsync<DescribeCustomerInfoResponse>(req, "DescribeCustomerInfo");
        }

        /// <summary>
        /// 查询客户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomerInfoRequest"/></param>
        /// <returns><see cref="DescribeCustomerInfoResponse"/></returns>
        public DescribeCustomerInfoResponse DescribeCustomerInfoSync(DescribeCustomerInfoRequest req)
        {
            return InternalRequestAsync<DescribeCustomerInfoResponse>(req, "DescribeCustomerInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public Task<DescribeDeviceListResponse> DescribeDeviceList(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList");
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceListRequest"/></param>
        /// <returns><see cref="DescribeDeviceListResponse"/></returns>
        public DescribeDeviceListResponse DescribeDeviceListSync(DescribeDeviceListRequest req)
        {
            return InternalRequestAsync<DescribeDeviceListResponse>(req, "DescribeDeviceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询设备类工单的工单详情，如：'receiving', 'rackOn', 'powerOn', 'powerOff', 'rackOff', 'quit'
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribeDeviceWorkOrderDetailResponse"/></returns>
        public Task<DescribeDeviceWorkOrderDetailResponse> DescribeDeviceWorkOrderDetail(DescribeDeviceWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribeDeviceWorkOrderDetailResponse>(req, "DescribeDeviceWorkOrderDetail");
        }

        /// <summary>
        /// 用于查询设备类工单的工单详情，如：'receiving', 'rackOn', 'powerOn', 'powerOff', 'rackOff', 'quit'
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribeDeviceWorkOrderDetailResponse"/></returns>
        public DescribeDeviceWorkOrderDetailResponse DescribeDeviceWorkOrderDetailSync(DescribeDeviceWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribeDeviceWorkOrderDetailResponse>(req, "DescribeDeviceWorkOrderDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询机房管理单元资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdcUnitAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeIdcUnitAssetDetailResponse"/></returns>
        public Task<DescribeIdcUnitAssetDetailResponse> DescribeIdcUnitAssetDetail(DescribeIdcUnitAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeIdcUnitAssetDetailResponse>(req, "DescribeIdcUnitAssetDetail");
        }

        /// <summary>
        /// 查询机房管理单元资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdcUnitAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeIdcUnitAssetDetailResponse"/></returns>
        public DescribeIdcUnitAssetDetailResponse DescribeIdcUnitAssetDetailSync(DescribeIdcUnitAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeIdcUnitAssetDetailResponse>(req, "DescribeIdcUnitAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询机房管理单元详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdcUnitDetailRequest"/></param>
        /// <returns><see cref="DescribeIdcUnitDetailResponse"/></returns>
        public Task<DescribeIdcUnitDetailResponse> DescribeIdcUnitDetail(DescribeIdcUnitDetailRequest req)
        {
            return InternalRequestAsync<DescribeIdcUnitDetailResponse>(req, "DescribeIdcUnitDetail");
        }

        /// <summary>
        /// 查询机房管理单元详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdcUnitDetailRequest"/></param>
        /// <returns><see cref="DescribeIdcUnitDetailResponse"/></returns>
        public DescribeIdcUnitDetailResponse DescribeIdcUnitDetailSync(DescribeIdcUnitDetailRequest req)
        {
            return InternalRequestAsync<DescribeIdcUnitDetailResponse>(req, "DescribeIdcUnitDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机房和机房管理单元信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIdcsRequest"/></param>
        /// <returns><see cref="DescribeIdcsResponse"/></returns>
        public Task<DescribeIdcsResponse> DescribeIdcs(DescribeIdcsRequest req)
        {
            return InternalRequestAsync<DescribeIdcsResponse>(req, "DescribeIdcs");
        }

        /// <summary>
        /// 获取机房和机房管理单元信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIdcsRequest"/></param>
        /// <returns><see cref="DescribeIdcsResponse"/></returns>
        public DescribeIdcsResponse DescribeIdcsSync(DescribeIdcsRequest req)
        {
            return InternalRequestAsync<DescribeIdcsResponse>(req, "DescribeIdcs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备型号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelRequest"/></param>
        /// <returns><see cref="DescribeModelResponse"/></returns>
        public Task<DescribeModelResponse> DescribeModel(DescribeModelRequest req)
        {
            return InternalRequestAsync<DescribeModelResponse>(req, "DescribeModel");
        }

        /// <summary>
        /// 查询设备型号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelRequest"/></param>
        /// <returns><see cref="DescribeModelResponse"/></returns>
        public DescribeModelResponse DescribeModelSync(DescribeModelRequest req)
        {
            return InternalRequestAsync<DescribeModelResponse>(req, "DescribeModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备型号评估工单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelEvaluationWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribeModelEvaluationWorkOrderDetailResponse"/></returns>
        public Task<DescribeModelEvaluationWorkOrderDetailResponse> DescribeModelEvaluationWorkOrderDetail(DescribeModelEvaluationWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribeModelEvaluationWorkOrderDetailResponse>(req, "DescribeModelEvaluationWorkOrderDetail");
        }

        /// <summary>
        /// 查询设备型号评估工单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeModelEvaluationWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribeModelEvaluationWorkOrderDetailResponse"/></returns>
        public DescribeModelEvaluationWorkOrderDetailResponse DescribeModelEvaluationWorkOrderDetailSync(DescribeModelEvaluationWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribeModelEvaluationWorkOrderDetailResponse>(req, "DescribeModelEvaluationWorkOrderDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取型号的填写模板
        /// </summary>
        /// <param name="req"><see cref="DescribeModelTemplateRequest"/></param>
        /// <returns><see cref="DescribeModelTemplateResponse"/></returns>
        public Task<DescribeModelTemplateResponse> DescribeModelTemplate(DescribeModelTemplateRequest req)
        {
            return InternalRequestAsync<DescribeModelTemplateResponse>(req, "DescribeModelTemplate");
        }

        /// <summary>
        /// 获取型号的填写模板
        /// </summary>
        /// <param name="req"><see cref="DescribeModelTemplateRequest"/></param>
        /// <returns><see cref="DescribeModelTemplateResponse"/></returns>
        public DescribeModelTemplateResponse DescribeModelTemplateSync(DescribeModelTemplateRequest req)
        {
            return InternalRequestAsync<DescribeModelTemplateResponse>(req, "DescribeModelTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户的型号和对应的版本数量
        /// </summary>
        /// <param name="req"><see cref="DescribeModelVersionListRequest"/></param>
        /// <returns><see cref="DescribeModelVersionListResponse"/></returns>
        public Task<DescribeModelVersionListResponse> DescribeModelVersionList(DescribeModelVersionListRequest req)
        {
            return InternalRequestAsync<DescribeModelVersionListResponse>(req, "DescribeModelVersionList");
        }

        /// <summary>
        /// 获取用户的型号和对应的版本数量
        /// </summary>
        /// <param name="req"><see cref="DescribeModelVersionListRequest"/></param>
        /// <returns><see cref="DescribeModelVersionListResponse"/></returns>
        public DescribeModelVersionListResponse DescribeModelVersionListSync(DescribeModelVersionListRequest req)
        {
            return InternalRequestAsync<DescribeModelVersionListResponse>(req, "DescribeModelVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询人员到访工单详情
        /// </summary>
        /// <param name="req"><see cref="DescribePersonnelVisitWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribePersonnelVisitWorkOrderDetailResponse"/></returns>
        public Task<DescribePersonnelVisitWorkOrderDetailResponse> DescribePersonnelVisitWorkOrderDetail(DescribePersonnelVisitWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribePersonnelVisitWorkOrderDetailResponse>(req, "DescribePersonnelVisitWorkOrderDetail");
        }

        /// <summary>
        /// 查询人员到访工单详情
        /// </summary>
        /// <param name="req"><see cref="DescribePersonnelVisitWorkOrderDetailRequest"/></param>
        /// <returns><see cref="DescribePersonnelVisitWorkOrderDetailResponse"/></returns>
        public DescribePersonnelVisitWorkOrderDetailResponse DescribePersonnelVisitWorkOrderDetailSync(DescribePersonnelVisitWorkOrderDetailRequest req)
        {
            return InternalRequestAsync<DescribePersonnelVisitWorkOrderDetailResponse>(req, "DescribePersonnelVisitWorkOrderDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机架总数及各状态对应的数量汇总
        /// </summary>
        /// <param name="req"><see cref="DescribePositionStatusSummaryRequest"/></param>
        /// <returns><see cref="DescribePositionStatusSummaryResponse"/></returns>
        public Task<DescribePositionStatusSummaryResponse> DescribePositionStatusSummary(DescribePositionStatusSummaryRequest req)
        {
            return InternalRequestAsync<DescribePositionStatusSummaryResponse>(req, "DescribePositionStatusSummary");
        }

        /// <summary>
        /// 获取机架总数及各状态对应的数量汇总
        /// </summary>
        /// <param name="req"><see cref="DescribePositionStatusSummaryRequest"/></param>
        /// <returns><see cref="DescribePositionStatusSummaryResponse"/></returns>
        public DescribePositionStatusSummaryResponse DescribePositionStatusSummarySync(DescribePositionStatusSummaryRequest req)
        {
            return InternalRequestAsync<DescribePositionStatusSummaryResponse>(req, "DescribePositionStatusSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机位列表
        /// </summary>
        /// <param name="req"><see cref="DescribePositionsRequest"/></param>
        /// <returns><see cref="DescribePositionsResponse"/></returns>
        public Task<DescribePositionsResponse> DescribePositions(DescribePositionsRequest req)
        {
            return InternalRequestAsync<DescribePositionsResponse>(req, "DescribePositions");
        }

        /// <summary>
        /// 获取机位列表
        /// </summary>
        /// <param name="req"><see cref="DescribePositionsRequest"/></param>
        /// <returns><see cref="DescribePositionsResponse"/></returns>
        public DescribePositionsResponse DescribePositionsSync(DescribePositionsRequest req)
        {
            return InternalRequestAsync<DescribePositionsResponse>(req, "DescribePositions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRacksRequest"/></param>
        /// <returns><see cref="DescribeRacksResponse"/></returns>
        public Task<DescribeRacksResponse> DescribeRacks(DescribeRacksRequest req)
        {
            return InternalRequestAsync<DescribeRacksResponse>(req, "DescribeRacks");
        }

        /// <summary>
        /// 获取机架列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRacksRequest"/></param>
        /// <returns><see cref="DescribeRacksResponse"/></returns>
        public DescribeRacksResponse DescribeRacksSync(DescribeRacksRequest req)
        {
            return InternalRequestAsync<DescribeRacksResponse>(req, "DescribeRacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机房管理单元的机位分布
        /// </summary>
        /// <param name="req"><see cref="DescribeRacksDistributionRequest"/></param>
        /// <returns><see cref="DescribeRacksDistributionResponse"/></returns>
        public Task<DescribeRacksDistributionResponse> DescribeRacksDistribution(DescribeRacksDistributionRequest req)
        {
            return InternalRequestAsync<DescribeRacksDistributionResponse>(req, "DescribeRacksDistribution");
        }

        /// <summary>
        /// 获取机房管理单元的机位分布
        /// </summary>
        /// <param name="req"><see cref="DescribeRacksDistributionRequest"/></param>
        /// <returns><see cref="DescribeRacksDistributionResponse"/></returns>
        public DescribeRacksDistributionResponse DescribeRacksDistributionSync(DescribeRacksDistributionRequest req)
        {
            return InternalRequestAsync<DescribeRacksDistributionResponse>(req, "DescribeRacksDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资源汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public Task<DescribeResourceUsageResponse> DescribeResourceUsage(DescribeResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageResponse>(req, "DescribeResourceUsage");
        }

        /// <summary>
        /// 查询资源汇总
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeResourceUsageResponse"/></returns>
        public DescribeResourceUsageResponse DescribeResourceUsageSync(DescribeResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeResourceUsageResponse>(req, "DescribeResourceUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询工单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkOrderListRequest"/></param>
        /// <returns><see cref="DescribeWorkOrderListResponse"/></returns>
        public Task<DescribeWorkOrderListResponse> DescribeWorkOrderList(DescribeWorkOrderListRequest req)
        {
            return InternalRequestAsync<DescribeWorkOrderListResponse>(req, "DescribeWorkOrderList");
        }

        /// <summary>
        /// 查询工单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkOrderListRequest"/></param>
        /// <returns><see cref="DescribeWorkOrderListResponse"/></returns>
        public DescribeWorkOrderListResponse DescribeWorkOrderListSync(DescribeWorkOrderListRequest req)
        {
            return InternalRequestAsync<DescribeWorkOrderListResponse>(req, "DescribeWorkOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 工单统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkOrderStatisticsRequest"/></param>
        /// <returns><see cref="DescribeWorkOrderStatisticsResponse"/></returns>
        public Task<DescribeWorkOrderStatisticsResponse> DescribeWorkOrderStatistics(DescribeWorkOrderStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeWorkOrderStatisticsResponse>(req, "DescribeWorkOrderStatistics");
        }

        /// <summary>
        /// 工单统计数据查询
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkOrderStatisticsRequest"/></param>
        /// <returns><see cref="DescribeWorkOrderStatisticsResponse"/></returns>
        public DescribeWorkOrderStatisticsResponse DescribeWorkOrderStatisticsSync(DescribeWorkOrderStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeWorkOrderStatisticsResponse>(req, "DescribeWorkOrderStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户可用的工单类型
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkOrderTypesRequest"/></param>
        /// <returns><see cref="DescribeWorkOrderTypesResponse"/></returns>
        public Task<DescribeWorkOrderTypesResponse> DescribeWorkOrderTypes(DescribeWorkOrderTypesRequest req)
        {
            return InternalRequestAsync<DescribeWorkOrderTypesResponse>(req, "DescribeWorkOrderTypes");
        }

        /// <summary>
        /// 获取用户可用的工单类型
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkOrderTypesRequest"/></param>
        /// <returns><see cref="DescribeWorkOrderTypesResponse"/></returns>
        public DescribeWorkOrderTypesResponse DescribeWorkOrderTypesSync(DescribeWorkOrderTypesRequest req)
        {
            return InternalRequestAsync<DescribeWorkOrderTypesResponse>(req, "DescribeWorkOrderTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如果当前该工单类型是收藏状态，调用接口后变成未收藏状态，如果是未收藏状态，调用该接口变为收藏状态
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkOrderTypeCollectFlagRequest"/></param>
        /// <returns><see cref="ModifyWorkOrderTypeCollectFlagResponse"/></returns>
        public Task<ModifyWorkOrderTypeCollectFlagResponse> ModifyWorkOrderTypeCollectFlag(ModifyWorkOrderTypeCollectFlagRequest req)
        {
            return InternalRequestAsync<ModifyWorkOrderTypeCollectFlagResponse>(req, "ModifyWorkOrderTypeCollectFlag");
        }

        /// <summary>
        /// 如果当前该工单类型是收藏状态，调用接口后变成未收藏状态，如果是未收藏状态，调用该接口变为收藏状态
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkOrderTypeCollectFlagRequest"/></param>
        /// <returns><see cref="ModifyWorkOrderTypeCollectFlagResponse"/></returns>
        public ModifyWorkOrderTypeCollectFlagResponse ModifyWorkOrderTypeCollectFlagSync(ModifyWorkOrderTypeCollectFlagRequest req)
        {
            return InternalRequestAsync<ModifyWorkOrderTypeCollectFlagResponse>(req, "ModifyWorkOrderTypeCollectFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
