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
       private const string sdkVersion = "SDK_NET_3.0.1218";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcaplusdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 根据给定的表信息，清除表数据。
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
        public Task<ClearTablesResponse> ClearTables(ClearTablesRequest req)
        {
            return InternalRequestAsync<ClearTablesResponse>(req, "ClearTables");
        }

        /// <summary>
        /// 根据给定的表信息，清除表数据。
        /// </summary>
        /// <param name="req"><see cref="ClearTablesRequest"/></param>
        /// <returns><see cref="ClearTablesResponse"/></returns>
        public ClearTablesResponse ClearTablesSync(ClearTablesRequest req)
        {
            return InternalRequestAsync<ClearTablesResponse>(req, "ClearTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 选中目标表格，上传并校验改表文件，返回是否允许修改表格结构的结果。
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
        public Task<CompareIdlFilesResponse> CompareIdlFiles(CompareIdlFilesRequest req)
        {
            return InternalRequestAsync<CompareIdlFilesResponse>(req, "CompareIdlFiles");
        }

        /// <summary>
        /// 选中目标表格，上传并校验改表文件，返回是否允许修改表格结构的结果。
        /// </summary>
        /// <param name="req"><see cref="CompareIdlFilesRequest"/></param>
        /// <returns><see cref="CompareIdlFilesResponse"/></returns>
        public CompareIdlFilesResponse CompareIdlFilesSync(CompareIdlFilesRequest req)
        {
            return InternalRequestAsync<CompareIdlFilesResponse>(req, "CompareIdlFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户创建备份任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup");
        }

        /// <summary>
        /// 用户创建备份任务
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
            return InternalRequestAsync<CreateBackupResponse>(req, "CreateBackup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建TcaplusDB集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// 本接口用于创建TcaplusDB集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 构造表格过去时间点的快照
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotsRequest"/></param>
        /// <returns><see cref="CreateSnapshotsResponse"/></returns>
        public Task<CreateSnapshotsResponse> CreateSnapshots(CreateSnapshotsRequest req)
        {
            return InternalRequestAsync<CreateSnapshotsResponse>(req, "CreateSnapshots");
        }

        /// <summary>
        /// 构造表格过去时间点的快照
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotsRequest"/></param>
        /// <returns><see cref="CreateSnapshotsResponse"/></returns>
        public CreateSnapshotsResponse CreateSnapshotsSync(CreateSnapshotsRequest req)
        {
            return InternalRequestAsync<CreateSnapshotsResponse>(req, "CreateSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在TcaplusDB集群下创建表格组
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public Task<CreateTableGroupResponse> CreateTableGroup(CreateTableGroupRequest req)
        {
            return InternalRequestAsync<CreateTableGroupResponse>(req, "CreateTableGroup");
        }

        /// <summary>
        /// 在TcaplusDB集群下创建表格组
        /// </summary>
        /// <param name="req"><see cref="CreateTableGroupRequest"/></param>
        /// <returns><see cref="CreateTableGroupResponse"/></returns>
        public CreateTableGroupResponse CreateTableGroupSync(CreateTableGroupRequest req)
        {
            return InternalRequestAsync<CreateTableGroupResponse>(req, "CreateTableGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据选择的IDL文件列表，批量创建表格
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
        public Task<CreateTablesResponse> CreateTables(CreateTablesRequest req)
        {
            return InternalRequestAsync<CreateTablesResponse>(req, "CreateTables");
        }

        /// <summary>
        /// 根据选择的IDL文件列表，批量创建表格
        /// </summary>
        /// <param name="req"><see cref="CreateTablesRequest"/></param>
        /// <returns><see cref="CreateTablesResponse"/></returns>
        public CreateTablesResponse CreateTablesSync(CreateTablesRequest req)
        {
            return InternalRequestAsync<CreateTablesResponse>(req, "CreateTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除手工备份
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRecordsRequest"/></param>
        /// <returns><see cref="DeleteBackupRecordsResponse"/></returns>
        public Task<DeleteBackupRecordsResponse> DeleteBackupRecords(DeleteBackupRecordsRequest req)
        {
            return InternalRequestAsync<DeleteBackupRecordsResponse>(req, "DeleteBackupRecords");
        }

        /// <summary>
        /// 删除手工备份
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRecordsRequest"/></param>
        /// <returns><see cref="DeleteBackupRecordsResponse"/></returns>
        public DeleteBackupRecordsResponse DeleteBackupRecordsSync(DeleteBackupRecordsRequest req)
        {
            return InternalRequestAsync<DeleteBackupRecordsResponse>(req, "DeleteBackupRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除TcaplusDB集群，必须在集群所属所有资源（包括表格组，表）都已经释放的情况下才会成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 删除TcaplusDB集群，必须在集群所属所有资源（包括表格组，表）都已经释放的情况下才会成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 指定集群ID和待删除IDL文件的信息，删除目标文件，如果文件正在被表关联则删除失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
        public Task<DeleteIdlFilesResponse> DeleteIdlFiles(DeleteIdlFilesRequest req)
        {
            return InternalRequestAsync<DeleteIdlFilesResponse>(req, "DeleteIdlFiles");
        }

        /// <summary>
        /// 指定集群ID和待删除IDL文件的信息，删除目标文件，如果文件正在被表关联则删除失败。
        /// </summary>
        /// <param name="req"><see cref="DeleteIdlFilesRequest"/></param>
        /// <returns><see cref="DeleteIdlFilesResponse"/></returns>
        public DeleteIdlFilesResponse DeleteIdlFilesSync(DeleteIdlFilesRequest req)
        {
            return InternalRequestAsync<DeleteIdlFilesResponse>(req, "DeleteIdlFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除表格的快照
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots");
        }

        /// <summary>
        /// 删除表格的快照
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotsRequest"/></param>
        /// <returns><see cref="DeleteSnapshotsResponse"/></returns>
        public DeleteSnapshotsResponse DeleteSnapshotsSync(DeleteSnapshotsRequest req)
        {
            return InternalRequestAsync<DeleteSnapshotsResponse>(req, "DeleteSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除表格的数据订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteTableDataFlowRequest"/></param>
        /// <returns><see cref="DeleteTableDataFlowResponse"/></returns>
        public Task<DeleteTableDataFlowResponse> DeleteTableDataFlow(DeleteTableDataFlowRequest req)
        {
            return InternalRequestAsync<DeleteTableDataFlowResponse>(req, "DeleteTableDataFlow");
        }

        /// <summary>
        /// 删除表格的数据订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteTableDataFlowRequest"/></param>
        /// <returns><see cref="DeleteTableDataFlowResponse"/></returns>
        public DeleteTableDataFlowResponse DeleteTableDataFlowSync(DeleteTableDataFlowRequest req)
        {
            return InternalRequestAsync<DeleteTableDataFlowResponse>(req, "DeleteTableDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除表格组
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public Task<DeleteTableGroupResponse> DeleteTableGroup(DeleteTableGroupRequest req)
        {
            return InternalRequestAsync<DeleteTableGroupResponse>(req, "DeleteTableGroup");
        }

        /// <summary>
        /// 删除表格组
        /// </summary>
        /// <param name="req"><see cref="DeleteTableGroupRequest"/></param>
        /// <returns><see cref="DeleteTableGroupResponse"/></returns>
        public DeleteTableGroupResponse DeleteTableGroupSync(DeleteTableGroupRequest req)
        {
            return InternalRequestAsync<DeleteTableGroupResponse>(req, "DeleteTableGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除表格的分布式索引
        /// </summary>
        /// <param name="req"><see cref="DeleteTableIndexRequest"/></param>
        /// <returns><see cref="DeleteTableIndexResponse"/></returns>
        public Task<DeleteTableIndexResponse> DeleteTableIndex(DeleteTableIndexRequest req)
        {
            return InternalRequestAsync<DeleteTableIndexResponse>(req, "DeleteTableIndex");
        }

        /// <summary>
        /// 删除表格的分布式索引
        /// </summary>
        /// <param name="req"><see cref="DeleteTableIndexRequest"/></param>
        /// <returns><see cref="DeleteTableIndexResponse"/></returns>
        public DeleteTableIndexResponse DeleteTableIndexSync(DeleteTableIndexRequest req)
        {
            return InternalRequestAsync<DeleteTableIndexResponse>(req, "DeleteTableIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定的表,第一次调用此接口代表将表移动至回收站，再次调用代表将此表格从回收站中彻底删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
        public Task<DeleteTablesResponse> DeleteTables(DeleteTablesRequest req)
        {
            return InternalRequestAsync<DeleteTablesResponse>(req, "DeleteTables");
        }

        /// <summary>
        /// 删除指定的表,第一次调用此接口代表将表移动至回收站，再次调用代表将此表格从回收站中彻底删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteTablesRequest"/></param>
        /// <returns><see cref="DeleteTablesResponse"/></returns>
        public DeleteTablesResponse DeleteTablesSync(DeleteTablesRequest req)
        {
            return InternalRequestAsync<DeleteTablesResponse>(req, "DeleteTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取审批管理的申请单
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications");
        }

        /// <summary>
        /// 获取审批管理的申请单
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份记录
        /// 
        /// 查询集群级别时， 将TableGroupId设置为"-1", 将TableName设置为"-1"
        /// 查询集群+表格组级别时， 将TableName设置为"-1"
        /// 查询集群+表格组+表格级别时， 都不能设置为“-1”
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRecordsRequest"/></param>
        /// <returns><see cref="DescribeBackupRecordsResponse"/></returns>
        public Task<DescribeBackupRecordsResponse> DescribeBackupRecords(DescribeBackupRecordsRequest req)
        {
            return InternalRequestAsync<DescribeBackupRecordsResponse>(req, "DescribeBackupRecords");
        }

        /// <summary>
        /// 查询备份记录
        /// 
        /// 查询集群级别时， 将TableGroupId设置为"-1", 将TableName设置为"-1"
        /// 查询集群+表格组级别时， 将TableName设置为"-1"
        /// 查询集群+表格组+表格级别时， 都不能设置为“-1”
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupRecordsRequest"/></param>
        /// <returns><see cref="DescribeBackupRecordsResponse"/></returns>
        public DescribeBackupRecordsResponse DescribeBackupRecordsSync(DescribeBackupRecordsRequest req)
        {
            return InternalRequestAsync<DescribeBackupRecordsResponse>(req, "DescribeBackupRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTagsRequest"/></param>
        /// <returns><see cref="DescribeClusterTagsResponse"/></returns>
        public Task<DescribeClusterTagsResponse> DescribeClusterTags(DescribeClusterTagsRequest req)
        {
            return InternalRequestAsync<DescribeClusterTagsResponse>(req, "DescribeClusterTags");
        }

        /// <summary>
        /// 获取集群关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterTagsRequest"/></param>
        /// <returns><see cref="DescribeClusterTagsResponse"/></returns>
        public DescribeClusterTagsResponse DescribeClusterTagsSync(DescribeClusterTagsRequest req)
        {
            return InternalRequestAsync<DescribeClusterTagsResponse>(req, "DescribeClusterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TcaplusDB集群列表，包含集群详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 查询TcaplusDB集群列表，包含集群详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表描述文件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
        public Task<DescribeIdlFileInfosResponse> DescribeIdlFileInfos(DescribeIdlFileInfosRequest req)
        {
            return InternalRequestAsync<DescribeIdlFileInfosResponse>(req, "DescribeIdlFileInfos");
        }

        /// <summary>
        /// 查询表描述文件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeIdlFileInfosRequest"/></param>
        /// <returns><see cref="DescribeIdlFileInfosResponse"/></returns>
        public DescribeIdlFileInfosResponse DescribeIdlFileInfosSync(DescribeIdlFileInfosRequest req)
        {
            return InternalRequestAsync<DescribeIdlFileInfosResponse>(req, "DescribeIdlFileInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询独占集群可以申请的剩余机器
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRequest"/></param>
        /// <returns><see cref="DescribeMachineResponse"/></returns>
        public Task<DescribeMachineResponse> DescribeMachine(DescribeMachineRequest req)
        {
            return InternalRequestAsync<DescribeMachineResponse>(req, "DescribeMachine");
        }

        /// <summary>
        /// 查询独占集群可以申请的剩余机器
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineRequest"/></param>
        /// <returns><see cref="DescribeMachineResponse"/></returns>
        public DescribeMachineResponse DescribeMachineSync(DescribeMachineRequest req)
        {
            return InternalRequestAsync<DescribeMachineResponse>(req, "DescribeMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TcaplusDB服务支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 查询TcaplusDB服务支持的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
        }

        /// <summary>
        /// 查询快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取表格组关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupTagsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupTagsResponse"/></returns>
        public Task<DescribeTableGroupTagsResponse> DescribeTableGroupTags(DescribeTableGroupTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupTagsResponse>(req, "DescribeTableGroupTags");
        }

        /// <summary>
        /// 获取表格组关联的标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupTagsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupTagsResponse"/></returns>
        public DescribeTableGroupTagsResponse DescribeTableGroupTagsSync(DescribeTableGroupTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupTagsResponse>(req, "DescribeTableGroupTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表格组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public Task<DescribeTableGroupsResponse> DescribeTableGroups(DescribeTableGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupsResponse>(req, "DescribeTableGroups");
        }

        /// <summary>
        /// 查询表格组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTableGroupsRequest"/></param>
        /// <returns><see cref="DescribeTableGroupsResponse"/></returns>
        public DescribeTableGroupsResponse DescribeTableGroupsSync(DescribeTableGroupsRequest req)
        {
            return InternalRequestAsync<DescribeTableGroupsResponse>(req, "DescribeTableGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取表格标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTableTagsRequest"/></param>
        /// <returns><see cref="DescribeTableTagsResponse"/></returns>
        public Task<DescribeTableTagsResponse> DescribeTableTags(DescribeTableTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableTagsResponse>(req, "DescribeTableTags");
        }

        /// <summary>
        /// 获取表格标签
        /// </summary>
        /// <param name="req"><see cref="DescribeTableTagsRequest"/></param>
        /// <returns><see cref="DescribeTableTagsResponse"/></returns>
        public DescribeTableTagsResponse DescribeTableTagsSync(DescribeTableTagsRequest req)
        {
            return InternalRequestAsync<DescribeTableTagsResponse>(req, "DescribeTableTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// 查询表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询回收站中的表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
        public Task<DescribeTablesInRecycleResponse> DescribeTablesInRecycle(DescribeTablesInRecycleRequest req)
        {
            return InternalRequestAsync<DescribeTablesInRecycleResponse>(req, "DescribeTablesInRecycle");
        }

        /// <summary>
        /// 查询回收站中的表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesInRecycleRequest"/></param>
        /// <returns><see cref="DescribeTablesInRecycleResponse"/></returns>
        public DescribeTablesInRecycleResponse DescribeTablesInRecycleSync(DescribeTablesInRecycleRequest req)
        {
            return InternalRequestAsync<DescribeTablesInRecycleResponse>(req, "DescribeTablesInRecycle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询本用户是否在白名单中，控制是否能创建TDR类型的APP或表
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
        public Task<DescribeUinInWhitelistResponse> DescribeUinInWhitelist(DescribeUinInWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeUinInWhitelistResponse>(req, "DescribeUinInWhitelist");
        }

        /// <summary>
        /// 查询本用户是否在白名单中，控制是否能创建TDR类型的APP或表
        /// </summary>
        /// <param name="req"><see cref="DescribeUinInWhitelistRequest"/></param>
        /// <returns><see cref="DescribeUinInWhitelistResponse"/></returns>
        public DescribeUinInWhitelistResponse DescribeUinInWhitelistSync(DescribeUinInWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeUinInWhitelistResponse>(req, "DescribeUinInWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当restful api为关闭状态时，可以通过此接口关闭restful api
        /// </summary>
        /// <param name="req"><see cref="DisableRestProxyRequest"/></param>
        /// <returns><see cref="DisableRestProxyResponse"/></returns>
        public Task<DisableRestProxyResponse> DisableRestProxy(DisableRestProxyRequest req)
        {
            return InternalRequestAsync<DisableRestProxyResponse>(req, "DisableRestProxy");
        }

        /// <summary>
        /// 当restful api为关闭状态时，可以通过此接口关闭restful api
        /// </summary>
        /// <param name="req"><see cref="DisableRestProxyRequest"/></param>
        /// <returns><see cref="DisableRestProxyResponse"/></returns>
        public DisableRestProxyResponse DisableRestProxySync(DisableRestProxyRequest req)
        {
            return InternalRequestAsync<DisableRestProxyResponse>(req, "DisableRestProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 当restful api为关闭状态时，可以通过此接口开启restful api。
        /// </summary>
        /// <param name="req"><see cref="EnableRestProxyRequest"/></param>
        /// <returns><see cref="EnableRestProxyResponse"/></returns>
        public Task<EnableRestProxyResponse> EnableRestProxy(EnableRestProxyRequest req)
        {
            return InternalRequestAsync<EnableRestProxyResponse>(req, "EnableRestProxy");
        }

        /// <summary>
        /// 当restful api为关闭状态时，可以通过此接口开启restful api。
        /// </summary>
        /// <param name="req"><see cref="EnableRestProxyRequest"/></param>
        /// <returns><see cref="EnableRestProxyResponse"/></returns>
        public EnableRestProxyResponse EnableRestProxySync(EnableRestProxyRequest req)
        {
            return InternalRequestAsync<EnableRestProxyResponse>(req, "EnableRestProxy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将快照数据导入到新表或当前表
        /// </summary>
        /// <param name="req"><see cref="ImportSnapshotsRequest"/></param>
        /// <returns><see cref="ImportSnapshotsResponse"/></returns>
        public Task<ImportSnapshotsResponse> ImportSnapshots(ImportSnapshotsRequest req)
        {
            return InternalRequestAsync<ImportSnapshotsResponse>(req, "ImportSnapshots");
        }

        /// <summary>
        /// 将快照数据导入到新表或当前表
        /// </summary>
        /// <param name="req"><see cref="ImportSnapshotsRequest"/></param>
        /// <returns><see cref="ImportSnapshotsResponse"/></returns>
        public ImportSnapshotsResponse ImportSnapshotsSync(ImportSnapshotsRequest req)
        {
            return InternalRequestAsync<ImportSnapshotsResponse>(req, "ImportSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合并指定表格
        /// </summary>
        /// <param name="req"><see cref="MergeTablesDataRequest"/></param>
        /// <returns><see cref="MergeTablesDataResponse"/></returns>
        public Task<MergeTablesDataResponse> MergeTablesData(MergeTablesDataRequest req)
        {
            return InternalRequestAsync<MergeTablesDataResponse>(req, "MergeTablesData");
        }

        /// <summary>
        /// 合并指定表格
        /// </summary>
        /// <param name="req"><see cref="MergeTablesDataRequest"/></param>
        /// <returns><see cref="MergeTablesDataResponse"/></returns>
        public MergeTablesDataResponse MergeTablesDataSync(MergeTablesDataRequest req)
        {
            return InternalRequestAsync<MergeTablesDataResponse>(req, "MergeTablesData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群审批状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCensorshipRequest"/></param>
        /// <returns><see cref="ModifyCensorshipResponse"/></returns>
        public Task<ModifyCensorshipResponse> ModifyCensorship(ModifyCensorshipRequest req)
        {
            return InternalRequestAsync<ModifyCensorshipResponse>(req, "ModifyCensorship");
        }

        /// <summary>
        /// 修改集群审批状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCensorshipRequest"/></param>
        /// <returns><see cref="ModifyCensorshipResponse"/></returns>
        public ModifyCensorshipResponse ModifyCensorshipSync(ModifyCensorshipRequest req)
        {
            return InternalRequestAsync<ModifyCensorshipResponse>(req, "ModifyCensorship")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改独占集群机器
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public Task<ModifyClusterMachineResponse> ModifyClusterMachine(ModifyClusterMachineRequest req)
        {
            return InternalRequestAsync<ModifyClusterMachineResponse>(req, "ModifyClusterMachine");
        }

        /// <summary>
        /// 修改独占集群机器
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterMachineRequest"/></param>
        /// <returns><see cref="ModifyClusterMachineResponse"/></returns>
        public ModifyClusterMachineResponse ModifyClusterMachineSync(ModifyClusterMachineRequest req)
        {
            return InternalRequestAsync<ModifyClusterMachineResponse>(req, "ModifyClusterMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改指定的集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName");
        }

        /// <summary>
        /// 修改指定的集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改指定集群的密码，后台将在旧密码失效之前同时支持TcaplusDB SDK使用旧密码和新密码访问数据库。在旧密码失效之前不能提交新的密码修改请求，在旧密码失效之后不能提交修改旧密码过期时间的请求。
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public Task<ModifyClusterPasswordResponse> ModifyClusterPassword(ModifyClusterPasswordRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordResponse>(req, "ModifyClusterPassword");
        }

        /// <summary>
        /// 修改指定集群的密码，后台将在旧密码失效之前同时支持TcaplusDB SDK使用旧密码和新密码访问数据库。在旧密码失效之前不能提交新的密码修改请求，在旧密码失效之后不能提交修改旧密码过期时间的请求。
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPasswordRequest"/></param>
        /// <returns><see cref="ModifyClusterPasswordResponse"/></returns>
        public ModifyClusterPasswordResponse ModifyClusterPasswordSync(ModifyClusterPasswordRequest req)
        {
            return InternalRequestAsync<ModifyClusterPasswordResponse>(req, "ModifyClusterPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群标签
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public Task<ModifyClusterTagsResponse> ModifyClusterTags(ModifyClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyClusterTagsResponse>(req, "ModifyClusterTags");
        }

        /// <summary>
        /// 修改集群标签
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterTagsRequest"/></param>
        /// <returns><see cref="ModifyClusterTagsResponse"/></returns>
        public ModifyClusterTagsResponse ModifyClusterTagsSync(ModifyClusterTagsRequest req)
        {
            return InternalRequestAsync<ModifyClusterTagsResponse>(req, "ModifyClusterTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改表格快照的过期时间
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotsRequest"/></param>
        /// <returns><see cref="ModifySnapshotsResponse"/></returns>
        public Task<ModifySnapshotsResponse> ModifySnapshots(ModifySnapshotsRequest req)
        {
            return InternalRequestAsync<ModifySnapshotsResponse>(req, "ModifySnapshots");
        }

        /// <summary>
        /// 修改表格快照的过期时间
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotsRequest"/></param>
        /// <returns><see cref="ModifySnapshotsResponse"/></returns>
        public ModifySnapshotsResponse ModifySnapshotsSync(ModifySnapshotsRequest req)
        {
            return InternalRequestAsync<ModifySnapshotsResponse>(req, "ModifySnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改TcaplusDB表格组名称
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public Task<ModifyTableGroupNameResponse> ModifyTableGroupName(ModifyTableGroupNameRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupNameResponse>(req, "ModifyTableGroupName");
        }

        /// <summary>
        /// 修改TcaplusDB表格组名称
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupNameRequest"/></param>
        /// <returns><see cref="ModifyTableGroupNameResponse"/></returns>
        public ModifyTableGroupNameResponse ModifyTableGroupNameSync(ModifyTableGroupNameRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupNameResponse>(req, "ModifyTableGroupName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改表格组标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupTagsRequest"/></param>
        /// <returns><see cref="ModifyTableGroupTagsResponse"/></returns>
        public Task<ModifyTableGroupTagsResponse> ModifyTableGroupTags(ModifyTableGroupTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupTagsResponse>(req, "ModifyTableGroupTags");
        }

        /// <summary>
        /// 修改表格组标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableGroupTagsRequest"/></param>
        /// <returns><see cref="ModifyTableGroupTagsResponse"/></returns>
        public ModifyTableGroupTagsResponse ModifyTableGroupTagsSync(ModifyTableGroupTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableGroupTagsResponse>(req, "ModifyTableGroupTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改表备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
        public Task<ModifyTableMemosResponse> ModifyTableMemos(ModifyTableMemosRequest req)
        {
            return InternalRequestAsync<ModifyTableMemosResponse>(req, "ModifyTableMemos");
        }

        /// <summary>
        /// 修改表备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTableMemosRequest"/></param>
        /// <returns><see cref="ModifyTableMemosResponse"/></returns>
        public ModifyTableMemosResponse ModifyTableMemosSync(ModifyTableMemosRequest req)
        {
            return InternalRequestAsync<ModifyTableMemosResponse>(req, "ModifyTableMemos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 表格扩缩容
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
        public Task<ModifyTableQuotasResponse> ModifyTableQuotas(ModifyTableQuotasRequest req)
        {
            return InternalRequestAsync<ModifyTableQuotasResponse>(req, "ModifyTableQuotas");
        }

        /// <summary>
        /// 表格扩缩容
        /// </summary>
        /// <param name="req"><see cref="ModifyTableQuotasRequest"/></param>
        /// <returns><see cref="ModifyTableQuotasResponse"/></returns>
        public ModifyTableQuotasResponse ModifyTableQuotasSync(ModifyTableQuotasRequest req)
        {
            return InternalRequestAsync<ModifyTableQuotasResponse>(req, "ModifyTableQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改表格标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableTagsRequest"/></param>
        /// <returns><see cref="ModifyTableTagsResponse"/></returns>
        public Task<ModifyTableTagsResponse> ModifyTableTags(ModifyTableTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableTagsResponse>(req, "ModifyTableTags");
        }

        /// <summary>
        /// 修改表格标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTableTagsRequest"/></param>
        /// <returns><see cref="ModifyTableTagsResponse"/></returns>
        public ModifyTableTagsResponse ModifyTableTagsSync(ModifyTableTagsRequest req)
        {
            return InternalRequestAsync<ModifyTableTagsResponse>(req, "ModifyTableTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据用户选定的表定义IDL文件，批量修改指定的表
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
        public Task<ModifyTablesResponse> ModifyTables(ModifyTablesRequest req)
        {
            return InternalRequestAsync<ModifyTablesResponse>(req, "ModifyTables");
        }

        /// <summary>
        /// 根据用户选定的表定义IDL文件，批量修改指定的表
        /// </summary>
        /// <param name="req"><see cref="ModifyTablesRequest"/></param>
        /// <returns><see cref="ModifyTablesResponse"/></returns>
        public ModifyTablesResponse ModifyTablesSync(ModifyTablesRequest req)
        {
            return InternalRequestAsync<ModifyTablesResponse>(req, "ModifyTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复回收站中，用户自行删除的表。对欠费待释放的表无效。
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
        public Task<RecoverRecycleTablesResponse> RecoverRecycleTables(RecoverRecycleTablesRequest req)
        {
            return InternalRequestAsync<RecoverRecycleTablesResponse>(req, "RecoverRecycleTables");
        }

        /// <summary>
        /// 恢复回收站中，用户自行删除的表。对欠费待释放的表无效。
        /// </summary>
        /// <param name="req"><see cref="RecoverRecycleTablesRequest"/></param>
        /// <returns><see cref="RecoverRecycleTablesResponse"/></returns>
        public RecoverRecycleTablesResponse RecoverRecycleTablesSync(RecoverRecycleTablesRequest req)
        {
            return InternalRequestAsync<RecoverRecycleTablesResponse>(req, "RecoverRecycleTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 表格数据回档
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
        public Task<RollbackTablesResponse> RollbackTables(RollbackTablesRequest req)
        {
            return InternalRequestAsync<RollbackTablesResponse>(req, "RollbackTables");
        }

        /// <summary>
        /// 表格数据回档
        /// </summary>
        /// <param name="req"><see cref="RollbackTablesRequest"/></param>
        /// <returns><see cref="RollbackTablesResponse"/></returns>
        public RollbackTablesResponse RollbackTablesSync(RollbackTablesRequest req)
        {
            return InternalRequestAsync<RollbackTablesResponse>(req, "RollbackTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增、删除、修改备份过期策略， ClusterId必须为具体的集群Id（appid）
        /// </summary>
        /// <param name="req"><see cref="SetBackupExpireRuleRequest"/></param>
        /// <returns><see cref="SetBackupExpireRuleResponse"/></returns>
        public Task<SetBackupExpireRuleResponse> SetBackupExpireRule(SetBackupExpireRuleRequest req)
        {
            return InternalRequestAsync<SetBackupExpireRuleResponse>(req, "SetBackupExpireRule");
        }

        /// <summary>
        /// 新增、删除、修改备份过期策略， ClusterId必须为具体的集群Id（appid）
        /// </summary>
        /// <param name="req"><see cref="SetBackupExpireRuleRequest"/></param>
        /// <returns><see cref="SetBackupExpireRuleResponse"/></returns>
        public SetBackupExpireRuleResponse SetBackupExpireRuleSync(SetBackupExpireRuleRequest req)
        {
            return InternalRequestAsync<SetBackupExpireRuleResponse>(req, "SetBackupExpireRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增、修改表格数据订阅
        /// </summary>
        /// <param name="req"><see cref="SetTableDataFlowRequest"/></param>
        /// <returns><see cref="SetTableDataFlowResponse"/></returns>
        public Task<SetTableDataFlowResponse> SetTableDataFlow(SetTableDataFlowRequest req)
        {
            return InternalRequestAsync<SetTableDataFlowResponse>(req, "SetTableDataFlow");
        }

        /// <summary>
        /// 新增、修改表格数据订阅
        /// </summary>
        /// <param name="req"><see cref="SetTableDataFlowRequest"/></param>
        /// <returns><see cref="SetTableDataFlowResponse"/></returns>
        public SetTableDataFlowResponse SetTableDataFlowSync(SetTableDataFlowRequest req)
        {
            return InternalRequestAsync<SetTableDataFlowResponse>(req, "SetTableDataFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置表格分布式索引
        /// </summary>
        /// <param name="req"><see cref="SetTableIndexRequest"/></param>
        /// <returns><see cref="SetTableIndexResponse"/></returns>
        public Task<SetTableIndexResponse> SetTableIndex(SetTableIndexRequest req)
        {
            return InternalRequestAsync<SetTableIndexResponse>(req, "SetTableIndex");
        }

        /// <summary>
        /// 设置表格分布式索引
        /// </summary>
        /// <param name="req"><see cref="SetTableIndexRequest"/></param>
        /// <returns><see cref="SetTableIndexResponse"/></returns>
        public SetTableIndexResponse SetTableIndexSync(SetTableIndexRequest req)
        {
            return InternalRequestAsync<SetTableIndexResponse>(req, "SetTableIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新申请单状态
        /// </summary>
        /// <param name="req"><see cref="UpdateApplyRequest"/></param>
        /// <returns><see cref="UpdateApplyResponse"/></returns>
        public Task<UpdateApplyResponse> UpdateApply(UpdateApplyRequest req)
        {
            return InternalRequestAsync<UpdateApplyResponse>(req, "UpdateApply");
        }

        /// <summary>
        /// 更新申请单状态
        /// </summary>
        /// <param name="req"><see cref="UpdateApplyRequest"/></param>
        /// <returns><see cref="UpdateApplyResponse"/></returns>
        public UpdateApplyResponse UpdateApplySync(UpdateApplyRequest req)
        {
            return InternalRequestAsync<UpdateApplyResponse>(req, "UpdateApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传并校验创建表格文件，返回校验合法的表格定义
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
        public Task<VerifyIdlFilesResponse> VerifyIdlFiles(VerifyIdlFilesRequest req)
        {
            return InternalRequestAsync<VerifyIdlFilesResponse>(req, "VerifyIdlFiles");
        }

        /// <summary>
        /// 上传并校验创建表格文件，返回校验合法的表格定义
        /// </summary>
        /// <param name="req"><see cref="VerifyIdlFilesRequest"/></param>
        /// <returns><see cref="VerifyIdlFilesResponse"/></returns>
        public VerifyIdlFilesResponse VerifyIdlFilesSync(VerifyIdlFilesRequest req)
        {
            return InternalRequestAsync<VerifyIdlFilesResponse>(req, "VerifyIdlFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
