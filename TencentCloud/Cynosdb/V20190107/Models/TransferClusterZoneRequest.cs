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

    public class TransferClusterZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>源集群Id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>目标可用区</p>
        /// </summary>
        [JsonProperty("DstZone")]
        public string DstZone{ get; set; }

        /// <summary>
        /// <p>跨可用区迁移主从数据延迟校验阈值，单位毫秒(ms)</p>
        /// </summary>
        [JsonProperty("MaxLag")]
        public long? MaxLag{ get; set; }

        /// <summary>
        /// <p>Immediate:立即执行，InMaintain:时间窗口执行</p>
        /// </summary>
        [JsonProperty("TransferType")]
        public string TransferType{ get; set; }

        /// <summary>
        /// <p>多可用区备区</p>
        /// </summary>
        [JsonProperty("DstSlaveZone")]
        public string DstSlaveZone{ get; set; }

        /// <summary>
        /// <p>proxy迁移的目标可用区信息</p>
        /// </summary>
        [JsonProperty("ProxyZones")]
        public ProxyZone[] ProxyZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DstZone", this.DstZone);
            this.SetParamSimple(map, prefix + "MaxLag", this.MaxLag);
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamSimple(map, prefix + "DstSlaveZone", this.DstSlaveZone);
            this.SetParamArrayObj(map, prefix + "ProxyZones.", this.ProxyZones);
        }
    }
}

