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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecondaryZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// 副可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondaryZone")]
        public string SecondaryZone{ get; set; }

        /// <summary>
        /// 可用区可用的子网id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondarySubnet")]
        public string SecondarySubnet{ get; set; }

        /// <summary>
        /// 可用区可用的子网可用ip的数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserIpNum")]
        public string UserIpNum{ get; set; }

        /// <summary>
        /// 可用区可用的子网可用ip的数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondaryUserSubnetIPNum")]
        public long? SecondaryUserSubnetIPNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecondaryZone", this.SecondaryZone);
            this.SetParamSimple(map, prefix + "SecondarySubnet", this.SecondarySubnet);
            this.SetParamSimple(map, prefix + "UserIpNum", this.UserIpNum);
            this.SetParamSimple(map, prefix + "SecondaryUserSubnetIPNum", this.SecondaryUserSubnetIPNum);
        }
    }
}

