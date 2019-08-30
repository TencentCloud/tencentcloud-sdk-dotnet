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

namespace TencentCloud.Wss.V20180426
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Wss.V20180426.Models;

   public class WssClient : AbstractClient{

       private const string endpoint = "wss.tencentcloudapi.com";
       private const string version = "2018-04-26";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public WssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public WssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（DeleteCert）用于删除证书。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCertRequest"/></param>
        /// <returns>参考<see cref="DeleteCertResponse"/>实例</returns>
        public async Task<DeleteCertResponse> DeleteCert(DeleteCertRequest req)
        {
             JsonResponseModel<DeleteCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeCertList)用于获取证书列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCertListRequest"/></param>
        /// <returns>参考<see cref="DescribeCertListResponse"/>实例</returns>
        public async Task<DescribeCertListResponse> DescribeCertList(DescribeCertListRequest req)
        {
             JsonResponseModel<DescribeCertListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UploadCert）用于上传证书。
        /// </summary>
        /// <param name="req">参考<see cref="UploadCertRequest"/></param>
        /// <returns>参考<see cref="UploadCertResponse"/>实例</returns>
        public async Task<UploadCertResponse> UploadCert(UploadCertRequest req)
        {
             JsonResponseModel<UploadCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
