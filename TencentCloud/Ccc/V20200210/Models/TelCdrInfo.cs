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

    public class TelCdrInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>主叫号码</p>
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// <p>被叫号码</p>
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// <p>呼叫发起时间戳，Unix 时间戳</p>
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// <p>呼入呼出方向 0 呼入 1 呼出</p>
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// <p>通话类型 1 呼出 2 呼入 3 音频呼入 5 预测式外呼 6 内线呼叫</p>
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// <p>通话时长</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>录音信息</p>
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// <p>录音 ID</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>座席信息</p>
        /// </summary>
        [JsonProperty("SeatUser")]
        public SeatUserInfo SeatUser{ get; set; }

        /// <summary>
        /// <p>EndStatus与EndStatusString一一对应，具体枚举如下：</p><p><strong>场景             EndStatus    EndStatusString    状态说明</strong></p><p>电话呼入&amp;呼出    1            ok                            <strong>正常通话</strong></p><p>电话呼入                 102            ivrGiveUp            <strong>IVR期间用户放弃</strong></p><p>电话呼入                 103            waitingGiveUp           <strong>排队时用户放弃</strong></p><p>电话呼入                 104            ringingGiveUp           <strong>振铃时用户放弃</strong></p><p>电话呼入                 105            noSeatOnline           <strong>无座席在线</strong></p><p>电话呼入              106           notWorkTime           <strong>非工作时间</strong>   </p><p>电话呼入                107           ivrEnd                   <strong>IVR全自动结束(无人工介入)</strong></p><p>电话呼入                100          blackList <strong>黑名单(系统侧)</strong></p><p>电话呼出             108            restrictedCallee    <strong>全局外呼风险号码拦截(系统侧)</strong></p><p>电话呼出             109            tooManyRequest        <strong>外呼频控拦截(系统侧)</strong></p><p>电话呼出             110            restrictedArea        <strong>外呼地域拦截(系统侧)</strong></p><p>电话呼出             111            restrictedTime    <strong>外呼时段拦截(系统侧)</strong></p><p>电话呼出             202            notAnswer     <strong>被叫未接听</strong></p><p>电话呼出            203        userReject    <strong>被叫拒接挂断</strong></p><p>电话呼出              204        powerOff    <strong>被叫关机</strong></p><p>电话呼出           205            numberNotExist    <strong>被叫空号</strong></p><p>电话呼出             206               busy    <strong>被叫忙</strong></p><p>电话呼出               207               outOfCredit    <strong>被叫欠费</strong></p><p>电话呼出             208               operatorError    <strong>运营商线路异常</strong></p><p>电话呼出             209               callerCancel    <strong>主叫取消</strong></p><p>电话呼出            210               notInService    <strong>被叫不在服务区</strong></p><p>电话呼入&amp;呼出    211    clientError    <strong>座席客户端错误</strong></p><p>电话呼出        212     carrierBlocked      <strong>运营商拦截</strong></p><p>电话呼出        213     callReminder      <strong>提示来电提醒</strong></p><p>电话呼出        215     numberInvalid      <strong>被叫号码无效</strong></p><p>电话呼出        216     callRestricted      <strong>提示呼叫受限</strong></p><p>电话呼出        217     calleeRestricted      <strong>被叫黑名单受限</strong></p><p>电话呼出        218     areaRestricted      <strong>被叫区域受限</strong></p><p>电话呼出        219     promptCallForwarding      <strong>提示呼叫转移</strong></p><p>电话呼出        220     callerCancelWhileRing      <strong>振铃中主叫取消</strong></p><p>电话呼出        221     callerCancelWithoutRing      <strong>未振铃被叫号码异常</strong></p><p>电话呼出        222     voiceMailReached      <strong>语音信箱挂断</strong></p><p>音频呼入        501     callConflict      <strong>VoIP用户呼叫冲突终止</strong></p><p>音频呼入        502     clientTimeout      <strong>VoIP用户客户端超时</strong></p><p>音频呼入        503     voipClientError      <strong>VoIP用户客户端错误</strong></p><p>中文详情<a href="https://www.tencentcloud.com/zh/document/product/1229/71847">参考</a></p><p>英文详情<a href="https://www.tencentcloud.com/document/product/1229/71847?lang=en">参考</a></p>
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// <p>技能组名称</p>
        /// </summary>
        [JsonProperty("SkillGroup")]
        public string SkillGroup{ get; set; }

        /// <summary>
        /// <p>主叫归属地</p>
        /// </summary>
        [JsonProperty("CallerLocation")]
        public string CallerLocation{ get; set; }

        /// <summary>
        /// <p>IVR 阶段耗时</p>
        /// </summary>
        [JsonProperty("IVRDuration")]
        public long? IVRDuration{ get; set; }

        /// <summary>
        /// <p>振铃时间戳，UNIX 秒级时间戳</p>
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// <p>接听时间戳，UNIX 秒级时间戳</p>
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// <p>结束时间戳，UNIX 秒级时间戳</p>
        /// </summary>
        [JsonProperty("EndedTimestamp")]
        public long? EndedTimestamp{ get; set; }

        /// <summary>
        /// <p>IVR 按键信息 ，e.g. [&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]</p>
        /// </summary>
        [JsonProperty("IVRKeyPressed")]
        [System.Obsolete]
        public string[] IVRKeyPressed{ get; set; }

        /// <summary>
        /// <p>IVR按键信息（e.g.xa0[{&quot;Key&quot;:&quot;1&quot;,&quot;Label&quot;:&quot;非常满意&quot;}]）</p>
        /// </summary>
        [JsonProperty("IVRKeyPressedEx")]
        public IVRKeyPressedElement[] IVRKeyPressedEx{ get; set; }

        /// <summary>
        /// <p>挂机方 seat 座席 user 用户 system 系统</p>
        /// </summary>
        [JsonProperty("HungUpSide")]
        public string HungUpSide{ get; set; }

        /// <summary>
        /// <p>服务参与者列表</p>
        /// </summary>
        [JsonProperty("ServeParticipants")]
        public ServeParticipant[] ServeParticipants{ get; set; }

        /// <summary>
        /// <p>技能组ID</p>
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// <p>参考 EndStatus 字段</p>
        /// </summary>
        [JsonProperty("EndStatusString")]
        public string EndStatusString{ get; set; }

        /// <summary>
        /// <p>会话开始时间戳，UNIX 秒级时间戳</p>
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// <p>进入排队时间，Unix 秒级时间戳</p>
        /// </summary>
        [JsonProperty("QueuedTimestamp")]
        public long? QueuedTimestamp{ get; set; }

        /// <summary>
        /// <p>后置IVR按键信息（e.g.xa0[{&quot;Key&quot;:&quot;1&quot;,&quot;Label&quot;:&quot;非常满意&quot;}]）</p>
        /// </summary>
        [JsonProperty("PostIVRKeyPressed")]
        [System.Obsolete]
        public IVRKeyPressedElement[] PostIVRKeyPressed{ get; set; }

        /// <summary>
        /// <p>满意度按键信息 Key 为 noInput 表示进入满意度但无按键</p>
        /// </summary>
        [JsonProperty("PostIVRKeyPressedEx")]
        public IVRKeyPressedElement[] PostIVRKeyPressedEx{ get; set; }

        /// <summary>
        /// <p>排队技能组Id</p>
        /// </summary>
        [JsonProperty("QueuedSkillGroupId")]
        public long? QueuedSkillGroupId{ get; set; }

        /// <summary>
        /// <p>会话 ID</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>主叫号码保护ID，开启号码保护映射功能时有效，且Caller字段置空</p>
        /// </summary>
        [JsonProperty("ProtectedCaller")]
        public string ProtectedCaller{ get; set; }

        /// <summary>
        /// <p>被叫号码保护ID，开启号码保护映射功能时有效，且Callee字段置空</p>
        /// </summary>
        [JsonProperty("ProtectedCallee")]
        public string ProtectedCallee{ get; set; }

        /// <summary>
        /// <p>客户自定义数据（User-to-User Interface）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uui")]
        [System.Obsolete]
        public string Uui{ get; set; }

        /// <summary>
        /// <p>客户自定义数据（User-to-User Interface）</p>
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// <p>获取录音ASR文本信息地址</p>
        /// </summary>
        [JsonProperty("AsrUrl")]
        public string AsrUrl{ get; set; }

        /// <summary>
        /// <p>AsrUrl的状态：Complete<br>已完成;<br>Processing<br>正在生成中;<br>NotExists<br>无记录(未开启生成离线asr或者无套餐包)</p>
        /// </summary>
        [JsonProperty("AsrStatus")]
        public string AsrStatus{ get; set; }

        /// <summary>
        /// <p>录音转存第三方COS地址</p>
        /// </summary>
        [JsonProperty("CustomRecordURL")]
        public string CustomRecordURL{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>排队技能组名称</p>
        /// </summary>
        [JsonProperty("QueuedSkillGroupName")]
        public string QueuedSkillGroupName{ get; set; }

        /// <summary>
        /// <p>通话中语音留言录音URL</p>
        /// </summary>
        [JsonProperty("VoicemailRecordURL")]
        public string[] VoicemailRecordURL{ get; set; }

        /// <summary>
        /// <p>通话中语音留言ASR文本信息地址</p>
        /// </summary>
        [JsonProperty("VoicemailAsrURL")]
        public string[] VoicemailAsrURL{ get; set; }

        /// <summary>
        /// <p>如果是智能体相关通话，这里是智能体 ID</p>
        /// </summary>
        [JsonProperty("AIAgentId")]
        public long? AIAgentId{ get; set; }

        /// <summary>
        /// <p>如果是智能体相关通话，这里是智能体名称</p>
        /// </summary>
        [JsonProperty("AIAgentName")]
        public string AIAgentName{ get; set; }

        /// <summary>
        /// <p>接通后系统挂断原因，枚举类似</p>
        /// </summary>
        [JsonProperty("SysHangupReason")]
        public long? SysHangupReason{ get; set; }

        /// <summary>
        /// <p>接通后系统挂断原因，文字描述信息</p>
        /// </summary>
        [JsonProperty("SysHangupReasonString")]
        public string SysHangupReasonString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
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
            this.SetParamArrayObj(map, prefix + "IVRKeyPressedEx.", this.IVRKeyPressedEx);
            this.SetParamSimple(map, prefix + "HungUpSide", this.HungUpSide);
            this.SetParamArrayObj(map, prefix + "ServeParticipants.", this.ServeParticipants);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "EndStatusString", this.EndStatusString);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "QueuedTimestamp", this.QueuedTimestamp);
            this.SetParamArrayObj(map, prefix + "PostIVRKeyPressed.", this.PostIVRKeyPressed);
            this.SetParamArrayObj(map, prefix + "PostIVRKeyPressedEx.", this.PostIVRKeyPressedEx);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupId", this.QueuedSkillGroupId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ProtectedCaller", this.ProtectedCaller);
            this.SetParamSimple(map, prefix + "ProtectedCallee", this.ProtectedCallee);
            this.SetParamSimple(map, prefix + "Uui", this.Uui);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamSimple(map, prefix + "AsrUrl", this.AsrUrl);
            this.SetParamSimple(map, prefix + "AsrStatus", this.AsrStatus);
            this.SetParamSimple(map, prefix + "CustomRecordURL", this.CustomRecordURL);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupName", this.QueuedSkillGroupName);
            this.SetParamArraySimple(map, prefix + "VoicemailRecordURL.", this.VoicemailRecordURL);
            this.SetParamArraySimple(map, prefix + "VoicemailAsrURL.", this.VoicemailAsrURL);
            this.SetParamSimple(map, prefix + "AIAgentId", this.AIAgentId);
            this.SetParamSimple(map, prefix + "AIAgentName", this.AIAgentName);
            this.SetParamSimple(map, prefix + "SysHangupReason", this.SysHangupReason);
            this.SetParamSimple(map, prefix + "SysHangupReasonString", this.SysHangupReasonString);
        }
    }
}

