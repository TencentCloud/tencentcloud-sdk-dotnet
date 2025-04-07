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

namespace TencentCloud.Cloudapp.V20220530
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudapp.V20220530.Models;

   public class CloudappClient : AbstractClient{

       private const string endpoint = "cloudapp.tencentcloudapi.com";
       private const string version = "2022-05-30";
       private const string sdkVersion = "SDK_NET_3.0.1216";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudappClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudappClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 从软件进程读取 LICENSE。
        /// </summary>
        /// <param name="req"><see cref="VerifyLicenseRequest"/></param>
        /// <returns><see cref="VerifyLicenseResponse"/></returns>
        public Task<VerifyLicenseResponse> VerifyLicense(VerifyLicenseRequest req)
        {
            return InternalRequestAsync<VerifyLicenseResponse>(req, "VerifyLicense");
        }

        /// <summary>
        /// 从软件进程读取 LICENSE。
        /// </summary>
        /// <param name="req"><see cref="VerifyLicenseRequest"/></param>
        /// <returns><see cref="VerifyLicenseResponse"/></returns>
        public VerifyLicenseResponse VerifyLicenseSync(VerifyLicenseRequest req)
        {
            return InternalRequestAsync<VerifyLicenseResponse>(req, "VerifyLicense")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
