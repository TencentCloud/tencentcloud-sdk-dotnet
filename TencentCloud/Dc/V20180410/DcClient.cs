/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public DcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public DcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接受专线通道申请
        /// </summary>
        /// <param name="req">参考<see cref="AcceptDirectConnectTunnelRequest"/></param>
        /// <returns>参考<see cref="AcceptDirectConnectTunnelResponse"/>实例</returns>
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
        /// 用于创建专线通道的接口
        /// </summary>
        /// <param name="req">参考<see cref="CreateDirectConnectTunnelRequest"/></param>
        /// <returns>参考<see cref="CreateDirectConnectTunnelResponse"/>实例</returns>
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
        /// 删除专线通道
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDirectConnectTunnelRequest"/></param>
        /// <returns>参考<see cref="DeleteDirectConnectTunnelResponse"/>实例</returns>
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
        /// 用于查询专线通道列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDirectConnectTunnelsRequest"/></param>
        /// <returns>参考<see cref="DescribeDirectConnectTunnelsResponse"/>实例</returns>
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
        /// 修改专线通道属性
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDirectConnectTunnelAttributeRequest"/></param>
        /// <returns>参考<see cref="ModifyDirectConnectTunnelAttributeResponse"/>实例</returns>
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
        /// 拒绝专线通道申请
        /// </summary>
        /// <param name="req">参考<see cref="RejectDirectConnectTunnelRequest"/></param>
        /// <returns>参考<see cref="RejectDirectConnectTunnelResponse"/>实例</returns>
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

    }
}
