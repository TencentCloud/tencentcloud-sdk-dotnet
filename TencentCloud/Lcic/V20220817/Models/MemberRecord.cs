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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MemberRecord : AbstractModel
    {
        
        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户名称。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 在线时长，单位秒。
        /// </summary>
        [JsonProperty("PresentTime")]
        public ulong? PresentTime{ get; set; }

        /// <summary>
        /// 是否开启摄像头。
        /// </summary>
        [JsonProperty("Camera")]
        public ulong? Camera{ get; set; }

        /// <summary>
        /// 是否开启麦克风。
        /// </summary>
        [JsonProperty("Mic")]
        public ulong? Mic{ get; set; }

        /// <summary>
        /// 是否禁言。
        /// </summary>
        [JsonProperty("Silence")]
        public ulong? Silence{ get; set; }

        /// <summary>
        /// 回答问题数量。
        /// </summary>
        [JsonProperty("AnswerQuestions")]
        public ulong? AnswerQuestions{ get; set; }

        /// <summary>
        /// 举手数量。
        /// </summary>
        [JsonProperty("HandUps")]
        public ulong? HandUps{ get; set; }

        /// <summary>
        /// 首次进入房间的unix时间戳。
        /// </summary>
        [JsonProperty("FirstJoinTimestamp")]
        public ulong? FirstJoinTimestamp{ get; set; }

        /// <summary>
        /// 最后一次退出房间的unix时间戳。
        /// </summary>
        [JsonProperty("LastQuitTimestamp")]
        public ulong? LastQuitTimestamp{ get; set; }

        /// <summary>
        /// 奖励次数。
        /// </summary>
        [JsonProperty("Rewords")]
        public ulong? Rewords{ get; set; }

        /// <summary>
        /// 用户IP。
        /// </summary>
        [JsonProperty("IPAddress")]
        public string IPAddress{ get; set; }

        /// <summary>
        /// 用户位置信息。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 用户设备平台信息。0:unknown  1:windows  2:mac  3:android  4:ios  5:web   6:h5   7:miniprogram （小程序）
        /// </summary>
        [JsonProperty("Device")]
        public long? Device{ get; set; }

        /// <summary>
        /// 每个成员上麦次数。
        /// </summary>
        [JsonProperty("PerMemberMicCount")]
        public long? PerMemberMicCount{ get; set; }

        /// <summary>
        /// 每个成员发送消息数量。
        /// </summary>
        [JsonProperty("PerMemberMessageCount")]
        public long? PerMemberMessageCount{ get; set; }

        /// <summary>
        /// 用户角色。0代表学生；1代表老师； 2助教；3巡课。
        /// </summary>
        [JsonProperty("Role")]
        public ulong? Role{ get; set; }

        /// <summary>
        /// 上课班号
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 子上课班号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubGroupId")]
        public string[] SubGroupId{ get; set; }

        /// <summary>
        /// 用户的上台状态
        /// </summary>
        [JsonProperty("Stage")]
        public long? Stage{ get; set; }

        /// <summary>
        /// 用户状态。0为未到，1为在线，2为离线，3为被踢，4为永久被踢，5为暂时掉线
        /// </summary>
        [JsonProperty("CurrentState")]
        public ulong? CurrentState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PresentTime", this.PresentTime);
            this.SetParamSimple(map, prefix + "Camera", this.Camera);
            this.SetParamSimple(map, prefix + "Mic", this.Mic);
            this.SetParamSimple(map, prefix + "Silence", this.Silence);
            this.SetParamSimple(map, prefix + "AnswerQuestions", this.AnswerQuestions);
            this.SetParamSimple(map, prefix + "HandUps", this.HandUps);
            this.SetParamSimple(map, prefix + "FirstJoinTimestamp", this.FirstJoinTimestamp);
            this.SetParamSimple(map, prefix + "LastQuitTimestamp", this.LastQuitTimestamp);
            this.SetParamSimple(map, prefix + "Rewords", this.Rewords);
            this.SetParamSimple(map, prefix + "IPAddress", this.IPAddress);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Device", this.Device);
            this.SetParamSimple(map, prefix + "PerMemberMicCount", this.PerMemberMicCount);
            this.SetParamSimple(map, prefix + "PerMemberMessageCount", this.PerMemberMessageCount);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "SubGroupId.", this.SubGroupId);
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "CurrentState", this.CurrentState);
        }
    }
}

