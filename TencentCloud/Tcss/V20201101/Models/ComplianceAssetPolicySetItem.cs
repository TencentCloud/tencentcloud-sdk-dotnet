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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComplianceAssetPolicySetItem : AbstractModel
    {
        
        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("CustomerAssetItemId")]
        public ulong? CustomerAssetItemId{ get; set; }

        /// <summary>
        /// 需要忽略指定资产内的检查项ID列表，为空表示所有
        /// </summary>
        [JsonProperty("CustomerPolicyItemIdSet")]
        public ulong?[] CustomerPolicyItemIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerAssetItemId", this.CustomerAssetItemId);
            this.SetParamArraySimple(map, prefix + "CustomerPolicyItemIdSet.", this.CustomerPolicyItemIdSet);
        }
    }
}

