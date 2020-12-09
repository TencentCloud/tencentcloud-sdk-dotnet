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
        /// 根据给定的表信息，清除表数据。
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
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
        /// 选中目标表格，上传并校验改表文件，返回是否允许修改表格结构的结果。
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
        /// 选中目标表格，上传并校验改表文件，返回是否允许修改表格结构的结果。
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
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
        /// 用户创建备份任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户创建备份任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建TcaplusDB集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public async Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建TcaplusDB集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
             JsonResponseModel<CreateClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在TcaplusDB集群下创建表格组
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public async Task<CreateTableGroupResponse> CreateTableGroup(CreateTableGroupRequest req)
        {
             JsonResponseModel<CreateTableGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在TcaplusDB集群下创建表格组
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public CreateTableGroupResponse CreateTableGroupSync(CreateTableGroupRequest req)
        {
             JsonResponseModel<CreateTableGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据选择的IDL文件列表，批量创建表格
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
        /// 根据选择的IDL文件列表，批量创建表格
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
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
        /// 删除TcaplusDB集群，必须在集群所属所有资源（包括表格组，表）都已经释放的情况下才会成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public async Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除TcaplusDB集群，必须在集群所属所有资源（包括表格组，表）都已经释放的情况下才会成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
             JsonResponseModel<DeleteClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定集群ID和待删除IDL文件的信息，删除目标文件，如果文件正在被表关联则删除失败。
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
        /// 指定集群ID和待删除IDL文件的信息，删除目标文件，如果文件正在被表关联则删除失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
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
        /// 删除表格组
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public async Task<DeleteTableGroupResponse> DeleteTableGroup(DeleteTableGroupRequest req)
        {
             JsonResponseModel<DeleteTableGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除表格组
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public DeleteTableGroupResponse DeleteTableGroupSync(DeleteTableGroupRequest req)
        {
             JsonResponseModel<DeleteTableGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTableGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除表格的分布式索引
        /// </summary>
        /// <param name="req"><see cref="DeleteTableIndexRequest"/></param>
        /// <returns><see cref="DeleteTableIndexResponse"/></returns>
        public async Task<DeleteTableIndexResponse> DeleteTableIndex(DeleteTableIndexRequest req)
        {
             JsonResponseModel<DeleteTableIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTableIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除表格的分布式索引
        /// </summary>
        /// <param name="req"><see cref="DeleteTableIndexRequest"/></param>
        /// <returns><see cref="DeleteTableIndexResponse"/></returns>
        public DeleteTableIndexResponse DeleteTableIndexSync(DeleteTableIndexRequest req)
        {
             JsonResponseModel<DeleteTableIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTableIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTableIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定的表,第一次调用此接口代表将表移动至回收站，再次调用代表将此表格从回收站中彻底删除。
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
        /// 删除指定的表,第一次调用此接口代表将表移动至回收站，再次调用代表将此表格从回收站中彻底删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
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
        /// 获取集群关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTagsRequest"/></param>
        /// <returns><see cref="DescribeClusterTagsResponse"/></returns>
        public async Task<DescribeClusterTagsResponse> DescribeClusterTags(DescribeClusterTagsRequest req)
        {
             JsonResponseModel<DescribeClusterTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取集群关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTagsRequest"/></param>
        /// <returns><see cref="DescribeClusterTagsResponse"/></returns>
        public DescribeClusterTagsResponse DescribeClusterTagsSync(DescribeClusterTagsRequest req)
        {
             JsonResponseModel<DescribeClusterTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询TcaplusDB集群列表，包含集群详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public async Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询TcaplusDB集群列表，包含集群详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
             JsonResponseModel<DescribeClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClustersResponse>>(strResp);
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
        /// 查询表描述文件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
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
        /// 查询独占集群可以申请的剩余机器
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRequest"/></param>
        /// <returns><see cref="DescribeMachineResponse"/></returns>
        public async Task<DescribeMachineResponse> DescribeMachine(DescribeMachineRequest req)
        {
             JsonResponseModel<DescribeMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询独占集群可以申请的剩余机器
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRequest"/></param>
        /// <returns><see cref="DescribeMachineResponse"/></returns>
        public DescribeMachineResponse DescribeMachineSync(DescribeMachineRequest req)
        {
             JsonResponseModel<DescribeMachineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineResponse>>(strResp);
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
        /// 查询TcaplusDB服务支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
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
        /// 获取表格组关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupTagsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupTagsResponse"/></returns>
        public async Task<DescribeTableGroupTagsResponse> DescribeTableGroupTags(DescribeTableGroupTagsRequest req)
        {
             JsonResponseModel<DescribeTableGroupTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableGroupTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableGroupTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取表格组关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupTagsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupTagsResponse"/></returns>
        public DescribeTableGroupTagsResponse DescribeTableGroupTagsSync(DescribeTableGroupTagsRequest req)
        {
             JsonResponseModel<DescribeTableGroupTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableGroupTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableGroupTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表格组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public async Task<DescribeTableGroupsResponse> DescribeTableGroups(DescribeTableGroupsRequest req)
        {
             JsonResponseModel<DescribeTableGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询表格组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public DescribeTableGroupsResponse DescribeTableGroupsSync(DescribeTableGroupsRequest req)
        {
             JsonResponseModel<DescribeTableGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取表格标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTableTagsRequest"/></param>
        /// <returns><see cref="DescribeTableTagsResponse"/></returns>
        public async Task<DescribeTableTagsResponse> DescribeTableTags(DescribeTableTagsRequest req)
        {
             JsonResponseModel<DescribeTableTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取表格标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTableTagsRequest"/></param>
        /// <returns><see cref="DescribeTableTagsResponse"/></returns>
        public DescribeTableTagsResponse DescribeTableTagsSync(DescribeTableTagsRequest req)
        {
             JsonResponseModel<DescribeTableTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableTagsResponse>>(strResp);
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
        /// 查询表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
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
        /// 查询回收站中的表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
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
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
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
        /// 查询本用户是否在白名单中，控制是否能创建TDR类型的APP或表
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
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
        /// 修改独占集群机器
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public async Task<ModifyClusterMachineResponse> ModifyClusterMachine(ModifyClusterMachineRequest req)
        {
             JsonResponseModel<ModifyClusterMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改独占集群机器
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public ModifyClusterMachineResponse ModifyClusterMachineSync(ModifyClusterMachineRequest req)
        {
             JsonResponseModel<ModifyClusterMachineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定的集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public async Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
             JsonResponseModel<ModifyClusterNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定的集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
             JsonResponseModel<ModifyClusterNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定集群的密码，后台将在旧密码失效之前同时支持TcaplusDB SDK使用旧密码和新密码访问数据库。在旧密码失效之前不能提交新的密码修改请求，在旧密码失效之后不能提交修改旧密码过期时间的请求。
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public async Task<ModifyClusterPasswordResponse> ModifyClusterPassword(ModifyClusterPasswordRequest req)
        {
             JsonResponseModel<ModifyClusterPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定集群的密码，后台将在旧密码失效之前同时支持TcaplusDB SDK使用旧密码和新密码访问数据库。在旧密码失效之前不能提交新的密码修改请求，在旧密码失效之后不能提交修改旧密码过期时间的请求。
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public ModifyClusterPasswordResponse ModifyClusterPasswordSync(ModifyClusterPasswordRequest req)
        {
             JsonResponseModel<ModifyClusterPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群标签
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public async Task<ModifyClusterTagsResponse> ModifyClusterTags(ModifyClusterTagsRequest req)
        {
             JsonResponseModel<ModifyClusterTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClusterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改集群标签
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public ModifyClusterTagsResponse ModifyClusterTagsSync(ModifyClusterTagsRequest req)
        {
             JsonResponseModel<ModifyClusterTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClusterTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClusterTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改TcaplusDB表格组名称
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public async Task<ModifyTableGroupNameResponse> ModifyTableGroupName(ModifyTableGroupNameRequest req)
        {
             JsonResponseModel<ModifyTableGroupNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableGroupName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableGroupNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改TcaplusDB表格组名称
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public ModifyTableGroupNameResponse ModifyTableGroupNameSync(ModifyTableGroupNameRequest req)
        {
             JsonResponseModel<ModifyTableGroupNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableGroupName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableGroupNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改表格组标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupTagsRequest"/></param>
        /// <returns><see cref="ModifyTableGroupTagsResponse"/></returns>
        public async Task<ModifyTableGroupTagsResponse> ModifyTableGroupTags(ModifyTableGroupTagsRequest req)
        {
             JsonResponseModel<ModifyTableGroupTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableGroupTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableGroupTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改表格组标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupTagsRequest"/></param>
        /// <returns><see cref="ModifyTableGroupTagsResponse"/></returns>
        public ModifyTableGroupTagsResponse ModifyTableGroupTagsSync(ModifyTableGroupTagsRequest req)
        {
             JsonResponseModel<ModifyTableGroupTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableGroupTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableGroupTagsResponse>>(strResp);
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
        /// 修改表备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
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
        /// 表格扩缩容
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
        /// 表格扩缩容
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
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
        /// 修改表格标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableTagsRequest"/></param>
        /// <returns><see cref="ModifyTableTagsResponse"/></returns>
        public async Task<ModifyTableTagsResponse> ModifyTableTags(ModifyTableTagsRequest req)
        {
             JsonResponseModel<ModifyTableTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改表格标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableTagsRequest"/></param>
        /// <returns><see cref="ModifyTableTagsResponse"/></returns>
        public ModifyTableTagsResponse ModifyTableTagsSync(ModifyTableTagsRequest req)
        {
             JsonResponseModel<ModifyTableTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableTagsResponse>>(strResp);
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
        /// 根据用户选定的表定义IDL文件，批量修改指定的表
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
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
        /// 恢复回收站中，用户自行删除的表。对欠费待释放的表无效。
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
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
        /// 表格数据回档
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
        /// 表格数据回档
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
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
        /// 设置表格分布式索引
        /// </summary>
        /// <param name="req"><see cref="SetTableIndexRequest"/></param>
        /// <returns><see cref="SetTableIndexResponse"/></returns>
        public async Task<SetTableIndexResponse> SetTableIndex(SetTableIndexRequest req)
        {
             JsonResponseModel<SetTableIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetTableIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTableIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置表格分布式索引
        /// </summary>
        /// <param name="req"><see cref="SetTableIndexRequest"/></param>
        /// <returns><see cref="SetTableIndexResponse"/></returns>
        public SetTableIndexResponse SetTableIndexSync(SetTableIndexRequest req)
        {
             JsonResponseModel<SetTableIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetTableIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetTableIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传并校验创建表格文件，返回校验合法的表格定义
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
        /// 上传并校验创建表格文件，返回校验合法的表格定义
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
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
