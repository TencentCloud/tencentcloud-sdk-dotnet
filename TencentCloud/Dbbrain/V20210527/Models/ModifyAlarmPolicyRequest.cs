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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAlarmPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("ApplyType")]
        public string ApplyType{ get; set; }

        /// <summary>
        /// 开启策略
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public InstanceID[] InstanceIds{ get; set; }

        /// <summary>
        /// User-动态关联该用户所有实例
        /// Instance-关联实例列表的实例
        /// </summary>
        [JsonProperty("NewProfileLevel")]
        public string NewProfileLevel{ get; set; }

        /// <summary>
        /// 新策略名
        /// </summary>
        [JsonProperty("NewProfileName")]
        public string NewProfileName{ get; set; }

        /// <summary>
        /// 旧策略名
        /// </summary>
        [JsonProperty("ProfileName")]
        public string ProfileName{ get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [JsonProperty("ProfileType")]
        public string ProfileType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 规则类型 0-快速，1-自定义 若值为0，则QuickRule不能为空，若值为1，则Rules 不能为空
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// 接受模板
        /// </summary>
        [JsonProperty("TemplateInfo")]
        public TemplateInfo[] TemplateInfo{ get; set; }

        /// <summary>
        /// 快速规则  支持包括fatal-致命, critical-严重,
        /// warning-告警,
        /// information-通知
        /// </summary>
        [JsonProperty("QuickRule")]
        public string QuickRule{ get; set; }

        /// <summary>
        /// 自定义规则
        /// </summary>
        [JsonProperty("Rules")]
        public AlarmsRules[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamArrayObj(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "NewProfileLevel", this.NewProfileLevel);
            this.SetParamSimple(map, prefix + "NewProfileName", this.NewProfileName);
            this.SetParamSimple(map, prefix + "ProfileName", this.ProfileName);
            this.SetParamSimple(map, prefix + "ProfileType", this.ProfileType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArrayObj(map, prefix + "TemplateInfo.", this.TemplateInfo);
            this.SetParamSimple(map, prefix + "QuickRule", this.QuickRule);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

