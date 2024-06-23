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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeDistribution : AbstractModel
    {
        
        /// <summary>
        /// 主实例Master节点所在主机ID或者只读实例所在主机ID
        /// </summary>
        [JsonProperty("Node")]
        public string Node{ get; set; }

        /// <summary>
        /// 主实例第一Slave节点所在主机ID
        /// </summary>
        [JsonProperty("SlaveNodeOne")]
        public string SlaveNodeOne{ get; set; }

        /// <summary>
        /// 主实例第二Slave节点所在主机ID
        /// </summary>
        [JsonProperty("SlaveNodeTwo")]
        public string SlaveNodeTwo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Node", this.Node);
            this.SetParamSimple(map, prefix + "SlaveNodeOne", this.SlaveNodeOne);
            this.SetParamSimple(map, prefix + "SlaveNodeTwo", this.SlaveNodeTwo);
        }
    }
}

