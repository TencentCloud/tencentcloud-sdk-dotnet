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

namespace TencentCloud.Tke.V20180525
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tke.V20180525.Models;

   public class TkeClient : AbstractClient{

       private const string endpoint = "tke.tencentcloudapi.com";
       private const string version = "2018-05-25";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加已经存在的实例到集群
        /// </summary>
        /// <param name="req">参考<see cref="AddExistedInstancesRequest"/></param>
        /// <returns>参考<see cref="AddExistedInstancesResponse"/>实例</returns>
        public async Task<AddExistedInstancesResponse> AddExistedInstances(AddExistedInstancesRequest req)
        {
             JsonResponseModel<AddExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req">参考<see cref="CreateClusterRequest"/></param>
        /// <returns>参考<see cref="CreateClusterResponse"/>实例</returns>
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
        /// 扩展(新建)集群节点
        /// </summary>
        /// <param name="req">参考<see cref="CreateClusterInstancesRequest"/></param>
        /// <returns>参考<see cref="CreateClusterInstancesResponse"/>实例</returns>
        public async Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
             JsonResponseModel<CreateClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除集群(YUNAPI V3版本)
        /// </summary>
        /// <param name="req">参考<see cref="DeleteClusterRequest"/></param>
        /// <returns>参考<see cref="DeleteClusterResponse"/>实例</returns>
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
        /// 删除集群中的实例
        /// </summary>
        /// <param name="req">参考<see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns>参考<see cref="DeleteClusterInstancesResponse"/>实例</returns>
        public async Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
             JsonResponseModel<DeleteClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  查询集群下节点实例信息 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeClusterInstancesResponse"/>实例</returns>
        public async Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
             JsonResponseModel<DescribeClusterInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 集群的密钥信息
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClusterSecurityRequest"/></param>
        /// <returns>参考<see cref="DescribeClusterSecurityResponse"/>实例</returns>
        public async Task<DescribeClusterSecurityResponse> DescribeClusterSecurity(DescribeClusterSecurityRequest req)
        {
             JsonResponseModel<DescribeClusterSecurityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterSecurity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSecurityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeClustersRequest"/></param>
        /// <returns>参考<see cref="DescribeClustersResponse"/>实例</returns>
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
        /// 查询已经存在的节点，判断是否可以加入集群
        /// </summary>
        /// <param name="req">参考<see cref="DescribeExistedInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeExistedInstancesResponse"/>实例</returns>
        public async Task<DescribeExistedInstancesResponse> DescribeExistedInstances(DescribeExistedInstancesRequest req)
        {
             JsonResponseModel<DescribeExistedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExistedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExistedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
