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
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（DeleteCert）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertRequest"/></param>
        /// <returns><see cref="DeleteCertResponse"/></returns>
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
        /// DeleteCert接口的同步版本，本接口（DeleteCert）用于删除证书。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCertRequest"/></param>
        /// <returns>参考<see cref="DeleteCertResponse"/>实例</returns>
        public DeleteCertResponse DeleteCertSync(DeleteCertRequest req)
        {
             JsonResponseModel<DeleteCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCert");
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
        /// <param name="req"><see cref="DescribeCertListRequest"/></param>
        /// <returns><see cref="DescribeCertListResponse"/></returns>
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
        /// DescribeCertList接口的同步版本，本接口(DescribeCertList)用于获取证书列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCertListRequest"/></param>
        /// <returns>参考<see cref="DescribeCertListResponse"/>实例</returns>
        public DescribeCertListResponse DescribeCertListSync(DescribeCertListRequest req)
        {
             JsonResponseModel<DescribeCertListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertList");
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
        /// <param name="req"><see cref="UploadCertRequest"/></param>
        /// <returns><see cref="UploadCertResponse"/></returns>
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

        /// <summary>
        /// UploadCert接口的同步版本，本接口（UploadCert）用于上传证书。
        /// </summary>
        /// <param name="req">参考<see cref="UploadCertRequest"/></param>
        /// <returns>参考<see cref="UploadCertResponse"/>实例</returns>
        public UploadCertResponse UploadCertSync(UploadCertRequest req)
        {
             JsonResponseModel<UploadCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadCert");
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
