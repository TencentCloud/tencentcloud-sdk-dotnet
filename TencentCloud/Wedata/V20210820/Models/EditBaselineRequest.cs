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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditBaselineRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 基线名称
        /// </summary>
        [JsonProperty("BaselineName")]
        public string BaselineName{ get; set; }

        /// <summary>
        /// D或者H；分别表示天基线和小时基线
        /// </summary>
        [JsonProperty("BaselineType")]
        public string BaselineType{ get; set; }

        /// <summary>
        /// 基线负责人id
        /// </summary>
        [JsonProperty("InChargeUin")]
        public string InChargeUin{ get; set; }

        /// <summary>
        /// 基线负责人名称
        /// </summary>
        [JsonProperty("InChargeName")]
        public string InChargeName{ get; set; }

        /// <summary>
        /// 保障任务
        /// </summary>
        [JsonProperty("PromiseTasks")]
        public BaselineTaskInfo[] PromiseTasks{ get; set; }

        /// <summary>
        /// 保障时间
        /// </summary>
        [JsonProperty("PromiseTime")]
        public string PromiseTime{ get; set; }

        /// <summary>
        /// 告警余量/分钟
        /// </summary>
        [JsonProperty("WarningMargin")]
        public ulong? WarningMargin{ get; set; }

        /// <summary>
        /// 基线id
        /// </summary>
        [JsonProperty("BaselineId")]
        public string BaselineId{ get; set; }

        /// <summary>
        /// 更新人id
        /// </summary>
        [JsonProperty("UpdateUin")]
        public string UpdateUin{ get; set; }

        /// <summary>
        /// 更新人名字
        /// </summary>
        [JsonProperty("UpdateName")]
        public string UpdateName{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("IsNewAlarm")]
        public bool? IsNewAlarm{ get; set; }

        /// <summary>
        /// 现有告警规则信息
        /// </summary>
        [JsonProperty("AlarmRuleDto")]
        public AlarmRuleDto AlarmRuleDto{ get; set; }

        /// <summary>
        /// 告警更新请求
        /// </summary>
        [JsonProperty("BaselineModifyAlarmRuleRequest")]
        public ModifyAlarmRuleRequest BaselineModifyAlarmRuleRequest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "BaselineName", this.BaselineName);
            this.SetParamSimple(map, prefix + "BaselineType", this.BaselineType);
            this.SetParamSimple(map, prefix + "InChargeUin", this.InChargeUin);
            this.SetParamSimple(map, prefix + "InChargeName", this.InChargeName);
            this.SetParamArrayObj(map, prefix + "PromiseTasks.", this.PromiseTasks);
            this.SetParamSimple(map, prefix + "PromiseTime", this.PromiseTime);
            this.SetParamSimple(map, prefix + "WarningMargin", this.WarningMargin);
            this.SetParamSimple(map, prefix + "BaselineId", this.BaselineId);
            this.SetParamSimple(map, prefix + "UpdateUin", this.UpdateUin);
            this.SetParamSimple(map, prefix + "UpdateName", this.UpdateName);
            this.SetParamSimple(map, prefix + "IsNewAlarm", this.IsNewAlarm);
            this.SetParamObj(map, prefix + "AlarmRuleDto.", this.AlarmRuleDto);
            this.SetParamObj(map, prefix + "BaselineModifyAlarmRuleRequest.", this.BaselineModifyAlarmRuleRequest);
        }
    }
}

