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

    public class NodeSpecFamily : AbstractModel
    {
        
        /// <summary>
        /// 机型
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// 机型名称
        /// </summary>
        [JsonProperty("FamilyName")]
        public string FamilyName{ get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// InstanceType的列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public NodeSpecInstanceType[] InstanceTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "FamilyName", this.FamilyName);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArrayObj(map, prefix + "InstanceTypes.", this.InstanceTypes);
        }
    }
}

