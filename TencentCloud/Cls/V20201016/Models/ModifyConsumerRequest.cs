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

    public class ModifyConsumerRequest : AbstractModel
    {
        
        /// <summary>
        /// 投递任务绑定的日志主题Id。
        /// - 通过 [获取日志主题列表](https://cloud.tencent.com/document/product/614/56454) 获取日志主题Id。
        /// - 通过 [创建日志主题](https://cloud.tencent.com/document/product/614/56456) 获取日志主题Id。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 投递任务是否生效，默认不生效
        /// </summary>
        [JsonProperty("Effective")]
        public bool? Effective{ get; set; }

        /// <summary>
        /// 是否投递日志的元数据信息，默认为 true。
        /// 当NeedContent为true时：字段Content有效。
        /// 当NeedContent为false时：字段Content无效。
        /// </summary>
        [JsonProperty("NeedContent")]
        public bool? NeedContent{ get; set; }

        /// <summary>
        /// 如果需要投递元数据信息，元数据信息的描述
        /// </summary>
        [JsonProperty("Content")]
        public ConsumerContent Content{ get; set; }

        /// <summary>
        /// CKafka的描述
        /// </summary>
        [JsonProperty("Ckafka")]
        public Ckafka Ckafka{ get; set; }

        /// <summary>
        /// 投递时压缩方式，取值0，2，3。[0：NONE；2：SNAPPY；3：LZ4]
        /// </summary>
        [JsonProperty("Compression")]
        public long? Compression{ get; set; }

        /// <summary>
        /// 角色访问描述名 [创建角色](https://cloud.tencent.com/document/product/598/19381)
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// 外部ID
        /// </summary>
        [JsonProperty("ExternalId")]
        public string ExternalId{ get; set; }

        /// <summary>
        /// 高级配置
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public AdvancedConsumerConfiguration AdvancedConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Effective", this.Effective);
            this.SetParamSimple(map, prefix + "NeedContent", this.NeedContent);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamObj(map, prefix + "Ckafka.", this.Ckafka);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "ExternalId", this.ExternalId);
            this.SetParamObj(map, prefix + "AdvancedConfig.", this.AdvancedConfig);
        }
    }
}

