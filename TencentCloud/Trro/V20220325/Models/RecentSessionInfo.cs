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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecentSessionInfo : AbstractModel
    {
        
        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 远端设备ID
        /// </summary>
        [JsonProperty("RemoteDeviceId")]
        public string RemoteDeviceId{ get; set; }

        /// <summary>
        /// 现场设备ID
        /// </summary>
        [JsonProperty("FieldDeviceId")]
        public string FieldDeviceId{ get; set; }

        /// <summary>
        /// 分辨率
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 会话开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("LatestUpdateTime")]
        public ulong? LatestUpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RemoteDeviceId", this.RemoteDeviceId);
            this.SetParamSimple(map, prefix + "FieldDeviceId", this.FieldDeviceId);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "LatestUpdateTime", this.LatestUpdateTime);
        }
    }
}

