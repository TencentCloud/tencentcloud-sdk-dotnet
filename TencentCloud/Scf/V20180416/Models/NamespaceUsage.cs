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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamespaceUsage : AbstractModel
    {
        
        /// <summary>
        /// 函数数组
        /// </summary>
        [JsonProperty("Functions")]
        public string[] Functions{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 命名空间函数个数
        /// </summary>
        [JsonProperty("FunctionsCount")]
        public long? FunctionsCount{ get; set; }

        /// <summary>
        /// 命名空间配额总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalConcurrencyMem")]
        public long? TotalConcurrencyMem{ get; set; }

        /// <summary>
        /// 命名空间配额使用量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalAllocatedConcurrencyMem")]
        public long? TotalAllocatedConcurrencyMem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "FunctionsCount", this.FunctionsCount);
            this.SetParamSimple(map, prefix + "TotalConcurrencyMem", this.TotalConcurrencyMem);
            this.SetParamSimple(map, prefix + "TotalAllocatedConcurrencyMem", this.TotalAllocatedConcurrencyMem);
        }
    }
}

