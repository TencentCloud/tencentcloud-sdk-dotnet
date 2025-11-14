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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 采集规则配置ID
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 采集规则配置名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 日志格式化方式
        /// </summary>
        [JsonProperty("LogFormat")]
        public string LogFormat{ get; set; }

        /// <summary>
        /// 日志采集路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 采集的日志类型。
        /// - json_log代表：JSON-文件日志（详见[使用 JSON 提取模式采集日志](https://cloud.tencent.com/document/product/614/17419)）；
        /// - delimiter_log代表：分隔符-文件日志（详见[使用分隔符提取模式采集日志](https://cloud.tencent.com/document/product/614/17420)）；
        /// - minimalist_log代表：单行全文-文件日志（详见[使用单行全文提取模式采集日志](https://cloud.tencent.com/document/product/614/17421)）；
        /// - fullregex_log代表：单行完全正则-文件日志（详见[使用单行-完全正则提取模式采集日志](https://cloud.tencent.com/document/product/614/52365)）；
        /// - multiline_log代表：多行全文-文件日志（详见[使用多行全文提取模式采集日志](https://cloud.tencent.com/document/product/614/17422)）；
        /// - multiline_fullregex_log代表：多行完全正则-文件日志（详见[使用多行-完全正则提取模式采集日志](https://cloud.tencent.com/document/product/614/52366)）；
        /// - user_define_log代表：组合解析（适用于多格式嵌套的日志，详见[使用组合解析提取模式采集日志](https://cloud.tencent.com/document/product/614/61310)）；
        /// - service_syslog代表：syslog 采集（详见[采集 Syslog](https://cloud.tencent.com/document/product/614/81454)）；
        /// - windows_event_log代表：Windows事件日志（详见[采集 Windows 事件日志](https://cloud.tencent.com/document/product/614/96678)）。
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 提取规则，如果设置了ExtractRule，则必须设置LogType
        /// </summary>
        [JsonProperty("ExtractRule")]
        public ExtractRuleInfo ExtractRule{ get; set; }

        /// <summary>
        /// 采集黑名单路径列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludePaths")]
        public ExcludePathInfo[] ExcludePaths{ get; set; }

        /// <summary>
        /// 采集配置所属日志主题ID即TopicId
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 更新时间
        /// - 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// - 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 用户自定义解析字符串，详见[使用组合解析提取模式采集日志](https://cloud.tencent.com/document/product/614/61310)。
        /// </summary>
        [JsonProperty("UserDefineRule")]
        public string UserDefineRule{ get; set; }

        /// <summary>
        /// 高级采集配置。 Json字符串， Key/Value定义为如下：
        /// - ClsAgentFileTimeout(超时属性), 取值范围: 大于等于0的整数， 0为不超时
        /// - ClsAgentMaxDepth(最大目录深度)，取值范围: 大于等于0的整数
        /// - ClsAgentParseFailMerge(合并解析失败日志)，取值范围: true或false
        /// 样例：
        /// `{\"ClsAgentFileTimeout\":0,\"ClsAgentMaxDepth\":10,\"ClsAgentParseFailMerge\":true}`
        /// 
        /// 控制台默认占位值：`{\"ClsAgentDefault\":0}`
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public string AdvancedConfig{ get; set; }

        /// <summary>
        /// 日志输入类型，支持file、window_event、syslog、k8s_stdout、k8s_file
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LogFormat", this.LogFormat);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
            this.SetParamArrayObj(map, prefix + "ExcludePaths.", this.ExcludePaths);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UserDefineRule", this.UserDefineRule);
            this.SetParamSimple(map, prefix + "AdvancedConfig", this.AdvancedConfig);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
        }
    }
}

