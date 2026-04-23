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
        /// <p>多写url</p>
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// <p>RelabelConfig</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("URLRelabelConfig")]
        public string URLRelabelConfig{ get; set; }

        /// <summary>
        /// <p>鉴权</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicAuth")]
        public BasicAuth BasicAuth{ get; set; }

        /// <summary>
        /// <p>最大block</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxBlockSize")]
        [System.Obsolete]
        public string MaxBlockSize{ get; set; }

        /// <summary>
        /// <p>Label</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Label")]
        [System.Obsolete]
        public string Label{ get; set; }

        /// <summary>
        /// <p>HTTP 额外添加的头</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Headers")]
        public RemoteWriteHeader[] Headers{ get; set; }

        /// <summary>
        /// <p>数据多写类型:<br>1- 只多写采集指标<br>2- 只多写预聚合指标<br>3- 同时多写采集和预聚合指标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteWriteType")]
        public long? RemoteWriteType{ get; set; }


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
            this.SetParamSimple(map, prefix + "RemoteWriteType", this.RemoteWriteType);
        }
    }
}

