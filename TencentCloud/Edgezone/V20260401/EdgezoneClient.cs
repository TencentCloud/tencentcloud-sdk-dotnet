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

namespace TencentCloud.Edgezone.V20260401
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Edgezone.V20260401.Models;

   public class EdgezoneClient : AbstractClient{

       private const string endpoint = "edgezone.tencentcloudapi.com";
       private const string version = "2026-04-01";
       private const string sdkVersion = "SDK_NET_3.0.1508";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EdgezoneClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EdgezoneClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 从静态 IP 池为指定公网实例批量申请多个 Ip 地址（随机分配）。申请前需检查用户配额。
        /// 此接口仅适用于 `RouteMode=static` 的公网实例。BGP/OSPF 实例调用此接口将返回错误。
        /// </summary>
        /// <param name="req"><see cref="ApplyPublicIpsRequest"/></param>
        /// <returns><see cref="ApplyPublicIpsResponse"/></returns>
        public Task<ApplyPublicIpsResponse> ApplyPublicIps(ApplyPublicIpsRequest req)
        {
            return InternalRequestAsync<ApplyPublicIpsResponse>(req, "ApplyPublicIps");
        }

        /// <summary>
        /// 从静态 IP 池为指定公网实例批量申请多个 Ip 地址（随机分配）。申请前需检查用户配额。
        /// 此接口仅适用于 `RouteMode=static` 的公网实例。BGP/OSPF 实例调用此接口将返回错误。
        /// </summary>
        /// <param name="req"><see cref="ApplyPublicIpsRequest"/></param>
        /// <returns><see cref="ApplyPublicIpsResponse"/></returns>
        public ApplyPublicIpsResponse ApplyPublicIpsSync(ApplyPublicIpsRequest req)
        {
            return InternalRequestAsync<ApplyPublicIpsResponse>(req, "ApplyPublicIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通边缘节点计费服务。
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeServiceRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeServiceResponse"/></returns>
        public Task<CreateEdgeNodeServiceResponse> CreateEdgeNodeService(CreateEdgeNodeServiceRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeServiceResponse>(req, "CreateEdgeNodeService");
        }

        /// <summary>
        /// 开通边缘节点计费服务。
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeServiceRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeServiceResponse"/></returns>
        public CreateEdgeNodeServiceResponse CreateEdgeNodeServiceSync(CreateEdgeNodeServiceRequest req)
        {
            return InternalRequestAsync<CreateEdgeNodeServiceResponse>(req, "CreateEdgeNodeService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建物理机实例，系统自动分配物理机资源并完成装机。如果用户未在当前可用区开通计费，系统自动开通。支持并发分配物理机资源，异步执行网络分配和装机任务。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// 创建物理机实例，系统自动分配物理机资源并完成装机。如果用户未在当前可用区开通计费，系统自动开通。支持并发分配物理机资源，异步执行网络分配和装机任务。
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建私网实例，一个用户在一个可用区仅支持创建一个私网实例，网络地址由 Network（网络号）和 Mask（掩码位数）两个参数共同决定子网范围。Network 必须是三个 RFC 1918 私有地址段之一的合法网络地址：10.0.0.0/8、172.16.0.0/12 或 192.168.0.0/16，且 host 位必须全为 0（即Network 与 Mask 组合后不能有主机位被置位，例如 10.0.0.1/24 是非法的，应填 10.0.0.0/24）。Mask 的上限统一为 28，下限由所属地址段决定：10.x.x.x 段允许 8～28，172.16.x.x 段允许 12～28，192.168.x.x 段允许 16～28。
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePrivateNetworkInstanceResponse"/></returns>
        public Task<CreatePrivateNetworkInstanceResponse> CreatePrivateNetworkInstance(CreatePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePrivateNetworkInstanceResponse>(req, "CreatePrivateNetworkInstance");
        }

        /// <summary>
        /// 创建私网实例，一个用户在一个可用区仅支持创建一个私网实例，网络地址由 Network（网络号）和 Mask（掩码位数）两个参数共同决定子网范围。Network 必须是三个 RFC 1918 私有地址段之一的合法网络地址：10.0.0.0/8、172.16.0.0/12 或 192.168.0.0/16，且 host 位必须全为 0（即Network 与 Mask 组合后不能有主机位被置位，例如 10.0.0.1/24 是非法的，应填 10.0.0.0/24）。Mask 的上限统一为 28，下限由所属地址段决定：10.x.x.x 段允许 8～28，172.16.x.x 段允许 12～28，192.168.x.x 段允许 16～28。
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePrivateNetworkInstanceResponse"/></returns>
        public CreatePrivateNetworkInstanceResponse CreatePrivateNetworkInstanceSync(CreatePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePrivateNetworkInstanceResponse>(req, "CreatePrivateNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户输入可用区ID、公网实例名称、网络线路、路由模式以创建公网实例，一个用户在一个可用区仅支持创建一个公网实例
        /// 路由模式为 **静态** 的公网实例需要用户主动申请和释放公网IP
        /// 路由模式为 **OSPF、BGP** 的公网实例在创建时自动分配公网IP段，销毁时自动释放公网IP段
        /// </summary>
        /// <param name="req"><see cref="CreatePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePublicNetworkInstanceResponse"/></returns>
        public Task<CreatePublicNetworkInstanceResponse> CreatePublicNetworkInstance(CreatePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePublicNetworkInstanceResponse>(req, "CreatePublicNetworkInstance");
        }

        /// <summary>
        /// 用户输入可用区ID、公网实例名称、网络线路、路由模式以创建公网实例，一个用户在一个可用区仅支持创建一个公网实例
        /// 路由模式为 **静态** 的公网实例需要用户主动申请和释放公网IP
        /// 路由模式为 **OSPF、BGP** 的公网实例在创建时自动分配公网IP段，销毁时自动释放公网IP段
        /// </summary>
        /// <param name="req"><see cref="CreatePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="CreatePublicNetworkInstanceResponse"/></returns>
        public CreatePublicNetworkInstanceResponse CreatePublicNetworkInstanceSync(CreatePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<CreatePublicNetworkInstanceResponse>(req, "CreatePublicNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除私网实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePrivateNetworkInstanceResponse"/></returns>
        public Task<DeletePrivateNetworkInstanceResponse> DeletePrivateNetworkInstance(DeletePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePrivateNetworkInstanceResponse>(req, "DeletePrivateNetworkInstance");
        }

        /// <summary>
        /// 删除私网实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePrivateNetworkInstanceResponse"/></returns>
        public DeletePrivateNetworkInstanceResponse DeletePrivateNetworkInstanceSync(DeletePrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePrivateNetworkInstanceResponse>(req, "DeletePrivateNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改公网实例信息
        /// </summary>
        /// <param name="req"><see cref="DeletePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePublicNetworkInstanceResponse"/></returns>
        public Task<DeletePublicNetworkInstanceResponse> DeletePublicNetworkInstance(DeletePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePublicNetworkInstanceResponse>(req, "DeletePublicNetworkInstance");
        }

        /// <summary>
        /// 修改公网实例信息
        /// </summary>
        /// <param name="req"><see cref="DeletePublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="DeletePublicNetworkInstanceResponse"/></returns>
        public DeletePublicNetworkInstanceResponse DeletePublicNetworkInstanceSync(DeletePublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<DeletePublicNetworkInstanceResponse>(req, "DeletePublicNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据 AppId 查询账号下可用区维度的机型配额列表；若传入 Zone，则仅返回指定可用区下的机型配额；若不传，则返回账号下所有可用区的机型配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public Task<DescribeInstanceTypesResponse> DescribeInstanceTypes(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes");
        }

        /// <summary>
        /// 根据 AppId 查询账号下可用区维度的机型配额列表；若传入 Zone，则仅返回指定可用区下的机型配额；若不传，则返回账号下所有可用区的机型配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypesSync(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询物理机实例列表，支持按实例ID、实例名称、可用区、实例状态等条件筛选，并支持分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 查询物理机实例列表，支持按实例ID、实例名称、可用区、实例状态等条件筛选，并支持分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询私网实例，支持通过私网实例ID、私网实例名称、可用区ID等参数进行查询
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePrivateNetworkInstancesResponse"/></returns>
        public Task<DescribePrivateNetworkInstancesResponse> DescribePrivateNetworkInstances(DescribePrivateNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNetworkInstancesResponse>(req, "DescribePrivateNetworkInstances");
        }

        /// <summary>
        /// 查询私网实例，支持通过私网实例ID、私网实例名称、可用区ID等参数进行查询
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePrivateNetworkInstancesResponse"/></returns>
        public DescribePrivateNetworkInstancesResponse DescribePrivateNetworkInstancesSync(DescribePrivateNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrivateNetworkInstancesResponse>(req, "DescribePrivateNetworkInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户的公网Ip信息，对于路由模式为Static的公网实例，会返回所有已申请的公网Ip信息，对于路由模式为Ospf和Bgp的公网实例，会直接返回网段信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpsRequest"/></param>
        /// <returns><see cref="DescribePublicIpsResponse"/></returns>
        public Task<DescribePublicIpsResponse> DescribePublicIps(DescribePublicIpsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpsResponse>(req, "DescribePublicIps");
        }

        /// <summary>
        /// 查询用户的公网Ip信息，对于路由模式为Static的公网实例，会返回所有已申请的公网Ip信息，对于路由模式为Ospf和Bgp的公网实例，会直接返回网段信息
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpsRequest"/></param>
        /// <returns><see cref="DescribePublicIpsResponse"/></returns>
        public DescribePublicIpsResponse DescribePublicIpsSync(DescribePublicIpsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpsResponse>(req, "DescribePublicIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询公网实例列表，支持按实例ID、实例名称、可用区等条件筛选，并支持分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkInstancesResponse"/></returns>
        public Task<DescribePublicNetworkInstancesResponse> DescribePublicNetworkInstances(DescribePublicNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkInstancesResponse>(req, "DescribePublicNetworkInstances");
        }

        /// <summary>
        /// 查询公网实例列表，支持按实例ID、实例名称、可用区等条件筛选，并支持分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePublicNetworkInstancesRequest"/></param>
        /// <returns><see cref="DescribePublicNetworkInstancesResponse"/></returns>
        public DescribePublicNetworkInstancesResponse DescribePublicNetworkInstancesSync(DescribePublicNetworkInstancesRequest req)
        {
            return InternalRequestAsync<DescribePublicNetworkInstancesResponse>(req, "DescribePublicNetworkInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按指标名，查询统计数据。数据按1分钟间隔统计
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDataRequest"/></param>
        /// <returns><see cref="DescribeZoneDataResponse"/></returns>
        public Task<DescribeZoneDataResponse> DescribeZoneData(DescribeZoneDataRequest req)
        {
            return InternalRequestAsync<DescribeZoneDataResponse>(req, "DescribeZoneData");
        }

        /// <summary>
        /// 按指标名，查询统计数据。数据按1分钟间隔统计
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneDataRequest"/></param>
        /// <returns><see cref="DescribeZoneDataResponse"/></returns>
        public DescribeZoneDataResponse DescribeZoneDataSync(DescribeZoneDataRequest req)
        {
            return InternalRequestAsync<DescribeZoneDataResponse>(req, "DescribeZoneData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨地域聚合查询所有已配置 region 下的可用区列表。支持通过 FilterByAppId 参数控制是否按账号过滤：默认仅返回账号关联的可用区，设为 False 时返回所有可用区。本地域直查数据库，远程地域并发 HTTP 请求后合并返回。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones");
        }

        /// <summary>
        /// 跨地域聚合查询所有已配置 region 下的可用区列表。支持通过 FilterByAppId 参数控制是否按账号过滤：默认仅返回账号关联的可用区，设为 False 时返回所有可用区。本地域直查数据库，远程地域并发 HTTP 请求后合并返回。
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
            return InternalRequestAsync<DescribeZonesResponse>(req, "DescribeZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改物理机实例的属性，支持修改实例名称、变更公网IP（IPv4/IPv6）。InstanceName 和 NewPublicIp 至少传入一个。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributeResponse"/></returns>
        public Task<ModifyInstanceAttributeResponse> ModifyInstanceAttribute(ModifyInstanceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributeResponse>(req, "ModifyInstanceAttribute");
        }

        /// <summary>
        /// 修改物理机实例的属性，支持修改实例名称、变更公网IP（IPv4/IPv6）。InstanceName 和 NewPublicIp 至少传入一个。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstanceAttributeResponse"/></returns>
        public ModifyInstanceAttributeResponse ModifyInstanceAttributeSync(ModifyInstanceAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceAttributeResponse>(req, "ModifyInstanceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改私网实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPrivateNetworkInstanceResponse"/></returns>
        public Task<ModifyPrivateNetworkInstanceResponse> ModifyPrivateNetworkInstance(ModifyPrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNetworkInstanceResponse>(req, "ModifyPrivateNetworkInstance");
        }

        /// <summary>
        /// 修改私网实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPrivateNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPrivateNetworkInstanceResponse"/></returns>
        public ModifyPrivateNetworkInstanceResponse ModifyPrivateNetworkInstanceSync(ModifyPrivateNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPrivateNetworkInstanceResponse>(req, "ModifyPrivateNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改公网实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPublicNetworkInstanceResponse"/></returns>
        public Task<ModifyPublicNetworkInstanceResponse> ModifyPublicNetworkInstance(ModifyPublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPublicNetworkInstanceResponse>(req, "ModifyPublicNetworkInstance");
        }

        /// <summary>
        /// 修改公网实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyPublicNetworkInstanceRequest"/></param>
        /// <returns><see cref="ModifyPublicNetworkInstanceResponse"/></returns>
        public ModifyPublicNetworkInstanceResponse ModifyPublicNetworkInstanceSync(ModifyPublicNetworkInstanceRequest req)
        {
            return InternalRequestAsync<ModifyPublicNetworkInstanceResponse>(req, "ModifyPublicNetworkInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量释放已分配给 STATIC 公网实例但**未绑定物理服务器**的 IPv4 地址
        /// 此接口仅适用于 STATIC 模式实例。BGP/OSPF 实例的 CIDR 在实例删除时自动归还，无需手动释放单个 IP。
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicIpRequest"/></param>
        /// <returns><see cref="ReleasePublicIpResponse"/></returns>
        public Task<ReleasePublicIpResponse> ReleasePublicIp(ReleasePublicIpRequest req)
        {
            return InternalRequestAsync<ReleasePublicIpResponse>(req, "ReleasePublicIp");
        }

        /// <summary>
        /// 批量释放已分配给 STATIC 公网实例但**未绑定物理服务器**的 IPv4 地址
        /// 此接口仅适用于 STATIC 模式实例。BGP/OSPF 实例的 CIDR 在实例删除时自动归还，无需手动释放单个 IP。
        /// </summary>
        /// <param name="req"><see cref="ReleasePublicIpRequest"/></param>
        /// <returns><see cref="ReleasePublicIpResponse"/></returns>
        public ReleasePublicIpResponse ReleasePublicIpSync(ReleasePublicIpRequest req)
        {
            return InternalRequestAsync<ReleasePublicIpResponse>(req, "ReleasePublicIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁物理机实例，释放资源。接口同步释放网络资源（IP回收）并更新状态为 terminating，后台异步执行磁盘清理。支持部分成功。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// 销毁物理机实例，释放资源。接口同步释放网络资源（IP回收）并更新状态为 terminating，后台异步执行磁盘清理。支持部分成功。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
