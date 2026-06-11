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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessKeyAlarm : AbstractModel
    {
        
        /// <summary>
        /// <p>告警名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>告警等级<br>0-无效 1-提示 2-低危 3-中危 4-高危 5-严重</p>
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// <p>告警记录ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>告警规则ID</p>
        /// </summary>
        [JsonProperty("AlarmRuleID")]
        public long? AlarmRuleID{ get; set; }

        /// <summary>
        /// <p>告警类型<br>0 异常调用<br>1 泄漏监测</p>
        /// </summary>
        [JsonProperty("AlarmType")]
        public long? AlarmType{ get; set; }

        /// <summary>
        /// <p>访问密钥</p>
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// <p>访问密钥ID</p>
        /// </summary>
        [JsonProperty("AccessKeyID")]
        public ulong? AccessKeyID{ get; set; }

        /// <summary>
        /// <p>访问密钥备注</p>
        /// </summary>
        [JsonProperty("AccessKeyRemark")]
        public string AccessKeyRemark{ get; set; }

        /// <summary>
        /// <p>最后告警时间</p>
        /// </summary>
        [JsonProperty("LastAlarmTime")]
        public string LastAlarmTime{ get; set; }

        /// <summary>
        /// <p>告警状态<br>0-未处理 1-已处理 2-已忽略</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>聚合日期</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>告警标签</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// <p>所属主账号Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>所属主账号昵称</p>
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// <p>所属子账号Uin</p>
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// <p>所属子账号昵称</p>
        /// </summary>
        [JsonProperty("SubNickname")]
        public string SubNickname{ get; set; }

        /// <summary>
        /// <p>账号类型<br>0 主账号AK 1 子账号AK 2 临时密钥</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>所属appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>泄漏证据</p>
        /// </summary>
        [JsonProperty("LeakEvidence")]
        public string[] LeakEvidence{ get; set; }

        /// <summary>
        /// <p>是否支持编辑信任账号</p>
        /// </summary>
        [JsonProperty("IsSupportEditWhiteAccount")]
        public bool? IsSupportEditWhiteAccount{ get; set; }

        /// <summary>
        /// <p>告警证据</p>
        /// </summary>
        [JsonProperty("Evidence")]
        public string Evidence{ get; set; }

        /// <summary>
        /// <p>告警规则标识</p>
        /// </summary>
        [JsonProperty("RuleKey")]
        public string RuleKey{ get; set; }

        /// <summary>
        /// <p>云厂商类型 0:腾讯云 1:亚马逊云 2:微软云 3:谷歌云 4:阿里云 5:华为云</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>告警AI分析状态<br>-1 分析失败<br>0 未分析<br>1 分析中<br>2 分析成功，真实告警<br>3 分析成功，可疑告警</p>
        /// </summary>
        [JsonProperty("AIStatus")]
        public long? AIStatus{ get; set; }

        /// <summary>
        /// <p>首次告警时间戳（秒级）</p>
        /// </summary>
        [JsonProperty("FirstAlarmTimestamp")]
        public long? FirstAlarmTimestamp{ get; set; }

        /// <summary>
        /// <p>最后告警时间戳（秒级）</p>
        /// </summary>
        [JsonProperty("LastAlarmTimestamp")]
        public long? LastAlarmTimestamp{ get; set; }

        /// <summary>
        /// <p>ai分析失败描述，未失败为空字符串</p>
        /// </summary>
        [JsonProperty("AIFailedReason")]
        public string AIFailedReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AlarmRuleID", this.AlarmRuleID);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "AccessKeyID", this.AccessKeyID);
            this.SetParamSimple(map, prefix + "AccessKeyRemark", this.AccessKeyRemark);
            this.SetParamSimple(map, prefix + "LastAlarmTime", this.LastAlarmTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "SubNickname", this.SubNickname);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamArraySimple(map, prefix + "LeakEvidence.", this.LeakEvidence);
            this.SetParamSimple(map, prefix + "IsSupportEditWhiteAccount", this.IsSupportEditWhiteAccount);
            this.SetParamSimple(map, prefix + "Evidence", this.Evidence);
            this.SetParamSimple(map, prefix + "RuleKey", this.RuleKey);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "AIStatus", this.AIStatus);
            this.SetParamSimple(map, prefix + "FirstAlarmTimestamp", this.FirstAlarmTimestamp);
            this.SetParamSimple(map, prefix + "LastAlarmTimestamp", this.LastAlarmTimestamp);
            this.SetParamSimple(map, prefix + "AIFailedReason", this.AIFailedReason);
        }
    }
}

