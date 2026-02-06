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

    public class CreateSplunkDeliverRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>日志主题id- 通过<a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a>获取日志主题Id。</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>splunk投递任务名称；name有如下限制：- 不能为空- 长度不大于64- 只能包含aA-zZ、下划线、-、0-9</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Splunk投递任务-目标配置-网络信息</p>
        /// </summary>
        [JsonProperty("NetInfo")]
        public NetInfo NetInfo{ get; set; }

        /// <summary>
        /// <p>Splunk投递任务元信息</p>
        /// </summary>
        [JsonProperty("MetadataInfo")]
        public MetadataInfo MetadataInfo{ get; set; }

        /// <summary>
        /// <p>是否开启服务日志 1:关闭；2:开启 ;默认开启</p>
        /// </summary>
        [JsonProperty("HasServiceLog")]
        public long? HasServiceLog{ get; set; }

        /// <summary>
        /// <p>高级配置-是否启用索引器；1-不启用；2-启用；默认：1</p>
        /// </summary>
        [JsonProperty("IndexAck")]
        public long? IndexAck{ get; set; }

        /// <summary>
        /// <p>高级配置-数据来源；不超过64个字符</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>高级配置-数据来源类型；不超过64个字符</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>高级配置-Splunk写入的索引；不超过64个字符</p>
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// <p>高级配置-通道需满足限制：如果启用索引器，那么Channel必填</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>日志预过滤-数据写入 Splunk 的原始数据进行预过滤处理</p>
        /// </summary>
        [JsonProperty("DSLFilter")]
        public string DSLFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "NetInfo.", this.NetInfo);
            this.SetParamObj(map, prefix + "MetadataInfo.", this.MetadataInfo);
            this.SetParamSimple(map, prefix + "HasServiceLog", this.HasServiceLog);
            this.SetParamSimple(map, prefix + "IndexAck", this.IndexAck);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "DSLFilter", this.DSLFilter);
        }
    }
}

