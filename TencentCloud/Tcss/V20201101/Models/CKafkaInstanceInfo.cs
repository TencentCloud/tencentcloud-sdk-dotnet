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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CKafkaInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 主题列表
        /// </summary>
        [JsonProperty("TopicList")]
        public CKafkaTopicInfo[] TopicList{ get; set; }

        /// <summary>
        /// 路由列表
        /// </summary>
        [JsonProperty("RouteList")]
        public CkafkaRouteInfo[] RouteList{ get; set; }

        /// <summary>
        /// kafka版本号
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "TopicList.", this.TopicList);
            this.SetParamArrayObj(map, prefix + "RouteList.", this.RouteList);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
        }
    }
}

