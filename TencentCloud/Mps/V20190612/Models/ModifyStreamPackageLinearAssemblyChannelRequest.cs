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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyStreamPackageLinearAssemblyChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel Id。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 修改后的名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 定义channel的特性，Standard支持直播和点播源，Basic只支持点播源编排。
        /// </summary>
        [JsonProperty("Tier")]
        public string Tier{ get; set; }

        /// <summary>
        /// 频道中的source切换的模式，分Linear线性和Loop循环，直播只支持Linear。
        /// </summary>
        [JsonProperty("PlaybackMode")]
        public string PlaybackMode{ get; set; }

        /// <summary>
        /// 时移开启开关。
        /// </summary>
        [JsonProperty("TimeShiftEnable")]
        public bool? TimeShiftEnable{ get; set; }

        /// <summary>
        /// 时移配置。	
        /// </summary>
        [JsonProperty("TimeShiftConf")]
        public TimeShiftInfo TimeShiftConf{ get; set; }

        /// <summary>
        /// 垫片配置。	
        /// </summary>
        [JsonProperty("SlateConf")]
        public SlateInfo SlateConf{ get; set; }

        /// <summary>
        /// 输出配置。	
        /// </summary>
        [JsonProperty("Outputs")]
        public OutputInfo[] Outputs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Tier", this.Tier);
            this.SetParamSimple(map, prefix + "PlaybackMode", this.PlaybackMode);
            this.SetParamSimple(map, prefix + "TimeShiftEnable", this.TimeShiftEnable);
            this.SetParamObj(map, prefix + "TimeShiftConf.", this.TimeShiftConf);
            this.SetParamObj(map, prefix + "SlateConf.", this.SlateConf);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
        }
    }
}

