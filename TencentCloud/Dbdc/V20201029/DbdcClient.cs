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

namespace TencentCloud.Dbdc.V20201029
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbdc.V20201029.Models;

   public class DbdcClient : AbstractClient{

       private const string endpoint = "dbdc.tencentcloudapi.com";
       private const string version = "2020-10-29";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbdcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DbdcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口用于查询独享集群内的DB实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询独享集群内的DB实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostListRequest"/></param>
        /// <returns><see cref="DescribeHostListResponse"/></returns>
        public async Task<DescribeHostListResponse> DescribeHostList(DescribeHostListRequest req)
        {
             JsonResponseModel<DescribeHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostListRequest"/></param>
        /// <returns><see cref="DescribeHostListResponse"/></returns>
        public DescribeHostListResponse DescribeHostListSync(DescribeHostListRequest req)
        {
             JsonResponseModel<DescribeHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询独享集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public async Task<DescribeInstanceDetailResponse> DescribeInstanceDetail(DescribeInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询独享集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDetailResponse"/></returns>
        public DescribeInstanceDetailResponse DescribeInstanceDetailSync(DescribeInstanceDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询独享集群实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public async Task<DescribeInstanceListResponse> DescribeInstanceList(DescribeInstanceListRequest req)
        {
             JsonResponseModel<DescribeInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查询独享集群实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceListRequest"/></param>
        /// <returns><see cref="DescribeInstanceListResponse"/></returns>
        public DescribeInstanceListResponse DescribeInstanceListSync(DescribeInstanceListRequest req)
        {
             JsonResponseModel<DescribeInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据不同地域不同用户，获取集群列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据不同地域不同用户，获取集群列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public async Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest req)
        {
             JsonResponseModel<ModifyInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyInstanceNameResponse"/></returns>
        public ModifyInstanceNameResponse ModifyInstanceNameSync(ModifyInstanceNameRequest req)
        {
             JsonResponseModel<ModifyInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
