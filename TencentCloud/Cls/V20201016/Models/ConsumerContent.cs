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

    public class ConsumerContent : AbstractModel
    {
        
        /// <summary>
        /// 是否投递 TAG 信息。
        /// 当EnableTag为true时，表示投递TAG元信息。
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// 需要投递的元数据列表，目前仅支持：\_\_SOURCE\_\_，\_\_FILENAME\_\_，\_\_TIMESTAMP\_\_，\_\_HOSTNAME\_\_和\_\_PKGID\_\_
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// 当EnableTag为true时，必须填写TagJsonNotTiled字段。
        /// TagJsonNotTiled用于标识tag信息是否json平铺。
        /// 
        /// TagJsonNotTiled为true时不平铺，示例：
        /// TAG信息：`{"__TAG__":{"fieldA":200,"fieldB":"text"}}`
        /// 不平铺：`{"__TAG__":{"fieldA":200,"fieldB":"text"}}`
        /// 
        /// TagJsonNotTiled为false时平铺，示例：
        /// TAG信息：`{"__TAG__":{"fieldA":200,"fieldB":"text"}}`
        /// 平铺：`{"__TAG__.fieldA":200,"__TAG__.fieldB":"text"}`
        /// </summary>
        [JsonProperty("TagJsonNotTiled")]
        public bool? TagJsonNotTiled{ get; set; }

        /// <summary>
        /// 投递时间戳精度，可选项 [1：秒；2：毫秒] ，默认是1。
        /// </summary>
        [JsonProperty("TimestampAccuracy")]
        public long? TimestampAccuracy{ get; set; }

        /// <summary>
        /// 投递Json格式。
        /// JsonType为0：和原始日志一致，不转义。示例：
        /// 日志原文：`{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`
        /// 投递到Ckafka：`{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`
        /// 
        /// JsonType为1：转义。示例：
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
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "TagJsonNotTiled", this.TagJsonNotTiled);
            this.SetParamSimple(map, prefix + "TimestampAccuracy", this.TimestampAccuracy);
            this.SetParamSimple(map, prefix + "JsonType", this.JsonType);
        }
    }
}

