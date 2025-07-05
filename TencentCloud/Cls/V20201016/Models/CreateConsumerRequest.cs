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

    public class CreateConsumerRequest : AbstractModel
    {
        
        /// <summary>
        /// 投递任务绑定的日志主题 ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "NeedContent", this.NeedContent);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamObj(map, prefix + "Ckafka.", this.Ckafka);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
        }
    }
}

