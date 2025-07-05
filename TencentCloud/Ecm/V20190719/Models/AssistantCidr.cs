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

    public class AssistantCidr : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。形如：vpc-6v2ht8q5
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 辅助CIDR。形如：172.16.0.0/16
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 辅助CIDR类型（0：普通辅助CIDR，1：容器辅助CIDR），默认都是0。
        /// </summary>
        [JsonProperty("AssistantType")]
        public ulong? AssistantType{ get; set; }

        /// <summary>
        /// 辅助CIDR拆分的子网。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetSet")]
        public Subnet[] SubnetSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "AssistantType", this.AssistantType);
            this.SetParamArrayObj(map, prefix + "SubnetSet.", this.SubnetSet);
        }
    }
}

