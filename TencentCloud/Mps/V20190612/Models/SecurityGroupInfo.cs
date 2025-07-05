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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 安全组 ID。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 安全组名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 白名单列表。
        /// </summary>
        [JsonProperty("Whitelist")]
        public string[] Whitelist{ get; set; }

        /// <summary>
        /// 绑定的输入流列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OccupiedInputs")]
        public string[] OccupiedInputs{ get; set; }

        /// <summary>
        /// 安全组地址。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 绑定的输出流列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OccupiedOutputs")]
        public string[] OccupiedOutputs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Whitelist.", this.Whitelist);
            this.SetParamArraySimple(map, prefix + "OccupiedInputs.", this.OccupiedInputs);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArraySimple(map, prefix + "OccupiedOutputs.", this.OccupiedOutputs);
        }
    }
}

