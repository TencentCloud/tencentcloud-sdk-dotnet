/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Yunsou.V20180504
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Yunsou.V20180504.Models;

   public class YunsouClient : AbstractClient{

       private const string endpoint = "yunsou.tencentcloudapi.com";
       private const string version = "2018-05-04";
       private const string sdkVersion = "SDK_NET_3.0.1273";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YunsouClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public YunsouClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 上传云搜数据的API接口
        /// </summary>
        /// <param name="req"><see cref="DataManipulationRequest"/></param>
        /// <returns><see cref="DataManipulationResponse"/></returns>
        public Task<DataManipulationResponse> DataManipulation(DataManipulationRequest req)
        {
            return InternalRequestAsync<DataManipulationResponse>(req, "DataManipulation");
        }

        /// <summary>
        /// 上传云搜数据的API接口
        /// </summary>
        /// <param name="req"><see cref="DataManipulationRequest"/></param>
        /// <returns><see cref="DataManipulationResponse"/></returns>
        public DataManipulationResponse DataManipulationSync(DataManipulationRequest req)
        {
            return InternalRequestAsync<DataManipulationResponse>(req, "DataManipulation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于检索云搜中的数据
        /// </summary>
        /// <param name="req"><see cref="DataSearchRequest"/></param>
        /// <returns><see cref="DataSearchResponse"/></returns>
        public Task<DataSearchResponse> DataSearch(DataSearchRequest req)
        {
            return InternalRequestAsync<DataSearchResponse>(req, "DataSearch");
        }

        /// <summary>
        /// 用于检索云搜中的数据
        /// </summary>
        /// <param name="req"><see cref="DataSearchRequest"/></param>
        /// <returns><see cref="DataSearchResponse"/></returns>
        public DataSearchResponse DataSearchSync(DataSearchRequest req)
        {
            return InternalRequestAsync<DataSearchResponse>(req, "DataSearch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
