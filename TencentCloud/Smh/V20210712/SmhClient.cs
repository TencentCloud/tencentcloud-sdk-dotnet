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

namespace TencentCloud.Smh.V20210712
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Smh.V20210712.Models;

   public class SmhClient : AbstractClient{

       private const string endpoint = "smh.tencentcloudapi.com";
       private const string version = "2021-07-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmhClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SmhClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="CreateLibraryRequest"/></param>
        /// <returns><see cref="CreateLibraryResponse"/></returns>
        public async Task<CreateLibraryResponse> CreateLibrary(CreateLibraryRequest req)
        {
             JsonResponseModel<CreateLibraryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="CreateLibraryRequest"/></param>
        /// <returns><see cref="CreateLibraryResponse"/></returns>
        public CreateLibraryResponse CreateLibrarySync(CreateLibraryRequest req)
        {
             JsonResponseModel<CreateLibraryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraryRequest"/></param>
        /// <returns><see cref="DeleteLibraryResponse"/></returns>
        public async Task<DeleteLibraryResponse> DeleteLibrary(DeleteLibraryRequest req)
        {
             JsonResponseModel<DeleteLibraryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除 PaaS 服务媒体库
        /// </summary>
        /// <param name="req"><see cref="DeleteLibraryRequest"/></param>
        /// <returns><see cref="DeleteLibraryResponse"/></returns>
        public DeleteLibraryResponse DeleteLibrarySync(DeleteLibraryRequest req)
        {
             JsonResponseModel<DeleteLibraryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrariesRequest"/></param>
        /// <returns><see cref="DescribeLibrariesResponse"/></returns>
        public async Task<DescribeLibrariesResponse> DescribeLibraries(DescribeLibrariesRequest req)
        {
             JsonResponseModel<DescribeLibrariesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLibraries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLibrariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrariesRequest"/></param>
        /// <returns><see cref="DescribeLibrariesResponse"/></returns>
        public DescribeLibrariesResponse DescribeLibrariesSync(DescribeLibrariesRequest req)
        {
             JsonResponseModel<DescribeLibrariesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLibraries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLibrariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrarySecretRequest"/></param>
        /// <returns><see cref="DescribeLibrarySecretResponse"/></returns>
        public async Task<DescribeLibrarySecretResponse> DescribeLibrarySecret(DescribeLibrarySecretRequest req)
        {
             JsonResponseModel<DescribeLibrarySecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLibrarySecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLibrarySecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询 PaaS 服务媒体库密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeLibrarySecretRequest"/></param>
        /// <returns><see cref="DescribeLibrarySecretResponse"/></returns>
        public DescribeLibrarySecretResponse DescribeLibrarySecretSync(DescribeLibrarySecretRequest req)
        {
             JsonResponseModel<DescribeLibrarySecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLibrarySecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLibrarySecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询官方云盘实例
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialInstancesRequest"/></param>
        /// <returns><see cref="DescribeOfficialInstancesResponse"/></returns>
        public async Task<DescribeOfficialInstancesResponse> DescribeOfficialInstances(DescribeOfficialInstancesRequest req)
        {
             JsonResponseModel<DescribeOfficialInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfficialInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfficialInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询官方云盘实例
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialInstancesRequest"/></param>
        /// <returns><see cref="DescribeOfficialInstancesResponse"/></returns>
        public DescribeOfficialInstancesResponse DescribeOfficialInstancesSync(DescribeOfficialInstancesRequest req)
        {
             JsonResponseModel<DescribeOfficialInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfficialInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfficialInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询官方云盘实例概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialOverviewRequest"/></param>
        /// <returns><see cref="DescribeOfficialOverviewResponse"/></returns>
        public async Task<DescribeOfficialOverviewResponse> DescribeOfficialOverview(DescribeOfficialOverviewRequest req)
        {
             JsonResponseModel<DescribeOfficialOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOfficialOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfficialOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询官方云盘实例概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeOfficialOverviewRequest"/></param>
        /// <returns><see cref="DescribeOfficialOverviewResponse"/></returns>
        public DescribeOfficialOverviewResponse DescribeOfficialOverviewSync(DescribeOfficialOverviewRequest req)
        {
             JsonResponseModel<DescribeOfficialOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOfficialOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOfficialOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流量资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public async Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流量资源包
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 PaaS 服务媒体库配置项
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraryRequest"/></param>
        /// <returns><see cref="ModifyLibraryResponse"/></returns>
        public async Task<ModifyLibraryResponse> ModifyLibrary(ModifyLibraryRequest req)
        {
             JsonResponseModel<ModifyLibraryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改 PaaS 服务媒体库配置项
        /// </summary>
        /// <param name="req"><see cref="ModifyLibraryRequest"/></param>
        /// <returns><see cref="ModifyLibraryResponse"/></returns>
        public ModifyLibraryResponse ModifyLibrarySync(ModifyLibraryRequest req)
        {
             JsonResponseModel<ModifyLibraryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLibrary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLibraryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送用于换绑官方云盘实例的超级管理员账号的短信验证码
        /// </summary>
        /// <param name="req"><see cref="SendSmsCodeRequest"/></param>
        /// <returns><see cref="SendSmsCodeResponse"/></returns>
        public async Task<SendSmsCodeResponse> SendSmsCode(SendSmsCodeRequest req)
        {
             JsonResponseModel<SendSmsCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSmsCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送用于换绑官方云盘实例的超级管理员账号的短信验证码
        /// </summary>
        /// <param name="req"><see cref="SendSmsCodeRequest"/></param>
        /// <returns><see cref="SendSmsCodeResponse"/></returns>
        public SendSmsCodeResponse SendSmsCodeSync(SendSmsCodeRequest req)
        {
             JsonResponseModel<SendSmsCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendSmsCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证短信验证码以换绑官方云盘实例的超级管理员账号
        /// </summary>
        /// <param name="req"><see cref="VerifySmsCodeRequest"/></param>
        /// <returns><see cref="VerifySmsCodeResponse"/></returns>
        public async Task<VerifySmsCodeResponse> VerifySmsCode(VerifySmsCodeRequest req)
        {
             JsonResponseModel<VerifySmsCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifySmsCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifySmsCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证短信验证码以换绑官方云盘实例的超级管理员账号
        /// </summary>
        /// <param name="req"><see cref="VerifySmsCodeRequest"/></param>
        /// <returns><see cref="VerifySmsCodeResponse"/></returns>
        public VerifySmsCodeResponse VerifySmsCodeSync(VerifySmsCodeRequest req)
        {
             JsonResponseModel<VerifySmsCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifySmsCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifySmsCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
