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

    public class CreateConsumerRequest : AbstractModel
    {
        
        /// <summary>
        /// 投递任务绑定的日志主题 ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 是否投递日志的元数据信息，默认为 true
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "NeedContent", this.NeedContent);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamObj(map, prefix + "Ckafka.", this.Ckafka);
        }
    }
}

