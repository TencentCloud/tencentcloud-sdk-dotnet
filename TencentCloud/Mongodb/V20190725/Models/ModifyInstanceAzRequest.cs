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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAzRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID，例如：cmgo-p8vn****。请登录 <a href="https://console.cloud.tencent.com/mongodb">MongoDB 控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>主节点所在的可用区 ID。获取方式，请参见<a href="https://cloud.tencent.com/document/product/240/3637">地域和可用区</a>。</p>
        /// </summary>
        [JsonProperty("PrimaryNodeZone")]
        public string PrimaryNodeZone{ get; set; }

        /// <summary>
        /// <p>从节点所在的可用区 ID 列表。<br><strong>注意</strong>：不可包含主节点与 Hidden 节点所在的可用区。</p>
        /// </summary>
        [JsonProperty("SecondaryNodeZone")]
        public string[] SecondaryNodeZone{ get; set; }

        /// <summary>
        /// <p>若当前实例未配置 Hidden 节点，则无需传入此参数。</p>
        /// </summary>
        [JsonProperty("HiddenNodeZone")]
        public string HiddenNodeZone{ get; set; }

        /// <summary>
        /// <p>只读节点所在的可用区 ID 列表。<br><strong>注意</strong>：若当前实例已包含只读节点，则此参数为必填项。</p>
        /// </summary>
        [JsonProperty("ReadonlyNodeZone")]
        public string[] ReadonlyNodeZone{ get; set; }

        /// <summary>
        /// <p>指定切换可用区的执行时间策略。</p><ul><li>0：立即执行切换。</li><li>1：在设定的维护时间窗执行切换。具体信息，请参见<a href="https://cloud.tencent.com/document/product/240/19910">设置实例维护时间</a>。</li></ul>
        /// </summary>
        [JsonProperty("InMaintenance")]
        public ulong? InMaintenance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PrimaryNodeZone", this.PrimaryNodeZone);
            this.SetParamArraySimple(map, prefix + "SecondaryNodeZone.", this.SecondaryNodeZone);
            this.SetParamSimple(map, prefix + "HiddenNodeZone", this.HiddenNodeZone);
            this.SetParamArraySimple(map, prefix + "ReadonlyNodeZone.", this.ReadonlyNodeZone);
            this.SetParamSimple(map, prefix + "InMaintenance", this.InMaintenance);
        }
    }
}

