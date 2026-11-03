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

    public class HostAutoScaleConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>主机自动扩容开关<br>枚举值：<br>ON：开启<br>OFF：关闭<br>补充说明：不传则不修改；映射底层自动加购开关 auto_repurchase_switch</p>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>扩容版本<br>枚举值：<br>PRO：专业版<br>ULTIMATE：旗舰版<br>补充说明：不传则不修改</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>扩容资产范围</p><p>枚举值：</p><ul><li>ALL： 全部资产</li><li>BY_TAG： 按标签扩容</li></ul>
        /// </summary>
        [JsonProperty("AssetRange")]
        public string AssetRange{ get; set; }

        /// <summary>
        /// <p>标签ID列表</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public long?[] TagIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
        }
    }
}

