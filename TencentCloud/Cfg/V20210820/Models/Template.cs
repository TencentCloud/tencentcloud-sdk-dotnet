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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Template : AbstractModel
    {
        
        /// <summary>
        /// 经验库ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 经验库标题
        /// </summary>
        [JsonProperty("TemplateTitle")]
        public string TemplateTitle{ get; set; }

        /// <summary>
        /// 经验库描述
        /// </summary>
        [JsonProperty("TemplateDescription")]
        public string TemplateDescription{ get; set; }

        /// <summary>
        /// 自定义标签
        /// </summary>
        [JsonProperty("TemplateTag")]
        public string TemplateTag{ get; set; }

        /// <summary>
        /// 使用状态。1 ---- 使用中，2 --- 停用
        /// </summary>
        [JsonProperty("TemplateIsUsed")]
        public long? TemplateIsUsed{ get; set; }

        /// <summary>
        /// 经验库创建时间
        /// </summary>
        [JsonProperty("TemplateCreateTime")]
        public string TemplateCreateTime{ get; set; }

        /// <summary>
        /// 经验库更新时间
        /// </summary>
        [JsonProperty("TemplateUpdateTime")]
        public string TemplateUpdateTime{ get; set; }

        /// <summary>
        /// 经验库模式。1:手工执行，2:自动执行
        /// </summary>
        [JsonProperty("TemplateMode")]
        public long? TemplateMode{ get; set; }

        /// <summary>
        /// 自动暂停时长。单位分钟
        /// </summary>
        [JsonProperty("TemplatePauseDuration")]
        public long? TemplatePauseDuration{ get; set; }

        /// <summary>
        /// 演练创建者Uin
        /// </summary>
        [JsonProperty("TemplateOwnerUin")]
        public string TemplateOwnerUin{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("TemplateRegionId")]
        public long? TemplateRegionId{ get; set; }

        /// <summary>
        /// 动作组
        /// </summary>
        [JsonProperty("TemplateGroups")]
        public TemplateGroup[] TemplateGroups{ get; set; }

        /// <summary>
        /// 监控指标
        /// </summary>
        [JsonProperty("TemplateMonitors")]
        public TemplateMonitor[] TemplateMonitors{ get; set; }

        /// <summary>
        /// 护栏监控
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplatePolicy")]
        public TemplatePolicy TemplatePolicy{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }

        /// <summary>
        /// 经验来源 0-自建 1-专家推荐
        /// </summary>
        [JsonProperty("TemplateSource")]
        public long? TemplateSource{ get; set; }

        /// <summary>
        /// apm应用信息
        /// </summary>
        [JsonProperty("ApmServiceList")]
        public ApmServiceInfo[] ApmServiceList{ get; set; }

        /// <summary>
        /// 告警指标
        /// </summary>
        [JsonProperty("AlarmPolicy")]
        public string[] AlarmPolicy{ get; set; }

        /// <summary>
        /// 护栏处理方式，1--顺序回滚，2--演练暂停
        /// </summary>
        [JsonProperty("PolicyDealType")]
        public long? PolicyDealType{ get; set; }

        /// <summary>
        /// 演练场景
        /// </summary>
        [JsonProperty("TemplateScenario")]
        public TaskTarget[] TemplateScenario{ get; set; }

        /// <summary>
        /// 演练目的
        /// </summary>
        [JsonProperty("TemplatePurpose")]
        public TaskTarget[] TemplatePurpose{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateTitle", this.TemplateTitle);
            this.SetParamSimple(map, prefix + "TemplateDescription", this.TemplateDescription);
            this.SetParamSimple(map, prefix + "TemplateTag", this.TemplateTag);
            this.SetParamSimple(map, prefix + "TemplateIsUsed", this.TemplateIsUsed);
            this.SetParamSimple(map, prefix + "TemplateCreateTime", this.TemplateCreateTime);
            this.SetParamSimple(map, prefix + "TemplateUpdateTime", this.TemplateUpdateTime);
            this.SetParamSimple(map, prefix + "TemplateMode", this.TemplateMode);
            this.SetParamSimple(map, prefix + "TemplatePauseDuration", this.TemplatePauseDuration);
            this.SetParamSimple(map, prefix + "TemplateOwnerUin", this.TemplateOwnerUin);
            this.SetParamSimple(map, prefix + "TemplateRegionId", this.TemplateRegionId);
            this.SetParamArrayObj(map, prefix + "TemplateGroups.", this.TemplateGroups);
            this.SetParamArrayObj(map, prefix + "TemplateMonitors.", this.TemplateMonitors);
            this.SetParamObj(map, prefix + "TemplatePolicy.", this.TemplatePolicy);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TemplateSource", this.TemplateSource);
            this.SetParamArrayObj(map, prefix + "ApmServiceList.", this.ApmServiceList);
            this.SetParamArraySimple(map, prefix + "AlarmPolicy.", this.AlarmPolicy);
            this.SetParamSimple(map, prefix + "PolicyDealType", this.PolicyDealType);
            this.SetParamArrayObj(map, prefix + "TemplateScenario.", this.TemplateScenario);
            this.SetParamArrayObj(map, prefix + "TemplatePurpose.", this.TemplatePurpose);
        }
    }
}

