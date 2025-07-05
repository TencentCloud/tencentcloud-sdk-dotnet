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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClientToken : AbstractModel
    {
        
        /// <summary>
        /// 节点 IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeIp")]
        public string NodeIp{ get; set; }

        /// <summary>
        /// 挂载点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDirectory")]
        public string LocalDirectory{ get; set; }

        /// <summary>
        /// 可以访问的 GooseFS 目录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GooseFSDirectory")]
        public string GooseFSDirectory{ get; set; }

        /// <summary>
        /// token
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeIp", this.NodeIp);
            this.SetParamSimple(map, prefix + "LocalDirectory", this.LocalDirectory);
            this.SetParamSimple(map, prefix + "GooseFSDirectory", this.GooseFSDirectory);
            this.SetParamSimple(map, prefix + "Token", this.Token);
        }
    }
}

