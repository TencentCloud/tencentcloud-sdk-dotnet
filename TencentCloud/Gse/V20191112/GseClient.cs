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

namespace TencentCloud.Gse.V20191112
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gse.V20191112.Models;

   public class GseClient : AbstractClient{

       private const string endpoint = "gse.tencentcloudapi.com";
       private const string version = "2019-11-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public async Task<CreateGameServerSessionResponse> CreateGameServerSession(CreateGameServerSessionRequest req)
        {
             JsonResponseModel<CreateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public CreateGameServerSessionResponse CreateGameServerSessionSync(CreateGameServerSessionRequest req)
        {
             JsonResponseModel<CreateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public async Task<DescribeGameServerSessionDetailsResponse> DescribeGameServerSessionDetails(DescribeGameServerSessionDetailsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGameServerSessionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public DescribeGameServerSessionDetailsResponse DescribeGameServerSessionDetailsSync(DescribeGameServerSessionDetailsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGameServerSessionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public async Task<DescribeGameServerSessionPlacementResponse> DescribeGameServerSessionPlacement(DescribeGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public DescribeGameServerSessionPlacementResponse DescribeGameServerSessionPlacementSync(DescribeGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public async Task<DescribeGameServerSessionsResponse> DescribeGameServerSessions(DescribeGameServerSessionsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGameServerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public DescribeGameServerSessionsResponse DescribeGameServerSessionsSync(DescribeGameServerSessionsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGameServerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询服务器实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询服务器实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public async Task<DescribePlayerSessionsResponse> DescribePlayerSessions(DescribePlayerSessionsRequest req)
        {
             JsonResponseModel<DescribePlayerSessionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlayerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public DescribePlayerSessionsResponse DescribePlayerSessionsSync(DescribePlayerSessionsRequest req)
        {
             JsonResponseModel<DescribePlayerSessionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlayerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public async Task<GetGameServerSessionLogUrlResponse> GetGameServerSessionLogUrl(GetGameServerSessionLogUrlRequest req)
        {
             JsonResponseModel<GetGameServerSessionLogUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGameServerSessionLogUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGameServerSessionLogUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public GetGameServerSessionLogUrlResponse GetGameServerSessionLogUrlSync(GetGameServerSessionLogUrlRequest req)
        {
             JsonResponseModel<GetGameServerSessionLogUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGameServerSessionLogUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGameServerSessionLogUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例登录所需要的凭据
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public async Task<GetInstanceAccessResponse> GetInstanceAccess(GetInstanceAccessRequest req)
        {
             JsonResponseModel<GetInstanceAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetInstanceAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInstanceAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例登录所需要的凭据
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public GetInstanceAccessResponse GetInstanceAccessSync(GetInstanceAccessRequest req)
        {
             JsonResponseModel<GetInstanceAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetInstanceAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInstanceAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public async Task<JoinGameServerSessionResponse> JoinGameServerSession(JoinGameServerSessionRequest req)
        {
             JsonResponseModel<JoinGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "JoinGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<JoinGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public JoinGameServerSessionResponse JoinGameServerSessionSync(JoinGameServerSessionRequest req)
        {
             JsonResponseModel<JoinGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "JoinGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<JoinGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public async Task<StartGameServerSessionPlacementResponse> StartGameServerSessionPlacement(StartGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StartGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public StartGameServerSessionPlacementResponse StartGameServerSessionPlacementSync(StartGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StartGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public async Task<StopGameServerSessionPlacementResponse> StopGameServerSessionPlacement(StopGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StopGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public StopGameServerSessionPlacementResponse StopGameServerSessionPlacementSync(StopGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StopGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public async Task<UpdateGameServerSessionResponse> UpdateGameServerSession(UpdateGameServerSessionRequest req)
        {
             JsonResponseModel<UpdateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public UpdateGameServerSessionResponse UpdateGameServerSessionSync(UpdateGameServerSessionRequest req)
        {
             JsonResponseModel<UpdateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
