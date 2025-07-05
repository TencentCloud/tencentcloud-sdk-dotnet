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

    public class CreateConfigExtraRequest : AbstractModel
    {
        
        /// <summary>
        /// 采集配置规程名称，最长63个字符，只能包含小写字符、数字及分隔符（“-”），且必须以小写字符开头，数字或小写字符结尾
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 日志主题id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 日志源类型。支持 container_stdout：容器标准输出；container_file：容器文件路径；host_file：节点文件路径。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 采集的日志类型，默认为minimalist_log。支持以下类型：
        /// - json_log代表：JSON-文件日志（详见[使用 JSON 提取模式采集日志](https://cloud.tencent.com/document/product/614/17419)）；
        /// - delimiter_log代表：分隔符-文件日志（详见[使用分隔符提取模式采集日志](https://cloud.tencent.com/document/product/614/17420)）；
        /// - minimalist_log代表：单行全文-文件日志（详见[使用单行全文提取模式采集日志](https://cloud.tencent.com/document/product/614/17421)）；
        /// - fullregex_log代表：单行完全正则-文件日志（详见[使用单行-完全正则提取模式采集日志](https://cloud.tencent.com/document/product/614/52365)）；
        /// - multiline_log代表：多行全文-文件日志（详见[使用多行全文提取模式采集日志](https://cloud.tencent.com/document/product/614/17422)）；
        /// - multiline_fullregex_log代表：多行完全正则-文件日志（详见[使用多行-完全正则提取模式采集日志](https://cloud.tencent.com/document/product/614/52366)）；
        /// - user_define_log代表：组合解析（适用于多格式嵌套的日志，详见[使用组合解析提取模式采集日志](https://cloud.tencent.com/document/product/614/61310)）。
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 采集配置标记。
        /// - 目前只支持label_k8s，用于标记自建k8s集群使用的采集配置
        /// </summary>
        [JsonProperty("ConfigFlag")]
        public string ConfigFlag{ get; set; }

        /// <summary>
        /// 日志集id
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志集name
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// 日志主题名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 节点文件路径类型配置。
        /// </summary>
        [JsonProperty("HostFile")]
        public HostFileInfo HostFile{ get; set; }

        /// <summary>
        /// 容器文件路径类型配置。
        /// </summary>
        [JsonProperty("ContainerFile")]
        public ContainerFileInfo ContainerFile{ get; set; }

        /// <summary>
        /// 容器标准输出类型配置。
        /// </summary>
        [JsonProperty("ContainerStdout")]
        public ContainerStdoutInfo ContainerStdout{ get; set; }

        /// <summary>
        /// 日志格式化方式，用于容器采集场景。
        /// - stdout-docker-json：用于docker容器采集场景
        /// - stdout-containerd：用于containerd容器采集场景
        /// </summary>
        [JsonProperty("LogFormat")]
        [System.Obsolete]
        public string LogFormat{ get; set; }

        /// <summary>
        /// 提取规则，如果设置了ExtractRule，则必须设置LogType
        /// </summary>
        [JsonProperty("ExtractRule")]
        public ExtractRuleInfo ExtractRule{ get; set; }

        /// <summary>
        /// 采集黑名单路径列表
        /// </summary>
        [JsonProperty("ExcludePaths")]
        public ExcludePathInfo[] ExcludePaths{ get; set; }

        /// <summary>
        /// 组合解析采集规则，用于复杂场景下的日志采集。
        /// - 取值参考：[使用组合解析提取模式采集日志
        /// ](https://cloud.tencent.com/document/product/614/61310)
        /// </summary>
        [JsonProperty("UserDefineRule")]
        public string UserDefineRule{ get; set; }

        /// <summary>
        /// 绑定的机器组id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 绑定的机器组id列表
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 采集相关配置信息。详情见CollectInfo复杂类型配置。
        /// </summary>
        [JsonProperty("CollectInfos")]
        public CollectInfo[] CollectInfos{ get; set; }

        /// <summary>
        /// 高级采集配置。 Json字符串， Key/Value定义为如下：
        /// - ClsAgentFileTimeout(超时属性), 取值范围: 大于等于0的整数， 0为不超时
        /// - ClsAgentMaxDepth(最大目录深度)，取值范围: 大于等于0的整数
        /// - ClsAgentParseFailMerge(合并解析失败日志)，取值范围: true或false
        /// - ClsAgentDefault(自定义默认值，无特殊含义，用于清空其他选项)，建议取值0
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public string AdvancedConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "ConfigFlag", this.ConfigFlag);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamObj(map, prefix + "HostFile.", this.HostFile);
            this.SetParamObj(map, prefix + "ContainerFile.", this.ContainerFile);
            this.SetParamObj(map, prefix + "ContainerStdout.", this.ContainerStdout);
            this.SetParamSimple(map, prefix + "LogFormat", this.LogFormat);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
            this.SetParamArrayObj(map, prefix + "ExcludePaths.", this.ExcludePaths);
            this.SetParamSimple(map, prefix + "UserDefineRule", this.UserDefineRule);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamArrayObj(map, prefix + "CollectInfos.", this.CollectInfos);
            this.SetParamSimple(map, prefix + "AdvancedConfig", this.AdvancedConfig);
        }
    }
}

