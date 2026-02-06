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

    public class ApmAppConfig : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// URL收敛开关
        /// </summary>
        [JsonProperty("UrlConvergenceSwitch")]
        public long? UrlConvergenceSwitch{ get; set; }

        /// <summary>
        /// URL收敛阈值
        /// </summary>
        [JsonProperty("UrlConvergenceThreshold")]
        public long? UrlConvergenceThreshold{ get; set; }

        /// <summary>
        /// URL收敛正则
        /// </summary>
        [JsonProperty("UrlConvergence")]
        public string UrlConvergence{ get; set; }

        /// <summary>
        /// 异常过滤正则
        /// </summary>
        [JsonProperty("ExceptionFilter")]
        public string ExceptionFilter{ get; set; }

        /// <summary>
        /// 错误码过滤
        /// </summary>
        [JsonProperty("ErrorCodeFilter")]
        public string ErrorCodeFilter{ get; set; }

        /// <summary>
        /// 服务组件类型
        /// </summary>
        [JsonProperty("Components")]
        public string Components{ get; set; }

        /// <summary>
        /// URL排除正则
        /// </summary>
        [JsonProperty("UrlExclude")]
        public string UrlExclude{ get; set; }

        /// <summary>
        /// 日志来源
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// 日志所在地域
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }

        /// <summary>
        /// 是否开启日志 0 关 1 开
        /// </summary>
        [JsonProperty("IsRelatedLog")]
        public long? IsRelatedLog{ get; set; }

        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("LogTopicID")]
        public string LogTopicID{ get; set; }

        /// <summary>
        /// 需过滤的接口名
        /// </summary>
        [JsonProperty("IgnoreOperationName")]
        public string IgnoreOperationName{ get; set; }

        /// <summary>
        /// CLS日志集 | ES集群ID
        /// </summary>
        [JsonProperty("LogSet")]
        public string LogSet{ get; set; }

        /// <summary>
        /// 探针每秒上报trace数
        /// </summary>
        [JsonProperty("TraceRateLimit")]
        public long? TraceRateLimit{ get; set; }

        /// <summary>
        /// 是否开启线程剖析
        /// </summary>
        [JsonProperty("EnableSnapshot")]
        public bool? EnableSnapshot{ get; set; }

        /// <summary>
        /// 线程剖析超时阈值
        /// </summary>
        [JsonProperty("SnapshotTimeout")]
        public long? SnapshotTimeout{ get; set; }

        /// <summary>
        /// 是否开启agent
        /// </summary>
        [JsonProperty("AgentEnable")]
        public bool? AgentEnable{ get; set; }

        /// <summary>
        /// 组件列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstrumentList")]
        public Instrument[] InstrumentList{ get; set; }

        /// <summary>
        /// 是否开启链路压缩
        /// </summary>
        [JsonProperty("TraceSquash")]
        public bool? TraceSquash{ get; set; }

        /// <summary>
        /// 是否开启应用诊断开关
        /// </summary>
        [JsonProperty("EventEnable")]
        public bool? EventEnable{ get; set; }

        /// <summary>
        /// 探针接口相关配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentOperationConfigView")]
        public AgentOperationConfigView AgentOperationConfigView{ get; set; }

        /// <summary>
        /// 是否开启应用日志配置
        /// </summary>
        [JsonProperty("EnableLogConfig")]
        public bool? EnableLogConfig{ get; set; }

        /// <summary>
        /// 应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// 应用是否开启dashboard配置： false 关（与业务系统保持一致）/true 开（应用级配置）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableDashboardConfig")]
        public bool? EnableDashboardConfig{ get; set; }

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
        /// 是否开启应用级别配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableSecurityConfig")]
        public bool? EnableSecurityConfig{ get; set; }

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
        /// 是否开启远程命令执行分析
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsRemoteCommandExecutionAnalysis")]
        public long? IsRemoteCommandExecutionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启内存马检测分析
        /// 注意：此字段可能返回 null，表示取不到有效值。
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDeleteAnyFileAnalysis")]
        public long? IsDeleteAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启读取任意文件检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsReadAnyFileAnalysis")]
        public long? IsReadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启上传任意文件检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsUploadAnyFileAnalysis")]
        public long? IsUploadAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启包含任意文件检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsIncludeAnyFileAnalysis")]
        public long? IsIncludeAnyFileAnalysis{ get; set; }

        /// <summary>
        /// 是否开启目录遍历检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDirectoryTraversalAnalysis")]
        public long? IsDirectoryTraversalAnalysis{ get; set; }

        /// <summary>
        /// 是否开启模板引擎注入检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsTemplateEngineInjectionAnalysis")]
        public long? IsTemplateEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启脚本引擎注入检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsScriptEngineInjectionAnalysis")]
        public long? IsScriptEngineInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启表达式注入检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsExpressionInjectionAnalysis")]
        public long? IsExpressionInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启JNDI注入检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsJNDIInjectionAnalysis")]
        public long? IsJNDIInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启JNI注入检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsJNIInjectionAnalysis")]
        public long? IsJNIInjectionAnalysis{ get; set; }

        /// <summary>
        /// 是否开启Webshell后门检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsWebshellBackdoorAnalysis")]
        public long? IsWebshellBackdoorAnalysis{ get; set; }

        /// <summary>
        /// 是否开启反序列化检测（0-关闭，1-开启）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDeserializationAnalysis")]
        public long? IsDeserializationAnalysis{ get; set; }

        /// <summary>
        /// 接口名称自动收敛开关（0-关闭，1-开启）
        /// </summary>
        [JsonProperty("UrlAutoConvergenceEnable")]
        public bool? UrlAutoConvergenceEnable{ get; set; }

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
        /// 探针熔断内存阈值
        /// </summary>
        [JsonProperty("DisableMemoryUsed")]
        public long? DisableMemoryUsed{ get; set; }

        /// <summary>
        /// 探针熔断CPU阈值
        /// </summary>
        [JsonProperty("DisableCpuUsed")]
        public long? DisableCpuUsed{ get; set; }

        /// <summary>
        /// 是否开启SQL参数获取
        /// </summary>
        [JsonProperty("DbStatementParametersEnabled")]
        public bool? DbStatementParametersEnabled{ get; set; }

        /// <summary>
        /// 慢SQL阈值
        /// </summary>
        [JsonProperty("SlowSQLThresholds")]
        public ApmTag[] SlowSQLThresholds{ get; set; }

        /// <summary>
        /// 是否开启脱敏规则
        /// </summary>
        [JsonProperty("EnableDesensitizationRule")]
        public long? EnableDesensitizationRule{ get; set; }

        /// <summary>
        /// 脱敏规则
        /// </summary>
        [JsonProperty("DesensitizationRule")]
        public string DesensitizationRule{ get; set; }

        /// <summary>
        /// spanId的索引key: 当CLS索引类型为键值索引时生效
        /// </summary>
        [JsonProperty("LogSpanIdKey")]
        public string LogSpanIdKey{ get; set; }

        /// <summary>
        /// 自动性能剖析配置
        /// </summary>
        [JsonProperty("AutoProfilingConfig")]
        public AutoProfilingConfig AutoProfilingConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "UrlConvergenceSwitch", this.UrlConvergenceSwitch);
            this.SetParamSimple(map, prefix + "UrlConvergenceThreshold", this.UrlConvergenceThreshold);
            this.SetParamSimple(map, prefix + "UrlConvergence", this.UrlConvergence);
            this.SetParamSimple(map, prefix + "ExceptionFilter", this.ExceptionFilter);
            this.SetParamSimple(map, prefix + "ErrorCodeFilter", this.ErrorCodeFilter);
            this.SetParamSimple(map, prefix + "Components", this.Components);
            this.SetParamSimple(map, prefix + "UrlExclude", this.UrlExclude);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "LogRegion", this.LogRegion);
            this.SetParamSimple(map, prefix + "IsRelatedLog", this.IsRelatedLog);
            this.SetParamSimple(map, prefix + "LogTopicID", this.LogTopicID);
            this.SetParamSimple(map, prefix + "IgnoreOperationName", this.IgnoreOperationName);
            this.SetParamSimple(map, prefix + "LogSet", this.LogSet);
            this.SetParamSimple(map, prefix + "TraceRateLimit", this.TraceRateLimit);
            this.SetParamSimple(map, prefix + "EnableSnapshot", this.EnableSnapshot);
            this.SetParamSimple(map, prefix + "SnapshotTimeout", this.SnapshotTimeout);
            this.SetParamSimple(map, prefix + "AgentEnable", this.AgentEnable);
            this.SetParamArrayObj(map, prefix + "InstrumentList.", this.InstrumentList);
            this.SetParamSimple(map, prefix + "TraceSquash", this.TraceSquash);
            this.SetParamSimple(map, prefix + "EventEnable", this.EventEnable);
            this.SetParamObj(map, prefix + "AgentOperationConfigView.", this.AgentOperationConfigView);
            this.SetParamSimple(map, prefix + "EnableLogConfig", this.EnableLogConfig);
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamSimple(map, prefix + "EnableDashboardConfig", this.EnableDashboardConfig);
            this.SetParamSimple(map, prefix + "IsRelatedDashboard", this.IsRelatedDashboard);
            this.SetParamSimple(map, prefix + "DashboardTopicID", this.DashboardTopicID);
            this.SetParamSimple(map, prefix + "EnableSecurityConfig", this.EnableSecurityConfig);
            this.SetParamSimple(map, prefix + "IsInstrumentationVulnerabilityScan", this.IsInstrumentationVulnerabilityScan);
            this.SetParamSimple(map, prefix + "IsSqlInjectionAnalysis", this.IsSqlInjectionAnalysis);
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
        }
    }
}

