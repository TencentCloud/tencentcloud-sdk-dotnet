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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSceneRequest : AbstractModel
    {
        
        /// <summary>
        /// 场景名称
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// 场景触发规则
        /// </summary>
        [JsonProperty("SceneTrigger")]
        public string SceneTrigger{ get; set; }

        /// <summary>
        /// 录制时长 (秒)
        /// </summary>
        [JsonProperty("RecordDuration")]
        public long? RecordDuration{ get; set; }

        /// <summary>
        /// 录像存储时长(天)
        /// </summary>
        [JsonProperty("StoreDuration")]
        public long? StoreDuration{ get; set; }

        /// <summary>
        /// 设备列表(不推荐使用)
        /// </summary>
        [JsonProperty("Devices")]
        public DeviceItem[] Devices{ get; set; }

        /// <summary>
        /// 通道列表
        /// </summary>
        [JsonProperty("Channels")]
        public ChannelItem[] Channels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamSimple(map, prefix + "SceneTrigger", this.SceneTrigger);
            this.SetParamSimple(map, prefix + "RecordDuration", this.RecordDuration);
            this.SetParamSimple(map, prefix + "StoreDuration", this.StoreDuration);
            this.SetParamArrayObj(map, prefix + "Devices.", this.Devices);
            this.SetParamArrayObj(map, prefix + "Channels.", this.Channels);
        }
    }
}

