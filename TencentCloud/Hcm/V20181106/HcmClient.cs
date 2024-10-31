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

namespace TencentCloud.Hcm.V20181106
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hcm.V20181106.Models;

   public class HcmClient : AbstractClient{

       private const string endpoint = "hcm.tencentcloudapi.com";
       private const string version = "2018-11-06";
       private const string sdkVersion = "SDK_NET_3.0.1114";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HcmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HcmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 速算题目批改接口，根据用户上传的图片或图片的URL识别图片中的数学算式，进而给出算式的正确性评估。
        /// </summary>
        /// <param name="req"><see cref="EvaluationRequest"/></param>
        /// <returns><see cref="EvaluationResponse"/></returns>
        public Task<EvaluationResponse> Evaluation(EvaluationRequest req)
        {
            return InternalRequestAsync<EvaluationResponse>(req, "Evaluation");
        }

        /// <summary>
        /// 速算题目批改接口，根据用户上传的图片或图片的URL识别图片中的数学算式，进而给出算式的正确性评估。
        /// </summary>
        /// <param name="req"><see cref="EvaluationRequest"/></param>
        /// <returns><see cref="EvaluationResponse"/></returns>
        public EvaluationResponse EvaluationSync(EvaluationRequest req)
        {
            return InternalRequestAsync<EvaluationResponse>(req, "Evaluation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
