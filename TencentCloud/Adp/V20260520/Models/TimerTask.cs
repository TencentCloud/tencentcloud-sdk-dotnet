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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerTask : AbstractModel
    {
        
        /// <summary>
        /// 任务配置
        /// </summary>
        [JsonProperty("Config")]
        public TimerConfig Config{ get; set; }

        /// <summary>
        /// staffBizId
        /// </summary>
        [JsonProperty("OwnerUserId")]
        public string OwnerUserId{ get; set; }

        /// <summary>
        /// 定时配置概要
        /// </summary>
        [JsonProperty("PolicySummary")]
        public string PolicySummary{ get; set; }

        /// <summary>
        /// 概要信息
        /// </summary>
        [JsonProperty("Profile")]
        public TimerProfile Profile{ get; set; }

        /// <summary>
        /// 空间ID
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("Status")]
        public TimerStatus Status{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TimerId")]
        public string TimerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "OwnerUserId", this.OwnerUserId);
            this.SetParamSimple(map, prefix + "PolicySummary", this.PolicySummary);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "TimerId", this.TimerId);
        }
    }
}

