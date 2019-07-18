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

namespace TencentCloud.Drm.V20181115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Drm.V20181115.Models;

   public class DrmClient : AbstractClient{

       private const string endpoint = "drm.tencentcloudapi.com";
       private const string version = "2018-11-15";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public DrmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public DrmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口用来设置fairplay方案所需的私钥、私钥密钥、ask等信息。
        /// 如需使用fairplay方案，请务必先设置私钥。
        /// </summary>
        /// <param name="req">参考<see cref="AddFairPlayPemRequest"/></param>
        /// <returns>参考<see cref="AddFairPlayPemResponse"/>实例</returns>
        public async Task<AddFairPlayPemResponse> AddFairPlayPem(AddFairPlayPemRequest req)
        {
             JsonResponseModel<AddFairPlayPemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddFairPlayPem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddFairPlayPemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来生成DRM方案对应的播放许可证，开发者需提供DRM方案类型、内容类型参数，后台将生成许可证后返回许可证数据
        /// 开发者需要转发终端设备发出的许可证请求信息。
        /// </summary>
        /// <param name="req">参考<see cref="CreateLicenseRequest"/></param>
        /// <returns>参考<see cref="CreateLicenseResponse"/>实例</returns>
        public async Task<CreateLicenseResponse> CreateLicense(CreateLicenseRequest req)
        {
             JsonResponseModel<CreateLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来删除fairplay方案的私钥、ask等信息
        /// 注：高风险操作，删除后，您将无法使用腾讯云DRM提供的fairplay服务。
        /// 由于缓存，删除操作需要约半小时生效
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFairPlayPemRequest"/></param>
        /// <returns>参考<see cref="DeleteFairPlayPemResponse"/>实例</returns>
        public async Task<DeleteFairPlayPemResponse> DeleteFairPlayPem(DeleteFairPlayPemRequest req)
        {
             JsonResponseModel<DeleteFairPlayPemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFairPlayPem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFairPlayPemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用来查询设置的FairPlay私钥校验信息。可用该接口校验设置的私钥与本身的私钥是否一致。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFairPlayPemRequest"/></param>
        /// <returns>参考<see cref="DescribeFairPlayPemResponse"/>实例</returns>
        public async Task<DescribeFairPlayPemResponse> DescribeFairPlayPem(DescribeFairPlayPemRequest req)
        {
             JsonResponseModel<DescribeFairPlayPemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFairPlayPem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFairPlayPemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开发者需要指定使用的DRM类型、和需要加密的Track类型，后台返回加密使用的密钥
        /// 如果加密使用的ContentID没有关联的密钥信息，后台会自动生成新的密钥返回
        /// </summary>
        /// <param name="req">参考<see cref="DescribeKeysRequest"/></param>
        /// <returns>参考<see cref="DescribeKeysResponse"/>实例</returns>
        public async Task<DescribeKeysResponse> DescribeKeys(DescribeKeysRequest req)
        {
             JsonResponseModel<DescribeKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用来设置fairplay方案所需的私钥、私钥密钥、ask等信息。
        /// 如需使用fairplay方案，请务必先设置私钥。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyFairPlayPemRequest"/></param>
        /// <returns>参考<see cref="ModifyFairPlayPemResponse"/>实例</returns>
        public async Task<ModifyFairPlayPemResponse> ModifyFairPlayPem(ModifyFairPlayPemRequest req)
        {
             JsonResponseModel<ModifyFairPlayPemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFairPlayPem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFairPlayPemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开发者调用该接口，启动一次内容文件的DRM加密工作流
        /// </summary>
        /// <param name="req">参考<see cref="StartEncryptionRequest"/></param>
        /// <returns>参考<see cref="StartEncryptionResponse"/>实例</returns>
        public async Task<StartEncryptionResponse> StartEncryption(StartEncryptionRequest req)
        {
             JsonResponseModel<StartEncryptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartEncryption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartEncryptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
