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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyModuleNetworkRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块Id
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 默认出带宽上限
        /// </summary>
        [JsonProperty("DefaultBandwidth")]
        public long? DefaultBandwidth{ get; set; }

        /// <summary>
        /// 默认入带宽上限
        /// </summary>
        [JsonProperty("DefaultBandwidthIn")]
        public long? DefaultBandwidthIn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "DefaultBandwidth", this.DefaultBandwidth);
            this.SetParamSimple(map, prefix + "DefaultBandwidthIn", this.DefaultBandwidthIn);
        }
    }
}

