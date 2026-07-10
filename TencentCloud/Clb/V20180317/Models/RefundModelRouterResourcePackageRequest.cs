/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefundModelRouterResourcePackageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待退还的模型路由资源包Id</p><p>非有效状态或者设置了自动续订且自动续订已生效的资源包不允许退款。</p>
        /// </summary>
        [JsonProperty("ModelRouterResourcePackageIds")]
        public string[] ModelRouterResourcePackageIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ModelRouterResourcePackageIds.", this.ModelRouterResourcePackageIds);
        }
    }
}

