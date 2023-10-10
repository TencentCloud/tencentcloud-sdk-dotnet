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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetTypeTopResponse : AbstractModel
    {
        
        /// <summary>
        /// 账号Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("User")]
        public AssetKeyVal[] User{ get; set; }

        /// <summary>
        /// 端口Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public AssetKeyVal[] Port{ get; set; }

        /// <summary>
        /// 进程Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Process")]
        public AssetKeyVal[] Process{ get; set; }

        /// <summary>
        /// 软件Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Software")]
        public AssetKeyVal[] Software{ get; set; }

        /// <summary>
        /// 数据库Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Database")]
        public AssetKeyVal[] Database{ get; set; }

        /// <summary>
        /// Web应用Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebApp")]
        public AssetKeyVal[] WebApp{ get; set; }

        /// <summary>
        /// Web站点Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebLocation")]
        public AssetKeyVal[] WebLocation{ get; set; }

        /// <summary>
        /// Web框架Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebFrame")]
        public AssetKeyVal[] WebFrame{ get; set; }

        /// <summary>
        /// Web服务Top5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebService")]
        public AssetKeyVal[] WebService{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "User.", this.User);
            this.SetParamArrayObj(map, prefix + "Port.", this.Port);
            this.SetParamArrayObj(map, prefix + "Process.", this.Process);
            this.SetParamArrayObj(map, prefix + "Software.", this.Software);
            this.SetParamArrayObj(map, prefix + "Database.", this.Database);
            this.SetParamArrayObj(map, prefix + "WebApp.", this.WebApp);
            this.SetParamArrayObj(map, prefix + "WebLocation.", this.WebLocation);
            this.SetParamArrayObj(map, prefix + "WebFrame.", this.WebFrame);
            this.SetParamArrayObj(map, prefix + "WebService.", this.WebService);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

