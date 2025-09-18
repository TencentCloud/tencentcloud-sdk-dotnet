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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyConnectorRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }

        /// <summary>
        /// connector ID
        /// </summary>
        [JsonProperty("ConnectorResourceId")]
        public string ConnectorResourceId{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源版本
        /// </summary>
        [JsonProperty("VersionId")]
        public long? VersionId{ get; set; }

        /// <summary>
        /// 连接器名称
        /// </summary>
        [JsonProperty("Connector")]
        public string Connector{ get; set; }

        /// <summary>
        /// 连接方式
        /// </summary>
        [JsonProperty("ConnectionMethod")]
        public string ConnectionMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
            this.SetParamSimple(map, prefix + "ConnectorResourceId", this.ConnectorResourceId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "Connector", this.Connector);
            this.SetParamSimple(map, prefix + "ConnectionMethod", this.ConnectionMethod);
        }
    }
}

