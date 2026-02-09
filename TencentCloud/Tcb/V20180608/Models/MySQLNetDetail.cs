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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MySQLNetDetail : AbstractModel
    {
        
        /// <summary>
        /// 内网地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateNetAddress")]
        public string PrivateNetAddress{ get; set; }

        /// <summary>
        /// 外网地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PubNetAddress")]
        public string PubNetAddress{ get; set; }

        /// <summary>
        /// 网络信息（VPCID/SubnetID）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Net")]
        public string Net{ get; set; }

        /// <summary>
        /// 是否开通公网
        /// </summary>
        [JsonProperty("PubNetAccessEnabled")]
        public bool? PubNetAccessEnabled{ get; set; }

        /// <summary>
        /// vpc id 
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// vpc name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网名
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivateNetAddress", this.PrivateNetAddress);
            this.SetParamSimple(map, prefix + "PubNetAddress", this.PubNetAddress);
            this.SetParamSimple(map, prefix + "Net", this.Net);
            this.SetParamSimple(map, prefix + "PubNetAccessEnabled", this.PubNetAccessEnabled);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
        }
    }
}

