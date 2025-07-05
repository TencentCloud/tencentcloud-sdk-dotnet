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

    public class UebaRule : AbstractModel
    {
        
        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 策略类型
        /// 0:系统策略
        /// 1:自定义策略
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// 策略等级
        /// 0:提示
        /// 1:低危
        /// 2:中危
        /// 3:高危
        /// 4:严重
        /// </summary>
        [JsonProperty("RuleLevel")]
        public long? RuleLevel{ get; set; }

        /// <summary>
        /// 策略内容
        /// </summary>
        [JsonProperty("RuleContent")]
        public string RuleContent{ get; set; }

        /// <summary>
        /// 策略开关
        /// </summary>
        [JsonProperty("RuleStatus")]
        public bool? RuleStatus{ get; set; }

        /// <summary>
        /// 命中次数
        /// </summary>
        [JsonProperty("HitCount")]
        public ulong? HitCount{ get; set; }

        /// <summary>
        /// 所属账号Appid
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// 多账号，成员ID
        /// </summary>
        [JsonProperty("MemberID")]
        public string MemberID{ get; set; }

        /// <summary>
        /// Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 自定义规则具体内容
        /// </summary>
        [JsonProperty("CustomRuleDetail")]
        public UebaCustomRule CustomRuleDetail{ get; set; }

        /// <summary>
        /// 云类型
        /// 腾讯云：0
        /// aws：1
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "RuleLevel", this.RuleLevel);
            this.SetParamSimple(map, prefix + "RuleContent", this.RuleContent);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamSimple(map, prefix + "HitCount", this.HitCount);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "MemberID", this.MemberID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamObj(map, prefix + "CustomRuleDetail.", this.CustomRuleDetail);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

