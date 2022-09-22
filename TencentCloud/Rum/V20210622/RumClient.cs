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

namespace TencentCloud.Rum.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rum.V20210622.Models;

   public class RumClient : AbstractClient{

       private const string endpoint = "rum.tencentcloudapi.com";
       private const string version = "2021-06-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RumClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RumClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 接口请求域名： rum.tencentcloudapi.com 。
        /// 
        /// 本接口用于创建日志下载任务
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public async Task<CreateLogExportResponse> CreateLogExport(CreateLogExportRequest req)
        {
             JsonResponseModel<CreateLogExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名： rum.tencentcloudapi.com 。
        /// 
        /// 本接口用于创建日志下载任务
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="CreateLogExportRequest"/></param>
        /// <returns><see cref="CreateLogExportResponse"/></returns>
        public CreateLogExportResponse CreateLogExportSync(CreateLogExportRequest req)
        {
             JsonResponseModel<CreateLogExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建离线日志监听，对应用户的离线日志将上报
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineLogConfigRequest"/></param>
        /// <returns><see cref="CreateOfflineLogConfigResponse"/></returns>
        public async Task<CreateOfflineLogConfigResponse> CreateOfflineLogConfig(CreateOfflineLogConfigRequest req)
        {
             JsonResponseModel<CreateOfflineLogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOfflineLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建离线日志监听，对应用户的离线日志将上报
        /// </summary>
        /// <param name="req"><see cref="CreateOfflineLogConfigRequest"/></param>
        /// <returns><see cref="CreateOfflineLogConfigResponse"/></returns>
        public CreateOfflineLogConfigResponse CreateOfflineLogConfigSync(CreateOfflineLogConfigRequest req)
        {
             JsonResponseModel<CreateOfflineLogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOfflineLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOfflineLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建项目（归属于某个团队）
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public async Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建项目（归属于某个团队）
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建对应项目的文件记录
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public async Task<CreateReleaseFileResponse> CreateReleaseFile(CreateReleaseFileRequest req)
        {
             JsonResponseModel<CreateReleaseFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReleaseFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReleaseFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建对应项目的文件记录
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public CreateReleaseFileResponse CreateReleaseFileSync(CreateReleaseFileRequest req)
        {
             JsonResponseModel<CreateReleaseFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReleaseFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReleaseFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 个人用户添加星标项目
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public async Task<CreateStarProjectResponse> CreateStarProject(CreateStarProjectRequest req)
        {
             JsonResponseModel<CreateStarProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStarProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStarProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 个人用户添加星标项目
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public CreateStarProjectResponse CreateStarProjectSync(CreateStarProjectRequest req)
        {
             JsonResponseModel<CreateStarProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStarProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStarProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Rum实例
        /// </summary>
        /// <param name="req"><see cref="CreateTawInstanceRequest"/></param>
        /// <returns><see cref="CreateTawInstanceResponse"/></returns>
        public async Task<CreateTawInstanceResponse> CreateTawInstance(CreateTawInstanceRequest req)
        {
             JsonResponseModel<CreateTawInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTawInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTawInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Rum实例
        /// </summary>
        /// <param name="req"><see cref="CreateTawInstanceRequest"/></param>
        /// <returns><see cref="CreateTawInstanceResponse"/></returns>
        public CreateTawInstanceResponse CreateTawInstanceSync(CreateTawInstanceRequest req)
        {
             JsonResponseModel<CreateTawInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTawInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTawInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建白名单
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public async Task<CreateWhitelistResponse> CreateWhitelist(CreateWhitelistRequest req)
        {
             JsonResponseModel<CreateWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建白名单
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public CreateWhitelistResponse CreateWhitelistSync(CreateWhitelistRequest req)
        {
             JsonResponseModel<CreateWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例，谨慎操作，不可恢复
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除实例，谨慎操作，不可恢复
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名： rum.tencentcloudapi.com 。
        /// 
        /// 本接口用于删除日志下载任务
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public async Task<DeleteLogExportResponse> DeleteLogExport(DeleteLogExportRequest req)
        {
             JsonResponseModel<DeleteLogExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名： rum.tencentcloudapi.com 。
        /// 
        /// 本接口用于删除日志下载任务
        /// 
        /// 默认接口请求频率限制：20次/秒。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogExportRequest"/></param>
        /// <returns><see cref="DeleteLogExportResponse"/></returns>
        public DeleteLogExportResponse DeleteLogExportSync(DeleteLogExportRequest req)
        {
             JsonResponseModel<DeleteLogExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除 rum 离线日志监听 - 对应用户的离线日志将不会上报
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogConfigRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogConfigResponse"/></returns>
        public async Task<DeleteOfflineLogConfigResponse> DeleteOfflineLogConfig(DeleteOfflineLogConfigRequest req)
        {
             JsonResponseModel<DeleteOfflineLogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOfflineLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOfflineLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除 rum 离线日志监听 - 对应用户的离线日志将不会上报
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogConfigRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogConfigResponse"/></returns>
        public DeleteOfflineLogConfigResponse DeleteOfflineLogConfigSync(DeleteOfflineLogConfigRequest req)
        {
             JsonResponseModel<DeleteOfflineLogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOfflineLogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOfflineLogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除对应的离线日志记录
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogRecordRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogRecordResponse"/></returns>
        public async Task<DeleteOfflineLogRecordResponse> DeleteOfflineLogRecord(DeleteOfflineLogRecordRequest req)
        {
             JsonResponseModel<DeleteOfflineLogRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteOfflineLogRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOfflineLogRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除对应的离线日志记录
        /// </summary>
        /// <param name="req"><see cref="DeleteOfflineLogRecordRequest"/></param>
        /// <returns><see cref="DeleteOfflineLogRecordResponse"/></returns>
        public DeleteOfflineLogRecordResponse DeleteOfflineLogRecordSync(DeleteOfflineLogRecordRequest req)
        {
             JsonResponseModel<DeleteOfflineLogRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteOfflineLogRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteOfflineLogRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除给定的 rum 的项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public async Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除给定的 rum 的项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
             JsonResponseModel<DeleteProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将对应 sourcemap 文件删除
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public async Task<DeleteReleaseFileResponse> DeleteReleaseFile(DeleteReleaseFileRequest req)
        {
             JsonResponseModel<DeleteReleaseFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReleaseFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReleaseFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将对应 sourcemap 文件删除
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public DeleteReleaseFileResponse DeleteReleaseFileSync(DeleteReleaseFileRequest req)
        {
             JsonResponseModel<DeleteReleaseFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReleaseFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReleaseFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户名下的星标项目
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public async Task<DeleteStarProjectResponse> DeleteStarProject(DeleteStarProjectRequest req)
        {
             JsonResponseModel<DeleteStarProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStarProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStarProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户名下的星标项目
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public DeleteStarProjectResponse DeleteStarProjectSync(DeleteStarProjectRequest req)
        {
             JsonResponseModel<DeleteStarProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStarProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStarProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public async Task<DeleteWhitelistResponse> DeleteWhitelist(DeleteWhitelistRequest req)
        {
             JsonResponseModel<DeleteWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public DeleteWhitelistResponse DeleteWhitelistSync(DeleteWhitelistRequest req)
        {
             JsonResponseModel<DeleteWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 转发monitor查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public async Task<DescribeDataResponse> DescribeData(DescribeDataRequest req)
        {
             JsonResponseModel<DescribeDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 转发monitor查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public DescribeDataResponse DescribeDataSync(DescribeDataRequest req)
        {
             JsonResponseModel<DescribeDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public async Task<DescribeDataCustomUrlResponse> DescribeDataCustomUrl(DescribeDataCustomUrlRequest req)
        {
             JsonResponseModel<DescribeDataCustomUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataCustomUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataCustomUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public DescribeDataCustomUrlResponse DescribeDataCustomUrlSync(DescribeDataCustomUrlRequest req)
        {
             JsonResponseModel<DescribeDataCustomUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataCustomUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataCustomUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public async Task<DescribeDataEventUrlResponse> DescribeDataEventUrl(DescribeDataEventUrlRequest req)
        {
             JsonResponseModel<DescribeDataEventUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataEventUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEventUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public DescribeDataEventUrlResponse DescribeDataEventUrlSync(DescribeDataEventUrlRequest req)
        {
             JsonResponseModel<DescribeDataEventUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataEventUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEventUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataFetchProject信息。已下线，请使用DescribeDataFetchUrl
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public async Task<DescribeDataFetchProjectResponse> DescribeDataFetchProject(DescribeDataFetchProjectRequest req)
        {
             JsonResponseModel<DescribeDataFetchProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataFetchProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataFetchProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataFetchProject信息。已下线，请使用DescribeDataFetchUrl
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public DescribeDataFetchProjectResponse DescribeDataFetchProjectSync(DescribeDataFetchProjectRequest req)
        {
             JsonResponseModel<DescribeDataFetchProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataFetchProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataFetchProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public async Task<DescribeDataFetchUrlResponse> DescribeDataFetchUrl(DescribeDataFetchUrlRequest req)
        {
             JsonResponseModel<DescribeDataFetchUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataFetchUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataFetchUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public DescribeDataFetchUrlResponse DescribeDataFetchUrlSync(DescribeDataFetchUrlRequest req)
        {
             JsonResponseModel<DescribeDataFetchUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataFetchUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataFetchUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataFetchUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public async Task<DescribeDataFetchUrlInfoResponse> DescribeDataFetchUrlInfo(DescribeDataFetchUrlInfoRequest req)
        {
             JsonResponseModel<DescribeDataFetchUrlInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataFetchUrlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataFetchUrlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataFetchUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public DescribeDataFetchUrlInfoResponse DescribeDataFetchUrlInfoSync(DescribeDataFetchUrlInfoRequest req)
        {
             JsonResponseModel<DescribeDataFetchUrlInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataFetchUrlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataFetchUrlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取loginfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public async Task<DescribeDataLogUrlInfoResponse> DescribeDataLogUrlInfo(DescribeDataLogUrlInfoRequest req)
        {
             JsonResponseModel<DescribeDataLogUrlInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataLogUrlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataLogUrlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取loginfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public DescribeDataLogUrlInfoResponse DescribeDataLogUrlInfoSync(DescribeDataLogUrlInfoRequest req)
        {
             JsonResponseModel<DescribeDataLogUrlInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataLogUrlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataLogUrlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public async Task<DescribeDataLogUrlStatisticsResponse> DescribeDataLogUrlStatistics(DescribeDataLogUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataLogUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataLogUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataLogUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public DescribeDataLogUrlStatisticsResponse DescribeDataLogUrlStatisticsSync(DescribeDataLogUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataLogUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataLogUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataLogUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public async Task<DescribeDataPerformancePageResponse> DescribeDataPerformancePage(DescribeDataPerformancePageRequest req)
        {
             JsonResponseModel<DescribeDataPerformancePageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataPerformancePage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPerformancePageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public DescribeDataPerformancePageResponse DescribeDataPerformancePageSync(DescribeDataPerformancePageRequest req)
        {
             JsonResponseModel<DescribeDataPerformancePageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataPerformancePage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPerformancePageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PerformanceProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformanceProjectRequest"/></param>
        /// <returns><see cref="DescribeDataPerformanceProjectResponse"/></returns>
        public async Task<DescribeDataPerformanceProjectResponse> DescribeDataPerformanceProject(DescribeDataPerformanceProjectRequest req)
        {
             JsonResponseModel<DescribeDataPerformanceProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataPerformanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPerformanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PerformanceProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformanceProjectRequest"/></param>
        /// <returns><see cref="DescribeDataPerformanceProjectResponse"/></returns>
        public DescribeDataPerformanceProjectResponse DescribeDataPerformanceProjectSync(DescribeDataPerformanceProjectRequest req)
        {
             JsonResponseModel<DescribeDataPerformanceProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataPerformanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPerformanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PvUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public async Task<DescribeDataPvUrlInfoResponse> DescribeDataPvUrlInfo(DescribeDataPvUrlInfoRequest req)
        {
             JsonResponseModel<DescribeDataPvUrlInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataPvUrlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPvUrlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PvUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public DescribeDataPvUrlInfoResponse DescribeDataPvUrlInfoSync(DescribeDataPvUrlInfoRequest req)
        {
             JsonResponseModel<DescribeDataPvUrlInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataPvUrlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPvUrlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public async Task<DescribeDataPvUrlStatisticsResponse> DescribeDataPvUrlStatistics(DescribeDataPvUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataPvUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataPvUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPvUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public DescribeDataPvUrlStatisticsResponse DescribeDataPvUrlStatisticsSync(DescribeDataPvUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataPvUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataPvUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPvUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public async Task<DescribeDataReportCountResponse> DescribeDataReportCount(DescribeDataReportCountRequest req)
        {
             JsonResponseModel<DescribeDataReportCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataReportCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataReportCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public DescribeDataReportCountResponse DescribeDataReportCountSync(DescribeDataReportCountRequest req)
        {
             JsonResponseModel<DescribeDataReportCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataReportCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataReportCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public async Task<DescribeDataSetUrlStatisticsResponse> DescribeDataSetUrlStatistics(DescribeDataSetUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataSetUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataSetUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSetUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public DescribeDataSetUrlStatisticsResponse DescribeDataSetUrlStatisticsSync(DescribeDataSetUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataSetUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataSetUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataSetUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public async Task<DescribeDataStaticProjectResponse> DescribeDataStaticProject(DescribeDataStaticProjectRequest req)
        {
             JsonResponseModel<DescribeDataStaticProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataStaticProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataStaticProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public DescribeDataStaticProjectResponse DescribeDataStaticProjectSync(DescribeDataStaticProjectRequest req)
        {
             JsonResponseModel<DescribeDataStaticProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataStaticProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataStaticProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public async Task<DescribeDataStaticResourceResponse> DescribeDataStaticResource(DescribeDataStaticResourceRequest req)
        {
             JsonResponseModel<DescribeDataStaticResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataStaticResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataStaticResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public DescribeDataStaticResourceResponse DescribeDataStaticResourceSync(DescribeDataStaticResourceRequest req)
        {
             JsonResponseModel<DescribeDataStaticResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataStaticResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataStaticResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public async Task<DescribeDataStaticUrlResponse> DescribeDataStaticUrl(DescribeDataStaticUrlRequest req)
        {
             JsonResponseModel<DescribeDataStaticUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataStaticUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataStaticUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public DescribeDataStaticUrlResponse DescribeDataStaticUrlSync(DescribeDataStaticUrlRequest req)
        {
             JsonResponseModel<DescribeDataStaticUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataStaticUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataStaticUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public async Task<DescribeDataWebVitalsPageResponse> DescribeDataWebVitalsPage(DescribeDataWebVitalsPageRequest req)
        {
             JsonResponseModel<DescribeDataWebVitalsPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataWebVitalsPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataWebVitalsPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public DescribeDataWebVitalsPageResponse DescribeDataWebVitalsPageSync(DescribeDataWebVitalsPageRequest req)
        {
             JsonResponseModel<DescribeDataWebVitalsPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataWebVitalsPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataWebVitalsPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public async Task<DescribeErrorResponse> DescribeError(DescribeErrorRequest req)
        {
             JsonResponseModel<DescribeErrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public DescribeErrorResponse DescribeErrorSync(DescribeErrorRequest req)
        {
             JsonResponseModel<DescribeErrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名： rum.tencentcloudapi.com 。
        /// 
        /// 本接口用于获取日志下载任务列表
        /// 
        /// 默认接口请求频率限制：20次/秒
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public async Task<DescribeLogExportsResponse> DescribeLogExports(DescribeLogExportsRequest req)
        {
             JsonResponseModel<DescribeLogExportsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口请求域名： rum.tencentcloudapi.com 。
        /// 
        /// 本接口用于获取日志下载任务列表
        /// 
        /// 默认接口请求频率限制：20次/秒
        /// </summary>
        /// <param name="req"><see cref="DescribeLogExportsRequest"/></param>
        /// <returns><see cref="DescribeLogExportsResponse"/></returns>
        public DescribeLogExportsResponse DescribeLogExportsSync(DescribeLogExportsRequest req)
        {
             JsonResponseModel<DescribeLogExportsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeLogListRequest"/></param>
        /// <returns><see cref="DescribeLogListResponse"/></returns>
        public async Task<DescribeLogListResponse> DescribeLogList(DescribeLogListRequest req)
        {
             JsonResponseModel<DescribeLogListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeLogListRequest"/></param>
        /// <returns><see cref="DescribeLogListResponse"/></returns>
        public DescribeLogListResponse DescribeLogListSync(DescribeLogListRequest req)
        {
             JsonResponseModel<DescribeLogListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设置的离线日志监听配置 - 返回设置的用户唯一标识
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogConfigsResponse"/></returns>
        public async Task<DescribeOfflineLogConfigsResponse> DescribeOfflineLogConfigs(DescribeOfflineLogConfigsRequest req)
        {
             JsonResponseModel<DescribeOfflineLogConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineLogConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineLogConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取设置的离线日志监听配置 - 返回设置的用户唯一标识
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogConfigsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogConfigsResponse"/></returns>
        public DescribeOfflineLogConfigsResponse DescribeOfflineLogConfigsSync(DescribeOfflineLogConfigsRequest req)
        {
             JsonResponseModel<DescribeOfflineLogConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineLogConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineLogConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有离线日志记录(最多100条)
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogRecordsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogRecordsResponse"/></returns>
        public async Task<DescribeOfflineLogRecordsResponse> DescribeOfflineLogRecords(DescribeOfflineLogRecordsRequest req)
        {
             JsonResponseModel<DescribeOfflineLogRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineLogRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineLogRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取所有离线日志记录(最多100条)
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogRecordsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogRecordsResponse"/></returns>
        public DescribeOfflineLogRecordsResponse DescribeOfflineLogRecordsSync(DescribeOfflineLogRecordsRequest req)
        {
             JsonResponseModel<DescribeOfflineLogRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineLogRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineLogRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取对应离线日志
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogsResponse"/></returns>
        public async Task<DescribeOfflineLogsResponse> DescribeOfflineLogs(DescribeOfflineLogsRequest req)
        {
             JsonResponseModel<DescribeOfflineLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfflineLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取对应离线日志
        /// </summary>
        /// <param name="req"><see cref="DescribeOfflineLogsRequest"/></param>
        /// <returns><see cref="DescribeOfflineLogsResponse"/></returns>
        public DescribeOfflineLogsResponse DescribeOfflineLogsSync(DescribeOfflineLogsRequest req)
        {
             JsonResponseModel<DescribeOfflineLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfflineLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfflineLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目上报率列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public async Task<DescribeProjectLimitsResponse> DescribeProjectLimits(DescribeProjectLimitsRequest req)
        {
             JsonResponseModel<DescribeProjectLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目上报率列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public DescribeProjectLimitsResponse DescribeProjectLimitsSync(DescribeProjectLimitsRequest req)
        {
             JsonResponseModel<DescribeProjectLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目列表（实例创建的团队下的项目列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public async Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目列表（实例创建的团队下的项目列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的PV列表
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public async Task<DescribePvListResponse> DescribePvList(DescribePvListRequest req)
        {
             JsonResponseModel<DescribePvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的PV列表
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public DescribePvListResponse DescribePvListSync(DescribePvListRequest req)
        {
             JsonResponseModel<DescribePvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取上传文件存储的临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public async Task<DescribeReleaseFileSignResponse> DescribeReleaseFileSign(DescribeReleaseFileSignRequest req)
        {
             JsonResponseModel<DescribeReleaseFileSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReleaseFileSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReleaseFileSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取上传文件存储的临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public DescribeReleaseFileSignResponse DescribeReleaseFileSignSync(DescribeReleaseFileSignRequest req)
        {
             JsonResponseModel<DescribeReleaseFileSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReleaseFileSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReleaseFileSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目对应sourcemap文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public async Task<DescribeReleaseFilesResponse> DescribeReleaseFiles(DescribeReleaseFilesRequest req)
        {
             JsonResponseModel<DescribeReleaseFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReleaseFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReleaseFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目对应sourcemap文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public DescribeReleaseFilesResponse DescribeReleaseFilesSync(DescribeReleaseFilesRequest req)
        {
             JsonResponseModel<DescribeReleaseFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReleaseFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReleaseFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public async Task<DescribeScoresResponse> DescribeScores(DescribeScoresRequest req)
        {
             JsonResponseModel<DescribeScoresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScores");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScoresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public DescribeScoresResponse DescribeScoresSync(DescribeScoresRequest req)
        {
             JsonResponseModel<DescribeScoresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScores");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScoresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询片区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public async Task<DescribeTawAreasResponse> DescribeTawAreas(DescribeTawAreasRequest req)
        {
             JsonResponseModel<DescribeTawAreasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTawAreas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTawAreasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询片区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public DescribeTawAreasResponse DescribeTawAreasSync(DescribeTawAreasRequest req)
        {
             JsonResponseModel<DescribeTawAreasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTawAreas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTawAreasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawInstancesRequest"/></param>
        /// <returns><see cref="DescribeTawInstancesResponse"/></returns>
        public async Task<DescribeTawInstancesResponse> DescribeTawInstances(DescribeTawInstancesRequest req)
        {
             JsonResponseModel<DescribeTawInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTawInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTawInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawInstancesRequest"/></param>
        /// <returns><see cref="DescribeTawInstancesResponse"/></returns>
        public DescribeTawInstancesResponse DescribeTawInstancesSync(DescribeTawInstancesRequest req)
        {
             JsonResponseModel<DescribeTawInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTawInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTawInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的UV列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public async Task<DescribeUvListResponse> DescribeUvList(DescribeUvListRequest req)
        {
             JsonResponseModel<DescribeUvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的UV列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public DescribeUvListResponse DescribeUvListSync(DescribeUvListRequest req)
        {
             JsonResponseModel<DescribeUvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public async Task<DescribeWhitelistsResponse> DescribeWhitelists(DescribeWhitelistsRequest req)
        {
             JsonResponseModel<DescribeWhitelistsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWhitelists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhitelistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public DescribeWhitelistsResponse DescribeWhitelistsSync(DescribeWhitelistsRequest req)
        {
             JsonResponseModel<DescribeWhitelistsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWhitelists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWhitelistsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例信息
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 rum 项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public async Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 rum 项目信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
             JsonResponseModel<ModifyProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增修改限流
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public async Task<ModifyProjectLimitResponse> ModifyProjectLimit(ModifyProjectLimitRequest req)
        {
             JsonResponseModel<ModifyProjectLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProjectLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增修改限流
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public ModifyProjectLimitResponse ModifyProjectLimitSync(ModifyProjectLimitRequest req)
        {
             JsonResponseModel<ModifyProjectLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProjectLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProjectLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复实例
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public async Task<ResumeInstanceResponse> ResumeInstance(ResumeInstanceRequest req)
        {
             JsonResponseModel<ResumeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResumeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复实例
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public ResumeInstanceResponse ResumeInstanceSync(ResumeInstanceRequest req)
        {
             JsonResponseModel<ResumeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResumeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResumeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止实例
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public async Task<StopInstanceResponse> StopInstance(StopInstanceRequest req)
        {
             JsonResponseModel<StopInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止实例
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public StopInstanceResponse StopInstanceSync(StopInstanceRequest req)
        {
             JsonResponseModel<StopInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
