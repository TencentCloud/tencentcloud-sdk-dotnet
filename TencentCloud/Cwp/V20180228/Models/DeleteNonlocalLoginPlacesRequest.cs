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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteNonlocalLoginPlacesRequest : AbstractModel
    {
        
        /// <summary>
        /// 删除异地登录事件的方式，可选值："Ids"、"Ip"、"All"，默认为Ids
        /// </summary>
        [JsonProperty("DelType")]
        public string DelType{ get; set; }

        /// <summary>
        /// 异地登录事件ID数组。DelType为Ids或DelType未填时此项必填
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// 异地登录事件的Ip。DelType为Ip时必填
        /// </summary>
        [JsonProperty("Ip")]
        public string[] Ip{ get; set; }

        /// <summary>
        /// 主机Uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DelType", this.DelType);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamArraySimple(map, prefix + "Ip.", this.Ip);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

