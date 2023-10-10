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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetAttackWhiteListRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否全部主机； 0否，1是。
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// 来源IP 单IP:1.1.1.1  IP范围:1.1.1.1-1.1.2.1  IP范围：1.1.1.0/24 
        /// </summary>
        [JsonProperty("SrcIp")]
        public string[] SrcIp{ get; set; }

        /// <summary>
        /// 是否加白所有符合该规则的告警 ，1:处理,0:不处理
        /// </summary>
        [JsonProperty("DealOldEvents")]
        public ulong? DealOldEvents{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// quuid 列表
        /// </summary>
        [JsonProperty("QuuidList")]
        public string[] QuuidList{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "SrcIp.", this.SrcIp);
            this.SetParamSimple(map, prefix + "DealOldEvents", this.DealOldEvents);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "QuuidList.", this.QuuidList);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

