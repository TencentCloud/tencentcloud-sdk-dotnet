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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EipAddressRelation : AbstractModel
    {
        
        /// <summary>
        /// 高防弹性公网IP绑定的实例地区，例如hk代表中国香港
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipAddressRegion")]
        public string EipAddressRegion{ get; set; }

        /// <summary>
        /// 绑定的资源实例ID。可能是一个CVM。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipBoundRscIns")]
        public string EipBoundRscIns{ get; set; }

        /// <summary>
        /// 绑定的弹性网卡ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipBoundRscEni")]
        public string EipBoundRscEni{ get; set; }

        /// <summary>
        /// 绑定的资源内网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EipBoundRscVip")]
        public string EipBoundRscVip{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EipAddressRegion", this.EipAddressRegion);
            this.SetParamSimple(map, prefix + "EipBoundRscIns", this.EipBoundRscIns);
            this.SetParamSimple(map, prefix + "EipBoundRscEni", this.EipBoundRscEni);
            this.SetParamSimple(map, prefix + "EipBoundRscVip", this.EipBoundRscVip);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

