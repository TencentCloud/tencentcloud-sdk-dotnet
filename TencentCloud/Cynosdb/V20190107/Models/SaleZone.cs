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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaleZone : AbstractModel
    {
        
        /// <summary>
        /// 可用区英文名
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 可用区数字ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 可用区中文名
        /// </summary>
        [JsonProperty("ZoneZh")]
        public string ZoneZh{ get; set; }

        /// <summary>
        /// 是否支持serverless集群<br>
        /// 0:不支持<br>
        /// 1:支持
        /// </summary>
        [JsonProperty("IsSupportServerless")]
        public long? IsSupportServerless{ get; set; }

        /// <summary>
        /// 是否支持普通集群<br>
        /// 0:不支持<br>
        /// 1:支持
        /// </summary>
        [JsonProperty("IsSupportNormal")]
        public long? IsSupportNormal{ get; set; }

        /// <summary>
        /// 物理区
        /// </summary>
        [JsonProperty("PhysicalZone")]
        public string PhysicalZone{ get; set; }

        /// <summary>
        /// 用户是否有可用区权限
        /// </summary>
        [JsonProperty("HasPermission")]
        public bool? HasPermission{ get; set; }

        /// <summary>
        /// 是否为全链路RDMA可用区
        /// </summary>
        [JsonProperty("IsWholeRdmaZone")]
        public string IsWholeRdmaZone{ get; set; }

        /// <summary>
        /// 当前可用区是否允许新购集群，1:允许，0:不允许
        /// </summary>
        [JsonProperty("IsSupportCreateCluster")]
        public long? IsSupportCreateCluster{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneZh", this.ZoneZh);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
            this.SetParamSimple(map, prefix + "IsSupportNormal", this.IsSupportNormal);
            this.SetParamSimple(map, prefix + "PhysicalZone", this.PhysicalZone);
            this.SetParamSimple(map, prefix + "HasPermission", this.HasPermission);
            this.SetParamSimple(map, prefix + "IsWholeRdmaZone", this.IsWholeRdmaZone);
            this.SetParamSimple(map, prefix + "IsSupportCreateCluster", this.IsSupportCreateCluster);
        }
    }
}

