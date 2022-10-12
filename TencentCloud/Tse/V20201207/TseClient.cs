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

namespace TencentCloud.Tse.V20201207
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tse.V20201207.Models;

   public class TseClient : AbstractClient{

       private const string endpoint = "tse.tencentcloudapi.com";
       private const string version = "2020-12-07";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建引擎实例
        /// </summary>
        /// <param name="req"><see cref="CreateEngineRequest"/></param>
        /// <returns><see cref="CreateEngineResponse"/></returns>
        public async Task<CreateEngineResponse> CreateEngine(CreateEngineRequest req)
        {
             JsonResponseModel<CreateEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建引擎实例
        /// </summary>
        /// <param name="req"><see cref="CreateEngineRequest"/></param>
        /// <returns><see cref="CreateEngineResponse"/></returns>
        public CreateEngineResponse CreateEngineSync(CreateEngineRequest req)
        {
             JsonResponseModel<CreateEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除引擎实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEngineRequest"/></param>
        /// <returns><see cref="DeleteEngineResponse"/></returns>
        public async Task<DeleteEngineResponse> DeleteEngine(DeleteEngineRequest req)
        {
             JsonResponseModel<DeleteEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除引擎实例
        /// </summary>
        /// <param name="req"><see cref="DeleteEngineRequest"/></param>
        /// <returns><see cref="DeleteEngineResponse"/></returns>
        public DeleteEngineResponse DeleteEngineSync(DeleteEngineRequest req)
        {
             JsonResponseModel<DeleteEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生网关节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public async Task<DescribeCloudNativeAPIGatewayNodesResponse> DescribeCloudNativeAPIGatewayNodes(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudNativeAPIGatewayNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云原生网关节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudNativeAPIGatewayNodesRequest"/></param>
        /// <returns><see cref="DescribeCloudNativeAPIGatewayNodesResponse"/></returns>
        public DescribeCloudNativeAPIGatewayNodesResponse DescribeCloudNativeAPIGatewayNodesSync(DescribeCloudNativeAPIGatewayNodesRequest req)
        {
             JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudNativeAPIGatewayNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudNativeAPIGatewayNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Nacos类型引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosReplicasRequest"/></param>
        /// <returns><see cref="DescribeNacosReplicasResponse"/></returns>
        public async Task<DescribeNacosReplicasResponse> DescribeNacosReplicas(DescribeNacosReplicasRequest req)
        {
             JsonResponseModel<DescribeNacosReplicasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNacosReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Nacos类型引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosReplicasRequest"/></param>
        /// <returns><see cref="DescribeNacosReplicasResponse"/></returns>
        public DescribeNacosReplicasResponse DescribeNacosReplicasSync(DescribeNacosReplicasRequest req)
        {
             JsonResponseModel<DescribeNacosReplicasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNacosReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询nacos服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNacosServerInterfacesResponse"/></returns>
        public async Task<DescribeNacosServerInterfacesResponse> DescribeNacosServerInterfaces(DescribeNacosServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeNacosServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNacosServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询nacos服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNacosServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeNacosServerInterfacesResponse"/></returns>
        public DescribeNacosServerInterfacesResponse DescribeNacosServerInterfacesSync(DescribeNacosServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeNacosServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNacosServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNacosServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public async Task<DescribeSREInstanceAccessAddressResponse> DescribeSREInstanceAccessAddress(DescribeSREInstanceAccessAddressRequest req)
        {
             JsonResponseModel<DescribeSREInstanceAccessAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSREInstanceAccessAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstanceAccessAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询引擎实例访问地址
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstanceAccessAddressRequest"/></param>
        /// <returns><see cref="DescribeSREInstanceAccessAddressResponse"/></returns>
        public DescribeSREInstanceAccessAddressResponse DescribeSREInstanceAccessAddressSync(DescribeSREInstanceAccessAddressRequest req)
        {
             JsonResponseModel<DescribeSREInstanceAccessAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSREInstanceAccessAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstanceAccessAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public async Task<DescribeSREInstancesResponse> DescribeSREInstances(DescribeSREInstancesRequest req)
        {
             JsonResponseModel<DescribeSREInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSREInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询引擎实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSREInstancesRequest"/></param>
        /// <returns><see cref="DescribeSREInstancesResponse"/></returns>
        public DescribeSREInstancesResponse DescribeSREInstancesSync(DescribeSREInstancesRequest req)
        {
             JsonResponseModel<DescribeSREInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSREInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSREInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Zookeeper类型注册引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperReplicasRequest"/></param>
        /// <returns><see cref="DescribeZookeeperReplicasResponse"/></returns>
        public async Task<DescribeZookeeperReplicasResponse> DescribeZookeeperReplicas(DescribeZookeeperReplicasRequest req)
        {
             JsonResponseModel<DescribeZookeeperReplicasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZookeeperReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Zookeeper类型注册引擎实例副本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperReplicasRequest"/></param>
        /// <returns><see cref="DescribeZookeeperReplicasResponse"/></returns>
        public DescribeZookeeperReplicasResponse DescribeZookeeperReplicasSync(DescribeZookeeperReplicasRequest req)
        {
             JsonResponseModel<DescribeZookeeperReplicasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZookeeperReplicas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperReplicasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询zookeeper服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeZookeeperServerInterfacesResponse"/></returns>
        public async Task<DescribeZookeeperServerInterfacesResponse> DescribeZookeeperServerInterfaces(DescribeZookeeperServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeZookeeperServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZookeeperServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询zookeeper服务接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeZookeeperServerInterfacesRequest"/></param>
        /// <returns><see cref="DescribeZookeeperServerInterfacesResponse"/></returns>
        public DescribeZookeeperServerInterfacesResponse DescribeZookeeperServerInterfacesSync(DescribeZookeeperServerInterfacesRequest req)
        {
             JsonResponseModel<DescribeZookeeperServerInterfacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZookeeperServerInterfaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZookeeperServerInterfacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改引擎公网访问配置
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineInternetAccessRequest"/></param>
        /// <returns><see cref="UpdateEngineInternetAccessResponse"/></returns>
        public async Task<UpdateEngineInternetAccessResponse> UpdateEngineInternetAccess(UpdateEngineInternetAccessRequest req)
        {
             JsonResponseModel<UpdateEngineInternetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEngineInternetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEngineInternetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改引擎公网访问配置
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineInternetAccessRequest"/></param>
        /// <returns><see cref="UpdateEngineInternetAccessResponse"/></returns>
        public UpdateEngineInternetAccessResponse UpdateEngineInternetAccessSync(UpdateEngineInternetAccessRequest req)
        {
             JsonResponseModel<UpdateEngineInternetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEngineInternetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEngineInternetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
