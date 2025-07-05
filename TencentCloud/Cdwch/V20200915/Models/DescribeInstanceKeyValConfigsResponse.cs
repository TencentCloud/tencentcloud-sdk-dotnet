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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceKeyValConfigsResponse : AbstractModel
    {
        
        /// <summary>
        /// 参数列表
        /// </summary>
        [JsonProperty("ConfigItems")]
        public InstanceConfigInfo[] ConfigItems{ get; set; }

        /// <summary>
        /// 未配置的参数列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnConfigItems")]
        public InstanceConfigInfo[] UnConfigItems{ get; set; }

        /// <summary>
        /// 配置的多层级参数列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MapConfigItems")]
        public MapConfigItem[] MapConfigItems{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ConfigItems.", this.ConfigItems);
            this.SetParamArrayObj(map, prefix + "UnConfigItems.", this.UnConfigItems);
            this.SetParamArrayObj(map, prefix + "MapConfigItems.", this.MapConfigItems);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

