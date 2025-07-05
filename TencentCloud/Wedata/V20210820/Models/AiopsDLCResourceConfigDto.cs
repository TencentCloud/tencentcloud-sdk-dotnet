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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiopsDLCResourceConfigDto : AbstractModel
    {
        
        /// <summary>
        /// Driver资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// Executor资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// Executor数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorNumbers")]
        public string ExecutorNumbers{ get; set; }

        /// <summary>
        /// 资源配置方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsInherit")]
        public string IsInherit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNumbers", this.ExecutorNumbers);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
        }
    }
}

