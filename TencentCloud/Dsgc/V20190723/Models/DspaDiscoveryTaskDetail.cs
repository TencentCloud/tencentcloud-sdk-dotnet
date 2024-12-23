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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaDiscoveryTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 执行周期，0单次 1每天 2每周 3每月
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 执行计划，0立即 1定时
        /// </summary>
        [JsonProperty("Plan")]
        public long? Plan{ get; set; }

        /// <summary>
        /// 任务开关；1 打开，0 关闭
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 元数据对象信息
        /// </summary>
        [JsonProperty("DataSourceInfo")]
        public DspaDiscoveryTaskDataSource DataSourceInfo{ get; set; }

        /// <summary>
        /// 通用规则集开关，0 关闭，1 启用
        /// </summary>
        [JsonProperty("GeneralRuleSetEnable")]
        public long? GeneralRuleSetEnable{ get; set; }

        /// <summary>
        /// 当创建任务时，用户打开了通用规则集开关，则该字段就会保存默认合规组信息
        /// </summary>
        [JsonProperty("DefaultComplianceInfo")]
        public ScanTaskComplianceInfo[] DefaultComplianceInfo{ get; set; }

        /// <summary>
        /// 该任务中用户选择的合规组信息列表
        /// </summary>
        [JsonProperty("CustomComplianceInfo")]
        public ScanTaskComplianceInfo[] CustomComplianceInfo{ get; set; }

        /// <summary>
        /// 定时开始时间
        /// </summary>
        [JsonProperty("TimingStartTime")]
        public string TimingStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Plan", this.Plan);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamObj(map, prefix + "DataSourceInfo.", this.DataSourceInfo);
            this.SetParamSimple(map, prefix + "GeneralRuleSetEnable", this.GeneralRuleSetEnable);
            this.SetParamArrayObj(map, prefix + "DefaultComplianceInfo.", this.DefaultComplianceInfo);
            this.SetParamArrayObj(map, prefix + "CustomComplianceInfo.", this.CustomComplianceInfo);
            this.SetParamSimple(map, prefix + "TimingStartTime", this.TimingStartTime);
        }
    }
}

