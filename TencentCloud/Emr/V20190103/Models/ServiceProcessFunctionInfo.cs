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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceProcessFunctionInfo : AbstractModel
    {
        
        /// <summary>
        /// 探测告警级别
        /// </summary>
        [JsonProperty("DetectAlert")]
        public string DetectAlert{ get; set; }

        /// <summary>
        /// 探测功能描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetetcFunctionKey")]
        [System.Obsolete]
        public string DetetcFunctionKey{ get; set; }

        /// <summary>
        /// 探测功能结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetetcFunctionValue")]
        [System.Obsolete]
        public string DetetcFunctionValue{ get; set; }

        /// <summary>
        /// 探测结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetetcTime")]
        [System.Obsolete]
        public string DetetcTime{ get; set; }

        /// <summary>
        /// 探测功能描述
        /// </summary>
        [JsonProperty("DetectFunctionKey")]
        public string DetectFunctionKey{ get; set; }

        /// <summary>
        /// 探测功能结果
        /// </summary>
        [JsonProperty("DetectFunctionValue")]
        public string DetectFunctionValue{ get; set; }

        /// <summary>
        /// 探测结果
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DetectAlert", this.DetectAlert);
            this.SetParamSimple(map, prefix + "DetetcFunctionKey", this.DetetcFunctionKey);
            this.SetParamSimple(map, prefix + "DetetcFunctionValue", this.DetetcFunctionValue);
            this.SetParamSimple(map, prefix + "DetetcTime", this.DetetcTime);
            this.SetParamSimple(map, prefix + "DetectFunctionKey", this.DetectFunctionKey);
            this.SetParamSimple(map, prefix + "DetectFunctionValue", this.DetectFunctionValue);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
        }
    }
}

