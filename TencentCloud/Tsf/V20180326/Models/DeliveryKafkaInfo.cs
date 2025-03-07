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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliveryKafkaInfo : AbstractModel
    {
        
        /// <summary>
        /// 投递kafka的topic
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 采集日志的path
        /// </summary>
        [JsonProperty("Path")]
        public string[] Path{ get; set; }

        /// <summary>
        /// default，默认换行符分行
        /// time，按时间分行
        /// custom, 选了custom那么CustomRule就要填入具体的自定义值
        /// </summary>
        [JsonProperty("LineRule")]
        public string LineRule{ get; set; }

        /// <summary>
        /// 自定义的分行值
        /// </summary>
        [JsonProperty("CustomRule")]
        public string CustomRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamArraySimple(map, prefix + "Path.", this.Path);
            this.SetParamSimple(map, prefix + "LineRule", this.LineRule);
            this.SetParamSimple(map, prefix + "CustomRule", this.CustomRule);
        }
    }
}

