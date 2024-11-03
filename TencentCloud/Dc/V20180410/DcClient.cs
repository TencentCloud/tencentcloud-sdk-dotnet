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

namespace TencentCloud.Dc.V20180410
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dc.V20180410.Models;

   public class DcClient : AbstractClient{

       private const string endpoint = "dc.tencentcloudapi.com";
       private const string version = "2018-04-10";
       private const string sdkVersion = "SDK_NET_3.0.1116";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 接受专用通道申请。
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public Task<AcceptDirectConnectTunnelResponse> AcceptDirectConnectTunnel(AcceptDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<AcceptDirectConnectTunnelResponse>(req, "AcceptDirectConnectTunnel");
        }

        /// <summary>
        /// 接受专用通道申请。
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public AcceptDirectConnectTunnelResponse AcceptDirectConnectTunnelSync(AcceptDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<AcceptDirectConnectTunnelResponse>(req, "AcceptDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请互联网CIDR地址
        /// </summary>
        /// <param name="req"><see cref="ApplyInternetAddressRequest"/></param>
        /// <returns><see cref="ApplyInternetAddressResponse"/></returns>
        public Task<ApplyInternetAddressResponse> ApplyInternetAddress(ApplyInternetAddressRequest req)
        {
            return InternalRequestAsync<ApplyInternetAddressResponse>(req, "ApplyInternetAddress");
        }

        /// <summary>
        /// 申请互联网CIDR地址
        /// </summary>
        /// <param name="req"><see cref="ApplyInternetAddressRequest"/></param>
        /// <returns><see cref="ApplyInternetAddressResponse"/></returns>
        public ApplyInternetAddressResponse ApplyInternetAddressSync(ApplyInternetAddressRequest req)
        {
            return InternalRequestAsync<ApplyInternetAddressResponse>(req, "ApplyInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建敏捷上云服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudAttachServiceRequest"/></param>
        /// <returns><see cref="CreateCloudAttachServiceResponse"/></returns>
        public Task<CreateCloudAttachServiceResponse> CreateCloudAttachService(CreateCloudAttachServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudAttachServiceResponse>(req, "CreateCloudAttachService");
        }

        /// <summary>
        /// 创建敏捷上云服务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudAttachServiceRequest"/></param>
        /// <returns><see cref="CreateCloudAttachServiceResponse"/></returns>
        public CreateCloudAttachServiceResponse CreateCloudAttachServiceSync(CreateCloudAttachServiceRequest req)
        {
            return InternalRequestAsync<CreateCloudAttachServiceResponse>(req, "CreateCloudAttachService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 申请物理专线接入。
        /// 调用该接口时，请注意：
        /// 账号要进行实名认证，否则不允许申请物理专线；
        /// 若账户下存在欠费状态的物理专线，则不能申请更多的物理专线。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectRequest"/></param>
        /// <returns><see cref="CreateDirectConnectResponse"/></returns>
        public Task<CreateDirectConnectResponse> CreateDirectConnect(CreateDirectConnectRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectResponse>(req, "CreateDirectConnect");
        }

        /// <summary>
        /// 申请物理专线接入。
        /// 调用该接口时，请注意：
        /// 账号要进行实名认证，否则不允许申请物理专线；
        /// 若账户下存在欠费状态的物理专线，则不能申请更多的物理专线。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectRequest"/></param>
        /// <returns><see cref="CreateDirectConnectResponse"/></returns>
        public CreateDirectConnectResponse CreateDirectConnectSync(CreateDirectConnectRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectResponse>(req, "CreateDirectConnect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建专用通道。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public Task<CreateDirectConnectTunnelResponse> CreateDirectConnectTunnel(CreateDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectTunnelResponse>(req, "CreateDirectConnectTunnel");
        }

        /// <summary>
        /// 创建专用通道。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public CreateDirectConnectTunnelResponse CreateDirectConnectTunnelSync(CreateDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<CreateDirectConnectTunnelResponse>(req, "CreateDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除物理专线。只能删除处于已连接状态的物理专线。
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public Task<DeleteDirectConnectResponse> DeleteDirectConnect(DeleteDirectConnectRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectResponse>(req, "DeleteDirectConnect");
        }

        /// <summary>
        /// 删除物理专线。只能删除处于已连接状态的物理专线。
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public DeleteDirectConnectResponse DeleteDirectConnectSync(DeleteDirectConnectRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectResponse>(req, "DeleteDirectConnect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除专用通道。
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public Task<DeleteDirectConnectTunnelResponse> DeleteDirectConnectTunnel(DeleteDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectTunnelResponse>(req, "DeleteDirectConnectTunnel");
        }

        /// <summary>
        /// 删除专用通道。
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public DeleteDirectConnectTunnelResponse DeleteDirectConnectTunnelSync(DeleteDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<DeleteDirectConnectTunnelResponse>(req, "DeleteDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询物理专线接入点。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public Task<DescribeAccessPointsResponse> DescribeAccessPoints(DescribeAccessPointsRequest req)
        {
            return InternalRequestAsync<DescribeAccessPointsResponse>(req, "DescribeAccessPoints");
        }

        /// <summary>
        /// 查询物理专线接入点。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public DescribeAccessPointsResponse DescribeAccessPointsSync(DescribeAccessPointsRequest req)
        {
            return InternalRequestAsync<DescribeAccessPointsResponse>(req, "DescribeAccessPoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询专用通道扩展信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelExtraResponse"/></returns>
        public Task<DescribeDirectConnectTunnelExtraResponse> DescribeDirectConnectTunnelExtra(DescribeDirectConnectTunnelExtraRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectTunnelExtraResponse>(req, "DescribeDirectConnectTunnelExtra");
        }

        /// <summary>
        /// 查询专用通道扩展信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelExtraResponse"/></returns>
        public DescribeDirectConnectTunnelExtraResponse DescribeDirectConnectTunnelExtraSync(DescribeDirectConnectTunnelExtraRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectTunnelExtraResponse>(req, "DescribeDirectConnectTunnelExtra")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询专用通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public Task<DescribeDirectConnectTunnelsResponse> DescribeDirectConnectTunnels(DescribeDirectConnectTunnelsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectTunnelsResponse>(req, "DescribeDirectConnectTunnels");
        }

        /// <summary>
        /// 查询专用通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public DescribeDirectConnectTunnelsResponse DescribeDirectConnectTunnelsSync(DescribeDirectConnectTunnelsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectTunnelsResponse>(req, "DescribeDirectConnectTunnels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询物理专线列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public Task<DescribeDirectConnectsResponse> DescribeDirectConnects(DescribeDirectConnectsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectsResponse>(req, "DescribeDirectConnects");
        }

        /// <summary>
        /// 查询物理专线列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public DescribeDirectConnectsResponse DescribeDirectConnectsSync(DescribeDirectConnectsRequest req)
        {
            return InternalRequestAsync<DescribeDirectConnectsResponse>(req, "DescribeDirectConnects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户互联网公网地址信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressResponse"/></returns>
        public Task<DescribeInternetAddressResponse> DescribeInternetAddress(DescribeInternetAddressRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressResponse>(req, "DescribeInternetAddress");
        }

        /// <summary>
        /// 获取用户互联网公网地址信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressResponse"/></returns>
        public DescribeInternetAddressResponse DescribeInternetAddressSync(DescribeInternetAddressRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressResponse>(req, "DescribeInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户互联网公网地址配额
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressQuotaResponse"/></returns>
        public Task<DescribeInternetAddressQuotaResponse> DescribeInternetAddressQuota(DescribeInternetAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressQuotaResponse>(req, "DescribeInternetAddressQuota");
        }

        /// <summary>
        /// 获取用户互联网公网地址配额
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressQuotaRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressQuotaResponse"/></returns>
        public DescribeInternetAddressQuotaResponse DescribeInternetAddressQuotaSync(DescribeInternetAddressQuotaRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressQuotaResponse>(req, "DescribeInternetAddressQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户互联网公网地址分配统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressStatisticsRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressStatisticsResponse"/></returns>
        public Task<DescribeInternetAddressStatisticsResponse> DescribeInternetAddressStatistics(DescribeInternetAddressStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressStatisticsResponse>(req, "DescribeInternetAddressStatistics");
        }

        /// <summary>
        /// 获取用户互联网公网地址分配统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInternetAddressStatisticsRequest"/></param>
        /// <returns><see cref="DescribeInternetAddressStatisticsResponse"/></returns>
        public DescribeInternetAddressStatisticsResponse DescribeInternetAddressStatisticsSync(DescribeInternetAddressStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeInternetAddressStatisticsResponse>(req, "DescribeInternetAddressStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribePublicDirectConnectTunnelRoutes）用于查询互联网通道路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicDirectConnectTunnelRoutesRequest"/></param>
        /// <returns><see cref="DescribePublicDirectConnectTunnelRoutesResponse"/></returns>
        public Task<DescribePublicDirectConnectTunnelRoutesResponse> DescribePublicDirectConnectTunnelRoutes(DescribePublicDirectConnectTunnelRoutesRequest req)
        {
            return InternalRequestAsync<DescribePublicDirectConnectTunnelRoutesResponse>(req, "DescribePublicDirectConnectTunnelRoutes");
        }

        /// <summary>
        /// 本接口（DescribePublicDirectConnectTunnelRoutes）用于查询互联网通道路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicDirectConnectTunnelRoutesRequest"/></param>
        /// <returns><see cref="DescribePublicDirectConnectTunnelRoutesResponse"/></returns>
        public DescribePublicDirectConnectTunnelRoutesResponse DescribePublicDirectConnectTunnelRoutesSync(DescribePublicDirectConnectTunnelRoutesRequest req)
        {
            return InternalRequestAsync<DescribePublicDirectConnectTunnelRoutesResponse>(req, "DescribePublicDirectConnectTunnelRoutes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停用用户申请的公网互联网地址
        /// </summary>
        /// <param name="req"><see cref="DisableInternetAddressRequest"/></param>
        /// <returns><see cref="DisableInternetAddressResponse"/></returns>
        public Task<DisableInternetAddressResponse> DisableInternetAddress(DisableInternetAddressRequest req)
        {
            return InternalRequestAsync<DisableInternetAddressResponse>(req, "DisableInternetAddress");
        }

        /// <summary>
        /// 停用用户申请的公网互联网地址
        /// </summary>
        /// <param name="req"><see cref="DisableInternetAddressRequest"/></param>
        /// <returns><see cref="DisableInternetAddressResponse"/></returns>
        public DisableInternetAddressResponse DisableInternetAddressSync(DisableInternetAddressRequest req)
        {
            return InternalRequestAsync<DisableInternetAddressResponse>(req, "DisableInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用已停用的互联网公网地址
        /// </summary>
        /// <param name="req"><see cref="EnableInternetAddressRequest"/></param>
        /// <returns><see cref="EnableInternetAddressResponse"/></returns>
        public Task<EnableInternetAddressResponse> EnableInternetAddress(EnableInternetAddressRequest req)
        {
            return InternalRequestAsync<EnableInternetAddressResponse>(req, "EnableInternetAddress");
        }

        /// <summary>
        /// 启用已停用的互联网公网地址
        /// </summary>
        /// <param name="req"><see cref="EnableInternetAddressRequest"/></param>
        /// <returns><see cref="EnableInternetAddressResponse"/></returns>
        public EnableInternetAddressResponse EnableInternetAddressSync(EnableInternetAddressRequest req)
        {
            return InternalRequestAsync<EnableInternetAddressResponse>(req, "EnableInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改物理专线的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public Task<ModifyDirectConnectAttributeResponse> ModifyDirectConnectAttribute(ModifyDirectConnectAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectAttributeResponse>(req, "ModifyDirectConnectAttribute");
        }

        /// <summary>
        /// 修改物理专线的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public ModifyDirectConnectAttributeResponse ModifyDirectConnectAttributeSync(ModifyDirectConnectAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectAttributeResponse>(req, "ModifyDirectConnectAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改专用通道属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public Task<ModifyDirectConnectTunnelAttributeResponse> ModifyDirectConnectTunnelAttribute(ModifyDirectConnectTunnelAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectTunnelAttributeResponse>(req, "ModifyDirectConnectTunnelAttribute");
        }

        /// <summary>
        /// 修改专用通道属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public ModifyDirectConnectTunnelAttributeResponse ModifyDirectConnectTunnelAttributeSync(ModifyDirectConnectTunnelAttributeRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectTunnelAttributeResponse>(req, "ModifyDirectConnectTunnelAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改专用通道扩展信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelExtraResponse"/></returns>
        public Task<ModifyDirectConnectTunnelExtraResponse> ModifyDirectConnectTunnelExtra(ModifyDirectConnectTunnelExtraRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectTunnelExtraResponse>(req, "ModifyDirectConnectTunnelExtra");
        }

        /// <summary>
        /// 修改专用通道扩展信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelExtraResponse"/></returns>
        public ModifyDirectConnectTunnelExtraResponse ModifyDirectConnectTunnelExtraSync(ModifyDirectConnectTunnelExtraRequest req)
        {
            return InternalRequestAsync<ModifyDirectConnectTunnelExtraResponse>(req, "ModifyDirectConnectTunnelExtra")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拒绝专用通道申请。
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public Task<RejectDirectConnectTunnelResponse> RejectDirectConnectTunnel(RejectDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<RejectDirectConnectTunnelResponse>(req, "RejectDirectConnectTunnel");
        }

        /// <summary>
        /// 拒绝专用通道申请。
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public RejectDirectConnectTunnelResponse RejectDirectConnectTunnelSync(RejectDirectConnectTunnelRequest req)
        {
            return InternalRequestAsync<RejectDirectConnectTunnelResponse>(req, "RejectDirectConnectTunnel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 释放已申请的互联网地址
        /// </summary>
        /// <param name="req"><see cref="ReleaseInternetAddressRequest"/></param>
        /// <returns><see cref="ReleaseInternetAddressResponse"/></returns>
        public Task<ReleaseInternetAddressResponse> ReleaseInternetAddress(ReleaseInternetAddressRequest req)
        {
            return InternalRequestAsync<ReleaseInternetAddressResponse>(req, "ReleaseInternetAddress");
        }

        /// <summary>
        /// 释放已申请的互联网地址
        /// </summary>
        /// <param name="req"><see cref="ReleaseInternetAddressRequest"/></param>
        /// <returns><see cref="ReleaseInternetAddressResponse"/></returns>
        public ReleaseInternetAddressResponse ReleaseInternetAddressSync(ReleaseInternetAddressRequest req)
        {
            return InternalRequestAsync<ReleaseInternetAddressResponse>(req, "ReleaseInternetAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
