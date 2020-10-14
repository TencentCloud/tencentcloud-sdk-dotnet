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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 接受专用通道申请
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public async Task<AcceptDirectConnectTunnelResponse> AcceptDirectConnectTunnel(AcceptDirectConnectTunnelRequest req)
        {
             JsonResponseModel<AcceptDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AcceptDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接受专用通道申请
        /// </summary>
        /// <param name="req"><see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="AcceptDirectConnectTunnelResponse"/></returns>
        public AcceptDirectConnectTunnelResponse AcceptDirectConnectTunnelSync(AcceptDirectConnectTunnelRequest req)
        {
             JsonResponseModel<AcceptDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AcceptDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AcceptDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请物理专线接入。
        /// 调用该接口时，请注意：
        /// 账号要进行实名认证，否则不允许申请物理专线；
        /// 若账户下存在欠费状态的物理专线，则不能申请更多的物理专线。
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectRequest"/></param>
        /// <returns><see cref="CreateDirectConnectResponse"/></returns>
        public async Task<CreateDirectConnectResponse> CreateDirectConnect(CreateDirectConnectRequest req)
        {
             JsonResponseModel<CreateDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建专用通道的接口
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public async Task<CreateDirectConnectTunnelResponse> CreateDirectConnectTunnel(CreateDirectConnectTunnelRequest req)
        {
             JsonResponseModel<CreateDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建专用通道的接口
        /// </summary>
        /// <param name="req"><see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="CreateDirectConnectTunnelResponse"/></returns>
        public CreateDirectConnectTunnelResponse CreateDirectConnectTunnelSync(CreateDirectConnectTunnelRequest req)
        {
             JsonResponseModel<CreateDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除物理专线。
        /// 只能删除处于已连接状态的物理专线。
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public async Task<DeleteDirectConnectResponse> DeleteDirectConnect(DeleteDirectConnectRequest req)
        {
             JsonResponseModel<DeleteDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除物理专线。
        /// 只能删除处于已连接状态的物理专线。
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectResponse"/></returns>
        public DeleteDirectConnectResponse DeleteDirectConnectSync(DeleteDirectConnectRequest req)
        {
             JsonResponseModel<DeleteDirectConnectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnect");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除专用通道
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public async Task<DeleteDirectConnectTunnelResponse> DeleteDirectConnectTunnel(DeleteDirectConnectTunnelRequest req)
        {
             JsonResponseModel<DeleteDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除专用通道
        /// </summary>
        /// <param name="req"><see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="DeleteDirectConnectTunnelResponse"/></returns>
        public DeleteDirectConnectTunnelResponse DeleteDirectConnectTunnelSync(DeleteDirectConnectTunnelRequest req)
        {
             JsonResponseModel<DeleteDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询物理专线接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public async Task<DescribeAccessPointsResponse> DescribeAccessPoints(DescribeAccessPointsRequest req)
        {
             JsonResponseModel<DescribeAccessPointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询物理专线接入点
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessPointsRequest"/></param>
        /// <returns><see cref="DescribeAccessPointsResponse"/></returns>
        public DescribeAccessPointsResponse DescribeAccessPointsSync(DescribeAccessPointsRequest req)
        {
             JsonResponseModel<DescribeAccessPointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectTunnelExtra）用于查询专用通道扩展信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelExtraResponse"/></returns>
        public async Task<DescribeDirectConnectTunnelExtraResponse> DescribeDirectConnectTunnelExtra(DescribeDirectConnectTunnelExtraRequest req)
        {
             JsonResponseModel<DescribeDirectConnectTunnelExtraResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectTunnelExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectTunnelExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDirectConnectTunnelExtra）用于查询专用通道扩展信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelExtraResponse"/></returns>
        public DescribeDirectConnectTunnelExtraResponse DescribeDirectConnectTunnelExtraSync(DescribeDirectConnectTunnelExtraRequest req)
        {
             JsonResponseModel<DescribeDirectConnectTunnelExtraResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectTunnelExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectTunnelExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询专用通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public async Task<DescribeDirectConnectTunnelsResponse> DescribeDirectConnectTunnels(DescribeDirectConnectTunnelsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectTunnelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnectTunnels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectTunnelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询专用通道列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectTunnelsResponse"/></returns>
        public DescribeDirectConnectTunnelsResponse DescribeDirectConnectTunnelsSync(DescribeDirectConnectTunnelsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectTunnelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnectTunnels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectTunnelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询物理专线列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public async Task<DescribeDirectConnectsResponse> DescribeDirectConnects(DescribeDirectConnectsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDirectConnects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询物理专线列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDirectConnectsRequest"/></param>
        /// <returns><see cref="DescribeDirectConnectsResponse"/></returns>
        public DescribeDirectConnectsResponse DescribeDirectConnectsSync(DescribeDirectConnectsRequest req)
        {
             JsonResponseModel<DescribeDirectConnectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDirectConnects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDirectConnectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePublicDirectConnectTunnelRoutes）用于查询互联网通道路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicDirectConnectTunnelRoutesRequest"/></param>
        /// <returns><see cref="DescribePublicDirectConnectTunnelRoutesResponse"/></returns>
        public async Task<DescribePublicDirectConnectTunnelRoutesResponse> DescribePublicDirectConnectTunnelRoutes(DescribePublicDirectConnectTunnelRoutesRequest req)
        {
             JsonResponseModel<DescribePublicDirectConnectTunnelRoutesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicDirectConnectTunnelRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicDirectConnectTunnelRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePublicDirectConnectTunnelRoutes）用于查询互联网通道路由列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicDirectConnectTunnelRoutesRequest"/></param>
        /// <returns><see cref="DescribePublicDirectConnectTunnelRoutesResponse"/></returns>
        public DescribePublicDirectConnectTunnelRoutesResponse DescribePublicDirectConnectTunnelRoutesSync(DescribePublicDirectConnectTunnelRoutesRequest req)
        {
             JsonResponseModel<DescribePublicDirectConnectTunnelRoutesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicDirectConnectTunnelRoutes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicDirectConnectTunnelRoutesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改物理专线的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public async Task<ModifyDirectConnectAttributeResponse> ModifyDirectConnectAttribute(ModifyDirectConnectAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改物理专线的属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectAttributeResponse"/></returns>
        public ModifyDirectConnectAttributeResponse ModifyDirectConnectAttributeSync(ModifyDirectConnectAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDirectConnectAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改专用通道属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public async Task<ModifyDirectConnectTunnelAttributeResponse> ModifyDirectConnectTunnelAttribute(ModifyDirectConnectTunnelAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectTunnelAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改专用通道属性
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelAttributeResponse"/></returns>
        public ModifyDirectConnectTunnelAttributeResponse ModifyDirectConnectTunnelAttributeSync(ModifyDirectConnectTunnelAttributeRequest req)
        {
             JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDirectConnectTunnelAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectTunnelAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDirectConnectTunnelExtra）用于修改专用通道扩展信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelExtraResponse"/></returns>
        public async Task<ModifyDirectConnectTunnelExtraResponse> ModifyDirectConnectTunnelExtra(ModifyDirectConnectTunnelExtraRequest req)
        {
             JsonResponseModel<ModifyDirectConnectTunnelExtraResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDirectConnectTunnelExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectTunnelExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifyDirectConnectTunnelExtra）用于修改专用通道扩展信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDirectConnectTunnelExtraRequest"/></param>
        /// <returns><see cref="ModifyDirectConnectTunnelExtraResponse"/></returns>
        public ModifyDirectConnectTunnelExtraResponse ModifyDirectConnectTunnelExtraSync(ModifyDirectConnectTunnelExtraRequest req)
        {
             JsonResponseModel<ModifyDirectConnectTunnelExtraResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDirectConnectTunnelExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDirectConnectTunnelExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拒绝专用通道申请
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public async Task<RejectDirectConnectTunnelResponse> RejectDirectConnectTunnel(RejectDirectConnectTunnelRequest req)
        {
             JsonResponseModel<RejectDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RejectDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拒绝专用通道申请
        /// </summary>
        /// <param name="req"><see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns><see cref="RejectDirectConnectTunnelResponse"/></returns>
        public RejectDirectConnectTunnelResponse RejectDirectConnectTunnelSync(RejectDirectConnectTunnelRequest req)
        {
             JsonResponseModel<RejectDirectConnectTunnelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RejectDirectConnectTunnel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RejectDirectConnectTunnelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
