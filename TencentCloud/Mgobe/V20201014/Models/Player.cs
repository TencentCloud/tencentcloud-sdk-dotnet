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

namespace TencentCloud.Mgobe.V20201014.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Player : AbstractModel
    {
        
        /// <summary>
        /// 玩家 OpenId。最长不超过64个字符。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 玩家昵称。最长不超过32个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 队伍 ID。最长不超过16个字符。
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// 是否为机器人。
        /// </summary>
        [JsonProperty("IsRobot")]
        public bool? IsRobot{ get; set; }

        /// <summary>
        /// 玩家 PlayerId。出参使用，由后端返回。
        /// </summary>
        [JsonProperty("PlayerId")]
        public string PlayerId{ get; set; }

        /// <summary>
        /// 自定义玩家状态。非负数，最大不超过4294967295。默认为0。
        /// </summary>
        [JsonProperty("CustomPlayerStatus")]
        public ulong? CustomPlayerStatus{ get; set; }

        /// <summary>
        /// 自定义玩家属性。最长不超过256个字符。默认为空字符串。
        /// </summary>
        [JsonProperty("CustomProfile")]
        public string CustomProfile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "IsRobot", this.IsRobot);
            this.SetParamSimple(map, prefix + "PlayerId", this.PlayerId);
            this.SetParamSimple(map, prefix + "CustomPlayerStatus", this.CustomPlayerStatus);
            this.SetParamSimple(map, prefix + "CustomProfile", this.CustomProfile);
        }
    }
}

