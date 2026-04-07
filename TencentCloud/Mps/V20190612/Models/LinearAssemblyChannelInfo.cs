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

    public class LinearAssemblyChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>线性组装频道名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>定义channel的特性，Standard支持直播和点播源，Basic只支持点播源编排。</p>
        /// </summary>
        [JsonProperty("Tier")]
        public string Tier{ get; set; }

        /// <summary>
        /// <p>频道中的source切换的模式，分Linear线性和Loop循环，直播只支持Linear。</p>
        /// </summary>
        [JsonProperty("PlaybackMode")]
        public string PlaybackMode{ get; set; }

        /// <summary>
        /// <p>时移配置，vod有效。</p>
        /// </summary>
        [JsonProperty("TimeShiftConf")]
        public TimeShiftInfo TimeShiftConf{ get; set; }

        /// <summary>
        /// <p>垫片配置。</p>
        /// </summary>
        [JsonProperty("SlateConf")]
        public SlateInfo SlateConf{ get; set; }

        /// <summary>
        /// <p>output信息。</p>
        /// </summary>
        [JsonProperty("Outputs")]
        public OutputInfo[] Outputs{ get; set; }

        /// <summary>
        /// <p>该channel绑定的program列表。</p>
        /// </summary>
        [JsonProperty("AttachedPrograms")]
        public string[] AttachedPrograms{ get; set; }

        /// <summary>
        /// <p>program信息。</p>
        /// </summary>
        [JsonProperty("ProgramSchedules")]
        public ProgramScheduleInfo[] ProgramSchedules{ get; set; }

        /// <summary>
        /// <p>Id。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Region。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>State。</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>时移开启开关。</p>
        /// </summary>
        [JsonProperty("TimeShiftEnable")]
        public bool? TimeShiftEnable{ get; set; }

        /// <summary>
        /// <p>channel创建时间，unix秒时间戳。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Tier", this.Tier);
            this.SetParamSimple(map, prefix + "PlaybackMode", this.PlaybackMode);
            this.SetParamObj(map, prefix + "TimeShiftConf.", this.TimeShiftConf);
            this.SetParamObj(map, prefix + "SlateConf.", this.SlateConf);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamArraySimple(map, prefix + "AttachedPrograms.", this.AttachedPrograms);
            this.SetParamArrayObj(map, prefix + "ProgramSchedules.", this.ProgramSchedules);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "TimeShiftEnable", this.TimeShiftEnable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

