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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExposeInfo : AbstractModel
    {
        
        /// <summary>
        /// 暴露方式，支持 EXTERNAL（外网暴露），VPC （VPC内网打通）
        /// </summary>
        [JsonProperty("ExposeType")]
        public string ExposeType{ get; set; }

        /// <summary>
        /// 暴露Ip。暴露方式为 EXTERNAL 为外网 Ip，暴露方式为 VPC 时为指定 Vpc 下的Vip
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 暴露方式为 VPC 时，打通的私有网络Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 暴露方式为 VPC 时，打通的子网Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// GATEWAY 服务id，ExposeType = GATEWAY 时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GateWayServiceId")]
        public string GateWayServiceId{ get; set; }

        /// <summary>
        /// GATEWAY api id，ExposeType = GATEWAY 时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GateWayAPIId")]
        public string GateWayAPIId{ get; set; }

        /// <summary>
        /// GATEWAY domain，ExposeType = GATEWAY 时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GateWayDomain")]
        public string GateWayDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExposeType", this.ExposeType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "GateWayServiceId", this.GateWayServiceId);
            this.SetParamSimple(map, prefix + "GateWayAPIId", this.GateWayAPIId);
            this.SetParamSimple(map, prefix + "GateWayDomain", this.GateWayDomain);
        }
    }
}

