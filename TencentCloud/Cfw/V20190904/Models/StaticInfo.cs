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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StaticInfo : AbstractModel
    {
        
        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("InsID")]
        public string InsID{ get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("InsName")]
        public string InsName{ get; set; }

        /// <summary>
        /// ip信息
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 数
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "InsID", this.InsID);
            this.SetParamSimple(map, prefix + "InsName", this.InsName);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "Port", this.Port);
        }
    }
}

