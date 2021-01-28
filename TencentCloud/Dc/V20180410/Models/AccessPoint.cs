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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessPoint : AbstractModel
    {
        
        /// <summary>
        /// 接入点的名称。
        /// </summary>
        [JsonProperty("AccessPointName")]
        public string AccessPointName{ get; set; }

        /// <summary>
        /// 接入点唯一ID。
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// 接入点的状态。可用，不可用。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 接入点的位置。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 接入点支持的运营商列表。
        /// </summary>
        [JsonProperty("LineOperator")]
        public string[] LineOperator{ get; set; }

        /// <summary>
        /// 接入点管理的大区ID。
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 接入点可用的端口类型列表。1000BASE-T代表千兆电口，1000BASE-LX代表千兆单模光口10km，1000BASE-ZX代表千兆单模光口80km,10GBASE-LR代表万兆单模光口10km,10GBASE-ZR代表万兆单模光口80km,10GBASE-LH代表万兆单模光口40km,100GBASE-LR4代表100G单模光口10km
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailablePortType")]
        public string[] AvailablePortType{ get; set; }

        /// <summary>
        /// 接入点经纬度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Coordinate")]
        public Coordinate Coordinate{ get; set; }

        /// <summary>
        /// 接入点所在城市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessPointName", this.AccessPointName);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamArraySimple(map, prefix + "LineOperator.", this.LineOperator);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamArraySimple(map, prefix + "AvailablePortType.", this.AvailablePortType);
            this.SetParamObj(map, prefix + "Coordinate.", this.Coordinate);
            this.SetParamSimple(map, prefix + "City", this.City);
        }
    }
}

