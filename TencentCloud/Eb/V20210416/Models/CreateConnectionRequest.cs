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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 连接器描述
        /// </summary>
        [JsonProperty("ConnectionDescription")]
        public ConnectionDescription ConnectionDescription{ get; set; }

        /// <summary>
        /// 事件集ID
        /// </summary>
        [JsonProperty("EventBusId")]
        public string EventBusId{ get; set; }

        /// <summary>
        /// 连接器名称
        /// </summary>
        [JsonProperty("ConnectionName")]
        public string ConnectionName{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 使能开关
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 连接器类型，目前支持以下类型:apigw/ckafka/dts/tdmq
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ConnectionDescription.", this.ConnectionDescription);
            this.SetParamSimple(map, prefix + "EventBusId", this.EventBusId);
            this.SetParamSimple(map, prefix + "ConnectionName", this.ConnectionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

