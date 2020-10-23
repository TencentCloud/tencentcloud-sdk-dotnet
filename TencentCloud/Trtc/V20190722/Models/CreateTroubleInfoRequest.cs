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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTroubleInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用的ID
        /// </summary>
        [JsonProperty("SdkAppId")]
        public string SdkAppId{ get; set; }

        /// <summary>
        /// 房间ID
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 老师用户ID
        /// </summary>
        [JsonProperty("TeacherUserId")]
        public string TeacherUserId{ get; set; }

        /// <summary>
        /// 学生用户ID
        /// </summary>
        [JsonProperty("StudentUserId")]
        public string StudentUserId{ get; set; }

        /// <summary>
        /// 体验异常端（老师或学生）的用户 ID。
        /// </summary>
        [JsonProperty("TroubleUserId")]
        public string TroubleUserId{ get; set; }

        /// <summary>
        /// 异常类型。
        /// 1. 仅视频异常
        /// 2. 仅声音异常
        /// 3. 音视频都异常
        /// 5. 进房异常
        /// 4. 切课
        /// 6. 求助
        /// 7. 问题反馈
        /// 8. 投诉
        /// </summary>
        [JsonProperty("TroubleType")]
        public ulong? TroubleType{ get; set; }

        /// <summary>
        /// 异常发生的UNIX 时间戳，单位为秒。
        /// </summary>
        [JsonProperty("TroubleTime")]
        public ulong? TroubleTime{ get; set; }

        /// <summary>
        /// 异常详情
        /// </summary>
        [JsonProperty("TroubleMsg")]
        public string TroubleMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "TeacherUserId", this.TeacherUserId);
            this.SetParamSimple(map, prefix + "StudentUserId", this.StudentUserId);
            this.SetParamSimple(map, prefix + "TroubleUserId", this.TroubleUserId);
            this.SetParamSimple(map, prefix + "TroubleType", this.TroubleType);
            this.SetParamSimple(map, prefix + "TroubleTime", this.TroubleTime);
            this.SetParamSimple(map, prefix + "TroubleMsg", this.TroubleMsg);
        }
    }
}

