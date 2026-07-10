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

    public class InquirePriceCreateModelRouterResourcePackageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由资源包容量</p><p>取值范围：[1000, 10000000]</p><p>单次购买的模型路由资源包容量下限为1000，上限为10000000</p>
        /// </summary>
        [JsonProperty("ModelRouterResourcePackageAmount")]
        public ulong? ModelRouterResourcePackageAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelRouterResourcePackageAmount", this.ModelRouterResourcePackageAmount);
        }
    }
}

