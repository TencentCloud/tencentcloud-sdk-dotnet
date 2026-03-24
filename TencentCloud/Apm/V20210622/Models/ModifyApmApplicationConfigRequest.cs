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

    public class ModifyApmApplicationConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>业务系统 ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>应用名</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>URL收敛开关,0 关 | 1 开</p>
        /// </summary>
        [JsonProperty("UrlConvergenceSwitch")]
        public long? UrlConvergenceSwitch{ get; set; }

        /// <summary>
        /// <p>URL收敛阈值</p>
        /// </summary>
        [JsonProperty("UrlConvergenceThreshold")]
        public long? UrlConvergenceThreshold{ get; set; }

        /// <summary>
        /// <p>异常过滤正则规则，逗号分隔</p>
        /// </summary>
        [JsonProperty("ExceptionFilter")]
        public string ExceptionFilter{ get; set; }

        /// <summary>
        /// <p>URL收敛正则规则，逗号分隔</p>
        /// </summary>
        [JsonProperty("UrlConvergence")]
        public string UrlConvergence{ get; set; }

        /// <summary>
        /// <p>错误码过滤，逗号分隔</p>
        /// </summary>
        [JsonProperty("ErrorCodeFilter")]
        public string ErrorCodeFilter{ get; set; }

        /// <summary>
        /// <p>URL排除正则规则，逗号分隔</p>
        /// </summary>
        [JsonProperty("UrlExclude")]
        public string UrlExclude{ get; set; }

        /// <summary>
        /// <p>日志开关 0 关 1 开</p>
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// <p>日志地域</p>
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }

        /// <summary>
        /// <p>日志主题ID</p>
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// <p>CLS 日志集 | ES 集群ID</p>
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// <p>日志来源 CLS | ES</p>
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// <p>需过滤的接口</p>
        /// </summary>
        [JsonProperty("IgnoreOperationName")]
        public string IgnoreOperationName{ get; set; }

        /// <summary>
        /// <p>是否开启线程剖析</p>
        /// </summary>
        [JsonProperty("EnableSnapshot")]
        public bool? EnableSnapshot{ get; set; }

        /// <summary>
        /// <p>线程剖析超时阈值</p>
        /// </summary>
        [JsonProperty("SnapshotTimeout")]
        public long? SnapshotTimeout{ get; set; }

        /// <summary>
        /// <p>是否开启agent</p>
        /// </summary>
        [JsonProperty("AgentEnable")]
        public bool? AgentEnable{ get; set; }

        /// <summary>
        /// <p>是否开启链路压缩</p>
        /// </summary>
        [JsonProperty("TraceSquash")]
        public bool? TraceSquash{ get; set; }

        /// <summary>
        /// <p>是否开启应用诊断的开关</p>
        /// </summary>
        [JsonProperty("EventEnable")]
        public bool? EventEnable{ get; set; }

        /// <summary>
        /// <p>组件列表</p>
        /// </summary>
        [JsonProperty("InstrumentList")]
        public Instrument[] InstrumentList{ get; set; }

        /// <summary>
        /// <p>探针接口相关配置</p>
        /// </summary>
        [JsonProperty("AgentOperationConfigView")]
        public AgentOperationConfigView AgentOperationConfigView{ get; set; }

        /// <summary>
        /// <p>是否开启应用日志配置</p>
        /// </summary>
        [JsonProperty("EnableLogConfig")]
        public bool? EnableLogConfig{ get; set; }

        /// <summary>
        /// <p>应用是否开启dashboard配置： false 关（与业务系统保持一致）/true 开（应用级配置）</p>
        /// </summary>
        [JsonProperty("EnableDashboardConfig")]
        public bool? EnableDashboardConfig{ get; set; }

        /// <summary>
        /// <p>是否关联dashboard： 0 关 1 开</p>
        /// </summary>
        [JsonProperty("IsRelatedDashboard")]
        public long? IsRelatedDashboard{ get; set; }

        /// <summary>
        /// <p>dashboard ID</p>
        /// </summary>
        [JsonProperty("DashboardTopicID")]
        public string DashboardTopicID{ get; set; }

        /// <summary>
        /// <p>CLS索引类型(0=全文索引，1=键值索引)</p>
        /// </summary>
        [JsonProperty("LogIndexType")]
        public long? LogIndexType{ get; set; }

        /// <summary>
        /// <p>traceId的索引key: 当CLS索引类型为键值索引时生效</p>
        /// </summary>
        [JsonProperty("LogTraceIdKey")]
        public string LogTraceIdKey{ get; set; }

        /// <summary>
        /// <p>是否开启应用安全配置</p>
        /// </summary>
        [JsonProperty("EnableSecurityConfig")]
        public bool? EnableSecurityConfig{ get; set; }

        /// <summary>
        /// <p>是否开启SQL注入分析</p>
        /// </summary>
        [JsonProperty("IsSqlInjectionAnalysis")]
        public long? IsSqlInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启组件漏洞检测</p>
        /// </summary>
        [JsonProperty("IsInstrumentationVulnerabilityScan")]
        public long? IsInstrumentationVulnerabilityScan{ get; set; }

        /// <summary>
        /// <p>是否开启远程命令检测</p>
        /// </summary>
        [JsonProperty("IsRemoteCommandExecutionAnalysis")]
        public long? IsRemoteCommandExecutionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启内存马检测</p>
        /// </summary>
        [JsonProperty("IsMemoryHijackingAnalysis")]
        public long? IsMemoryHijackingAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启删除任意文件检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsDeleteAnyFileAnalysis")]
        public long? IsDeleteAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启读取任意文件检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsReadAnyFileAnalysis")]
        public long? IsReadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启上传任意文件检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsUploadAnyFileAnalysis")]
        public long? IsUploadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启包含任意文件检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsIncludeAnyFileAnalysis")]
        public long? IsIncludeAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启目录遍历检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsDirectoryTraversalAnalysis")]
        public long? IsDirectoryTraversalAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启模板引擎注入检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsTemplateEngineInjectionAnalysis")]
        public long? IsTemplateEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启脚本引擎注入检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsScriptEngineInjectionAnalysis")]
        public long? IsScriptEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启表达式注入检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsExpressionInjectionAnalysis")]
        public long? IsExpressionInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启JNDI注入检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsJNDIInjectionAnalysis")]
        public long? IsJNDIInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启JNI注入检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsJNIInjectionAnalysis")]
        public long? IsJNIInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启Webshell后门检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsWebshellBackdoorAnalysis")]
        public long? IsWebshellBackdoorAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启反序列化检测（0-关闭，1-开启）</p>
        /// </summary>
        [JsonProperty("IsDeserializationAnalysis")]
        public long? IsDeserializationAnalysis{ get; set; }

        /// <summary>
        /// <p>接口自动收敛开关,0 关 | 1 开</p>
        /// </summary>
        [JsonProperty("UrlAutoConvergenceEnable")]
        public bool? UrlAutoConvergenceEnable{ get; set; }

        /// <summary>
        /// <p>URL长分段收敛阈值</p>
        /// </summary>
        [JsonProperty("UrlLongSegmentThreshold")]
        public long? UrlLongSegmentThreshold{ get; set; }

        /// <summary>
        /// <p>URL数字分段收敛阈值</p>
        /// </summary>
        [JsonProperty("UrlNumberSegmentThreshold")]
        public long? UrlNumberSegmentThreshold{ get; set; }

        /// <summary>
        /// <p>探针熔断内存阈值</p>
        /// </summary>
        [JsonProperty("DisableMemoryUsed")]
        public long? DisableMemoryUsed{ get; set; }

        /// <summary>
        /// <p>探针熔断CPU阈值</p>
        /// </summary>
        [JsonProperty("DisableCpuUsed")]
        public long? DisableCpuUsed{ get; set; }

        /// <summary>
        /// <p>是否开启SQL参数获取</p>
        /// </summary>
        [JsonProperty("DbStatementParametersEnabled")]
        public bool? DbStatementParametersEnabled{ get; set; }

        /// <summary>
        /// <p>慢SQL阈值</p>
        /// </summary>
        [JsonProperty("SlowSQLThresholds")]
        public ApmTag[] SlowSQLThresholds{ get; set; }

        /// <summary>
        /// <p>是否开启脱敏规则</p>
        /// </summary>
        [JsonProperty("EnableDesensitizationRule")]
        public long? EnableDesensitizationRule{ get; set; }

        /// <summary>
        /// <p>脱敏规则</p>
        /// </summary>
        [JsonProperty("DesensitizationRule")]
        public string DesensitizationRule{ get; set; }

        /// <summary>
        /// <p>spanId的索引key: 当CLS索引类型为键值索引时生效</p>
        /// </summary>
        [JsonProperty("LogSpanIdKey")]
        public string LogSpanIdKey{ get; set; }

        /// <summary>
        /// <p>自动性能剖析任务配置</p>
        /// </summary>
        [JsonProperty("AutoProfilingConfig")]
        public AutoProfilingConfig AutoProfilingConfig{ get; set; }

        /// <summary>
        /// <p>阈值配置开关。true 表示使用应用级阈值；false 表示使用业务系统级阈值</p>
        /// </summary>
        [JsonProperty("EnableThresholdConfig")]
        public bool? EnableThresholdConfig{ get; set; }

        /// <summary>
        /// <p>错误率阈值（%），用于判断应用健康状态为&quot;红色&quot;</p>
        /// </summary>
        [JsonProperty("ErrRateThreshold")]
        public long? ErrRateThreshold{ get; set; }

        /// <summary>
        /// <p>响应时间预警阈值（ms），用于判断应用健康状态为&quot;黄色&quot;</p>
        /// </summary>
        [JsonProperty("ResponseDurationWarningThreshold")]
        public long? ResponseDurationWarningThreshold{ get; set; }

        /// <summary>
        /// <p>是否使用探针默认熔断阈值</p>
        /// </summary>
        [JsonProperty("UseDefaultFuseConfig")]
        public bool? UseDefaultFuseConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "UrlConvergenceSwitch", this.UrlConvergenceSwitch);
            this.SetParamSimple(map, prefix + "UrlConvergenceThreshold", this.UrlConvergenceThreshold);
            this.SetParamSimple(map, prefix + "ExceptionFilter", this.ExceptionFilter);
            this.SetParamSimple(map, prefix + "UrlConvergence", this.UrlConvergence);
            this.SetParamSimple(map, prefix + "ErrorCodeFilter", this.ErrorCodeFilter);
            this.SetParamSimple(map, prefix + "UrlExclude", this.UrlExclude);
            this.SetParamSimple(map, prefix + "IsRelatedLog", this.IsRelatedLog);
            this.SetParamSimple(map, prefix + "LogRegion", this.LogRegion);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "IgnoreOperationName", this.IgnoreOperationName);
            this.SetParamSimple(map, prefix + "EnableSnapshot", this.EnableSnapshot);
            this.SetParamSimple(map, prefix + "SnapshotTimeout", this.SnapshotTimeout);
            this.SetParamSimple(map, prefix + "AgentEnable", this.AgentEnable);
            this.SetParamSimple(map, prefix + "TraceSquash", this.TraceSquash);
            this.SetParamSimple(map, prefix + "EventEnable", this.EventEnable);
            this.SetParamArrayObj(map, prefix + "InstrumentList.", this.InstrumentList);
            this.SetParamObj(map, prefix + "AgentOperationConfigView.", this.AgentOperationConfigView);
            this.SetParamSimple(map, prefix + "EnableLogConfig", this.EnableLogConfig);
            this.SetParamSimple(map, prefix + "EnableDashboardConfig", this.EnableDashboardConfig);
            this.SetParamSimple(map, prefix + "IsRelatedDashboard", this.IsRelatedDashboard);
            this.SetParamSimple(map, prefix + "DashboardTopicID", this.DashboardTopicID);
            this.SetParamSimple(map, prefix + "LogIndexType", this.LogIndexType);
            this.SetParamSimple(map, prefix + "LogTraceIdKey", this.LogTraceIdKey);
            this.SetParamSimple(map, prefix + "EnableSecurityConfig", this.EnableSecurityConfig);
            this.SetParamSimple(map, prefix + "IsSqlInjectionAnalysis", this.IsSqlInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsInstrumentationVulnerabilityScan", this.IsInstrumentationVulnerabilityScan);
            this.SetParamSimple(map, prefix + "IsRemoteCommandExecutionAnalysis", this.IsRemoteCommandExecutionAnalysis);
            this.SetParamSimple(map, prefix + "IsMemoryHijackingAnalysis", this.IsMemoryHijackingAnalysis);
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
            this.SetParamSimple(map, prefix + "UrlAutoConvergenceEnable", this.UrlAutoConvergenceEnable);
            this.SetParamSimple(map, prefix + "UrlLongSegmentThreshold", this.UrlLongSegmentThreshold);
            this.SetParamSimple(map, prefix + "UrlNumberSegmentThreshold", this.UrlNumberSegmentThreshold);
            this.SetParamSimple(map, prefix + "DisableMemoryUsed", this.DisableMemoryUsed);
            this.SetParamSimple(map, prefix + "DisableCpuUsed", this.DisableCpuUsed);
            this.SetParamSimple(map, prefix + "DbStatementParametersEnabled", this.DbStatementParametersEnabled);
            this.SetParamArrayObj(map, prefix + "SlowSQLThresholds.", this.SlowSQLThresholds);
            this.SetParamSimple(map, prefix + "EnableDesensitizationRule", this.EnableDesensitizationRule);
            this.SetParamSimple(map, prefix + "DesensitizationRule", this.DesensitizationRule);
            this.SetParamSimple(map, prefix + "LogSpanIdKey", this.LogSpanIdKey);
            this.SetParamObj(map, prefix + "AutoProfilingConfig.", this.AutoProfilingConfig);
            this.SetParamSimple(map, prefix + "EnableThresholdConfig", this.EnableThresholdConfig);
            this.SetParamSimple(map, prefix + "ErrRateThreshold", this.ErrRateThreshold);
            this.SetParamSimple(map, prefix + "ResponseDurationWarningThreshold", this.ResponseDurationWarningThreshold);
            this.SetParamSimple(map, prefix + "UseDefaultFuseConfig", this.UseDefaultFuseConfig);
        }
    }
}

