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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventDataInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>事件发生的房间号。</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// <p>事件发生的用户。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>用户设备类型。0: Unknown; 1: Windows; 2: macOS; 3: Android; 4: iOS; 5: Web; 6: Mobile webpage; 7: Weixin Mini Program.</p>
        /// </summary>
        [JsonProperty("Device")]
        public ulong? Device{ get; set; }

        /// <summary>
        /// <p>录制时长。单位：秒</p>
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// <p>录制文件大小</p>
        /// </summary>
        [JsonProperty("RecordSize")]
        public ulong? RecordSize{ get; set; }

        /// <summary>
        /// <p>录制url</p>
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// <p>MemberQuit事件，对应Reason（0:主动退出 1:被踢 2:永久被踢 4:失去心跳下线 5:房间结束，成员自动退出）</p>
        /// </summary>
        [JsonProperty("Reason")]
        public ulong? Reason{ get; set; }

        /// <summary>
        /// <p>角色</p><p>枚举值：</p><ul><li>0： 学生</li><li>1： 老师</li><li>2： 助教</li><li>3： 巡课/督导</li></ul>
        /// </summary>
        [JsonProperty("Role")]
        public ulong? Role{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RecordSize", this.RecordSize);
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "Role", this.Role);
        }
    }
}

