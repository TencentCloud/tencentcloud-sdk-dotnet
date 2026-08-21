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

    public class DescribeLicenseStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>授权状态列表（旗舰版→专业版→RASP）</p>
        /// </summary>
        [JsonProperty("List")]
        public LicenseStatusItem[] List{ get; set; }

        /// <summary>
        /// <p>自动加购开关 0-关 1-开</p>
        /// </summary>
        [JsonProperty("AutoRepurchaseSwitch")]
        public long? AutoRepurchaseSwitch{ get; set; }

        /// <summary>
        /// <p>合并剩余解绑次数 = (旗舰版total + 专业版total) × 2 - 当月已解绑次数</p>
        /// </summary>
        [JsonProperty("UnbindCountLeft")]
        public long? UnbindCountLeft{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "AutoRepurchaseSwitch", this.AutoRepurchaseSwitch);
            this.SetParamSimple(map, prefix + "UnbindCountLeft", this.UnbindCountLeft);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

