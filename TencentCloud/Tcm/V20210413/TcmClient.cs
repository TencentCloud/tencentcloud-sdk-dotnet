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

namespace TencentCloud.Tcm.V20210413
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcm.V20210413.Models;

   public class TcmClient : AbstractClient{

       private const string endpoint = "tcm.tencentcloudapi.com";
       private const string version = "2021-04-13";
       private const string sdkVersion = "SDK_NET_3.0.1226";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建网格
        /// </summary>
        /// <param name="req"><see cref="CreateMeshRequest"/></param>
        /// <returns><see cref="CreateMeshResponse"/></returns>
        public Task<CreateMeshResponse> CreateMesh(CreateMeshRequest req)
        {
            return InternalRequestAsync<CreateMeshResponse>(req, "CreateMesh");
        }

        /// <summary>
        /// 创建网格
        /// </summary>
        /// <param name="req"><see cref="CreateMeshRequest"/></param>
        /// <returns><see cref="CreateMeshResponse"/></returns>
        public CreateMeshResponse CreateMeshSync(CreateMeshRequest req)
        {
            return InternalRequestAsync<CreateMeshResponse>(req, "CreateMesh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除网格
        /// </summary>
        /// <param name="req"><see cref="DeleteMeshRequest"/></param>
        /// <returns><see cref="DeleteMeshResponse"/></returns>
        public Task<DeleteMeshResponse> DeleteMesh(DeleteMeshRequest req)
        {
            return InternalRequestAsync<DeleteMeshResponse>(req, "DeleteMesh");
        }

        /// <summary>
        /// 删除网格
        /// </summary>
        /// <param name="req"><see cref="DeleteMeshRequest"/></param>
        /// <returns><see cref="DeleteMeshResponse"/></returns>
        public DeleteMeshResponse DeleteMeshSync(DeleteMeshRequest req)
        {
            return InternalRequestAsync<DeleteMeshResponse>(req, "DeleteMesh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取AccessLog配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessLogConfigRequest"/></param>
        /// <returns><see cref="DescribeAccessLogConfigResponse"/></returns>
        public Task<DescribeAccessLogConfigResponse> DescribeAccessLogConfig(DescribeAccessLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeAccessLogConfigResponse>(req, "DescribeAccessLogConfig");
        }

        /// <summary>
        /// 获取AccessLog配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessLogConfigRequest"/></param>
        /// <returns><see cref="DescribeAccessLogConfigResponse"/></returns>
        public DescribeAccessLogConfigResponse DescribeAccessLogConfigSync(DescribeAccessLogConfigRequest req)
        {
            return InternalRequestAsync<DescribeAccessLogConfigResponse>(req, "DescribeAccessLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshRequest"/></param>
        /// <returns><see cref="DescribeMeshResponse"/></returns>
        public Task<DescribeMeshResponse> DescribeMesh(DescribeMeshRequest req)
        {
            return InternalRequestAsync<DescribeMeshResponse>(req, "DescribeMesh");
        }

        /// <summary>
        /// 查询网格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshRequest"/></param>
        /// <returns><see cref="DescribeMeshResponse"/></returns>
        public DescribeMeshResponse DescribeMeshSync(DescribeMeshRequest req)
        {
            return InternalRequestAsync<DescribeMeshResponse>(req, "DescribeMesh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshListRequest"/></param>
        /// <returns><see cref="DescribeMeshListResponse"/></returns>
        public Task<DescribeMeshListResponse> DescribeMeshList(DescribeMeshListRequest req)
        {
            return InternalRequestAsync<DescribeMeshListResponse>(req, "DescribeMeshList");
        }

        /// <summary>
        /// 查询网格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshListRequest"/></param>
        /// <returns><see cref="DescribeMeshListResponse"/></returns>
        public DescribeMeshListResponse DescribeMeshListSync(DescribeMeshListRequest req)
        {
            return InternalRequestAsync<DescribeMeshListResponse>(req, "DescribeMeshList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关联集群
        /// </summary>
        /// <param name="req"><see cref="LinkClusterListRequest"/></param>
        /// <returns><see cref="LinkClusterListResponse"/></returns>
        public Task<LinkClusterListResponse> LinkClusterList(LinkClusterListRequest req)
        {
            return InternalRequestAsync<LinkClusterListResponse>(req, "LinkClusterList");
        }

        /// <summary>
        /// 关联集群
        /// </summary>
        /// <param name="req"><see cref="LinkClusterListRequest"/></param>
        /// <returns><see cref="LinkClusterListResponse"/></returns>
        public LinkClusterListResponse LinkClusterListSync(LinkClusterListRequest req)
        {
            return InternalRequestAsync<LinkClusterListResponse>(req, "LinkClusterList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="LinkPrometheusRequest"/></param>
        /// <returns><see cref="LinkPrometheusResponse"/></returns>
        public Task<LinkPrometheusResponse> LinkPrometheus(LinkPrometheusRequest req)
        {
            return InternalRequestAsync<LinkPrometheusResponse>(req, "LinkPrometheus");
        }

        /// <summary>
        /// 关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="LinkPrometheusRequest"/></param>
        /// <returns><see cref="LinkPrometheusResponse"/></returns>
        public LinkPrometheusResponse LinkPrometheusSync(LinkPrometheusRequest req)
        {
            return InternalRequestAsync<LinkPrometheusResponse>(req, "LinkPrometheus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改访问日志配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessLogConfigRequest"/></param>
        /// <returns><see cref="ModifyAccessLogConfigResponse"/></returns>
        public Task<ModifyAccessLogConfigResponse> ModifyAccessLogConfig(ModifyAccessLogConfigRequest req)
        {
            return InternalRequestAsync<ModifyAccessLogConfigResponse>(req, "ModifyAccessLogConfig");
        }

        /// <summary>
        /// 修改访问日志配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessLogConfigRequest"/></param>
        /// <returns><see cref="ModifyAccessLogConfigResponse"/></returns>
        public ModifyAccessLogConfigResponse ModifyAccessLogConfigSync(ModifyAccessLogConfigRequest req)
        {
            return InternalRequestAsync<ModifyAccessLogConfigResponse>(req, "ModifyAccessLogConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改网格
        /// </summary>
        /// <param name="req"><see cref="ModifyMeshRequest"/></param>
        /// <returns><see cref="ModifyMeshResponse"/></returns>
        public Task<ModifyMeshResponse> ModifyMesh(ModifyMeshRequest req)
        {
            return InternalRequestAsync<ModifyMeshResponse>(req, "ModifyMesh");
        }

        /// <summary>
        /// 修改网格
        /// </summary>
        /// <param name="req"><see cref="ModifyMeshRequest"/></param>
        /// <returns><see cref="ModifyMeshResponse"/></returns>
        public ModifyMeshResponse ModifyMeshSync(ModifyMeshRequest req)
        {
            return InternalRequestAsync<ModifyMeshResponse>(req, "ModifyMesh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 Tracing 配置
        /// </summary>
        /// <param name="req"><see cref="ModifyTracingConfigRequest"/></param>
        /// <returns><see cref="ModifyTracingConfigResponse"/></returns>
        public Task<ModifyTracingConfigResponse> ModifyTracingConfig(ModifyTracingConfigRequest req)
        {
            return InternalRequestAsync<ModifyTracingConfigResponse>(req, "ModifyTracingConfig");
        }

        /// <summary>
        /// 修改 Tracing 配置
        /// </summary>
        /// <param name="req"><see cref="ModifyTracingConfigRequest"/></param>
        /// <returns><see cref="ModifyTracingConfigResponse"/></returns>
        public ModifyTracingConfigResponse ModifyTracingConfigSync(ModifyTracingConfigRequest req)
        {
            return InternalRequestAsync<ModifyTracingConfigResponse>(req, "ModifyTracingConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解关联集群
        /// </summary>
        /// <param name="req"><see cref="UnlinkClusterRequest"/></param>
        /// <returns><see cref="UnlinkClusterResponse"/></returns>
        public Task<UnlinkClusterResponse> UnlinkCluster(UnlinkClusterRequest req)
        {
            return InternalRequestAsync<UnlinkClusterResponse>(req, "UnlinkCluster");
        }

        /// <summary>
        /// 解关联集群
        /// </summary>
        /// <param name="req"><see cref="UnlinkClusterRequest"/></param>
        /// <returns><see cref="UnlinkClusterResponse"/></returns>
        public UnlinkClusterResponse UnlinkClusterSync(UnlinkClusterRequest req)
        {
            return InternalRequestAsync<UnlinkClusterResponse>(req, "UnlinkCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="UnlinkPrometheusRequest"/></param>
        /// <returns><see cref="UnlinkPrometheusResponse"/></returns>
        public Task<UnlinkPrometheusResponse> UnlinkPrometheus(UnlinkPrometheusRequest req)
        {
            return InternalRequestAsync<UnlinkPrometheusResponse>(req, "UnlinkPrometheus");
        }

        /// <summary>
        /// 解除关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="UnlinkPrometheusRequest"/></param>
        /// <returns><see cref="UnlinkPrometheusResponse"/></returns>
        public UnlinkPrometheusResponse UnlinkPrometheusSync(UnlinkPrometheusRequest req)
        {
            return InternalRequestAsync<UnlinkPrometheusResponse>(req, "UnlinkPrometheus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
