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

    public class ModifySplunkDeliverRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 日志主题id
        /// - 通过[获取日志主题列表](https://cloud.tencent.com/document/product/614/56454)获取日志主题Id。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 投递任务名称
        /// name有以下限制：
        /// - 不能为空
        /// - 长度不大于64
        /// - 只能包含aA-zZ、下划线、-、0-9
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 投递任务启用状态；0:禁用；1:启用
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// splunk投递任务-目标配置
        /// </summary>
        [JsonProperty("NetInfo")]
        public NetInfo NetInfo{ get; set; }

        /// <summary>
        /// splunk投递任务元信息
        /// </summary>
        [JsonProperty("MetadataInfo")]
        public MetadataInfo MetadataInfo{ get; set; }

        /// <summary>
        /// 是否启用服务日志；1:关闭；2:开启
        /// </summary>
        [JsonProperty("HasServiceLog")]
        public long? HasServiceLog{ get; set; }

        /// <summary>
        /// 高级配置-是否启用索引器;
        /// 1-不开启；2-开启；默认为：1
        /// </summary>
        [JsonProperty("IndexAck")]
        public long? IndexAck{ get; set; }

        /// <summary>
        /// 高级配置-数据来源；不超过64个字符
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 高级配置-数据来源类型；不超过64个字符
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 高级配置-Splunk写入的索引；不超过64个字符
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// 高级配置-通道。
        /// 需满足限制：如果启用索引器，该值不能为空
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamObj(map, prefix + "NetInfo.", this.NetInfo);
            this.SetParamObj(map, prefix + "MetadataInfo.", this.MetadataInfo);
            this.SetParamSimple(map, prefix + "HasServiceLog", this.HasServiceLog);
            this.SetParamSimple(map, prefix + "IndexAck", this.IndexAck);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
        }
    }
}

