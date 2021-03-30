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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccelerateAreaInfo : AbstractModel
    {
        
        /// <summary>
        /// 加速地区，可选值：
        /// <li>Chinese Mainland：中国境内（不包含港澳台）。</li>
        /// <li>Outside Chinese Mainland：中国境外。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 腾讯禁用原因，可选值：
        /// <li>ForLegalReasons：因法律原因导致关闭加速；</li>
        /// <li>ForOverdueBills：因欠费停服导致关闭加速。</li>
        /// </summary>
        [JsonProperty("TencentDisableReason")]
        public string TencentDisableReason{ get; set; }

        /// <summary>
        /// 加速域名对应的 CNAME 域名。
        /// </summary>
        [JsonProperty("TencentEdgeDomain")]
        public string TencentEdgeDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "TencentDisableReason", this.TencentDisableReason);
            this.SetParamSimple(map, prefix + "TencentEdgeDomain", this.TencentEdgeDomain);
        }
    }
}

