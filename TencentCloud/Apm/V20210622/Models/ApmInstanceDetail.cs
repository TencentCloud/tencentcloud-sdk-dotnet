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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApmInstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// 存储使用量(MB)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AmountOfUsedStorage")]
        public float? AmountOfUsedStorage{ get; set; }

        /// <summary>
        /// 实例名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 实例所属tag列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 创建人Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateUin")]
        public string CreateUin{ get; set; }

        /// <summary>
        /// 该实例已上报的服务端应用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// 日均上报Span数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CountOfReportSpanPerDay")]
        public long? CountOfReportSpanPerDay{ get; set; }

        /// <summary>
        /// AppId信息
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Trace数据保存时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TraceDuration")]
        public long? TraceDuration{ get; set; }

        /// <summary>
        /// 实例描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 实例状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例所属地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例上报额度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpanDailyCounters")]
        public long? SpanDailyCounters{ get; set; }

        /// <summary>
        /// 实例是否开通计费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingInstance")]
        public long? BillingInstance{ get; set; }

        /// <summary>
        /// 错误率阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrRateThreshold")]
        public long? ErrRateThreshold{ get; set; }

        /// <summary>
        /// 采样率阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 是否开启错误采样 0  关 1 开
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorSample")]
        public long? ErrorSample{ get; set; }

        /// <summary>
        /// 慢调用保存阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlowRequestSavedThreshold")]
        public long? SlowRequestSavedThreshold{ get; set; }

        /// <summary>
        /// cls日志所在地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }

        /// <summary>
        /// 日志来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// 日志功能开关 0 关 | 1 开
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// 日志主题ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// 该实例已上报的客户端应用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientCount")]
        public long? ClientCount{ get; set; }

        /// <summary>
        /// 该实例已上报的总应用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// CLS日志集 | ES集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// Metric数据保存时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricDuration")]
        public long? MetricDuration{ get; set; }

        /// <summary>
        /// 用户自定义展示标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomShowTags")]
        public string[] CustomShowTags{ get; set; }

        /// <summary>
        /// 实例计费模式
        /// 1为预付费
        /// 0为按量付费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 实例计费模式是否生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayModeEffective")]
        public bool? PayModeEffective{ get; set; }

        /// <summary>
        /// 响应时间满意阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseDurationWarningThreshold")]
        public long? ResponseDurationWarningThreshold{ get; set; }

        /// <summary>
        /// 是否免费（0=否，1=限额免费，2=完全免费），默认0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Free")]
        public long? Free{ get; set; }

        /// <summary>
        /// 是否tsf默认业务系统（0=否，1-是）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultTSF")]
        public long? DefaultTSF{ get; set; }

        /// <summary>
        /// 是否关联dashboard： 0 关 1 开
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsRelatedDashboard")]
        public long? IsRelatedDashboard{ get; set; }

        /// <summary>
        /// dashboard ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DashboardTopicID")]
        public string DashboardTopicID{ get; set; }

        /// <summary>
        /// 是否开启组件漏洞检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsInstrumentationVulnerabilityScan")]
        public long? IsInstrumentationVulnerabilityScan{ get; set; }

        /// <summary>
        /// 是否开启SQL注入分析
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSqlInjectionAnalysis")]
        public long? IsSqlInjectionAnalysis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AmountOfUsedStorage", this.AmountOfUsedStorage);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "CountOfReportSpanPerDay", this.CountOfReportSpanPerDay);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TraceDuration", this.TraceDuration);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SpanDailyCounters", this.SpanDailyCounters);
            this.SetParamSimple(map, prefix + "BillingInstance", this.BillingInstance);
            this.SetParamSimple(map, prefix + "ErrRateThreshold", this.ErrRateThreshold);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "ErrorSample", this.ErrorSample);
            this.SetParamSimple(map, prefix + "SlowRequestSavedThreshold", this.SlowRequestSavedThreshold);
            this.SetParamSimple(map, prefix + "LogRegion", this.LogRegion);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "IsRelatedLog", this.IsRelatedLog);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
            this.SetParamSimple(map, prefix + "ClientCount", this.ClientCount);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "MetricDuration", this.MetricDuration);
            this.SetParamArraySimple(map, prefix + "CustomShowTags.", this.CustomShowTags);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeEffective", this.PayModeEffective);
            this.SetParamSimple(map, prefix + "ResponseDurationWarningThreshold", this.ResponseDurationWarningThreshold);
            this.SetParamSimple(map, prefix + "Free", this.Free);
            this.SetParamSimple(map, prefix + "DefaultTSF", this.DefaultTSF);
            this.SetParamSimple(map, prefix + "IsRelatedDashboard", this.IsRelatedDashboard);
            this.SetParamSimple(map, prefix + "DashboardTopicID", this.DashboardTopicID);
            this.SetParamSimple(map, prefix + "IsInstrumentationVulnerabilityScan", this.IsInstrumentationVulnerabilityScan);
            this.SetParamSimple(map, prefix + "IsSqlInjectionAnalysis", this.IsSqlInjectionAnalysis);
        }
    }
}

