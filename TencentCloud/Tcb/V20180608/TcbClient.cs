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

namespace TencentCloud.Tcb.V20180608
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcb.V20180608.Models;

   public class TcbClient : AbstractClient{

       private const string endpoint = "tcb.tencentcloudapi.com";
       private const string version = "2018-06-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取数据库权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns><see cref="DescribeDatabaseACLResponse"/></returns>
        public async Task<DescribeDatabaseACLResponse> DescribeDatabaseACL(DescribeDatabaseACLRequest req)
        {
             JsonResponseModel<DescribeDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDatabaseACL接口的同步版本，获取数据库权限
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDatabaseACLRequest"/></param>
        /// <returns>参考<see cref="DescribeDatabaseACLResponse"/>实例</returns>
        public DescribeDatabaseACLResponse DescribeDatabaseACLSync(DescribeDatabaseACLRequest req)
        {
             JsonResponseModel<DescribeDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvsRequest"/></param>
        /// <returns><see cref="DescribeEnvsResponse"/></returns>
        public async Task<DescribeEnvsResponse> DescribeEnvs(DescribeEnvsRequest req)
        {
             JsonResponseModel<DescribeEnvsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEnvs接口的同步版本，获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req">参考<see cref="DescribeEnvsRequest"/></param>
        /// <returns>参考<see cref="DescribeEnvsResponse"/>实例</returns>
        public DescribeEnvsResponse DescribeEnvsSync(DescribeEnvsRequest req)
        {
             JsonResponseModel<DescribeEnvsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据库权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDatabaseACLRequest"/></param>
        /// <returns><see cref="ModifyDatabaseACLResponse"/></returns>
        public async Task<ModifyDatabaseACLResponse> ModifyDatabaseACL(ModifyDatabaseACLRequest req)
        {
             JsonResponseModel<ModifyDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDatabaseACL接口的同步版本，修改数据库权限
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDatabaseACLRequest"/></param>
        /// <returns>参考<see cref="ModifyDatabaseACLResponse"/>实例</returns>
        public ModifyDatabaseACLResponse ModifyDatabaseACLSync(ModifyDatabaseACLRequest req)
        {
             JsonResponseModel<ModifyDatabaseACLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDatabaseACL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDatabaseACLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新环境信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEnvRequest"/></param>
        /// <returns><see cref="ModifyEnvResponse"/></returns>
        public async Task<ModifyEnvResponse> ModifyEnv(ModifyEnvRequest req)
        {
             JsonResponseModel<ModifyEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyEnv接口的同步版本，更新环境信息
        /// </summary>
        /// <param name="req">参考<see cref="ModifyEnvRequest"/></param>
        /// <returns>参考<see cref="ModifyEnvResponse"/>实例</returns>
        public ModifyEnvResponse ModifyEnvSync(ModifyEnvRequest req)
        {
             JsonResponseModel<ModifyEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
