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

namespace TencentCloud.Tcaplusdb.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcaplusdb.V20190823.Models;

   public class TcaplusdbClient : AbstractClient{

       private const string endpoint = "tcaplusdb.tencentcloudapi.com";
       private const string version = "2019-08-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcaplusdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcaplusdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 根据给定的表信息，清除表数据。
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
        public async Task<ClearTablesResponse> ClearTables(ClearTablesRequest req)
        {
             JsonResponseModel<ClearTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ClearTables接口的同步版本，根据给定的表信息，清除表数据。
        /// </summary>
        /// <param name="req">参考<see cref="ClearTablesRequest"/></param>
        /// <returns>参考<see cref="ClearTablesResponse"/>实例</returns>
        public ClearTablesResponse ClearTablesSync(ClearTablesRequest req)
        {
             JsonResponseModel<ClearTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 选中目标表，上传并校验改表文件，返回是否允许修改表结构
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
        public async Task<CompareIdlFilesResponse> CompareIdlFiles(CompareIdlFilesRequest req)
        {
             JsonResponseModel<CompareIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompareIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CompareIdlFiles接口的同步版本，选中目标表，上传并校验改表文件，返回是否允许修改表结构
        /// </summary>
        /// <param name="req">参考<see cref="CompareIdlFilesRequest"/></param>
        /// <returns>参考<see cref="CompareIdlFilesResponse"/>实例</returns>
        public CompareIdlFilesResponse CompareIdlFilesSync(CompareIdlFilesRequest req)
        {
             JsonResponseModel<CompareIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompareIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建TcaplusDB应用
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public async Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateApp接口的同步版本，本接口用于创建TcaplusDB应用
        /// </summary>
        /// <param name="req">参考<see cref="CreateAppRequest"/></param>
        /// <returns>参考<see cref="CreateAppResponse"/>实例</returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据选择的IDL文件列表，批量创建表
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
        public async Task<CreateTablesResponse> CreateTables(CreateTablesRequest req)
        {
             JsonResponseModel<CreateTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateTables接口的同步版本，根据选择的IDL文件列表，批量创建表
        /// </summary>
        /// <param name="req">参考<see cref="CreateTablesRequest"/></param>
        /// <returns>参考<see cref="CreateTablesResponse"/>实例</returns>
        public CreateTablesResponse CreateTablesSync(CreateTablesRequest req)
        {
             JsonResponseModel<CreateTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在TcaplusDB应用下创建大区
        /// </summary>
        /// <param name="req"><see cref="CreateZoneRequest"/></param>
        /// <returns><see cref="CreateZoneResponse"/></returns>
        public async Task<CreateZoneResponse> CreateZone(CreateZoneRequest req)
        {
             JsonResponseModel<CreateZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateZone接口的同步版本，在TcaplusDB应用下创建大区
        /// </summary>
        /// <param name="req">参考<see cref="CreateZoneRequest"/></param>
        /// <returns>参考<see cref="CreateZoneResponse"/>实例</returns>
        public CreateZoneResponse CreateZoneSync(CreateZoneRequest req)
        {
             JsonResponseModel<CreateZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除TcaplusDB应用实例，必须在应用实例所属所有资源（包括大区，表）都已经释放的情况下才会成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteAppRequest"/></param>
        /// <returns><see cref="DeleteAppResponse"/></returns>
        public async Task<DeleteAppResponse> DeleteApp(DeleteAppRequest req)
        {
             JsonResponseModel<DeleteAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteApp接口的同步版本，删除TcaplusDB应用实例，必须在应用实例所属所有资源（包括大区，表）都已经释放的情况下才会成功。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAppRequest"/></param>
        /// <returns>参考<see cref="DeleteAppResponse"/>实例</returns>
        public DeleteAppResponse DeleteAppSync(DeleteAppRequest req)
        {
             JsonResponseModel<DeleteAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定应用ID和待删除IDL文件的信息，删除目标文件，如果文件正在被表关联则删除失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
        public async Task<DeleteIdlFilesResponse> DeleteIdlFiles(DeleteIdlFilesRequest req)
        {
             JsonResponseModel<DeleteIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteIdlFiles接口的同步版本，指定应用ID和待删除IDL文件的信息，删除目标文件，如果文件正在被表关联则删除失败。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteIdlFilesRequest"/></param>
        /// <returns>参考<see cref="DeleteIdlFilesResponse"/>实例</returns>
        public DeleteIdlFilesResponse DeleteIdlFilesSync(DeleteIdlFilesRequest req)
        {
             JsonResponseModel<DeleteIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据指定的表信息删除目标表
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
        public async Task<DeleteTablesResponse> DeleteTables(DeleteTablesRequest req)
        {
             JsonResponseModel<DeleteTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteTables接口的同步版本，根据指定的表信息删除目标表
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTablesRequest"/></param>
        /// <returns>参考<see cref="DeleteTablesResponse"/>实例</returns>
        public DeleteTablesResponse DeleteTablesSync(DeleteTablesRequest req)
        {
             JsonResponseModel<DeleteTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除大区
        /// </summary>
        /// <param name="req"><see cref="DeleteZoneRequest"/></param>
        /// <returns><see cref="DeleteZoneResponse"/></returns>
        public async Task<DeleteZoneResponse> DeleteZone(DeleteZoneRequest req)
        {
             JsonResponseModel<DeleteZoneResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteZone接口的同步版本，删除大区
        /// </summary>
        /// <param name="req">参考<see cref="DeleteZoneRequest"/></param>
        /// <returns>参考<see cref="DeleteZoneResponse"/>实例</returns>
        public DeleteZoneResponse DeleteZoneSync(DeleteZoneRequest req)
        {
             JsonResponseModel<DeleteZoneResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteZone");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteZoneResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询TcaplusDB应用列表，包含应用详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAppsRequest"/></param>
        /// <returns><see cref="DescribeAppsResponse"/></returns>
        public async Task<DescribeAppsResponse> DescribeApps(DescribeAppsRequest req)
        {
             JsonResponseModel<DescribeAppsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeApps接口的同步版本，查询TcaplusDB应用列表，包含应用详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAppsRequest"/></param>
        /// <returns>参考<see cref="DescribeAppsResponse"/>实例</returns>
        public DescribeAppsResponse DescribeAppsSync(DescribeAppsRequest req)
        {
             JsonResponseModel<DescribeAppsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表描述文件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
        public async Task<DescribeIdlFileInfosResponse> DescribeIdlFileInfos(DescribeIdlFileInfosRequest req)
        {
             JsonResponseModel<DescribeIdlFileInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIdlFileInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdlFileInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIdlFileInfos接口的同步版本，查询表描述文件详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns>参考<see cref="DescribeIdlFileInfosResponse"/>实例</returns>
        public DescribeIdlFileInfosResponse DescribeIdlFileInfosSync(DescribeIdlFileInfosRequest req)
        {
             JsonResponseModel<DescribeIdlFileInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIdlFileInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIdlFileInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询TcaplusDB服务支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRegions接口的同步版本，查询TcaplusDB服务支持的地域列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeRegionsResponse"/>实例</returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public async Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTables接口的同步版本，查询表详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTablesRequest"/></param>
        /// <returns>参考<see cref="DescribeTablesResponse"/>实例</returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询回收站中的表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
        public async Task<DescribeTablesInRecycleResponse> DescribeTablesInRecycle(DescribeTablesInRecycleRequest req)
        {
             JsonResponseModel<DescribeTablesInRecycleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTablesInRecycle");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesInRecycleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTablesInRecycle接口的同步版本，查询回收站中的表详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns>参考<see cref="DescribeTablesInRecycleResponse"/>实例</returns>
        public DescribeTablesInRecycleResponse DescribeTablesInRecycleSync(DescribeTablesInRecycleRequest req)
        {
             JsonResponseModel<DescribeTablesInRecycleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTablesInRecycle");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesInRecycleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTasks接口的同步版本，查询任务列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribeTasksResponse"/>实例</returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本用户是否在白名单中，控制是否能创建TDR类型的APP或表
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
        public async Task<DescribeUinInWhitelistResponse> DescribeUinInWhitelist(DescribeUinInWhitelistRequest req)
        {
             JsonResponseModel<DescribeUinInWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUinInWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUinInWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUinInWhitelist接口的同步版本，查询本用户是否在白名单中，控制是否能创建TDR类型的APP或表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns>参考<see cref="DescribeUinInWhitelistResponse"/>实例</returns>
        public DescribeUinInWhitelistResponse DescribeUinInWhitelistSync(DescribeUinInWhitelistRequest req)
        {
             JsonResponseModel<DescribeUinInWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUinInWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUinInWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询大区列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeZones接口的同步版本，查询大区列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeZonesRequest"/></param>
        /// <returns>参考<see cref="DescribeZonesResponse"/>实例</returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定的应用名称
        /// </summary>
        /// <param name="req"><see cref="ModifyAppNameRequest"/></param>
        /// <returns><see cref="ModifyAppNameResponse"/></returns>
        public async Task<ModifyAppNameResponse> ModifyAppName(ModifyAppNameRequest req)
        {
             JsonResponseModel<ModifyAppNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAppName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAppName接口的同步版本，修改指定的应用名称
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAppNameRequest"/></param>
        /// <returns>参考<see cref="ModifyAppNameResponse"/>实例</returns>
        public ModifyAppNameResponse ModifyAppNameSync(ModifyAppNameRequest req)
        {
             JsonResponseModel<ModifyAppNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAppName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定AppInstanceId的实例密码，后台将在旧密码失效之前同时支持TcaplusDB SDK使用旧密码和新密码访问数据库。在旧密码失效之前不能提交新的密码修改请求，在旧密码失效之后不能提交修改旧密码过期时间的请求。
        /// </summary>
        /// <param name="req"><see cref="ModifyAppPasswordRequest"/></param>
        /// <returns><see cref="ModifyAppPasswordResponse"/></returns>
        public async Task<ModifyAppPasswordResponse> ModifyAppPassword(ModifyAppPasswordRequest req)
        {
             JsonResponseModel<ModifyAppPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAppPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyAppPassword接口的同步版本，修改指定AppInstanceId的实例密码，后台将在旧密码失效之前同时支持TcaplusDB SDK使用旧密码和新密码访问数据库。在旧密码失效之前不能提交新的密码修改请求，在旧密码失效之后不能提交修改旧密码过期时间的请求。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAppPasswordRequest"/></param>
        /// <returns>参考<see cref="ModifyAppPasswordResponse"/>实例</returns>
        public ModifyAppPasswordResponse ModifyAppPasswordSync(ModifyAppPasswordRequest req)
        {
             JsonResponseModel<ModifyAppPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAppPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改表备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
        public async Task<ModifyTableMemosResponse> ModifyTableMemos(ModifyTableMemosRequest req)
        {
             JsonResponseModel<ModifyTableMemosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableMemos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableMemosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTableMemos接口的同步版本，修改表备注信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTableMemosRequest"/></param>
        /// <returns>参考<see cref="ModifyTableMemosResponse"/>实例</returns>
        public ModifyTableMemosResponse ModifyTableMemosSync(ModifyTableMemosRequest req)
        {
             JsonResponseModel<ModifyTableMemosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableMemos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableMemosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 表扩缩容
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
        public async Task<ModifyTableQuotasResponse> ModifyTableQuotas(ModifyTableQuotasRequest req)
        {
             JsonResponseModel<ModifyTableQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTableQuotas接口的同步版本，表扩缩容
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTableQuotasRequest"/></param>
        /// <returns>参考<see cref="ModifyTableQuotasResponse"/>实例</returns>
        public ModifyTableQuotasResponse ModifyTableQuotasSync(ModifyTableQuotasRequest req)
        {
             JsonResponseModel<ModifyTableQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据用户选定的表定义IDL文件，批量修改指定的表
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
        public async Task<ModifyTablesResponse> ModifyTables(ModifyTablesRequest req)
        {
             JsonResponseModel<ModifyTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyTables接口的同步版本，根据用户选定的表定义IDL文件，批量修改指定的表
        /// </summary>
        /// <param name="req">参考<see cref="ModifyTablesRequest"/></param>
        /// <returns>参考<see cref="ModifyTablesResponse"/>实例</returns>
        public ModifyTablesResponse ModifyTablesSync(ModifyTablesRequest req)
        {
             JsonResponseModel<ModifyTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改TcaplusDB大区名称
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneNameRequest"/></param>
        /// <returns><see cref="ModifyZoneNameResponse"/></returns>
        public async Task<ModifyZoneNameResponse> ModifyZoneName(ModifyZoneNameRequest req)
        {
             JsonResponseModel<ModifyZoneNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyZoneName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyZoneName接口的同步版本，修改TcaplusDB大区名称
        /// </summary>
        /// <param name="req">参考<see cref="ModifyZoneNameRequest"/></param>
        /// <returns>参考<see cref="ModifyZoneNameResponse"/>实例</returns>
        public ModifyZoneNameResponse ModifyZoneNameSync(ModifyZoneNameRequest req)
        {
             JsonResponseModel<ModifyZoneNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyZoneName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyZoneNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 恢复回收站中，用户自行删除的表。对欠费待释放的表无效。
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
        public async Task<RecoverRecycleTablesResponse> RecoverRecycleTables(RecoverRecycleTablesRequest req)
        {
             JsonResponseModel<RecoverRecycleTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecoverRecycleTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverRecycleTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RecoverRecycleTables接口的同步版本，恢复回收站中，用户自行删除的表。对欠费待释放的表无效。
        /// </summary>
        /// <param name="req">参考<see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns>参考<see cref="RecoverRecycleTablesResponse"/>实例</returns>
        public RecoverRecycleTablesResponse RecoverRecycleTablesSync(RecoverRecycleTablesRequest req)
        {
             JsonResponseModel<RecoverRecycleTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecoverRecycleTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecoverRecycleTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 表数据回档
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
        public async Task<RollbackTablesResponse> RollbackTables(RollbackTablesRequest req)
        {
             JsonResponseModel<RollbackTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RollbackTables接口的同步版本，表数据回档
        /// </summary>
        /// <param name="req">参考<see cref="RollbackTablesRequest"/></param>
        /// <returns>参考<see cref="RollbackTablesResponse"/>实例</returns>
        public RollbackTablesResponse RollbackTablesSync(RollbackTablesRequest req)
        {
             JsonResponseModel<RollbackTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传并校验加表文件，返回校验合法的表定义
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
        public async Task<VerifyIdlFilesResponse> VerifyIdlFiles(VerifyIdlFilesRequest req)
        {
             JsonResponseModel<VerifyIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// VerifyIdlFiles接口的同步版本，上传并校验加表文件，返回校验合法的表定义
        /// </summary>
        /// <param name="req">参考<see cref="VerifyIdlFilesRequest"/></param>
        /// <returns>参考<see cref="VerifyIdlFilesResponse"/>实例</returns>
        public VerifyIdlFilesResponse VerifyIdlFilesSync(VerifyIdlFilesRequest req)
        {
             JsonResponseModel<VerifyIdlFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyIdlFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyIdlFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
