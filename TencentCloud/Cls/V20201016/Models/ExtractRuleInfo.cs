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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtractRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间字段的key名字，TikeKey和TimeFormat必须成对出现
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// 时间字段的格式，参考c语言的strftime函数对于时间的格式说明输出参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// 分隔符类型日志的分隔符，只有LogType为delimiter_log时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// 整条日志匹配规则，只有LogType为fullregex_log时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// 行首匹配规则，只有LogType为multiline_log或fullregex_log时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginRegex")]
        public string BeginRegex{ get; set; }

        /// <summary>
        /// 取的每个字段的key名字，为空的key代表丢弃这个字段，只有LogType为delimiter_log时有效，json_log的日志使用json本身的key。限制100个。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// 日志过滤规则列表（旧版），需要过滤日志的key，及其对应的regex。
        ///  注意：2.9.3及以上版本LogListener ，建议使用AdvanceFilterRules配置日志过滤规则。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterKeyRegex")]
        public KeyRegexInfo[] FilterKeyRegex{ get; set; }

        /// <summary>
        /// 解析失败日志是否上传，true表示上传，false表示不上传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnMatchUpLoadSwitch")]
        public bool? UnMatchUpLoadSwitch{ get; set; }

        /// <summary>
        /// 失败日志的key，当UnMatchUpLoadSwitch为true时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// 增量采集模式下的回溯数据量，默认：-1（全量采集）；其他非负数表示增量采集（从最新的位置，往前采集${Backtracking}字节（Byte）的日志）最大支持1073741824（1G）。
        /// 注意：
        /// - COS导入不支持此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Backtracking")]
        public long? Backtracking{ get; set; }

        /// <summary>
        /// 是否为Gbk编码。 0：否；1：是。
        /// 注意
        /// - 目前取0值时，表示UTF-8编码
        /// - COS导入不支持此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsGBK")]
        public long? IsGBK{ get; set; }

        /// <summary>
        /// 是否为标准json。  0：否； 1：是。
        /// 注
        /// - 标准json指采集器使用业界标准开源解析器进行json解析，非标json指采集器使用CLS自研json解析器进行解析，两种解析器没有本质区别，建议客户使用标准json进行解析。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JsonStandard")]
        public long? JsonStandard{ get; set; }

        /// <summary>
        /// syslog传输协议，取值为tcp或者udp，只有在LogType为service_syslog时生效，其余类型无需填写。
        /// 注意：
        /// - 该字段适用于：创建采集规则配置、修改采集规则配置。
        /// - COS导入不支持此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// syslog系统日志采集指定采集器监听的地址和端口 ，形式：[ip]:[port]，只有在LogType为service_syslog时生效，其余类型无需填写。
        /// 注意：
        /// - 该字段适用于：创建采集规则配置、修改采集规则配置。
        /// - COS导入不支持此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// rfc3164：指定系统日志采集使用RFC3164协议解析日志。
        /// rfc5424：指定系统日志采集使用RFC5424协议解析日志。
        /// auto：自动匹配rfc3164或者rfc5424其中一种协议。
        /// 只有在LogType为service_syslog时生效，其余类型无需填写。
        /// 注意：
        /// - 该字段适用于：创建采集规则配置、修改采集规则配置
        /// - COS导入不支持此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParseProtocol")]
        public string ParseProtocol{ get; set; }

        /// <summary>
        /// 元数据类型。0: 不使用元数据信息；1:使用机器组元数据；2:使用用户自定义元数据；3:使用采集配置路径。
        /// 注意：
        /// - COS导入不支持此字段。
        /// </summary>
        [JsonProperty("MetadataType")]
        public long? MetadataType{ get; set; }

        /// <summary>
        /// 采集配置路径正则表达式。
        /// 注意：
        /// - MetadataType为3时必填。
        /// - COS导入不支持此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PathRegex")]
        public string PathRegex{ get; set; }

        /// <summary>
        /// 用户自定义元数据信息。
        /// 注意：
        /// - MetadataType为2时必填。
        /// - COS导入不支持此字段。
        /// </summary>
        [JsonProperty("MetaTags")]
        public MetaTagInfo[] MetaTags{ get; set; }

        /// <summary>
        /// Windows事件日志采集规则，只有在LogType为windows_event_log时生效，其余类型无需填写。
        /// </summary>
        [JsonProperty("EventLogRules")]
        public EventLog[] EventLogRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "LogRegex", this.LogRegex);
            this.SetParamSimple(map, prefix + "BeginRegex", this.BeginRegex);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamArrayObj(map, prefix + "FilterKeyRegex.", this.FilterKeyRegex);
            this.SetParamSimple(map, prefix + "UnMatchUpLoadSwitch", this.UnMatchUpLoadSwitch);
            this.SetParamSimple(map, prefix + "UnMatchLogKey", this.UnMatchLogKey);
            this.SetParamSimple(map, prefix + "Backtracking", this.Backtracking);
            this.SetParamSimple(map, prefix + "IsGBK", this.IsGBK);
            this.SetParamSimple(map, prefix + "JsonStandard", this.JsonStandard);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "ParseProtocol", this.ParseProtocol);
            this.SetParamSimple(map, prefix + "MetadataType", this.MetadataType);
            this.SetParamSimple(map, prefix + "PathRegex", this.PathRegex);
            this.SetParamArrayObj(map, prefix + "MetaTags.", this.MetaTags);
            this.SetParamArrayObj(map, prefix + "EventLogRules.", this.EventLogRules);
        }
    }
}

