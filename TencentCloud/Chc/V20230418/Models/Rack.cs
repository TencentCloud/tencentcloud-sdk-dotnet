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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Rack : AbstractModel
    {
        
        /// <summary>
        /// 机架名称
        /// </summary>
        [JsonProperty("RackName")]
        public string RackName{ get; set; }

        /// <summary>
        /// 机架所属的机房管理单元ID
        /// </summary>
        [JsonProperty("IdcUnitId")]
        public ulong? IdcUnitId{ get; set; }

        /// <summary>
        /// 机架所属的机房管理单元名称
        /// </summary>
        [JsonProperty("IdcUnitName")]
        public string IdcUnitName{ get; set; }

        /// <summary>
        /// 机架所属的机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 机架所属的机房ID
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 机架ID
        /// </summary>
        [JsonProperty("RackId")]
        public ulong? RackId{ get; set; }

        /// <summary>
        /// 是否开电
        /// </summary>
        [JsonProperty("IsPowerOn")]
        public bool? IsPowerOn{ get; set; }

        /// <summary>
        /// 机架最近一次开电时间，YYYY-MM-DD 格式
        /// </summary>
        [JsonProperty("RackOpenTime")]
        public string RackOpenTime{ get; set; }

        /// <summary>
        /// 托管类型
        /// </summary>
        [JsonProperty("HostingType")]
        public string HostingType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RackName", this.RackName);
            this.SetParamSimple(map, prefix + "IdcUnitId", this.IdcUnitId);
            this.SetParamSimple(map, prefix + "IdcUnitName", this.IdcUnitName);
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "RackId", this.RackId);
            this.SetParamSimple(map, prefix + "IsPowerOn", this.IsPowerOn);
            this.SetParamSimple(map, prefix + "RackOpenTime", this.RackOpenTime);
            this.SetParamSimple(map, prefix + "HostingType", this.HostingType);
        }
    }
}

