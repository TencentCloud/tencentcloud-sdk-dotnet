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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaOption : AbstractModel
    {
        
        /// <summary>
        /// 投递到kafka的数据类型，如Avro,Json,canal-pb,canal-json,debezium
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// 同步topic策略，如Single（集中投递到单topic）,Multi (自定义topic名称)
        /// </summary>
        [JsonProperty("TopicType")]
        public string TopicType{ get; set; }

        /// <summary>
        /// 用于存储ddl的topic
        /// </summary>
        [JsonProperty("DDLTopicName")]
        public string DDLTopicName{ get; set; }

        /// <summary>
        /// 单topic和自定义topic的描述
        /// </summary>
        [JsonProperty("TopicRules")]
        public TopicRule[] TopicRules{ get; set; }

        /// <summary>
        /// 其他附加信息，对于特定数据类型可设置额外参数，比如针对Canal兼容的功能支持："canalOfficialFormat":"on"表示打开Canal兼容功能，默认不带。
        /// </summary>
        [JsonProperty("DataOption")]
        public KeyValuePairOption[] DataOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "DDLTopicName", this.DDLTopicName);
            this.SetParamArrayObj(map, prefix + "TopicRules.", this.TopicRules);
            this.SetParamArrayObj(map, prefix + "DataOption.", this.DataOption);
        }
    }
}

