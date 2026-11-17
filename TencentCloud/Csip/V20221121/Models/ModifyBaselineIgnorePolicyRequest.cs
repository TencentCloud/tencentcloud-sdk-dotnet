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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBaselineIgnorePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>检测项 ID，标识对哪个检测项设置忽略策略。</p>
        /// </summary>
        [JsonProperty("ItemID")]
        public ulong? ItemID{ get; set; }

        /// <summary>
        /// <p>忽略范围类型。</p><p>枚举值：</p><ul><li>ALL： 全部资产</li><li>PICK： 指定资产</li></ul>
        /// </summary>
        [JsonProperty("ScopeType")]
        public string ScopeType{ get; set; }

        /// <summary>
        /// <p>备注信息。</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>忽略策略记录 ID。新建时传 0，更新时传对应记录 ID。</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>自选资产 ID 列表，PICK 时生效，传入 instance-id 或集群 ID。</p>
        /// </summary>
        [JsonProperty("ScopeIncludeList")]
        public string[] ScopeIncludeList{ get; set; }

        /// <summary>
        /// <p>剔除资产 ID 列表，ALL 时生效，传入 instance-id 或集群 ID。</p>
        /// </summary>
        [JsonProperty("ScopeExcludeList")]
        public string[] ScopeExcludeList{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamSimple(map, prefix + "ScopeType", this.ScopeType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamArraySimple(map, prefix + "ScopeIncludeList.", this.ScopeIncludeList);
            this.SetParamArraySimple(map, prefix + "ScopeExcludeList.", this.ScopeExcludeList);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

