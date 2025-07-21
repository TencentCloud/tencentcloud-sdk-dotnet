/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Igtm.V20231024
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Igtm.V20231024.Models;

   public class IgtmClient : AbstractClient{

       private const string endpoint = "igtm.tencentcloudapi.com";
       private const string version = "2023-10-24";
       private const string sdkVersion = "SDK_NET_3.0.1284";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IgtmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IgtmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建地址池
        /// </summary>
        /// <param name="req"><see cref="CreateAddressPoolRequest"/></param>
        /// <returns><see cref="CreateAddressPoolResponse"/></returns>
        public Task<CreateAddressPoolResponse> CreateAddressPool(CreateAddressPoolRequest req)
        {
            return InternalRequestAsync<CreateAddressPoolResponse>(req, "CreateAddressPool");
        }

        /// <summary>
        /// 创建地址池
        /// </summary>
        /// <param name="req"><see cref="CreateAddressPoolRequest"/></param>
        /// <returns><see cref="CreateAddressPoolResponse"/></returns>
        public CreateAddressPoolResponse CreateAddressPoolSync(CreateAddressPoolRequest req)
        {
            return InternalRequestAsync<CreateAddressPoolResponse>(req, "CreateAddressPool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例接口，仅供免费实例使用
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// 创建实例接口，仅供免费实例使用
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增监控器
        /// </summary>
        /// <param name="req"><see cref="CreateMonitorRequest"/></param>
        /// <returns><see cref="CreateMonitorResponse"/></returns>
        public Task<CreateMonitorResponse> CreateMonitor(CreateMonitorRequest req)
        {
            return InternalRequestAsync<CreateMonitorResponse>(req, "CreateMonitor");
        }

        /// <summary>
        /// 新增监控器
        /// </summary>
        /// <param name="req"><see cref="CreateMonitorRequest"/></param>
        /// <returns><see cref="CreateMonitorResponse"/></returns>
        public CreateMonitorResponse CreateMonitorSync(CreateMonitorRequest req)
        {
            return InternalRequestAsync<CreateMonitorResponse>(req, "CreateMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建策略接口
        /// </summary>
        /// <param name="req"><see cref="CreateStrategyRequest"/></param>
        /// <returns><see cref="CreateStrategyResponse"/></returns>
        public Task<CreateStrategyResponse> CreateStrategy(CreateStrategyRequest req)
        {
            return InternalRequestAsync<CreateStrategyResponse>(req, "CreateStrategy");
        }

        /// <summary>
        /// 新建策略接口
        /// </summary>
        /// <param name="req"><see cref="CreateStrategyRequest"/></param>
        /// <returns><see cref="CreateStrategyResponse"/></returns>
        public CreateStrategyResponse CreateStrategySync(CreateStrategyRequest req)
        {
            return InternalRequestAsync<CreateStrategyResponse>(req, "CreateStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除地址池
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressPoolRequest"/></param>
        /// <returns><see cref="DeleteAddressPoolResponse"/></returns>
        public Task<DeleteAddressPoolResponse> DeleteAddressPool(DeleteAddressPoolRequest req)
        {
            return InternalRequestAsync<DeleteAddressPoolResponse>(req, "DeleteAddressPool");
        }

        /// <summary>
        /// 删除地址池
        /// </summary>
        /// <param name="req"><see cref="DeleteAddressPoolRequest"/></param>
        /// <returns><see cref="DeleteAddressPoolResponse"/></returns>
        public DeleteAddressPoolResponse DeleteAddressPoolSync(DeleteAddressPoolRequest req)
        {
            return InternalRequestAsync<DeleteAddressPoolResponse>(req, "DeleteAddressPool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除监控器
        /// </summary>
        /// <param name="req"><see cref="DeleteMonitorRequest"/></param>
        /// <returns><see cref="DeleteMonitorResponse"/></returns>
        public Task<DeleteMonitorResponse> DeleteMonitor(DeleteMonitorRequest req)
        {
            return InternalRequestAsync<DeleteMonitorResponse>(req, "DeleteMonitor");
        }

        /// <summary>
        /// 删除监控器
        /// </summary>
        /// <param name="req"><see cref="DeleteMonitorRequest"/></param>
        /// <returns><see cref="DeleteMonitorResponse"/></returns>
        public DeleteMonitorResponse DeleteMonitorSync(DeleteMonitorRequest req)
        {
            return InternalRequestAsync<DeleteMonitorResponse>(req, "DeleteMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略接口
        /// </summary>
        /// <param name="req"><see cref="DeleteStrategyRequest"/></param>
        /// <returns><see cref="DeleteStrategyResponse"/></returns>
        public Task<DeleteStrategyResponse> DeleteStrategy(DeleteStrategyRequest req)
        {
            return InternalRequestAsync<DeleteStrategyResponse>(req, "DeleteStrategy");
        }

        /// <summary>
        /// 删除策略接口
        /// </summary>
        /// <param name="req"><see cref="DeleteStrategyRequest"/></param>
        /// <returns><see cref="DeleteStrategyResponse"/></returns>
        public DeleteStrategyResponse DeleteStrategySync(DeleteStrategyRequest req)
        {
            return InternalRequestAsync<DeleteStrategyResponse>(req, "DeleteStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取地址所属地域
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressLocationRequest"/></param>
        /// <returns><see cref="DescribeAddressLocationResponse"/></returns>
        public Task<DescribeAddressLocationResponse> DescribeAddressLocation(DescribeAddressLocationRequest req)
        {
            return InternalRequestAsync<DescribeAddressLocationResponse>(req, "DescribeAddressLocation");
        }

        /// <summary>
        /// 获取地址所属地域
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressLocationRequest"/></param>
        /// <returns><see cref="DescribeAddressLocationResponse"/></returns>
        public DescribeAddressLocationResponse DescribeAddressLocationSync(DescribeAddressLocationRequest req)
        {
            return InternalRequestAsync<DescribeAddressLocationResponse>(req, "DescribeAddressLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 地址池详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressPoolDetailRequest"/></param>
        /// <returns><see cref="DescribeAddressPoolDetailResponse"/></returns>
        public Task<DescribeAddressPoolDetailResponse> DescribeAddressPoolDetail(DescribeAddressPoolDetailRequest req)
        {
            return InternalRequestAsync<DescribeAddressPoolDetailResponse>(req, "DescribeAddressPoolDetail");
        }

        /// <summary>
        /// 地址池详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressPoolDetailRequest"/></param>
        /// <returns><see cref="DescribeAddressPoolDetailResponse"/></returns>
        public DescribeAddressPoolDetailResponse DescribeAddressPoolDetailSync(DescribeAddressPoolDetailRequest req)
        {
            return InternalRequestAsync<DescribeAddressPoolDetailResponse>(req, "DescribeAddressPoolDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 地址池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressPoolListRequest"/></param>
        /// <returns><see cref="DescribeAddressPoolListResponse"/></returns>
        public Task<DescribeAddressPoolListResponse> DescribeAddressPoolList(DescribeAddressPoolListRequest req)
        {
            return InternalRequestAsync<DescribeAddressPoolListResponse>(req, "DescribeAddressPoolList");
        }

        /// <summary>
        /// 地址池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAddressPoolListRequest"/></param>
        /// <returns><see cref="DescribeAddressPoolListResponse"/></returns>
        public DescribeAddressPoolListResponse DescribeAddressPoolListSync(DescribeAddressPoolListRequest req)
        {
            return InternalRequestAsync<DescribeAddressPoolListResponse>(req, "DescribeAddressPoolList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 探测任务包详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDetectPackageDetailRequest"/></param>
        /// <returns><see cref="DescribeDetectPackageDetailResponse"/></returns>
        public Task<DescribeDetectPackageDetailResponse> DescribeDetectPackageDetail(DescribeDetectPackageDetailRequest req)
        {
            return InternalRequestAsync<DescribeDetectPackageDetailResponse>(req, "DescribeDetectPackageDetail");
        }

        /// <summary>
        /// 探测任务包详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDetectPackageDetailRequest"/></param>
        /// <returns><see cref="DescribeDetectPackageDetailResponse"/></returns>
        public DescribeDetectPackageDetailResponse DescribeDetectPackageDetailSync(DescribeDetectPackageDetailRequest req)
        {
            return InternalRequestAsync<DescribeDetectPackageDetailResponse>(req, "DescribeDetectPackageDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 探测任务套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDetectTaskPackageListRequest"/></param>
        /// <returns><see cref="DescribeDetectTaskPackageListResponse"/></returns>
        public Task<DescribeDetectTaskPackageListResponse> DescribeDetectTaskPackageList(DescribeDetectTaskPackageListRequest req)
        {
            return InternalRequestAsync<DescribeDetectTaskPackageListResponse>(req, "DescribeDetectTaskPackageList");
        }

        /// <summary>
        /// 探测任务套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDetectTaskPackageListRequest"/></param>
        /// <returns><see cref="DescribeDetectTaskPackageListResponse"/></returns>
        public DescribeDetectTaskPackageListResponse DescribeDetectTaskPackageListSync(DescribeDetectTaskPackageListRequest req)
        {
            return InternalRequestAsync<DescribeDetectTaskPackageListResponse>(req, "DescribeDetectTaskPackageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取探测节点列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDetectorsRequest"/></param>
        /// <returns><see cref="DescribeDetectorsResponse"/></returns>
        public Task<DescribeDetectorsResponse> DescribeDetectors(DescribeDetectorsRequest req)
        {
            return InternalRequestAsync<DescribeDetectorsResponse>(req, "DescribeDetectors");
        }

        /// <summary>
        /// 获取探测节点列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDetectorsRequest"/></param>
        /// <returns><see cref="DescribeDetectorsResponse"/></returns>
        public DescribeDetectorsResponse DescribeDetectorsSync(DescribeDetectorsRequest req)
        {
            return InternalRequestAsync<DescribeDetectorsResponse>(req, "DescribeDetectors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分组线路列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsLineListRequest"/></param>
        /// <returns><see cref="DescribeDnsLineListResponse"/></returns>
        public Task<DescribeDnsLineListResponse> DescribeDnsLineList(DescribeDnsLineListRequest req)
        {
            return InternalRequestAsync<DescribeDnsLineListResponse>(req, "DescribeDnsLineList");
        }

        /// <summary>
        /// 查询分组线路列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDnsLineListRequest"/></param>
        /// <returns><see cref="DescribeDnsLineListResponse"/></returns>
        public DescribeDnsLineListResponse DescribeDnsLineListSync(DescribeDnsLineListRequest req)
        {
            return InternalRequestAsync<DescribeDnsLineListResponse>(req, "DescribeDnsLineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public Task<DescribeInstanceDetailResponse> DescribeInstanceDetail(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail");
        }

        /// <summary>
        /// 实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public DescribeInstanceDetailResponse DescribeInstanceDetailSync(DescribeInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDetailResponse>(req, "DescribeInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList");
        }

        /// <summary>
        /// 实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeInstanceListResponse>(req, "DescribeInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePackageListRequest"/></param>
        /// <returns><see cref="DescribeInstancePackageListResponse"/></returns>
        public Task<DescribeInstancePackageListResponse> DescribeInstancePackageList(DescribeInstancePackageListRequest req)
        {
            return InternalRequestAsync<DescribeInstancePackageListResponse>(req, "DescribeInstancePackageList");
        }

        /// <summary>
        /// 实例套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePackageListRequest"/></param>
        /// <returns><see cref="DescribeInstancePackageListResponse"/></returns>
        public DescribeInstancePackageListResponse DescribeInstancePackageListSync(DescribeInstancePackageListRequest req)
        {
            return InternalRequestAsync<DescribeInstancePackageListResponse>(req, "DescribeInstancePackageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询监控器详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeMonitorDetailResponse"/></returns>
        public Task<DescribeMonitorDetailResponse> DescribeMonitorDetail(DescribeMonitorDetailRequest req)
        {
            return InternalRequestAsync<DescribeMonitorDetailResponse>(req, "DescribeMonitorDetail");
        }

        /// <summary>
        /// 查询监控器详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeMonitorDetailResponse"/></returns>
        public DescribeMonitorDetailResponse DescribeMonitorDetailSync(DescribeMonitorDetailRequest req)
        {
            return InternalRequestAsync<DescribeMonitorDetailResponse>(req, "DescribeMonitorDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取所有监控器
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsRequest"/></param>
        /// <returns><see cref="DescribeMonitorsResponse"/></returns>
        public Task<DescribeMonitorsResponse> DescribeMonitors(DescribeMonitorsRequest req)
        {
            return InternalRequestAsync<DescribeMonitorsResponse>(req, "DescribeMonitors");
        }

        /// <summary>
        /// 获取所有监控器
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorsRequest"/></param>
        /// <returns><see cref="DescribeMonitorsResponse"/></returns>
        public DescribeMonitorsResponse DescribeMonitorsSync(DescribeMonitorsRequest req)
        {
            return InternalRequestAsync<DescribeMonitorsResponse>(req, "DescribeMonitors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配额查询
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotasRequest"/></param>
        /// <returns><see cref="DescribeQuotasResponse"/></returns>
        public Task<DescribeQuotasResponse> DescribeQuotas(DescribeQuotasRequest req)
        {
            return InternalRequestAsync<DescribeQuotasResponse>(req, "DescribeQuotas");
        }

        /// <summary>
        /// 配额查询
        /// </summary>
        /// <param name="req"><see cref="DescribeQuotasRequest"/></param>
        /// <returns><see cref="DescribeQuotasResponse"/></returns>
        public DescribeQuotasResponse DescribeQuotasSync(DescribeQuotasRequest req)
        {
            return InternalRequestAsync<DescribeQuotasResponse>(req, "DescribeQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeStrategyDetailResponse"/></returns>
        public Task<DescribeStrategyDetailResponse> DescribeStrategyDetail(DescribeStrategyDetailRequest req)
        {
            return InternalRequestAsync<DescribeStrategyDetailResponse>(req, "DescribeStrategyDetail");
        }

        /// <summary>
        /// 策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyDetailRequest"/></param>
        /// <returns><see cref="DescribeStrategyDetailResponse"/></returns>
        public DescribeStrategyDetailResponse DescribeStrategyDetailSync(DescribeStrategyDetailRequest req)
        {
            return InternalRequestAsync<DescribeStrategyDetailResponse>(req, "DescribeStrategyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 策略列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyListRequest"/></param>
        /// <returns><see cref="DescribeStrategyListResponse"/></returns>
        public Task<DescribeStrategyListResponse> DescribeStrategyList(DescribeStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeStrategyListResponse>(req, "DescribeStrategyList");
        }

        /// <summary>
        /// 策略列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyListRequest"/></param>
        /// <returns><see cref="DescribeStrategyListResponse"/></returns>
        public DescribeStrategyListResponse DescribeStrategyListSync(DescribeStrategyListRequest req)
        {
            return InternalRequestAsync<DescribeStrategyListResponse>(req, "DescribeStrategyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改地址池
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressPoolRequest"/></param>
        /// <returns><see cref="ModifyAddressPoolResponse"/></returns>
        public Task<ModifyAddressPoolResponse> ModifyAddressPool(ModifyAddressPoolRequest req)
        {
            return InternalRequestAsync<ModifyAddressPoolResponse>(req, "ModifyAddressPool");
        }

        /// <summary>
        /// 修改地址池
        /// </summary>
        /// <param name="req"><see cref="ModifyAddressPoolRequest"/></param>
        /// <returns><see cref="ModifyAddressPoolResponse"/></returns>
        public ModifyAddressPoolResponse ModifyAddressPoolSync(ModifyAddressPoolRequest req)
        {
            return InternalRequestAsync<ModifyAddressPoolResponse>(req, "ModifyAddressPool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例配置
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceConfigRequest"/></param>
        /// <returns><see cref="ModifyInstanceConfigResponse"/></returns>
        public Task<ModifyInstanceConfigResponse> ModifyInstanceConfig(ModifyInstanceConfigRequest req)
        {
            return InternalRequestAsync<ModifyInstanceConfigResponse>(req, "ModifyInstanceConfig");
        }

        /// <summary>
        /// 修改实例配置
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceConfigRequest"/></param>
        /// <returns><see cref="ModifyInstanceConfigResponse"/></returns>
        public ModifyInstanceConfigResponse ModifyInstanceConfigSync(ModifyInstanceConfigRequest req)
        {
            return InternalRequestAsync<ModifyInstanceConfigResponse>(req, "ModifyInstanceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改监控器
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorRequest"/></param>
        /// <returns><see cref="ModifyMonitorResponse"/></returns>
        public Task<ModifyMonitorResponse> ModifyMonitor(ModifyMonitorRequest req)
        {
            return InternalRequestAsync<ModifyMonitorResponse>(req, "ModifyMonitor");
        }

        /// <summary>
        /// 修改监控器
        /// </summary>
        /// <param name="req"><see cref="ModifyMonitorRequest"/></param>
        /// <returns><see cref="ModifyMonitorResponse"/></returns>
        public ModifyMonitorResponse ModifyMonitorSync(ModifyMonitorRequest req)
        {
            return InternalRequestAsync<ModifyMonitorResponse>(req, "ModifyMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改策略接口
        /// </summary>
        /// <param name="req"><see cref="ModifyStrategyRequest"/></param>
        /// <returns><see cref="ModifyStrategyResponse"/></returns>
        public Task<ModifyStrategyResponse> ModifyStrategy(ModifyStrategyRequest req)
        {
            return InternalRequestAsync<ModifyStrategyResponse>(req, "ModifyStrategy");
        }

        /// <summary>
        /// 修改策略接口
        /// </summary>
        /// <param name="req"><see cref="ModifyStrategyRequest"/></param>
        /// <returns><see cref="ModifyStrategyResponse"/></returns>
        public ModifyStrategyResponse ModifyStrategySync(ModifyStrategyRequest req)
        {
            return InternalRequestAsync<ModifyStrategyResponse>(req, "ModifyStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
