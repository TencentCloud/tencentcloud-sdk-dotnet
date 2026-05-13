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
        /// <p>是否投递 TAG 信息。<br>当EnableTag为true时，表示投递TAG元信息。</p>
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// <p>需要投递的元数据列表，目前仅支持：__SOURCE__，__FILENAME__，__TIMESTAMP__，__HOSTNAME__和__PKGID__</p>
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// <p>当EnableTag为true时，必须填写TagJsonNotTiled字段。<br>TagJsonNotTiled用于标识tag信息是否json平铺。</p><p>TagJsonNotTiled为true时不平铺，示例：<br>TAG信息：<code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code><br>不平铺：<code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code></p><p>TagJsonNotTiled为false时平铺，示例：<br>TAG信息：<code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code><br>平铺：<code>{&quot;__TAG__.fieldA&quot;:200,&quot;__TAG__.fieldB&quot;:&quot;text&quot;}</code></p>
        /// </summary>
        [JsonProperty("TagJsonNotTiled")]
        public bool? TagJsonNotTiled{ get; set; }

        /// <summary>
        /// <p>投递时间戳精度，可选项 [1：秒；2：毫秒] ，默认是1。</p>
        /// </summary>
        [JsonProperty("TimestampAccuracy")]
        public long? TimestampAccuracy{ get; set; }

        /// <summary>
        /// <p>投递Json格式。</p><p>枚举值：</p><ul><li>0： 转义。示例：<br>日志原文：<code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>投递到Ckafka：<code>{&quot;a&quot;:&quot;aa&quot;,&quot;b&quot;:&quot;{\&quot;b1\&quot;:\&quot;b1b1\&quot;, \&quot;c1\&quot;:\&quot;c1c1\&quot;}&quot;}</code></li><li>1： 和原始日志一致，不转义。示例：<br>日志原文：<code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>投递到Ckafka：<code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code></li></ul>
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

