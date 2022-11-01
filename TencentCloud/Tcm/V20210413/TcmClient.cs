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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 创建网格
        /// </summary>
        /// <param name="req"><see cref="CreateMeshRequest"/></param>
        /// <returns><see cref="CreateMeshResponse"/></returns>
        public async Task<CreateMeshResponse> CreateMesh(CreateMeshRequest req)
        {
             JsonResponseModel<CreateMeshResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建网格
        /// </summary>
        /// <param name="req"><see cref="CreateMeshRequest"/></param>
        /// <returns><see cref="CreateMeshResponse"/></returns>
        public CreateMeshResponse CreateMeshSync(CreateMeshRequest req)
        {
             JsonResponseModel<CreateMeshResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除网格
        /// </summary>
        /// <param name="req"><see cref="DeleteMeshRequest"/></param>
        /// <returns><see cref="DeleteMeshResponse"/></returns>
        public async Task<DeleteMeshResponse> DeleteMesh(DeleteMeshRequest req)
        {
             JsonResponseModel<DeleteMeshResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除网格
        /// </summary>
        /// <param name="req"><see cref="DeleteMeshRequest"/></param>
        /// <returns><see cref="DeleteMeshResponse"/></returns>
        public DeleteMeshResponse DeleteMeshSync(DeleteMeshRequest req)
        {
             JsonResponseModel<DeleteMeshResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshRequest"/></param>
        /// <returns><see cref="DescribeMeshResponse"/></returns>
        public async Task<DescribeMeshResponse> DescribeMesh(DescribeMeshRequest req)
        {
             JsonResponseModel<DescribeMeshResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshRequest"/></param>
        /// <returns><see cref="DescribeMeshResponse"/></returns>
        public DescribeMeshResponse DescribeMeshSync(DescribeMeshRequest req)
        {
             JsonResponseModel<DescribeMeshResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshListRequest"/></param>
        /// <returns><see cref="DescribeMeshListResponse"/></returns>
        public async Task<DescribeMeshListResponse> DescribeMeshList(DescribeMeshListRequest req)
        {
             JsonResponseModel<DescribeMeshListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMeshList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询网格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMeshListRequest"/></param>
        /// <returns><see cref="DescribeMeshListResponse"/></returns>
        public DescribeMeshListResponse DescribeMeshListSync(DescribeMeshListRequest req)
        {
             JsonResponseModel<DescribeMeshListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMeshList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMeshListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联集群
        /// </summary>
        /// <param name="req"><see cref="LinkClusterListRequest"/></param>
        /// <returns><see cref="LinkClusterListResponse"/></returns>
        public async Task<LinkClusterListResponse> LinkClusterList(LinkClusterListRequest req)
        {
             JsonResponseModel<LinkClusterListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LinkClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LinkClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联集群
        /// </summary>
        /// <param name="req"><see cref="LinkClusterListRequest"/></param>
        /// <returns><see cref="LinkClusterListResponse"/></returns>
        public LinkClusterListResponse LinkClusterListSync(LinkClusterListRequest req)
        {
             JsonResponseModel<LinkClusterListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LinkClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LinkClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="LinkPrometheusRequest"/></param>
        /// <returns><see cref="LinkPrometheusResponse"/></returns>
        public async Task<LinkPrometheusResponse> LinkPrometheus(LinkPrometheusRequest req)
        {
             JsonResponseModel<LinkPrometheusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LinkPrometheus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LinkPrometheusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="LinkPrometheusRequest"/></param>
        /// <returns><see cref="LinkPrometheusResponse"/></returns>
        public LinkPrometheusResponse LinkPrometheusSync(LinkPrometheusRequest req)
        {
             JsonResponseModel<LinkPrometheusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LinkPrometheus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LinkPrometheusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改网格
        /// </summary>
        /// <param name="req"><see cref="ModifyMeshRequest"/></param>
        /// <returns><see cref="ModifyMeshResponse"/></returns>
        public async Task<ModifyMeshResponse> ModifyMesh(ModifyMeshRequest req)
        {
             JsonResponseModel<ModifyMeshResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改网格
        /// </summary>
        /// <param name="req"><see cref="ModifyMeshRequest"/></param>
        /// <returns><see cref="ModifyMeshResponse"/></returns>
        public ModifyMeshResponse ModifyMeshSync(ModifyMeshRequest req)
        {
             JsonResponseModel<ModifyMeshResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMesh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMeshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解关联集群
        /// </summary>
        /// <param name="req"><see cref="UnlinkClusterRequest"/></param>
        /// <returns><see cref="UnlinkClusterResponse"/></returns>
        public async Task<UnlinkClusterResponse> UnlinkCluster(UnlinkClusterRequest req)
        {
             JsonResponseModel<UnlinkClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnlinkCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlinkClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解关联集群
        /// </summary>
        /// <param name="req"><see cref="UnlinkClusterRequest"/></param>
        /// <returns><see cref="UnlinkClusterResponse"/></returns>
        public UnlinkClusterResponse UnlinkClusterSync(UnlinkClusterRequest req)
        {
             JsonResponseModel<UnlinkClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnlinkCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlinkClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="UnlinkPrometheusRequest"/></param>
        /// <returns><see cref="UnlinkPrometheusResponse"/></returns>
        public async Task<UnlinkPrometheusResponse> UnlinkPrometheus(UnlinkPrometheusRequest req)
        {
             JsonResponseModel<UnlinkPrometheusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnlinkPrometheus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlinkPrometheusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除关联Prometheus
        /// </summary>
        /// <param name="req"><see cref="UnlinkPrometheusRequest"/></param>
        /// <returns><see cref="UnlinkPrometheusResponse"/></returns>
        public UnlinkPrometheusResponse UnlinkPrometheusSync(UnlinkPrometheusRequest req)
        {
             JsonResponseModel<UnlinkPrometheusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnlinkPrometheus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlinkPrometheusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
