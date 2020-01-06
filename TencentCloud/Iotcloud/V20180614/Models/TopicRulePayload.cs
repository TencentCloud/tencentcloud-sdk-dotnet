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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicRulePayload : AbstractModel
    {
        
        /// <summary>
        /// 规则的SQL语句，如： SELECT * FROM 'pid/dname/event'，然后对其进行base64编码，得：U0VMRUNUICogRlJPTSAncGlkL2RuYW1lL2V2ZW50Jw==
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// 行为的JSON字符串，大部分种类举例如下：
        /// [{"republish":{"topic":"TEST/test"}},{"forward":{"api":"http://127.0.0.1:8080"}},{"ckafka":{"instance":{"id":"ckafka-test","name":""},"topic":{"id":"topic-test","name":"test"},"region":"gz"}},{"cmqqueue":{"queuename":"queue-test-TEST","region":"gz"}},{"mysql":{"instanceid":"cdb-test","region":"gz","username":"test","userpwd":"*****","dbname":"d_mqtt","tablename":"t_test","fieldpairs":[{"field":"test","value":"test"}],"devicetype":"CUSTOM"}}]
        /// </summary>
        [JsonProperty("Actions")]
        public string Actions{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否禁用规则
        /// </summary>
        [JsonProperty("RuleDisabled")]
        public bool? RuleDisabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "Actions", this.Actions);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleDisabled", this.RuleDisabled);
        }
    }
}

