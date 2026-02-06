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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApmInstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// 业务系统 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 业务系统名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 业务系统描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 业务系统状态。{
        /// 1: 初始化中; 2: 运行中; 4: 限流}
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 业务系统所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 业务系统 Tag 列表
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// AppID 信息
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 创建人 Uin
        /// </summary>
        [JsonProperty("CreateUin")]
        public string CreateUin{ get; set; }

        /// <summary>
        /// 存储使用量(单位：MB)
        /// </summary>
        [JsonProperty("AmountOfUsedStorage")]
        public float? AmountOfUsedStorage{ get; set; }

        /// <summary>
        /// 该业务系统服务端应用数量
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// 日均上报 Span 数
        /// </summary>
        [JsonProperty("CountOfReportSpanPerDay")]
        public long? CountOfReportSpanPerDay{ get; set; }

        /// <summary>
        /// Trace 数据保存时长（单位：天）
        /// </summary>
        [JsonProperty("TraceDuration")]
        public long? TraceDuration{ get; set; }

        /// <summary>
        /// 业务系统上报额度
        /// </summary>
        [JsonProperty("SpanDailyCounters")]
        public long? SpanDailyCounters{ get; set; }

        /// <summary>
        /// 业务系统是否已开通计费（0=未开通，1=已开通）
        /// </summary>
        [JsonProperty("BillingInstance")]
        public long? BillingInstance{ get; set; }

        /// <summary>
        /// 错误警示线（单位：%）
        /// </summary>
        [JsonProperty("ErrRateThreshold")]
        public long? ErrRateThreshold{ get; set; }

        /// <summary>
        /// 采样率（单位：%）
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 是否开启错误采样（0=关, 1=开）
        /// </summary>
        [JsonProperty("ErrorSample")]
        public long? ErrorSample{ get; set; }

        /// <summary>
        /// 采样慢调用保存阈值（单位：ms）
        /// </summary>
        [JsonProperty("SlowRequestSavedThreshold")]
        public long? SlowRequestSavedThreshold{ get; set; }

        /// <summary>
        /// CLS 日志所在地域
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }

        /// <summary>
        /// 日志源
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// 日志功能开关（0=关， 1=开）
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// 日志主题 ID
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// 该业务系统客户端应用数量
        /// </summary>
        [JsonProperty("ClientCount")]
        public long? ClientCount{ get; set; }

        /// <summary>
        /// 该业务系统最近2天活跃应用数量
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// CLS 日志集
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// Metric 数据保存时长（单位：天）
        /// </summary>
        [JsonProperty("MetricDuration")]
        public long? MetricDuration{ get; set; }

        /// <summary>
        /// 用户自定义展示标签列表
        /// </summary>
        [JsonProperty("CustomShowTags")]
        public string[] CustomShowTags{ get; set; }

        /// <summary>
        /// 业务系统计费模式（1为预付费，0为按量付费）
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 业务系统计费模式是否生效
        /// </summary>
        [JsonProperty("PayModeEffective")]
        public bool? PayModeEffective{ get; set; }

        /// <summary>
        /// 响应时间警示线（单位：ms）
        /// </summary>
        [JsonProperty("ResponseDurationWarningThreshold")]
        public long? ResponseDurationWarningThreshold{ get; set; }

        /// <summary>
        /// 是否免费（0=否，1=限额免费，2=完全免费），默认0
        /// </summary>
        [JsonProperty("Free")]
        public long? Free{ get; set; }

        /// <summary>
        /// 是否 TSF 默认业务系统（0=否，1=是）
        /// </summary>
        [JsonProperty("DefaultTSF")]
        public long? DefaultTSF{ get; set; }

        /// <summary>
        /// 是否关联 Dashboard（0=关, 1=开）
        /// </summary>
        [JsonProperty("IsRelatedDashboard")]
        public long? IsRelatedDashboard{ get; set; }

        /// <summary>
        /// 关联的 Dashboard ID
        /// </summary>
        [JsonProperty("DashboardTopicID")]
        public string DashboardTopicID{ get; set; }

        /// <summary>
        /// 是否开启组件漏洞检测（0=关， 1=开）
        /// </summary>
        [JsonProperty("IsInstrumentationVulnerabilityScan")]
        public long? IsInstrumentationVulnerabilityScan{ get; set; }

        /// <summary>
        /// 是否开启 SQL 注入分析（0=关， 1=开）
        /// </summary>
        [JsonProperty("IsSqlInjectionAnalysis")]
        public long? IsSqlInjectionAnalysis{ get; set; }

        /// <summary>
        /// 限流原因。{
        /// 1: 正式版限额;
        /// 2: 试用版限额;
        /// 4: 试用版到期;
        /// 8: 账号欠费
        /// }
        /// </summary>
        [JsonProperty("StopReason")]
        public long? StopReason{ get; set; }

        /// <summary>
        /// 是否开远程命令执行检测（0=关， 1=开）
        /// </summary>
        [JsonProperty("IsRemoteCommandExecutionAnalysis")]
        public long? IsRemoteCommandExecutionAnalysis{ get; set; }

        /// <summary>
        /// 是否开内存马执行检测（0=关， 1=开）
        /// </summary>
        [JsonProperty("IsMemoryHijackingAnalysis")]
        public long? IsMemoryHijackingAnalysis{ get; set; }

        /// <summary>
        /// CLS索引类型(0=全文索引，1=键值索引)
        /// </summary>
        [JsonProperty("LogIndexType")]
        public long? LogIndexType{ get; set; }

        /// <summary>
        /// traceId的索引key: 当CLS索引类型为键值索引时生效
        /// </summary>
        [JsonProperty("LogTraceIdKey")]
        public string LogTraceIdKey{ get; set; }

        /// <summary>
        /// 是否开启删除任意文件检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsDeleteAnyFileAnalysis")]
        public long? IsDeleteAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启读取任意文件检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsReadAnyFileAnalysis")]
        public long? IsReadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启上传任意文件检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsUploadAnyFileAnalysis")]
        public long? IsUploadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启包含任意文件检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsIncludeAnyFileAnalysis")]
        public long? IsIncludeAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启目录遍历检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsDirectoryTraversalAnalysis")]
        public long? IsDirectoryTraversalAnalysis{ get; set; }

        /// <summary>
        /// 是否开启模板引擎注入检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsTemplateEngineInjectionAnalysis")]
        public long? IsTemplateEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启脚本引擎注入检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsScriptEngineInjectionAnalysis")]
        public long? IsScriptEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启表达式注入检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsExpressionInjectionAnalysis")]
        public long? IsExpressionInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启JNDI注入检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsJNDIInjectionAnalysis")]
        public long? IsJNDIInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启JNI注入检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsJNIInjectionAnalysis")]
        public long? IsJNIInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启Webshell后门检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsWebshellBackdoorAnalysis")]
        public long? IsWebshellBackdoorAnalysis{ get; set; }

        /// <summary>
        /// 是否开启反序列化检测（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("IsDeserializationAnalysis")]
        public long? IsDeserializationAnalysis{ get; set; }

        /// <summary>
        /// 业务系统鉴权 token
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// URL长分段收敛阈值
        /// </summary>
        [JsonProperty("UrlLongSegmentThreshold")]
        public long? UrlLongSegmentThreshold{ get; set; }

        /// <summary>
        /// URL数字分段收敛阈值
        /// </summary>
        [JsonProperty("UrlNumberSegmentThreshold")]
        public long? UrlNumberSegmentThreshold{ get; set; }

        /// <summary>
        /// spanId的索引key: 当CLS索引类型为键值索引时生效
        /// </summary>
        [JsonProperty("LogSpanIdKey")]
        public string LogSpanIdKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "AmountOfUsedStorage", this.AmountOfUsedStorage);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "CountOfReportSpanPerDay", this.CountOfReportSpanPerDay);
            this.SetParamSimple(map, prefix + "TraceDuration", this.TraceDuration);
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
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "IsRemoteCommandExecutionAnalysis", this.IsRemoteCommandExecutionAnalysis);
            this.SetParamSimple(map, prefix + "IsMemoryHijackingAnalysis", this.IsMemoryHijackingAnalysis);
            this.SetParamSimple(map, prefix + "LogIndexType", this.LogIndexType);
            this.SetParamSimple(map, prefix + "LogTraceIdKey", this.LogTraceIdKey);
            this.SetParamSimple(map, prefix + "IsDeleteAnyFileAnalysis", this.IsDeleteAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsReadAnyFileAnalysis", this.IsReadAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsUploadAnyFileAnalysis", this.IsUploadAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsIncludeAnyFileAnalysis", this.IsIncludeAnyFileAnalysis);
            this.SetParamSimple(map, prefix + "IsDirectoryTraversalAnalysis", this.IsDirectoryTraversalAnalysis);
            this.SetParamSimple(map, prefix + "IsTemplateEngineInjectionAnalysis", this.IsTemplateEngineInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsScriptEngineInjectionAnalysis", this.IsScriptEngineInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsExpressionInjectionAnalysis", this.IsExpressionInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsJNDIInjectionAnalysis", this.IsJNDIInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsJNIInjectionAnalysis", this.IsJNIInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsWebshellBackdoorAnalysis", this.IsWebshellBackdoorAnalysis);
            this.SetParamSimple(map, prefix + "IsDeserializationAnalysis", this.IsDeserializationAnalysis);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "UrlLongSegmentThreshold", this.UrlLongSegmentThreshold);
            this.SetParamSimple(map, prefix + "UrlNumberSegmentThreshold", this.UrlNumberSegmentThreshold);
            this.SetParamSimple(map, prefix + "LogSpanIdKey", this.LogSpanIdKey);
        }
    }
}

