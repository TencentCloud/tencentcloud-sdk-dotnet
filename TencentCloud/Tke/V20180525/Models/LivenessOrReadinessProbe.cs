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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LivenessOrReadinessProbe : AbstractModel
    {
        
        /// <summary>
        /// 探针参数
        /// </summary>
        [JsonProperty("Probe")]
        public Probe Probe{ get; set; }

        /// <summary>
        /// 容器内检测命令参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Exec")]
        public Exec Exec{ get; set; }

        /// <summary>
        /// HttpGet检测参数
        /// </summary>
        [JsonProperty("HttpGet")]
        public HttpGet HttpGet{ get; set; }

        /// <summary>
        /// TcpSocket检测的端口参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcpSocket")]
        public TcpSocket TcpSocket{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Probe.", this.Probe);
            this.SetParamObj(map, prefix + "Exec.", this.Exec);
            this.SetParamObj(map, prefix + "HttpGet.", this.HttpGet);
            this.SetParamObj(map, prefix + "TcpSocket.", this.TcpSocket);
        }
    }
}

