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

    public class ModifyConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>采集规则配置ID，通过<a href="https://cloud.tencent.com/document/product/614/58616">获取采集规则配置</a>返回信息获取。</p>
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// <p>采集规则配置名称</p><ul><li>不能包含特殊字符｜</li><li>长度不能超过255字符，超过会被截断</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>日志采集路径，包含文件名</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>采集的日志类型。支持以下类型：</p><ul><li>json_log代表：JSON-文件日志（详见<a href="https://cloud.tencent.com/document/product/614/17419">使用 JSON 提取模式采集日志</a>）；</li><li>delimiter_log代表：分隔符-文件日志（详见<a href="https://cloud.tencent.com/document/product/614/17420">使用分隔符提取模式采集日志</a>）；</li><li>minimalist_log代表：单行全文-文件日志（详见<a href="https://cloud.tencent.com/document/product/614/17421">使用单行全文提取模式采集日志</a>）；</li><li>fullregex_log代表：单行完全正则-文件日志（详见<a href="https://cloud.tencent.com/document/product/614/52365">使用单行-完全正则提取模式采集日志</a>）；</li><li>multiline_log代表：多行全文-文件日志（详见<a href="https://cloud.tencent.com/document/product/614/17422">使用多行全文提取模式采集日志</a>）；</li><li>multiline_fullregex_log代表：多行完全正则-文件日志（详见<a href="https://cloud.tencent.com/document/product/614/52366">使用多行-完全正则提取模式采集日志</a>）；</li><li>user_define_log代表：组合解析（适用于多格式嵌套的日志，详见<a href="https://cloud.tencent.com/document/product/614/61310">使用组合解析提取模式采集日志</a>）；</li><li>service_syslog代表：syslog 采集（详见<a href="https://cloud.tencent.com/document/product/614/81454">采集 Syslog</a>）；</li><li>windows_event_log代表：Windows事件日志（详见<a href="https://cloud.tencent.com/document/product/614/96678">采集 Windows 事件日志</a>）。</li><li>journal_log代表：journal日志采集</li></ul>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>提取规则，如果设置了ExtractRule，则必须设置LogType</p>
        /// </summary>
        [JsonProperty("ExtractRule")]
        public ExtractRuleInfo ExtractRule{ get; set; }

        /// <summary>
        /// <p>采集黑名单路径列表</p>
        /// </summary>
        [JsonProperty("ExcludePaths")]
        public ExcludePathInfo[] ExcludePaths{ get; set; }

        /// <summary>
        /// <p>采集配置关联的日志主题（TopicId）</p><ul><li>通过<a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a>获取日志主题Id。</li></ul>
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// <p>用户自定义解析字符串，Json格式序列化的字符串。</p>
        /// </summary>
        [JsonProperty("UserDefineRule")]
        public string UserDefineRule{ get; set; }

        /// <summary>
        /// <p>高级采集配置。 Json字符串， Key/Value定义为如下：</p><ul><li>ClsAgentFileTimeout(超时属性), 取值范围: 大于等于0的整数， 0为不超时</li><li>ClsAgentMaxDepth(最大目录深度)，取值范围: 大于等于0的整数</li><li>ClsAgentParseFailMerge(合并解析失败日志)，取值范围: true或false<br>样例：<br><code>{\&quot;ClsAgentFileTimeout\&quot;:0,\&quot;ClsAgentMaxDepth\&quot;:10,\&quot;ClsAgentParseFailMerge\&quot;:true}</code></li></ul>
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public string AdvancedConfig{ get; set; }

        /// <summary>
        /// <p>日志输入类型（<span style="color:red; font-weight:bold">注：windows场景必填且仅支持file和windows_event类型</span>）</p><ul><li>file: 文件类型采集</li><li>windows_event：windows事件采集</li><li>syslog：系统日志采集</li></ul>
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
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
            this.SetParamArrayObj(map, prefix + "ExcludePaths.", this.ExcludePaths);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "UserDefineRule", this.UserDefineRule);
            this.SetParamSimple(map, prefix + "AdvancedConfig", this.AdvancedConfig);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
        }
    }
}

