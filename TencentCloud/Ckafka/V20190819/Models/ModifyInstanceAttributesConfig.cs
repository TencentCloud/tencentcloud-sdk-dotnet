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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAttributesConfig : AbstractModel
    {
        
        /// <summary>
        /// 自动创建 true 表示开启，false 表示不开启
        /// </summary>
        [JsonProperty("AutoCreateTopicEnable")]
        public bool? AutoCreateTopicEnable{ get; set; }

        /// <summary>
        /// 可选，如果auto.create.topic.enable设置为true没有设置该值时，默认设置为3
        /// </summary>
        [JsonProperty("DefaultNumPartitions")]
        public long? DefaultNumPartitions{ get; set; }

        /// <summary>
        /// 如歌auto.create.topic.enable设置为true没有指定该值时默认设置为2
        /// </summary>
        [JsonProperty("DefaultReplicationFactor")]
        public long? DefaultReplicationFactor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoCreateTopicEnable", this.AutoCreateTopicEnable);
            this.SetParamSimple(map, prefix + "DefaultNumPartitions", this.DefaultNumPartitions);
            this.SetParamSimple(map, prefix + "DefaultReplicationFactor", this.DefaultReplicationFactor);
        }
    }
}

