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

namespace TencentCloud.Lcic.V20220817
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lcic.V20220817.Models;

   public class LcicClient : AbstractClient{

       private const string endpoint = "lcic.tencentcloudapi.com";
       private const string version = "2022-08-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LcicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LcicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 如果批量注册的用户已存在，则会被覆盖。一次最多注册1000个用户。默认请求频率限制：10次/秒
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public async Task<BatchRegisterResponse> BatchRegister(BatchRegisterRequest req)
        {
             JsonResponseModel<BatchRegisterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchRegister");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如果批量注册的用户已存在，则会被覆盖。一次最多注册1000个用户。默认请求频率限制：10次/秒
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public BatchRegisterResponse BatchRegisterSync(BatchRegisterRequest req)
        {
             JsonResponseModel<BatchRegisterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchRegister");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定文档到房间
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public async Task<BindDocumentToRoomResponse> BindDocumentToRoom(BindDocumentToRoomRequest req)
        {
             JsonResponseModel<BindDocumentToRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDocumentToRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDocumentToRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定文档到房间
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public BindDocumentToRoomResponse BindDocumentToRoomSync(BindDocumentToRoomRequest req)
        {
             JsonResponseModel<BindDocumentToRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDocumentToRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDocumentToRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建房间内可以使用的文档。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public async Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建房间内可以使用的文档。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public CreateDocumentResponse CreateDocumentSync(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建房间
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public async Task<CreateRoomResponse> CreateRoom(CreateRoomRequest req)
        {
             JsonResponseModel<CreateRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建房间
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public CreateRoomResponse CreateRoomSync(CreateRoomRequest req)
        {
             JsonResponseModel<CreateRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建巡课
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public async Task<CreateSupervisorResponse> CreateSupervisor(CreateSupervisorRequest req)
        {
             JsonResponseModel<CreateSupervisorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSupervisor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSupervisorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建巡课
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public CreateSupervisorResponse CreateSupervisorSync(CreateSupervisorRequest req)
        {
             JsonResponseModel<CreateSupervisorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSupervisor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSupervisorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public async Task<DeleteRoomResponse> DeleteRoom(DeleteRoomRequest req)
        {
             JsonResponseModel<DeleteRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public DeleteRoomResponse DeleteRoomSync(DeleteRoomRequest req)
        {
             JsonResponseModel<DeleteRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDetailRequest"/></param>
        /// <returns><see cref="DescribeAppDetailResponse"/></returns>
        public async Task<DescribeAppDetailResponse> DescribeAppDetail(DescribeAppDetailRequest req)
        {
             JsonResponseModel<DescribeAppDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDetailRequest"/></param>
        /// <returns><see cref="DescribeAppDetailResponse"/></returns>
        public DescribeAppDetailResponse DescribeAppDetailSync(DescribeAppDetailRequest req)
        {
             JsonResponseModel<DescribeAppDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public async Task<DescribeRoomResponse> DescribeRoom(DescribeRoomRequest req)
        {
             JsonResponseModel<DescribeRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public DescribeRoomResponse DescribeRoomSync(DescribeRoomRequest req)
        {
             JsonResponseModel<DescribeRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间统计信息，仅可在房间结束后调用。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public async Task<DescribeRoomStatisticsResponse> DescribeRoomStatistics(DescribeRoomStatisticsRequest req)
        {
             JsonResponseModel<DescribeRoomStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间统计信息，仅可在房间结束后调用。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public DescribeRoomStatisticsResponse DescribeRoomStatisticsSync(DescribeRoomStatisticsRequest req)
        {
             JsonResponseModel<DescribeRoomStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public async Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用源账号登录，源账号为注册时填入的originId
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public async Task<LoginOriginIdResponse> LoginOriginId(LoginOriginIdRequest req)
        {
             JsonResponseModel<LoginOriginIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LoginOriginId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginOriginIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用源账号登录，源账号为注册时填入的originId
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public LoginOriginIdResponse LoginOriginIdSync(LoginOriginIdRequest req)
        {
             JsonResponseModel<LoginOriginIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LoginOriginId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginOriginIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public async Task<LoginUserResponse> LoginUser(LoginUserRequest req)
        {
             JsonResponseModel<LoginUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LoginUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public LoginUserResponse LoginUserSync(LoginUserRequest req)
        {
             JsonResponseModel<LoginUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LoginUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public async Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
             JsonResponseModel<ModifyAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
             JsonResponseModel<ModifyAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public async Task<ModifyRoomResponse> ModifyRoom(ModifyRoomRequest req)
        {
             JsonResponseModel<ModifyRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public ModifyRoomResponse ModifyRoomSync(ModifyRoomRequest req)
        {
             JsonResponseModel<ModifyRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest req)
        {
             JsonResponseModel<RegisterUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public RegisterUserResponse RegisterUserSync(RegisterUserRequest req)
        {
             JsonResponseModel<RegisterUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置应用的自定义内容，包括应用图标，自定义的代码等。如果已存在，则为更新。更新js、css内容后，要生效也需要调用该接口
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public async Task<SetAppCustomContentResponse> SetAppCustomContent(SetAppCustomContentRequest req)
        {
             JsonResponseModel<SetAppCustomContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAppCustomContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAppCustomContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置应用的自定义内容，包括应用图标，自定义的代码等。如果已存在，则为更新。更新js、css内容后，要生效也需要调用该接口
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public SetAppCustomContentResponse SetAppCustomContentSync(SetAppCustomContentRequest req)
        {
             JsonResponseModel<SetAppCustomContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAppCustomContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAppCustomContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文档从房间解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public async Task<UnbindDocumentFromRoomResponse> UnbindDocumentFromRoom(UnbindDocumentFromRoomRequest req)
        {
             JsonResponseModel<UnbindDocumentFromRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindDocumentFromRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDocumentFromRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文档从房间解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public UnbindDocumentFromRoomResponse UnbindDocumentFromRoomSync(UnbindDocumentFromRoomRequest req)
        {
             JsonResponseModel<UnbindDocumentFromRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindDocumentFromRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDocumentFromRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
