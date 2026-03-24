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

    public class ApmApplicationConfigView : AbstractModel
    {
        
        /// <summary>
        /// <p>业务系统 ID</p>
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// <p>应用名</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>接口过滤</p>
        /// </summary>
        [JsonProperty("OperationNameFilter")]
        public string OperationNameFilter{ get; set; }

        /// <summary>
        /// <p>错误类型过滤</p>
        /// </summary>
        [JsonProperty("ExceptionFilter")]
        public string ExceptionFilter{ get; set; }

        /// <summary>
        /// <p>HTTP 状态码过滤</p>
        /// </summary>
        [JsonProperty("ErrorCodeFilter")]
        public string ErrorCodeFilter{ get; set; }

        /// <summary>
        /// <p>应用诊断开关（已废弃）</p>
        /// </summary>
        [JsonProperty("EventEnable")]
        public bool? EventEnable{ get; set; }

        /// <summary>
        /// <p>URL 收敛开关 0 关 1 开</p>
        /// </summary>
        [JsonProperty("UrlConvergenceSwitch")]
        public long? UrlConvergenceSwitch{ get; set; }

        /// <summary>
        /// <p>URL 收敛阈值</p>
        /// </summary>
        [JsonProperty("UrlConvergenceThreshold")]
        public long? UrlConvergenceThreshold{ get; set; }

        /// <summary>
        /// <p>URL 收敛规则正则</p>
        /// </summary>
        [JsonProperty("UrlConvergence")]
        public string UrlConvergence{ get; set; }

        /// <summary>
        /// <p>URL 排除规则正则</p>
        /// </summary>
        [JsonProperty("UrlExclude")]
        public string UrlExclude{ get; set; }

        /// <summary>
        /// <p>是否开启日志 0 关 1 开</p>
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// <p>日志源</p>
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// <p>日志集</p>
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// <p>日志主题</p>
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// <p>方法栈快照开关 true 开启 false 关闭</p>
        /// </summary>
        [JsonProperty("SnapshotEnable")]
        public bool? SnapshotEnable{ get; set; }

        /// <summary>
        /// <p>慢调用监听触发阈值</p>
        /// </summary>
        [JsonProperty("SnapshotTimeout")]
        public long? SnapshotTimeout{ get; set; }

        /// <summary>
        /// <p>探针总开关</p>
        /// </summary>
        [JsonProperty("AgentEnable")]
        public bool? AgentEnable{ get; set; }

        /// <summary>
        /// <p>组件列表开关（已废弃）</p>
        /// </summary>
        [JsonProperty("InstrumentList")]
        public Instrument[] InstrumentList{ get; set; }

        /// <summary>
        /// <p>链路压缩开关（已废弃）</p>
        /// </summary>
        [JsonProperty("TraceSquash")]
        public bool? TraceSquash{ get; set; }

        /// <summary>
        /// <p>链路过滤配置</p>
        /// </summary>
        [JsonProperty("AgentIgnoreOperation")]
        public string AgentIgnoreOperation{ get; set; }

        /// <summary>
        /// <p>开启应用安全开关</p>
        /// </summary>
        [JsonProperty("EnableSecurityConfig")]
        public bool? EnableSecurityConfig{ get; set; }

        /// <summary>
        /// <p>是否开启SQL注入检测</p>
        /// </summary>
        [JsonProperty("IsSqlInjectionAnalysis")]
        public long? IsSqlInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启组件漏洞检测</p>
        /// </summary>
        [JsonProperty("IsInstrumentationVulnerabilityScan")]
        public long? IsInstrumentationVulnerabilityScan{ get; set; }

        /// <summary>
        /// <p>是否开启远程命令执行检测</p>
        /// </summary>
        [JsonProperty("IsRemoteCommandExecutionAnalysis")]
        public long? IsRemoteCommandExecutionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启内存泄漏检测</p>
        /// </summary>
        [JsonProperty("IsMemoryHijackingAnalysis")]
        public long? IsMemoryHijackingAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启删除任意文件检测</p>
        /// </summary>
        [JsonProperty("IsDeleteAnyFileAnalysis")]
        public long? IsDeleteAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启读取任意文件检测</p>
        /// </summary>
        [JsonProperty("IsReadAnyFileAnalysis")]
        public long? IsReadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启上传任意文件检测</p>
        /// </summary>
        [JsonProperty("IsUploadAnyFileAnalysis")]
        public long? IsUploadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启包含任意文件检测</p>
        /// </summary>
        [JsonProperty("IsIncludeAnyFileAnalysis")]
        public long? IsIncludeAnyFileAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启目录遍历检测</p>
        /// </summary>
        [JsonProperty("IsDirectoryTraversalAnalysis")]
        public long? IsDirectoryTraversalAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启模板引擎注入检测</p>
        /// </summary>
        [JsonProperty("IsTemplateEngineInjectionAnalysis")]
        public long? IsTemplateEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启脚本引擎注入检测</p>
        /// </summary>
        [JsonProperty("IsScriptEngineInjectionAnalysis")]
        public long? IsScriptEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启表达式注入检测</p>
        /// </summary>
        [JsonProperty("IsExpressionInjectionAnalysis")]
        public long? IsExpressionInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启JNDI注入检测</p>
        /// </summary>
        [JsonProperty("IsJndiInjectionAnalysis")]
        public long? IsJndiInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启JNI注入检测</p>
        /// </summary>
        [JsonProperty("IsJniInjectionAnalysis")]
        public long? IsJniInjectionAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启Webshell后门检测</p>
        /// </summary>
        [JsonProperty("IsWebshellBackdoorAnalysis")]
        public long? IsWebshellBackdoorAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启反序列化检测</p>
        /// </summary>
        [JsonProperty("IsDeserializationAnalysis")]
        public long? IsDeserializationAnalysis{ get; set; }

        /// <summary>
        /// <p>是否开启控制台开关</p>
        /// </summary>
        [JsonProperty("EnableDashboardConfig")]
        public bool? EnableDashboardConfig{ get; set; }

        /// <summary>
        /// <p>是否关联Dashboard</p>
        /// </summary>
        [JsonProperty("IsRelatedDashboard")]
        public long? IsRelatedDashboard{ get; set; }

        /// <summary>
        /// <p>Dashboard topic</p>
        /// </summary>
        [JsonProperty("DashboardTopicID")]
        public string DashboardTopicID{ get; set; }

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
        /// <p>自动性能剖析任务配置</p>
        /// </summary>
        [JsonProperty("AutoProfilingConfig")]
        public AutoProfilingConfig AutoProfilingConfig{ get; set; }

        /// <summary>
        /// <p>阈值配置开关</p>
        /// </summary>
        [JsonProperty("EnableThresholdConfig")]
        public bool? EnableThresholdConfig{ get; set; }

        /// <summary>
        /// <p>错误率阈值</p><p>单位：%</p>
        /// </summary>
        [JsonProperty("ErrRateThreshold")]
        public long? ErrRateThreshold{ get; set; }

        /// <summary>
        /// <p>响应时间预警阈值</p><p>单位：ms</p>
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
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "OperationNameFilter", this.OperationNameFilter);
            this.SetParamSimple(map, prefix + "ExceptionFilter", this.ExceptionFilter);
            this.SetParamSimple(map, prefix + "ErrorCodeFilter", this.ErrorCodeFilter);
            this.SetParamSimple(map, prefix + "EventEnable", this.EventEnable);
            this.SetParamSimple(map, prefix + "UrlConvergenceSwitch", this.UrlConvergenceSwitch);
            this.SetParamSimple(map, prefix + "UrlConvergenceThreshold", this.UrlConvergenceThreshold);
            this.SetParamSimple(map, prefix + "UrlConvergence", this.UrlConvergence);
            this.SetParamSimple(map, prefix + "UrlExclude", this.UrlExclude);
            this.SetParamSimple(map, prefix + "IsRelatedLog", this.IsRelatedLog);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
            this.SetParamSimple(map, prefix + "SnapshotEnable", this.SnapshotEnable);
            this.SetParamSimple(map, prefix + "SnapshotTimeout", this.SnapshotTimeout);
            this.SetParamSimple(map, prefix + "AgentEnable", this.AgentEnable);
            this.SetParamArrayObj(map, prefix + "InstrumentList.", this.InstrumentList);
            this.SetParamSimple(map, prefix + "TraceSquash", this.TraceSquash);
            this.SetParamSimple(map, prefix + "AgentIgnoreOperation", this.AgentIgnoreOperation);
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
            this.SetParamSimple(map, prefix + "IsJndiInjectionAnalysis", this.IsJndiInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsJniInjectionAnalysis", this.IsJniInjectionAnalysis);
            this.SetParamSimple(map, prefix + "IsWebshellBackdoorAnalysis", this.IsWebshellBackdoorAnalysis);
            this.SetParamSimple(map, prefix + "IsDeserializationAnalysis", this.IsDeserializationAnalysis);
            this.SetParamSimple(map, prefix + "EnableDashboardConfig", this.EnableDashboardConfig);
            this.SetParamSimple(map, prefix + "IsRelatedDashboard", this.IsRelatedDashboard);
            this.SetParamSimple(map, prefix + "DashboardTopicID", this.DashboardTopicID);
            this.SetParamSimple(map, prefix + "DisableMemoryUsed", this.DisableMemoryUsed);
            this.SetParamSimple(map, prefix + "DisableCpuUsed", this.DisableCpuUsed);
            this.SetParamSimple(map, prefix + "DbStatementParametersEnabled", this.DbStatementParametersEnabled);
            this.SetParamArrayObj(map, prefix + "SlowSQLThresholds.", this.SlowSQLThresholds);
            this.SetParamSimple(map, prefix + "EnableDesensitizationRule", this.EnableDesensitizationRule);
            this.SetParamSimple(map, prefix + "DesensitizationRule", this.DesensitizationRule);
            this.SetParamObj(map, prefix + "AutoProfilingConfig.", this.AutoProfilingConfig);
            this.SetParamSimple(map, prefix + "EnableThresholdConfig", this.EnableThresholdConfig);
            this.SetParamSimple(map, prefix + "ErrRateThreshold", this.ErrRateThreshold);
            this.SetParamSimple(map, prefix + "ResponseDurationWarningThreshold", this.ResponseDurationWarningThreshold);
            this.SetParamSimple(map, prefix + "UseDefaultFuseConfig", this.UseDefaultFuseConfig);
        }
    }
}

