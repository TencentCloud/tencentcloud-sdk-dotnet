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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSessionDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 主叫号码
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// 通话类型 1 呼出 2 呼入 3 音频呼入 5 预测式外呼 6 内线呼叫
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// 开始时间戳，Unix 秒级时间戳
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public long? StartTimeStamp{ get; set; }

        /// <summary>
        /// 振铃时间戳，UNIX 秒级时间戳
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// 接听时间戳，UNIX 秒级时间戳
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// 结束时间戳，UNIX 秒级时间戳
        /// </summary>
        [JsonProperty("EndedTimestamp")]
        public long? EndedTimestamp{ get; set; }

        /// <summary>
        /// 进入排队时间，Unix 秒级时间戳
        /// </summary>
        [JsonProperty("QueuedTimestamp")]
        public long? QueuedTimestamp{ get; set; }

        /// <summary>
        /// 座席账号
        /// </summary>
        [JsonProperty("StaffUserId")]
        public string StaffUserId{ get; set; }

        /// <summary>
        /// 参考 DescribeTelCdr 接口 EndStatus 字段
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// 排队技能组 ID
        /// </summary>
        [JsonProperty("QueuedSkillGroupId")]
        public long? QueuedSkillGroupId{ get; set; }

        /// <summary>
        /// 排队技能组名称
        /// </summary>
        [JsonProperty("QueuedSkillGroupName")]
        public string QueuedSkillGroupName{ get; set; }

        /// <summary>
        /// 录音链接，带鉴权和有效期，获取之后请在短时间内拉取，不要持久化此链接
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// 录音转存第三方 COS 链接
        /// </summary>
        [JsonProperty("CustomRecordURL")]
        public string CustomRecordURL{ get; set; }

        /// <summary>
        /// 录音文本信息链接，带鉴权和有效期，获取之后请在短时间内拉取，不要持久化此链接
        /// </summary>
        [JsonProperty("AsrURL")]
        public string AsrURL{ get; set; }

        /// <summary>
        /// 语音留言录音链接
        /// </summary>
        [JsonProperty("VoicemailRecordURL")]
        public string[] VoicemailRecordURL{ get; set; }

        /// <summary>
        /// 语音留言录音文本信息链接，需在控制台购买离线语音识别套餐包并开启离线语音识别开关
        /// </summary>
        [JsonProperty("VoicemailAsrURL")]
        public string[] VoicemailAsrURL{ get; set; }

        /// <summary>
        /// IVR 按键信息
        /// </summary>
        [JsonProperty("IVRKeyPressed")]
        public IVRKeyPressedElement[] IVRKeyPressed{ get; set; }

        /// <summary>
        /// 满意度按键信息
        /// </summary>
        [JsonProperty("PostIVRKeyPressed")]
        public IVRKeyPressedElement[] PostIVRKeyPressed{ get; set; }

        /// <summary>
        /// 挂机方 seat 座席 user 用户 system 系统
        /// </summary>
        [JsonProperty("HungUpSide")]
        public string HungUpSide{ get; set; }

        /// <summary>
        /// 客户自定义数据（User-to-User Interface）
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// 通话中的事件列表
        /// </summary>
        [JsonProperty("Events")]
        public SessionEvent[] Events{ get; set; }

        /// <summary>
        /// 服务参与者列表
        /// </summary>
        [JsonProperty("ServeParticipants")]
        public ServeParticipant[] ServeParticipants{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "StartTimeStamp", this.StartTimeStamp);
            this.SetParamSimple(map, prefix + "RingTimestamp", this.RingTimestamp);
            this.SetParamSimple(map, prefix + "AcceptTimestamp", this.AcceptTimestamp);
            this.SetParamSimple(map, prefix + "EndedTimestamp", this.EndedTimestamp);
            this.SetParamSimple(map, prefix + "QueuedTimestamp", this.QueuedTimestamp);
            this.SetParamSimple(map, prefix + "StaffUserId", this.StaffUserId);
            this.SetParamSimple(map, prefix + "EndStatus", this.EndStatus);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupId", this.QueuedSkillGroupId);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupName", this.QueuedSkillGroupName);
            this.SetParamSimple(map, prefix + "RecordURL", this.RecordURL);
            this.SetParamSimple(map, prefix + "CustomRecordURL", this.CustomRecordURL);
            this.SetParamSimple(map, prefix + "AsrURL", this.AsrURL);
            this.SetParamArraySimple(map, prefix + "VoicemailRecordURL.", this.VoicemailRecordURL);
            this.SetParamArraySimple(map, prefix + "VoicemailAsrURL.", this.VoicemailAsrURL);
            this.SetParamArrayObj(map, prefix + "IVRKeyPressed.", this.IVRKeyPressed);
            this.SetParamArrayObj(map, prefix + "PostIVRKeyPressed.", this.PostIVRKeyPressed);
            this.SetParamSimple(map, prefix + "HungUpSide", this.HungUpSide);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamArrayObj(map, prefix + "Events.", this.Events);
            this.SetParamArrayObj(map, prefix + "ServeParticipants.", this.ServeParticipants);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

