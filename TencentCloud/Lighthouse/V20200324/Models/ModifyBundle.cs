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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBundle : AbstractModel
    {
        
        /// <summary>
        /// 更改实例套餐后需要补的差价。
        /// </summary>
        [JsonProperty("ModifyPrice")]
        public Price ModifyPrice{ get; set; }

        /// <summary>
        /// 变更套餐状态。取值：
        /// <li>SOLD_OUT：套餐售罄</li>
        /// <li>AVAILABLE：支持套餐变更</li>
        /// <li>UNAVAILABLE：暂不支持套餐变更</li>
        /// </summary>
        [JsonProperty("ModifyBundleState")]
        public string ModifyBundleState{ get; set; }

        /// <summary>
        /// 套餐信息。
        /// </summary>
        [JsonProperty("Bundle")]
        public Bundle Bundle{ get; set; }

        /// <summary>
        /// 不支持套餐变更原因信息。变更套餐状态为"AVAILABLE"时, 该信息为空
        /// </summary>
        [JsonProperty("NotSupportModifyMessage")]
        public string NotSupportModifyMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ModifyPrice.", this.ModifyPrice);
            this.SetParamSimple(map, prefix + "ModifyBundleState", this.ModifyBundleState);
            this.SetParamObj(map, prefix + "Bundle.", this.Bundle);
            this.SetParamSimple(map, prefix + "NotSupportModifyMessage", this.NotSupportModifyMessage);
        }
    }
}

