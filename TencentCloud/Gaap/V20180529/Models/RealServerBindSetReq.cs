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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RealServerBindSetReq : AbstractModel
    {
        
        /// <summary>
        /// 源站id
        /// </summary>
        [JsonProperty("RealServerId")]
        public string RealServerId{ get; set; }

        /// <summary>
        /// 源站端口
        /// </summary>
        [JsonProperty("RealServerPort")]
        public ulong? RealServerPort{ get; set; }

        /// <summary>
        /// 源站IP
        /// </summary>
        [JsonProperty("RealServerIP")]
        public string RealServerIP{ get; set; }

        /// <summary>
        /// 源站权重
        /// </summary>
        [JsonProperty("RealServerWeight")]
        public ulong? RealServerWeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RealServerId", this.RealServerId);
            this.SetParamSimple(map, prefix + "RealServerPort", this.RealServerPort);
            this.SetParamSimple(map, prefix + "RealServerIP", this.RealServerIP);
            this.SetParamSimple(map, prefix + "RealServerWeight", this.RealServerWeight);
        }
    }
}

