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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TelCdrInfo : AbstractModel
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
        /// 呼叫发起时间戳，Unix 时间戳
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// 呼入呼出方向 0 呼入 1 呼出
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 录音信息
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// 录音 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 坐席信息
        /// </summary>
        [JsonProperty("SeatUser")]
        public SeatUserInfo SeatUser{ get; set; }

        /// <summary>
        /// EndStatus与EndStatusString一一对应，具体枚举如下：
        /// 
        /// **场景	         EndStatus	EndStatusString	状态说明**
        /// 
        /// 电话呼入&呼出	1	        ok	                        正常结束
        /// 
        /// 电话呼入&呼出	0	        error	                系统错误
        /// 
        /// 电话呼入	             102	        ivrGiveUp	        IVR 期间用户放弃
        /// 
        /// 电话呼入	             103	        waitingGiveUp	       会话排队期间用户放弃
        /// 
        /// 电话呼入	             104	        ringingGiveUp	       会话振铃期间用户放弃
        /// 
        /// 电话呼入	             105	        noSeatOnline	       无坐席在线
        /// 
        /// 电话呼入              106	       notWorkTime	       非工作时间   
        /// 
        /// 电话呼入	            107	       ivrEnd	               IVR 后直接结束
        /// 
        /// 电话呼入	            100	      blackList 呼入黑名单 
        /// 
        /// 电话呼出               2	              unconnected	未接通
        ///                          
        /// 电话呼出             201            unknown	未知状态
        /// 
        /// 电话呼出             202            notAnswer	未接听
        /// 
        /// 电话呼出            203	    userReject	拒接挂断
        /// 
        /// 电话呼出	          204	    powerOff	关机
        /// 
        /// 电话呼出           205            numberNotExist	空号
        /// 
        /// 电话呼出	         206	           busy	通话中
        /// 
        /// 电话呼出   	 207	           outOfCredit	欠费
        /// 
        /// 电话呼出	         208	           operatorError	运营商线路异常
        /// 
        /// 电话呼出         	209	           callerCancel	主叫取消
        /// 
        /// 电话呼出	        210	           notInService	不在服务区
        /// 
        /// 电话呼入&呼出	211    clientError    客户端错误
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// 技能组名称
        /// </summary>
        [JsonProperty("SkillGroup")]
        public string SkillGroup{ get; set; }

        /// <summary>
        /// 主叫归属地
        /// </summary>
        [JsonProperty("CallerLocation")]
        public string CallerLocation{ get; set; }

        /// <summary>
        /// IVR 阶段耗时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IVRDuration")]
        public long? IVRDuration{ get; set; }

        /// <summary>
        /// 振铃时间戳，UNIX 秒级时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// 接听时间戳，UNIX 秒级时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// 结束时间戳，UNIX 秒级时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndedTimestamp")]
        public long? EndedTimestamp{ get; set; }

        /// <summary>
        /// IVR 按键信息 ，e.g. ["1","2","3"]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IVRKeyPressed")]
        public string[] IVRKeyPressed{ get; set; }

        /// <summary>
        /// 挂机方 seat 坐席 user 用户 system 系统
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HungUpSide")]
        public string HungUpSide{ get; set; }

        /// <summary>
        /// 服务参与者列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServeParticipants")]
        public ServeParticipant[] ServeParticipants{ get; set; }

        /// <summary>
        /// 技能组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// EndStatus与EndStatusString一一对应，具体枚举如下：
        /// 
        /// **场景	         EndStatus	EndStatusString	状态说明**
        /// 
        /// 电话呼入&呼出	1	        ok	                        正常结束
        /// 
        /// 电话呼入&呼出	0	        error	                系统错误
        /// 
        /// 电话呼入	             102	        ivrGiveUp	        IVR 期间用户放弃
        /// 
        /// 电话呼入	             103	        waitingGiveUp	       会话排队期间用户放弃
        /// 
        /// 电话呼入	             104	        ringingGiveUp	       会话振铃期间用户放弃
        /// 
        /// 电话呼入	             105	        noSeatOnline	       无坐席在线
        /// 
        /// 电话呼入              106	       notWorkTime	       非工作时间   
        /// 
        /// 电话呼入	            107	       ivrEnd	               IVR 后直接结束
        /// 
        /// 电话呼入	            100	      blackList 呼入黑名单 
        /// 
        /// 电话呼出               2	              unconnected	未接通
        ///                          
        /// 电话呼出             201            unknown	未知状态
        /// 
        /// 电话呼出             202            notAnswer	未接听
        /// 
        /// 电话呼出            203	    userReject	拒接挂断
        /// 
        /// 电话呼出	          204	    powerOff	关机
        /// 
        /// 电话呼出           205            numberNotExist	空号
        /// 
        /// 电话呼出	         206	           busy	通话中
        /// 
        /// 电话呼出   	 207	           outOfCredit	欠费
        /// 
        /// 电话呼出	         208	           operatorError	运营商线路异常
        /// 
        /// 电话呼出         	209	           callerCancel	主叫取消
        /// 
        /// 电话呼出	        210	           notInService	不在服务区
        /// 
        /// 电话呼入&呼出	211    clientError    客户端错误
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndStatusString")]
        public string EndStatusString{ get; set; }

        /// <summary>
        /// 会话开始时间戳，UNIX 秒级时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// 进入排队时间，Unix 秒级时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueuedTimestamp")]
        public long? QueuedTimestamp{ get; set; }

        /// <summary>
        /// 后置IVR按键信息（e.g. [{"Key":"1","Label":"非常满意"}]）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostIVRKeyPressed")]
        public IVRKeyPressedElement[] PostIVRKeyPressed{ get; set; }

        /// <summary>
        /// 排队技能组Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueuedSkillGroupId")]
        public long? QueuedSkillGroupId{ get; set; }

        /// <summary>
        /// 会话 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 主叫号码保护ID，开启号码保护映射功能时有效，且Caller字段置空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtectedCaller")]
        public string ProtectedCaller{ get; set; }

        /// <summary>
        /// 被叫号码保护ID，开启号码保护映射功能时有效，且Callee字段置空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtectedCallee")]
        public string ProtectedCallee{ get; set; }

        /// <summary>
        /// 客户自定义数据（User-to-User Interface）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uui")]
        [System.Obsolete]
        public string Uui{ get; set; }

        /// <summary>
        /// 客户自定义数据（User-to-User Interface）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// IVR按键信息（e.g. [{"Key":"1","Label":"非常满意"}]）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IVRKeyPressedEx")]
        public IVRKeyPressedElement[] IVRKeyPressedEx{ get; set; }

        /// <summary>
        /// 获取录音ASR文本信息地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrUrl")]
        public string AsrUrl{ get; set; }

        /// <summary>
        /// 录音转存第三方COS地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomRecordURL")]
        public string CustomRecordURL{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 排队技能组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueuedSkillGroupName")]
        public string QueuedSkillGroupName{ get; set; }

        /// <summary>
        /// 通话中语音留言录音URL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoicemailRecordURL")]
        public string[] VoicemailRecordURL{ get; set; }

        /// <summary>
        /// 通话中语音留言ASR文本信息地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoicemailAsrURL")]
        public string[] VoicemailAsrURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RecordURL", this.RecordURL);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamObj(map, prefix + "SeatUser.", this.SeatUser);
            this.SetParamSimple(map, prefix + "EndStatus", this.EndStatus);
            this.SetParamSimple(map, prefix + "SkillGroup", this.SkillGroup);
            this.SetParamSimple(map, prefix + "CallerLocation", this.CallerLocation);
            this.SetParamSimple(map, prefix + "IVRDuration", this.IVRDuration);
            this.SetParamSimple(map, prefix + "RingTimestamp", this.RingTimestamp);
            this.SetParamSimple(map, prefix + "AcceptTimestamp", this.AcceptTimestamp);
            this.SetParamSimple(map, prefix + "EndedTimestamp", this.EndedTimestamp);
            this.SetParamArraySimple(map, prefix + "IVRKeyPressed.", this.IVRKeyPressed);
            this.SetParamSimple(map, prefix + "HungUpSide", this.HungUpSide);
            this.SetParamArrayObj(map, prefix + "ServeParticipants.", this.ServeParticipants);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "EndStatusString", this.EndStatusString);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "QueuedTimestamp", this.QueuedTimestamp);
            this.SetParamArrayObj(map, prefix + "PostIVRKeyPressed.", this.PostIVRKeyPressed);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupId", this.QueuedSkillGroupId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ProtectedCaller", this.ProtectedCaller);
            this.SetParamSimple(map, prefix + "ProtectedCallee", this.ProtectedCallee);
            this.SetParamSimple(map, prefix + "Uui", this.Uui);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamArrayObj(map, prefix + "IVRKeyPressedEx.", this.IVRKeyPressedEx);
            this.SetParamSimple(map, prefix + "AsrUrl", this.AsrUrl);
            this.SetParamSimple(map, prefix + "CustomRecordURL", this.CustomRecordURL);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupName", this.QueuedSkillGroupName);
            this.SetParamArraySimple(map, prefix + "VoicemailRecordURL.", this.VoicemailRecordURL);
            this.SetParamArraySimple(map, prefix + "VoicemailAsrURL.", this.VoicemailAsrURL);
        }
    }
}

