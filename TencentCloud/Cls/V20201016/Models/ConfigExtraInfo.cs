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

    public class ConfigExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// 采集规则扩展配置ID
        /// </summary>
        [JsonProperty("ConfigExtraId")]
        public string ConfigExtraId{ get; set; }

        /// <summary>
        /// 采集规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 自建k8s集群日志采集类型，支持
        /// - container_stdout 标准输出
        /// - container_file 标准文件
        /// - host_file 节点文件
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 节点文件配置信息
        /// </summary>
        [JsonProperty("HostFile")]
        public HostFileInfo HostFile{ get; set; }

        /// <summary>
        /// 容器文件路径信息
        /// </summary>
        [JsonProperty("ContainerFile")]
        public ContainerFileInfo ContainerFile{ get; set; }

        /// <summary>
        /// 容器标准输出信息
        /// </summary>
        [JsonProperty("ContainerStdout")]
        public ContainerStdoutInfo ContainerStdout{ get; set; }

        /// <summary>
        /// 日志格式化方式
        /// </summary>
        [JsonProperty("LogFormat")]
        public string LogFormat{ get; set; }

        /// <summary>
        /// 采集的日志类型，json_log代表json格式日志，delimiter_log代表分隔符格式日志，minimalist_log代表极简日志，multiline_log代表多行日志，fullregex_log代表完整正则，默认为minimalist_log
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
        /// 用户自定义解析字符串
        /// </summary>
        [JsonProperty("UserDefineRule")]
        public string UserDefineRule{ get; set; }

        /// <summary>
        /// 机器组ID
        /// - 通过[获取机器组列表](https://cloud.tencent.com/document/api/614/56438)获取机器组Id。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 自建采集配置标
        /// </summary>
        [JsonProperty("ConfigFlag")]
        public string ConfigFlag{ get; set; }

        /// <summary>
        /// 日志集ID
        /// - 通过[获取日志集列表](https://cloud.tencent.com/document/api/614/58624)获取日志集Id。
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志集name
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// 日志主题name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 采集相关配置信息。详情见 CollectInfo复杂类型配置。
        /// </summary>
        [JsonProperty("CollectInfos")]
        public CollectInfo[] CollectInfos{ get; set; }

        /// <summary>
        /// 高级采集配置。 Json字符串， Key/Value定义为如下：
        /// - ClsAgentFileTimeout(超时属性), 取值范围: 大于等于0的整数， 0为不超时
        /// - ClsAgentMaxDepth(最大目录深度)，取值范围: 大于等于0的整数
        /// - ClsAgentParseFailMerge(合并解析失败日志)，取值范围: true或false
        /// 样例：{"ClsAgentFileTimeout":0,"ClsAgentMaxDepth":10,"ClsAgentParseFailMerge":true}
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public string AdvancedConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigExtraId", this.ConfigExtraId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "HostFile.", this.HostFile);
            this.SetParamObj(map, prefix + "ContainerFile.", this.ContainerFile);
            this.SetParamObj(map, prefix + "ContainerStdout.", this.ContainerStdout);
            this.SetParamSimple(map, prefix + "LogFormat", this.LogFormat);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
            this.SetParamArrayObj(map, prefix + "ExcludePaths.", this.ExcludePaths);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UserDefineRule", this.UserDefineRule);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ConfigFlag", this.ConfigFlag);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamArrayObj(map, prefix + "CollectInfos.", this.CollectInfos);
            this.SetParamSimple(map, prefix + "AdvancedConfig", this.AdvancedConfig);
        }
    }
}

