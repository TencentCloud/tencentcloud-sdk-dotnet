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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartOptimizerPolicy : AbstractModel
    {
        
        /// <summary>
        /// 是否继承
        /// </summary>
        [JsonProperty("Inherit")]
        public string Inherit{ get; set; }

        /// <summary>
        /// 数据治理资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceInfo[] Resources{ get; set; }

        /// <summary>
        /// 数据重写策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Written")]
        public SmartOptimizerWrittenPolicy Written{ get; set; }

        /// <summary>
        /// 数据过期策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lifecycle")]
        public SmartOptimizerLifecyclePolicy Lifecycle{ get; set; }

        /// <summary>
        /// SmartOptimizerIndexPolicy
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Index")]
        public SmartOptimizerIndexPolicy Index{ get; set; }

        /// <summary>
        /// SmartOptimizerChangeTablePolicy
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChangeTable")]
        public SmartOptimizerChangeTablePolicy ChangeTable{ get; set; }

        /// <summary>
        /// 表过期策略
        /// </summary>
        [JsonProperty("TableExpiration")]
        public TableExpirationPolicy TableExpiration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Inherit", this.Inherit);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "Written.", this.Written);
            this.SetParamObj(map, prefix + "Lifecycle.", this.Lifecycle);
            this.SetParamObj(map, prefix + "Index.", this.Index);
            this.SetParamObj(map, prefix + "ChangeTable.", this.ChangeTable);
            this.SetParamObj(map, prefix + "TableExpiration.", this.TableExpiration);
        }
    }
}

