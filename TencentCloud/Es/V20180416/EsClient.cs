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

namespace TencentCloud.Es.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Es.V20180416.Models;

   public class EsClient : AbstractClient{

       private const string endpoint = "es.tencentcloudapi.com";
       private const string version = "2018-04-16";
       private const string sdkVersion = "SDK_NET_3.0.966";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 检查cos迁移索引元数据
        /// </summary>
        /// <param name="req"><see cref="CheckMigrateIndexMetaDataRequest"/></param>
        /// <returns><see cref="CheckMigrateIndexMetaDataResponse"/></returns>
        public Task<CheckMigrateIndexMetaDataResponse> CheckMigrateIndexMetaData(CheckMigrateIndexMetaDataRequest req)
        {
            return InternalRequestAsync<CheckMigrateIndexMetaDataResponse>(req, "CheckMigrateIndexMetaData");
        }

        /// <summary>
        /// 检查cos迁移索引元数据
        /// </summary>
        /// <param name="req"><see cref="CheckMigrateIndexMetaDataRequest"/></param>
        /// <returns><see cref="CheckMigrateIndexMetaDataResponse"/></returns>
        public CheckMigrateIndexMetaDataResponse CheckMigrateIndexMetaDataSync(CheckMigrateIndexMetaDataRequest req)
        {
            return InternalRequestAsync<CheckMigrateIndexMetaDataResponse>(req, "CheckMigrateIndexMetaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// cos迁移流程
        /// </summary>
        /// <param name="req"><see cref="CreateCosMigrateToServerlessInstanceRequest"/></param>
        /// <returns><see cref="CreateCosMigrateToServerlessInstanceResponse"/></returns>
        public Task<CreateCosMigrateToServerlessInstanceResponse> CreateCosMigrateToServerlessInstance(CreateCosMigrateToServerlessInstanceRequest req)
        {
            return InternalRequestAsync<CreateCosMigrateToServerlessInstanceResponse>(req, "CreateCosMigrateToServerlessInstance");
        }

        /// <summary>
        /// cos迁移流程
        /// </summary>
        /// <param name="req"><see cref="CreateCosMigrateToServerlessInstanceRequest"/></param>
        /// <returns><see cref="CreateCosMigrateToServerlessInstanceResponse"/></returns>
        public CreateCosMigrateToServerlessInstanceResponse CreateCosMigrateToServerlessInstanceSync(CreateCosMigrateToServerlessInstanceRequest req)
        {
            return InternalRequestAsync<CreateCosMigrateToServerlessInstanceResponse>(req, "CreateCosMigrateToServerlessInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex");
        }

        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建指定规格的ES集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// 创建指定规格的ES集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建Logstash实例
        /// </summary>
        /// <param name="req"><see cref="CreateLogstashInstanceRequest"/></param>
        /// <returns><see cref="CreateLogstashInstanceResponse"/></returns>
        public Task<CreateLogstashInstanceResponse> CreateLogstashInstance(CreateLogstashInstanceRequest req)
        {
            return InternalRequestAsync<CreateLogstashInstanceResponse>(req, "CreateLogstashInstance");
        }

        /// <summary>
        /// 用于创建Logstash实例
        /// </summary>
        /// <param name="req"><see cref="CreateLogstashInstanceRequest"/></param>
        /// <returns><see cref="CreateLogstashInstanceResponse"/></returns>
        public CreateLogstashInstanceResponse CreateLogstashInstanceSync(CreateLogstashInstanceRequest req)
        {
            return InternalRequestAsync<CreateLogstashInstanceResponse>(req, "CreateLogstashInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Serverless索引
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessInstanceResponse"/></returns>
        public Task<CreateServerlessInstanceResponse> CreateServerlessInstance(CreateServerlessInstanceRequest req)
        {
            return InternalRequestAsync<CreateServerlessInstanceResponse>(req, "CreateServerlessInstance");
        }

        /// <summary>
        /// 创建Serverless索引
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessInstanceResponse"/></returns>
        public CreateServerlessInstanceResponse CreateServerlessInstanceSync(CreateServerlessInstanceRequest req)
        {
            return InternalRequestAsync<CreateServerlessInstanceResponse>(req, "CreateServerlessInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Serverless索引空间
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessSpaceV2Request"/></param>
        /// <returns><see cref="CreateServerlessSpaceV2Response"/></returns>
        public Task<CreateServerlessSpaceV2Response> CreateServerlessSpaceV2(CreateServerlessSpaceV2Request req)
        {
            return InternalRequestAsync<CreateServerlessSpaceV2Response>(req, "CreateServerlessSpaceV2");
        }

        /// <summary>
        /// 创建Serverless索引空间
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessSpaceV2Request"/></param>
        /// <returns><see cref="CreateServerlessSpaceV2Response"/></returns>
        public CreateServerlessSpaceV2Response CreateServerlessSpaceV2Sync(CreateServerlessSpaceV2Request req)
        {
            return InternalRequestAsync<CreateServerlessSpaceV2Response>(req, "CreateServerlessSpaceV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除索引
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex");
        }

        /// <summary>
        /// 删除索引
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁集群实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// 销毁集群实例
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashInstanceRequest"/></param>
        /// <returns><see cref="DeleteLogstashInstanceResponse"/></returns>
        public Task<DeleteLogstashInstanceResponse> DeleteLogstashInstance(DeleteLogstashInstanceRequest req)
        {
            return InternalRequestAsync<DeleteLogstashInstanceResponse>(req, "DeleteLogstashInstance");
        }

        /// <summary>
        /// 用于删除Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashInstanceRequest"/></param>
        /// <returns><see cref="DeleteLogstashInstanceResponse"/></returns>
        public DeleteLogstashInstanceResponse DeleteLogstashInstanceSync(DeleteLogstashInstanceRequest req)
        {
            return InternalRequestAsync<DeleteLogstashInstanceResponse>(req, "DeleteLogstashInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量删除Logstash管道
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DeleteLogstashPipelinesResponse"/></returns>
        public Task<DeleteLogstashPipelinesResponse> DeleteLogstashPipelines(DeleteLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<DeleteLogstashPipelinesResponse>(req, "DeleteLogstashPipelines");
        }

        /// <summary>
        /// 用于批量删除Logstash管道
        /// </summary>
        /// <param name="req"><see cref="DeleteLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DeleteLogstashPipelinesResponse"/></returns>
        public DeleteLogstashPipelinesResponse DeleteLogstashPipelinesSync(DeleteLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<DeleteLogstashPipelinesResponse>(req, "DeleteLogstashPipelines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Serverless索引
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessInstanceResponse"/></returns>
        public Task<DeleteServerlessInstanceResponse> DeleteServerlessInstance(DeleteServerlessInstanceRequest req)
        {
            return InternalRequestAsync<DeleteServerlessInstanceResponse>(req, "DeleteServerlessInstance");
        }

        /// <summary>
        /// 删除Serverless索引
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessInstanceResponse"/></returns>
        public DeleteServerlessInstanceResponse DeleteServerlessInstanceSync(DeleteServerlessInstanceRequest req)
        {
            return InternalRequestAsync<DeleteServerlessInstanceResponse>(req, "DeleteServerlessInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Serverless空间子用户
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessSpaceUserRequest"/></param>
        /// <returns><see cref="DeleteServerlessSpaceUserResponse"/></returns>
        public Task<DeleteServerlessSpaceUserResponse> DeleteServerlessSpaceUser(DeleteServerlessSpaceUserRequest req)
        {
            return InternalRequestAsync<DeleteServerlessSpaceUserResponse>(req, "DeleteServerlessSpaceUser");
        }

        /// <summary>
        /// 删除Serverless空间子用户
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessSpaceUserRequest"/></param>
        /// <returns><see cref="DeleteServerlessSpaceUserResponse"/></returns>
        public DeleteServerlessSpaceUserResponse DeleteServerlessSpaceUserSync(DeleteServerlessSpaceUserRequest req)
        {
            return InternalRequestAsync<DeleteServerlessSpaceUserResponse>(req, "DeleteServerlessSpaceUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询智能运维诊断结果报告
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseResponse"/></returns>
        public Task<DescribeDiagnoseResponse> DescribeDiagnose(DescribeDiagnoseRequest req)
        {
            return InternalRequestAsync<DescribeDiagnoseResponse>(req, "DescribeDiagnose");
        }

        /// <summary>
        /// 查询智能运维诊断结果报告
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagnoseRequest"/></param>
        /// <returns><see cref="DescribeDiagnoseResponse"/></returns>
        public DescribeDiagnoseResponse DescribeDiagnoseSync(DescribeDiagnoseRequest req)
        {
            return InternalRequestAsync<DescribeDiagnoseResponse>(req, "DescribeDiagnose")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public Task<DescribeIndexListResponse> DescribeIndexList(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList");
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public DescribeIndexListResponse DescribeIndexListSync(DescribeIndexListRequest req)
        {
            return InternalRequestAsync<DescribeIndexListResponse>(req, "DescribeIndexList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取索引元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public Task<DescribeIndexMetaResponse> DescribeIndexMeta(DescribeIndexMetaRequest req)
        {
            return InternalRequestAsync<DescribeIndexMetaResponse>(req, "DescribeIndexMeta");
        }

        /// <summary>
        /// 获取索引元数据
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexMetaRequest"/></param>
        /// <returns><see cref="DescribeIndexMetaResponse"/></returns>
        public DescribeIndexMetaResponse DescribeIndexMetaSync(DescribeIndexMetaRequest req)
        {
            return InternalRequestAsync<DescribeIndexMetaResponse>(req, "DescribeIndexMeta")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户该地域下符合条件的ES集群的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs");
        }

        /// <summary>
        /// 查询用户该地域下符合条件的ES集群的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLogsResponse>(req, "DescribeInstanceLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations");
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePluginListRequest"/></param>
        /// <returns><see cref="DescribeInstancePluginListResponse"/></returns>
        public Task<DescribeInstancePluginListResponse> DescribeInstancePluginList(DescribeInstancePluginListRequest req)
        {
            return InternalRequestAsync<DescribeInstancePluginListResponse>(req, "DescribeInstancePluginList");
        }

        /// <summary>
        /// 查询实例插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancePluginListRequest"/></param>
        /// <returns><see cref="DescribeInstancePluginListResponse"/></returns>
        public DescribeInstancePluginListResponse DescribeInstancePluginListSync(DescribeInstancePluginListRequest req)
        {
            return InternalRequestAsync<DescribeInstancePluginListResponse>(req, "DescribeInstancePluginList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户该地域下符合条件的Logstash实例的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceLogsResponse"/></returns>
        public Task<DescribeLogstashInstanceLogsResponse> DescribeLogstashInstanceLogs(DescribeLogstashInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogstashInstanceLogsResponse>(req, "DescribeLogstashInstanceLogs");
        }

        /// <summary>
        /// 查询用户该地域下符合条件的Logstash实例的日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceLogsResponse"/></returns>
        public DescribeLogstashInstanceLogsResponse DescribeLogstashInstanceLogsSync(DescribeLogstashInstanceLogsRequest req)
        {
            return InternalRequestAsync<DescribeLogstashInstanceLogsResponse>(req, "DescribeLogstashInstanceLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceOperationsResponse"/></returns>
        public Task<DescribeLogstashInstanceOperationsResponse> DescribeLogstashInstanceOperations(DescribeLogstashInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeLogstashInstanceOperationsResponse>(req, "DescribeLogstashInstanceOperations");
        }

        /// <summary>
        /// 查询实例指定条件下的操作记录
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstanceOperationsResponse"/></returns>
        public DescribeLogstashInstanceOperationsResponse DescribeLogstashInstanceOperationsSync(DescribeLogstashInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeLogstashInstanceOperationsResponse>(req, "DescribeLogstashInstanceOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstancesRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstancesResponse"/></returns>
        public Task<DescribeLogstashInstancesResponse> DescribeLogstashInstances(DescribeLogstashInstancesRequest req)
        {
            return InternalRequestAsync<DescribeLogstashInstancesResponse>(req, "DescribeLogstashInstances");
        }

        /// <summary>
        /// 查询用户该地域下符合条件的所有Logstash实例
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashInstancesRequest"/></param>
        /// <returns><see cref="DescribeLogstashInstancesResponse"/></returns>
        public DescribeLogstashInstancesResponse DescribeLogstashInstancesSync(DescribeLogstashInstancesRequest req)
        {
            return InternalRequestAsync<DescribeLogstashInstancesResponse>(req, "DescribeLogstashInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于获取Logstash实例管道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DescribeLogstashPipelinesResponse"/></returns>
        public Task<DescribeLogstashPipelinesResponse> DescribeLogstashPipelines(DescribeLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<DescribeLogstashPipelinesResponse>(req, "DescribeLogstashPipelines");
        }

        /// <summary>
        /// 用于获取Logstash实例管道列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLogstashPipelinesRequest"/></param>
        /// <returns><see cref="DescribeLogstashPipelinesResponse"/></returns>
        public DescribeLogstashPipelinesResponse DescribeLogstashPipelinesSync(DescribeLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<DescribeLogstashPipelinesResponse>(req, "DescribeLogstashPipelines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看Serverless空间子用户
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessSpaceUserRequest"/></param>
        /// <returns><see cref="DescribeServerlessSpaceUserResponse"/></returns>
        public Task<DescribeServerlessSpaceUserResponse> DescribeServerlessSpaceUser(DescribeServerlessSpaceUserRequest req)
        {
            return InternalRequestAsync<DescribeServerlessSpaceUserResponse>(req, "DescribeServerlessSpaceUser");
        }

        /// <summary>
        /// 查看Serverless空间子用户
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessSpaceUserRequest"/></param>
        /// <returns><see cref="DescribeServerlessSpaceUserResponse"/></returns>
        public DescribeServerlessSpaceUserResponse DescribeServerlessSpaceUserSync(DescribeServerlessSpaceUserRequest req)
        {
            return InternalRequestAsync<DescribeServerlessSpaceUserResponse>(req, "DescribeServerlessSpaceUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Serverless索引空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessSpacesRequest"/></param>
        /// <returns><see cref="DescribeServerlessSpacesResponse"/></returns>
        public Task<DescribeServerlessSpacesResponse> DescribeServerlessSpaces(DescribeServerlessSpacesRequest req)
        {
            return InternalRequestAsync<DescribeServerlessSpacesResponse>(req, "DescribeServerlessSpaces");
        }

        /// <summary>
        /// 获取Serverless索引空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessSpacesRequest"/></param>
        /// <returns><see cref="DescribeServerlessSpacesResponse"/></returns>
        public DescribeServerlessSpacesResponse DescribeServerlessSpacesSync(DescribeServerlessSpacesRequest req)
        {
            return InternalRequestAsync<DescribeServerlessSpacesResponse>(req, "DescribeServerlessSpaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询快照信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCosSnapshotListRequest"/></param>
        /// <returns><see cref="DescribeUserCosSnapshotListResponse"/></returns>
        public Task<DescribeUserCosSnapshotListResponse> DescribeUserCosSnapshotList(DescribeUserCosSnapshotListRequest req)
        {
            return InternalRequestAsync<DescribeUserCosSnapshotListResponse>(req, "DescribeUserCosSnapshotList");
        }

        /// <summary>
        /// 查询快照信息接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCosSnapshotListRequest"/></param>
        /// <returns><see cref="DescribeUserCosSnapshotListResponse"/></returns>
        public DescribeUserCosSnapshotListResponse DescribeUserCosSnapshotListSync(DescribeUserCosSnapshotListRequest req)
        {
            return InternalRequestAsync<DescribeUserCosSnapshotListResponse>(req, "DescribeUserCosSnapshotList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群各视图数据，包括集群维度、节点维度、Kibana维度
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public Task<DescribeViewsResponse> DescribeViews(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews");
        }

        /// <summary>
        /// 查询集群各视图数据，包括集群维度、节点维度、Kibana维度
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public DescribeViewsResponse DescribeViewsSync(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能运维诊断集群
        /// </summary>
        /// <param name="req"><see cref="DiagnoseInstanceRequest"/></param>
        /// <returns><see cref="DiagnoseInstanceResponse"/></returns>
        public Task<DiagnoseInstanceResponse> DiagnoseInstance(DiagnoseInstanceRequest req)
        {
            return InternalRequestAsync<DiagnoseInstanceResponse>(req, "DiagnoseInstance");
        }

        /// <summary>
        /// 智能运维诊断集群
        /// </summary>
        /// <param name="req"><see cref="DiagnoseInstanceRequest"/></param>
        /// <returns><see cref="DiagnoseInstanceResponse"/></returns>
        public DiagnoseInstanceResponse DiagnoseInstanceSync(DiagnoseInstanceRequest req)
        {
            return InternalRequestAsync<DiagnoseInstanceResponse>(req, "DiagnoseInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看智能运维配置
        /// </summary>
        /// <param name="req"><see cref="GetDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="GetDiagnoseSettingsResponse"/></returns>
        public Task<GetDiagnoseSettingsResponse> GetDiagnoseSettings(GetDiagnoseSettingsRequest req)
        {
            return InternalRequestAsync<GetDiagnoseSettingsResponse>(req, "GetDiagnoseSettings");
        }

        /// <summary>
        /// 查看智能运维配置
        /// </summary>
        /// <param name="req"><see cref="GetDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="GetDiagnoseSettingsResponse"/></returns>
        public GetDiagnoseSettingsResponse GetDiagnoseSettingsSync(GetDiagnoseSettingsRequest req)
        {
            return InternalRequestAsync<GetDiagnoseSettingsResponse>(req, "GetDiagnoseSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public Task<GetRequestTargetNodeTypesResponse> GetRequestTargetNodeTypes(GetRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<GetRequestTargetNodeTypesResponse>(req, "GetRequestTargetNodeTypes");
        }

        /// <summary>
        /// 获取接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="GetRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="GetRequestTargetNodeTypesResponse"/></returns>
        public GetRequestTargetNodeTypesResponse GetRequestTargetNodeTypesSync(GetRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<GetRequestTargetNodeTypesResponse>(req, "GetRequestTargetNodeTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群续费询价接口，续费前通过调用该接口，可获取集群续费的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstanceResponse"/></returns>
        public Task<InquirePriceRenewInstanceResponse> InquirePriceRenewInstance(InquirePriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewInstanceResponse>(req, "InquirePriceRenewInstance");
        }

        /// <summary>
        /// 集群续费询价接口，续费前通过调用该接口，可获取集群续费的价格。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquirePriceRenewInstanceResponse"/></returns>
        public InquirePriceRenewInstanceResponse InquirePriceRenewInstanceSync(InquirePriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewInstanceResponse>(req, "InquirePriceRenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改绑定VIP的安全组，传安全组id列表
        /// </summary>
        /// <param name="req"><see cref="ModifyEsVipSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyEsVipSecurityGroupResponse"/></returns>
        public Task<ModifyEsVipSecurityGroupResponse> ModifyEsVipSecurityGroup(ModifyEsVipSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyEsVipSecurityGroupResponse>(req, "ModifyEsVipSecurityGroup");
        }

        /// <summary>
        /// 修改绑定VIP的安全组，传安全组id列表
        /// </summary>
        /// <param name="req"><see cref="ModifyEsVipSecurityGroupRequest"/></param>
        /// <returns><see cref="ModifyEsVipSecurityGroupResponse"/></returns>
        public ModifyEsVipSecurityGroupResponse ModifyEsVipSecurityGroupSync(ModifyEsVipSecurityGroupRequest req)
        {
            return InternalRequestAsync<ModifyEsVipSecurityGroupResponse>(req, "ModifyEsVipSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启ES集群实例(用于系统版本更新等操作)
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance");
        }

        /// <summary>
        /// 重启ES集群实例(用于系统版本更新等操作)
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启Kibana
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public Task<RestartKibanaResponse> RestartKibana(RestartKibanaRequest req)
        {
            return InternalRequestAsync<RestartKibanaResponse>(req, "RestartKibana");
        }

        /// <summary>
        /// 重启Kibana
        /// </summary>
        /// <param name="req"><see cref="RestartKibanaRequest"/></param>
        /// <returns><see cref="RestartKibanaResponse"/></returns>
        public RestartKibanaResponse RestartKibanaSync(RestartKibanaRequest req)
        {
            return InternalRequestAsync<RestartKibanaResponse>(req, "RestartKibana")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于重启Logstash实例
        /// </summary>
        /// <param name="req"><see cref="RestartLogstashInstanceRequest"/></param>
        /// <returns><see cref="RestartLogstashInstanceResponse"/></returns>
        public Task<RestartLogstashInstanceResponse> RestartLogstashInstance(RestartLogstashInstanceRequest req)
        {
            return InternalRequestAsync<RestartLogstashInstanceResponse>(req, "RestartLogstashInstance");
        }

        /// <summary>
        /// 用于重启Logstash实例
        /// </summary>
        /// <param name="req"><see cref="RestartLogstashInstanceRequest"/></param>
        /// <returns><see cref="RestartLogstashInstanceResponse"/></returns>
        public RestartLogstashInstanceResponse RestartLogstashInstanceSync(RestartLogstashInstanceRequest req)
        {
            return InternalRequestAsync<RestartLogstashInstanceResponse>(req, "RestartLogstashInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于重启集群节点
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public Task<RestartNodesResponse> RestartNodes(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes");
        }

        /// <summary>
        /// 用于重启集群节点
        /// </summary>
        /// <param name="req"><see cref="RestartNodesRequest"/></param>
        /// <returns><see cref="RestartNodesResponse"/></returns>
        public RestartNodesResponse RestartNodesSync(RestartNodesRequest req)
        {
            return InternalRequestAsync<RestartNodesResponse>(req, "RestartNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于下发并且部署管道
        /// </summary>
        /// <param name="req"><see cref="SaveAndDeployLogstashPipelineRequest"/></param>
        /// <returns><see cref="SaveAndDeployLogstashPipelineResponse"/></returns>
        public Task<SaveAndDeployLogstashPipelineResponse> SaveAndDeployLogstashPipeline(SaveAndDeployLogstashPipelineRequest req)
        {
            return InternalRequestAsync<SaveAndDeployLogstashPipelineResponse>(req, "SaveAndDeployLogstashPipeline");
        }

        /// <summary>
        /// 用于下发并且部署管道
        /// </summary>
        /// <param name="req"><see cref="SaveAndDeployLogstashPipelineRequest"/></param>
        /// <returns><see cref="SaveAndDeployLogstashPipelineResponse"/></returns>
        public SaveAndDeployLogstashPipelineResponse SaveAndDeployLogstashPipelineSync(SaveAndDeployLogstashPipelineRequest req)
        {
            return InternalRequestAsync<SaveAndDeployLogstashPipelineResponse>(req, "SaveAndDeployLogstashPipeline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于启动Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StartLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StartLogstashPipelinesResponse"/></returns>
        public Task<StartLogstashPipelinesResponse> StartLogstashPipelines(StartLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<StartLogstashPipelinesResponse>(req, "StartLogstashPipelines");
        }

        /// <summary>
        /// 用于启动Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StartLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StartLogstashPipelinesResponse"/></returns>
        public StartLogstashPipelinesResponse StartLogstashPipelinesSync(StartLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<StartLogstashPipelinesResponse>(req, "StartLogstashPipelines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于批量停止Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StopLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StopLogstashPipelinesResponse"/></returns>
        public Task<StopLogstashPipelinesResponse> StopLogstashPipelines(StopLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<StopLogstashPipelinesResponse>(req, "StopLogstashPipelines");
        }

        /// <summary>
        /// 用于批量停止Logstash管道
        /// </summary>
        /// <param name="req"><see cref="StopLogstashPipelinesRequest"/></param>
        /// <returns><see cref="StopLogstashPipelinesResponse"/></returns>
        public StopLogstashPipelinesResponse StopLogstashPipelinesSync(StopLogstashPipelinesRequest req)
        {
            return InternalRequestAsync<StopLogstashPipelinesResponse>(req, "StopLogstashPipelines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新智能运维配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="UpdateDiagnoseSettingsResponse"/></returns>
        public Task<UpdateDiagnoseSettingsResponse> UpdateDiagnoseSettings(UpdateDiagnoseSettingsRequest req)
        {
            return InternalRequestAsync<UpdateDiagnoseSettingsResponse>(req, "UpdateDiagnoseSettings");
        }

        /// <summary>
        /// 更新智能运维配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDiagnoseSettingsRequest"/></param>
        /// <returns><see cref="UpdateDiagnoseSettingsResponse"/></returns>
        public UpdateDiagnoseSettingsResponse UpdateDiagnoseSettingsSync(UpdateDiagnoseSettingsRequest req)
        {
            return InternalRequestAsync<UpdateDiagnoseSettingsResponse>(req, "UpdateDiagnoseSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新ES集群词典
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public Task<UpdateDictionariesResponse> UpdateDictionaries(UpdateDictionariesRequest req)
        {
            return InternalRequestAsync<UpdateDictionariesResponse>(req, "UpdateDictionaries");
        }

        /// <summary>
        /// 更新ES集群词典
        /// </summary>
        /// <param name="req"><see cref="UpdateDictionariesRequest"/></param>
        /// <returns><see cref="UpdateDictionariesResponse"/></returns>
        public UpdateDictionariesResponse UpdateDictionariesSync(UpdateDictionariesRequest req)
        {
            return InternalRequestAsync<UpdateDictionariesResponse>(req, "UpdateDictionaries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新索引
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public Task<UpdateIndexResponse> UpdateIndex(UpdateIndexRequest req)
        {
            return InternalRequestAsync<UpdateIndexResponse>(req, "UpdateIndex");
        }

        /// <summary>
        /// 更新索引
        /// </summary>
        /// <param name="req"><see cref="UpdateIndexRequest"/></param>
        /// <returns><see cref="UpdateIndexResponse"/></returns>
        public UpdateIndexResponse UpdateIndexSync(UpdateIndexRequest req)
        {
            return InternalRequestAsync<UpdateIndexResponse>(req, "UpdateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，重置密码， 添加Kibana黑白名单等操作。参数中InstanceId为必传参数，ForceRestart为选填参数，剩余参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeInfoList: 修改节点配置（节点横向扩缩容，纵向扩缩容，增加主节点，增加冷节点等）
        /// - EsConfig：修改集群配置
        /// - Password：修改默认用户elastic的密码
        /// - EsAcl：修改访问控制列表
        /// - CosBackUp: 设置集群COS自动备份信息
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public Task<UpdateInstanceResponse> UpdateInstance(UpdateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateInstanceResponse>(req, "UpdateInstance");
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，重置密码， 添加Kibana黑白名单等操作。参数中InstanceId为必传参数，ForceRestart为选填参数，剩余参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeInfoList: 修改节点配置（节点横向扩缩容，纵向扩缩容，增加主节点，增加冷节点等）
        /// - EsConfig：修改集群配置
        /// - Password：修改默认用户elastic的密码
        /// - EsAcl：修改访问控制列表
        /// - CosBackUp: 设置集群COS自动备份信息
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public UpdateInstanceResponse UpdateInstanceSync(UpdateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateInstanceResponse>(req, "UpdateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新实例Jdk配置
        /// </summary>
        /// <param name="req"><see cref="UpdateJdkRequest"/></param>
        /// <returns><see cref="UpdateJdkResponse"/></returns>
        public Task<UpdateJdkResponse> UpdateJdk(UpdateJdkRequest req)
        {
            return InternalRequestAsync<UpdateJdkResponse>(req, "UpdateJdk");
        }

        /// <summary>
        /// 更新实例Jdk配置
        /// </summary>
        /// <param name="req"><see cref="UpdateJdkRequest"/></param>
        /// <returns><see cref="UpdateJdkResponse"/></returns>
        public UpdateJdkResponse UpdateJdkSync(UpdateJdkRequest req)
        {
            return InternalRequestAsync<UpdateJdkResponse>(req, "UpdateJdk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，等操作。参数中InstanceId为必传参数，参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeNum: 修改实例节点数量（节点横向扩缩容，纵向扩缩容等）
        /// - YMLConfig: 修改实例YML配置
        /// - BindedES：修改绑定的ES集群配置
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashInstanceRequest"/></param>
        /// <returns><see cref="UpdateLogstashInstanceResponse"/></returns>
        public Task<UpdateLogstashInstanceResponse> UpdateLogstashInstance(UpdateLogstashInstanceRequest req)
        {
            return InternalRequestAsync<UpdateLogstashInstanceResponse>(req, "UpdateLogstashInstance");
        }

        /// <summary>
        /// 对集群进行节点规格变更，修改实例名称，修改配置，等操作。参数中InstanceId为必传参数，参数传递组合及含义如下：
        /// - InstanceName：修改实例名称(仅用于标识实例)
        /// - NodeNum: 修改实例节点数量（节点横向扩缩容，纵向扩缩容等）
        /// - YMLConfig: 修改实例YML配置
        /// - BindedES：修改绑定的ES集群配置
        /// 以上参数组合只能传递一种，多传或少传均会导致请求失败
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashInstanceRequest"/></param>
        /// <returns><see cref="UpdateLogstashInstanceResponse"/></returns>
        public UpdateLogstashInstanceResponse UpdateLogstashInstanceSync(UpdateLogstashInstanceRequest req)
        {
            return InternalRequestAsync<UpdateLogstashInstanceResponse>(req, "UpdateLogstashInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于更新管道描述信息
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashPipelineDescRequest"/></param>
        /// <returns><see cref="UpdateLogstashPipelineDescResponse"/></returns>
        public Task<UpdateLogstashPipelineDescResponse> UpdateLogstashPipelineDesc(UpdateLogstashPipelineDescRequest req)
        {
            return InternalRequestAsync<UpdateLogstashPipelineDescResponse>(req, "UpdateLogstashPipelineDesc");
        }

        /// <summary>
        /// 用于更新管道描述信息
        /// </summary>
        /// <param name="req"><see cref="UpdateLogstashPipelineDescRequest"/></param>
        /// <returns><see cref="UpdateLogstashPipelineDescResponse"/></returns>
        public UpdateLogstashPipelineDescResponse UpdateLogstashPipelineDescSync(UpdateLogstashPipelineDescRequest req)
        {
            return InternalRequestAsync<UpdateLogstashPipelineDescResponse>(req, "UpdateLogstashPipelineDesc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 变更插件列表
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public Task<UpdatePluginsResponse> UpdatePlugins(UpdatePluginsRequest req)
        {
            return InternalRequestAsync<UpdatePluginsResponse>(req, "UpdatePlugins");
        }

        /// <summary>
        /// 变更插件列表
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public UpdatePluginsResponse UpdatePluginsSync(UpdatePluginsRequest req)
        {
            return InternalRequestAsync<UpdatePluginsResponse>(req, "UpdatePlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public Task<UpdateRequestTargetNodeTypesResponse> UpdateRequestTargetNodeTypes(UpdateRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<UpdateRequestTargetNodeTypesResponse>(req, "UpdateRequestTargetNodeTypes");
        }

        /// <summary>
        /// 更新接收客户端请求的节点类型
        /// </summary>
        /// <param name="req"><see cref="UpdateRequestTargetNodeTypesRequest"/></param>
        /// <returns><see cref="UpdateRequestTargetNodeTypesResponse"/></returns>
        public UpdateRequestTargetNodeTypesResponse UpdateRequestTargetNodeTypesSync(UpdateRequestTargetNodeTypesRequest req)
        {
            return InternalRequestAsync<UpdateRequestTargetNodeTypesResponse>(req, "UpdateRequestTargetNodeTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新Serverless索引
        /// </summary>
        /// <param name="req"><see cref="UpdateServerlessInstanceRequest"/></param>
        /// <returns><see cref="UpdateServerlessInstanceResponse"/></returns>
        public Task<UpdateServerlessInstanceResponse> UpdateServerlessInstance(UpdateServerlessInstanceRequest req)
        {
            return InternalRequestAsync<UpdateServerlessInstanceResponse>(req, "UpdateServerlessInstance");
        }

        /// <summary>
        /// 更新Serverless索引
        /// </summary>
        /// <param name="req"><see cref="UpdateServerlessInstanceRequest"/></param>
        /// <returns><see cref="UpdateServerlessInstanceResponse"/></returns>
        public UpdateServerlessInstanceResponse UpdateServerlessInstanceSync(UpdateServerlessInstanceRequest req)
        {
            return InternalRequestAsync<UpdateServerlessInstanceResponse>(req, "UpdateServerlessInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新Serverless索引空间
        /// </summary>
        /// <param name="req"><see cref="UpdateServerlessSpaceRequest"/></param>
        /// <returns><see cref="UpdateServerlessSpaceResponse"/></returns>
        public Task<UpdateServerlessSpaceResponse> UpdateServerlessSpace(UpdateServerlessSpaceRequest req)
        {
            return InternalRequestAsync<UpdateServerlessSpaceResponse>(req, "UpdateServerlessSpace");
        }

        /// <summary>
        /// 更新Serverless索引空间
        /// </summary>
        /// <param name="req"><see cref="UpdateServerlessSpaceRequest"/></param>
        /// <returns><see cref="UpdateServerlessSpaceResponse"/></returns>
        public UpdateServerlessSpaceResponse UpdateServerlessSpaceSync(UpdateServerlessSpaceRequest req)
        {
            return InternalRequestAsync<UpdateServerlessSpaceResponse>(req, "UpdateServerlessSpace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级ES集群版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// 升级ES集群版本
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级ES商业特性
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public Task<UpgradeLicenseResponse> UpgradeLicense(UpgradeLicenseRequest req)
        {
            return InternalRequestAsync<UpgradeLicenseResponse>(req, "UpgradeLicense");
        }

        /// <summary>
        /// 升级ES商业特性
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public UpgradeLicenseResponse UpgradeLicenseSync(UpgradeLicenseRequest req)
        {
            return InternalRequestAsync<UpgradeLicenseResponse>(req, "UpgradeLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
