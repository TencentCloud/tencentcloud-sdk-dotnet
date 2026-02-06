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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CollectorTarget : AbstractModel
    {
        
        /// <summary>
        /// 采集配置名称
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// 命名空间列表，包括Include包含和Exclude不包含选项，两者都为空时等同于全部命名空间(包含当前所有的以及未来创建的)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Namespaces")]
        public Namespaces Namespaces{ get; set; }

        /// <summary>
        /// Pod标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodLabels")]
        public PodLabel[] PodLabels{ get; set; }

        /// <summary>
        /// 容器名称，支持小写字母、数字、连接符-、下划线_，最多支持63个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// ES索引名称前缀，如果当前采集配置下的容器日志输出到ES集群，则使用该字段作为ES索引名称的前缀，支持大小写字母、数字、连接符-、下划线_，最多支持50个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexPrefix")]
        public string IndexPrefix{ get; set; }

        /// <summary>
        /// 日志内容过滤，以逗号分隔，支持大小写字母、数字、连接符-、下划线_以及逗号，最多支持50个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogFilters")]
        public string LogFilters{ get; set; }

        /// <summary>
        /// 高级配置，可自定义采集规则，最多支持2048个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigContent")]
        public string ConfigContent{ get; set; }

        /// <summary>
        /// Ckafka实例的Topic
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaTopic")]
        public string KafkaTopic{ get; set; }

        /// <summary>
        /// ES索引名称，如果当前采集配置下的容器日志输出到ES集群，则使用该字段作为ES索引名称，支持大小写字母、数字、连接符-、下划线_，最多支持50个字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexAlias")]
        public string IndexAlias{ get; set; }

        /// <summary>
        /// /
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 日志采集host路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputPath")]
        public string InputPath{ get; set; }

        /// <summary>
        /// inputs.tail_files
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputsTailFiles")]
        public bool? InputsTailFiles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamObj(map, prefix + "Namespaces.", this.Namespaces);
            this.SetParamArrayObj(map, prefix + "PodLabels.", this.PodLabels);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "IndexPrefix", this.IndexPrefix);
            this.SetParamSimple(map, prefix + "LogFilters", this.LogFilters);
            this.SetParamSimple(map, prefix + "ConfigContent", this.ConfigContent);
            this.SetParamSimple(map, prefix + "KafkaTopic", this.KafkaTopic);
            this.SetParamSimple(map, prefix + "IndexAlias", this.IndexAlias);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "InputPath", this.InputPath);
            this.SetParamSimple(map, prefix + "InputsTailFiles", this.InputsTailFiles);
        }
    }
}

