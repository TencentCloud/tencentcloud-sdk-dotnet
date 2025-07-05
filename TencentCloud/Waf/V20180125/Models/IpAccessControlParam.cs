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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpAccessControlParam : AbstractModel
    {
        
        /// <summary>
        /// IP列表
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// valid_ts为有效日期，值为秒级时间戳（（如1680570420代表2023-04-04 09:07:00））
        /// </summary>
        [JsonProperty("ValidTs")]
        public ulong? ValidTs{ get; set; }

        /// <summary>
        /// 42为黑名单，40为白名单
        /// </summary>
        [JsonProperty("ActionType")]
        public long? ActionType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "ValidTs", this.ValidTs);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "Note", this.Note);
        }
    }
}

