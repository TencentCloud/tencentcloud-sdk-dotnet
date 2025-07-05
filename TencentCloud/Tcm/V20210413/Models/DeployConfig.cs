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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployConfig : AbstractModel
    {
        
        /// <summary>
        /// 部署类型，取值范围：
        /// - SPECIFIC：专有模式
        /// - AUTO：普通模式
        /// </summary>
        [JsonProperty("NodeSelectType")]
        public string NodeSelectType{ get; set; }

        /// <summary>
        /// 指定的节点
        /// </summary>
        [JsonProperty("Nodes")]
        public string[] Nodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeSelectType", this.NodeSelectType);
            this.SetParamArraySimple(map, prefix + "Nodes.", this.Nodes);
        }
    }
}

