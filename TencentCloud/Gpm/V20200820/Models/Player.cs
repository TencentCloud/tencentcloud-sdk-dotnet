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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Player : AbstractModel
    {
        
        /// <summary>
        /// 玩家 PlayerId 长度 128
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 玩家昵称，长度 128
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 玩家匹配属性，最多 10 条
        /// </summary>
        [JsonProperty("MatchAttributes")]
        public MatchAttribute[] MatchAttributes{ get; set; }

        /// <summary>
        /// 队伍名，可以传递不同队伍名，长度 128
        /// </summary>
        [JsonProperty("Team")]
        public string Team{ get; set; }

        /// <summary>
        /// 自定义玩家状态 透传参数 [0, 99999]
        /// </summary>
        [JsonProperty("CustomPlayerStatus")]
        public ulong? CustomPlayerStatus{ get; set; }

        /// <summary>
        /// 自定义玩家信息 透传参数 长度 1024
        /// </summary>
        [JsonProperty("CustomProfile")]
        public string CustomProfile{ get; set; }

        /// <summary>
        /// 各区域延迟，最多 20 条
        /// </summary>
        [JsonProperty("RegionLatencies")]
        public RegionLatency[] RegionLatencies{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "MatchAttributes.", this.MatchAttributes);
            this.SetParamSimple(map, prefix + "Team", this.Team);
            this.SetParamSimple(map, prefix + "CustomPlayerStatus", this.CustomPlayerStatus);
            this.SetParamSimple(map, prefix + "CustomProfile", this.CustomProfile);
            this.SetParamArrayObj(map, prefix + "RegionLatencies.", this.RegionLatencies);
        }
    }
}

