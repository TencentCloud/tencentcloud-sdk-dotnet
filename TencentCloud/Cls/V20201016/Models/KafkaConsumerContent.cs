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

    public class KafkaConsumerContent : AbstractModel
    {
        
        /// <summary>
        /// 消费数据格式。 0：原始内容；1：JSON。
        /// </summary>
        [JsonProperty("Format")]
        public long? Format{ get; set; }

        /// <summary>
        /// 是否投递 TAG 信息
        /// Format为0时，此字段不需要赋值
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// 元数据信息列表, 可选值为：\_\_SOURCE\_\_、\_\_FILENAME\_\_
        /// 、\_\_TIMESTAMP\_\_、\_\_HOSTNAME\_\_、\_\_PKGID\_\_
        /// Format为0时，此字段不需要赋值
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// tag数据处理方式：1:不平铺（默认值）；2:平铺。
        /// 
        /// 不平铺示例：
        /// TAG信息：`{"__TAG__":{"fieldA":200,"fieldB":"text"}}`
        /// 不平铺：`{"__TAG__":{"fieldA":200,"fieldB":"text"}}`
        /// 
        /// 平铺示例：
        /// TAG信息：`{"__TAG__":{"fieldA":200,"fieldB":"text"}}`
        /// 平铺：`{"__TAG__.fieldA":200,"__TAG__.fieldB":"text"}`
        /// </summary>
        [JsonProperty("TagTransaction")]
        public long? TagTransaction{ get; set; }

        /// <summary>
        /// 消费数据Json格式：
        /// 1：不转义（默认格式）
        /// 2：转义
        /// 
        /// 投递Json格式。
        /// JsonType为1：和原始日志一致，不转义。示例：
        /// 日志原文：`{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`
        /// 投递到Ckafka：`{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`
        /// 
        /// JsonType为2：转义。示例：
        /// 日志原文：`{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`
        /// 投递到Ckafka：`{"a":"aa","b":"{\"b1\":\"b1b1\", \"c1\":\"c1c1\"}"}`
        /// </summary>
        [JsonProperty("JsonType")]
        public long? JsonType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "TagTransaction", this.TagTransaction);
            this.SetParamSimple(map, prefix + "JsonType", this.JsonType);
        }
    }
}

