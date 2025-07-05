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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RemoteWrite : AbstractModel
    {
        
        /// <summary>
        /// 多写url
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// RelabelConfig
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("URLRelabelConfig")]
        public string URLRelabelConfig{ get; set; }

        /// <summary>
        /// 鉴权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicAuth")]
        public BasicAuth BasicAuth{ get; set; }

        /// <summary>
        /// 最大block
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxBlockSize")]
        [System.Obsolete]
        public string MaxBlockSize{ get; set; }

        /// <summary>
        /// Label
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Label")]
        [System.Obsolete]
        public string Label{ get; set; }

        /// <summary>
        /// HTTP 额外添加的头
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Headers")]
        public RemoteWriteHeader[] Headers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamSimple(map, prefix + "URLRelabelConfig", this.URLRelabelConfig);
            this.SetParamObj(map, prefix + "BasicAuth.", this.BasicAuth);
            this.SetParamSimple(map, prefix + "MaxBlockSize", this.MaxBlockSize);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
        }
    }
}

