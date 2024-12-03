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
       private const string sdkVersion = "SDK_NET_3.0.1134";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（DeleteCert）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertRequest"/></param>
        /// <returns><see cref="DeleteCertResponse"/></returns>
        public Task<DeleteCertResponse> DeleteCert(DeleteCertRequest req)
        {
            return InternalRequestAsync<DeleteCertResponse>(req, "DeleteCert");
        }

        /// <summary>
        /// 本接口（DeleteCert）用于删除证书。
        /// </summary>
        /// <param name="req"><see cref="DeleteCertRequest"/></param>
        /// <returns><see cref="DeleteCertResponse"/></returns>
        public DeleteCertResponse DeleteCertSync(DeleteCertRequest req)
        {
            return InternalRequestAsync<DeleteCertResponse>(req, "DeleteCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeCertList)用于获取证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertListRequest"/></param>
        /// <returns><see cref="DescribeCertListResponse"/></returns>
        public Task<DescribeCertListResponse> DescribeCertList(DescribeCertListRequest req)
        {
            return InternalRequestAsync<DescribeCertListResponse>(req, "DescribeCertList");
        }

        /// <summary>
        /// 本接口(DescribeCertList)用于获取证书列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCertListRequest"/></param>
        /// <returns><see cref="DescribeCertListResponse"/></returns>
        public DescribeCertListResponse DescribeCertListSync(DescribeCertListRequest req)
        {
            return InternalRequestAsync<DescribeCertListResponse>(req, "DescribeCertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UploadCert）用于上传证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertRequest"/></param>
        /// <returns><see cref="UploadCertResponse"/></returns>
        public Task<UploadCertResponse> UploadCert(UploadCertRequest req)
        {
            return InternalRequestAsync<UploadCertResponse>(req, "UploadCert");
        }

        /// <summary>
        /// 本接口（UploadCert）用于上传证书。
        /// </summary>
        /// <param name="req"><see cref="UploadCertRequest"/></param>
        /// <returns><see cref="UploadCertResponse"/></returns>
        public UploadCertResponse UploadCertSync(UploadCertRequest req)
        {
            return InternalRequestAsync<UploadCertResponse>(req, "UploadCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
