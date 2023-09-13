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

namespace TencentCloud.Weilingwith.V20230427
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Weilingwith.V20230427.Models;

   public class WeilingwithClient : AbstractClient{

       private const string endpoint = "weilingwith.tencentcloudapi.com";
       private const string version = "2023-04-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WeilingwithClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WeilingwithClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 查询指定空间关联的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public async Task<DescribeApplicationListResponse> DescribeApplicationList(DescribeApplicationListRequest req)
        {
             JsonResponseModel<DescribeApplicationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定空间关联的应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationListRequest"/></param>
        /// <returns><see cref="DescribeApplicationListResponse"/></returns>
        public DescribeApplicationListResponse DescribeApplicationListSync(DescribeApplicationListRequest req)
        {
             JsonResponseModel<DescribeApplicationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘应用凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeApplicationTokenRequest"/></param>
        /// <returns><see cref="DescribeEdgeApplicationTokenResponse"/></returns>
        public async Task<DescribeEdgeApplicationTokenResponse> DescribeEdgeApplicationToken(DescribeEdgeApplicationTokenRequest req)
        {
             JsonResponseModel<DescribeEdgeApplicationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeApplicationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeApplicationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘应用凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeApplicationTokenRequest"/></param>
        /// <returns><see cref="DescribeEdgeApplicationTokenResponse"/></returns>
        public DescribeEdgeApplicationTokenResponse DescribeEdgeApplicationTokenSync(DescribeEdgeApplicationTokenRequest req)
        {
             JsonResponseModel<DescribeEdgeApplicationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeApplicationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeApplicationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInterfaceListRequest"/></param>
        /// <returns><see cref="DescribeInterfaceListResponse"/></returns>
        public async Task<DescribeInterfaceListResponse> DescribeInterfaceList(DescribeInterfaceListRequest req)
        {
             JsonResponseModel<DescribeInterfaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInterfaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInterfaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInterfaceListRequest"/></param>
        /// <returns><see cref="DescribeInterfaceListResponse"/></returns>
        public DescribeInterfaceListResponse DescribeInterfaceListSync(DescribeInterfaceListRequest req)
        {
             JsonResponseModel<DescribeInterfaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInterfaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInterfaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户下的空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceListResponse"/></returns>
        public async Task<DescribeWorkspaceListResponse> DescribeWorkspaceList(DescribeWorkspaceListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取租户下的空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceListResponse"/></returns>
        public DescribeWorkspaceListResponse DescribeWorkspaceListSync(DescribeWorkspaceListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目空间人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceUserListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceUserListResponse"/></returns>
        public async Task<DescribeWorkspaceUserListResponse> DescribeWorkspaceUserList(DescribeWorkspaceUserListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceUserListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkspaceUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目空间人员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkspaceUserListRequest"/></param>
        /// <returns><see cref="DescribeWorkspaceUserListResponse"/></returns>
        public DescribeWorkspaceUserListResponse DescribeWorkspaceUserListSync(DescribeWorkspaceUserListRequest req)
        {
             JsonResponseModel<DescribeWorkspaceUserListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkspaceUserList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkspaceUserListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
