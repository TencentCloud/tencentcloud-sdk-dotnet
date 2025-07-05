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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ControlRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 通道ID（录像播放地址格式 https://${domain}/live/${ChannelId}@${Session}）
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 录像会话 ID （ 录像播放地址格式 https://${domain}/live/${ChannelId}@${Session}）
        /// </summary>
        [JsonProperty("Session")]
        public string Session{ get; set; }

        /// <summary>
        /// 录像操作类型 （play:播放；pause:暂停 ；stop:关闭）
        /// </summary>
        [JsonProperty("ControlAction")]
        public string ControlAction{ get; set; }

        /// <summary>
        /// 跳转进度 （ 参数应大于等于0，跳转到录像开始时间的相对时间（单位秒），例如0就是跳转到录像开始的时间,不可以和 Scale 参数同时出现）
        /// </summary>
        [JsonProperty("Position")]
        public long? Position{ get; set; }

        /// <summary>
        /// 速度 （ 范围（0.25,0.5,1,2,4,8），不可以和 Pos 参数同时出现）
        /// </summary>
        [JsonProperty("Scale")]
        public float? Scale{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Session", this.Session);
            this.SetParamSimple(map, prefix + "ControlAction", this.ControlAction);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
        }
    }
}

