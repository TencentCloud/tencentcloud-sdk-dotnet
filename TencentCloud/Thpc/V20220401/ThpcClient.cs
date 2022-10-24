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

namespace TencentCloud.Thpc.V20220401
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Thpc.V20220401.Models;

   public class ThpcClient : AbstractClient{

       private const string endpoint = "thpc.tencentcloudapi.com";
       private const string version = "2022-04-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ThpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ThpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口(AddNodes)用于添加一个或者多个计算节点或者登录节点到指定集群。
        /// </summary>
        /// <param name="req"><see cref="AddNodesRequest"/></param>
        /// <returns><see cref="AddNodesResponse"/></returns>
        public async Task<AddNodesResponse> AddNodes(AddNodesRequest req)
        {
             JsonResponseModel<AddNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(AddNodes)用于添加一个或者多个计算节点或者登录节点到指定集群。
        /// </summary>
        /// <param name="req"><see cref="AddNodesRequest"/></param>
        /// <returns><see cref="AddNodesResponse"/></returns>
        public AddNodesResponse AddNodesSync(AddNodesRequest req)
        {
             JsonResponseModel<AddNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(BindAutoScalingGroup)用于为集群队列绑定弹性伸缩组
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalingGroupRequest"/></param>
        /// <returns><see cref="BindAutoScalingGroupResponse"/></returns>
        public async Task<BindAutoScalingGroupResponse> BindAutoScalingGroup(BindAutoScalingGroupRequest req)
        {
             JsonResponseModel<BindAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(BindAutoScalingGroup)用于为集群队列绑定弹性伸缩组
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalingGroupRequest"/></param>
        /// <returns><see cref="BindAutoScalingGroupResponse"/></returns>
        public BindAutoScalingGroupResponse BindAutoScalingGroupSync(BindAutoScalingGroupRequest req)
        {
             JsonResponseModel<BindAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (CreateCluster) 用于创建并启动集群。
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
        /// 本接口 (CreateCluster) 用于创建并启动集群。
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
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
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
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
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
        /// 本接口(DeleteNodes)用于删除指定集群中一个或者多个计算节点或者登录节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteNodesRequest"/></param>
        /// <returns><see cref="DeleteNodesResponse"/></returns>
        public async Task<DeleteNodesResponse> DeleteNodes(DeleteNodesRequest req)
        {
             JsonResponseModel<DeleteNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteNodes)用于删除指定集群中一个或者多个计算节点或者登录节点。
        /// </summary>
        /// <param name="req"><see cref="DeleteNodesRequest"/></param>
        /// <returns><see cref="DeleteNodesResponse"/></returns>
        public DeleteNodesResponse DeleteNodesSync(DeleteNodesRequest req)
        {
             JsonResponseModel<DeleteNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeClusters）用于查询集群列表。
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
        /// 本接口（DescribeClusters）用于查询集群列表。
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
        /// 本接口(SetAutoScalingConfiguration)用于为集群设置集群弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="SetAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="SetAutoScalingConfigurationResponse"/></returns>
        public async Task<SetAutoScalingConfigurationResponse> SetAutoScalingConfiguration(SetAutoScalingConfigurationRequest req)
        {
             JsonResponseModel<SetAutoScalingConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAutoScalingConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoScalingConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(SetAutoScalingConfiguration)用于为集群设置集群弹性伸缩配置信息。
        /// </summary>
        /// <param name="req"><see cref="SetAutoScalingConfigurationRequest"/></param>
        /// <returns><see cref="SetAutoScalingConfigurationResponse"/></returns>
        public SetAutoScalingConfigurationResponse SetAutoScalingConfigurationSync(SetAutoScalingConfigurationRequest req)
        {
             JsonResponseModel<SetAutoScalingConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAutoScalingConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoScalingConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
