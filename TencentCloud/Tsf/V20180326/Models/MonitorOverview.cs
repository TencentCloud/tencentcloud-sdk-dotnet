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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorOverview : AbstractModel
    {
        
        /// <summary>
        /// 近24小时调用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationCountOfDay")]
        public string InvocationCountOfDay{ get; set; }

        /// <summary>
        /// 总调用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvocationCount")]
        public string InvocationCount{ get; set; }

        /// <summary>
        /// 近24小时调用错误数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCountOfDay")]
        public string ErrorCountOfDay{ get; set; }

        /// <summary>
        /// 总调用错误数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCount")]
        public string ErrorCount{ get; set; }

        /// <summary>
        /// 近24小时调用成功率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessRatioOfDay")]
        public string SuccessRatioOfDay{ get; set; }

        /// <summary>
        /// 总调用成功率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessRatio")]
        public string SuccessRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvocationCountOfDay", this.InvocationCountOfDay);
            this.SetParamSimple(map, prefix + "InvocationCount", this.InvocationCount);
            this.SetParamSimple(map, prefix + "ErrorCountOfDay", this.ErrorCountOfDay);
            this.SetParamSimple(map, prefix + "ErrorCount", this.ErrorCount);
            this.SetParamSimple(map, prefix + "SuccessRatioOfDay", this.SuccessRatioOfDay);
            this.SetParamSimple(map, prefix + "SuccessRatio", this.SuccessRatio);
        }
    }
}

